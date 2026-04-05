using System;
using System.Threading;

namespace DiagnosticarRede
{
    class Program
    {

        static void Main(string[] args)
        {

            Program meuPrograma = new Program();
            meuPrograma.MenuPrincipal();
        }
        private void MenuPrincipal()
        {
            bool rodando = true;
            // Heurística #6 (Reconhecimento em vez de Recordação)
            while (rodando)
            {
                Console.Clear();
                Console.WriteLine("=== Diagnóstico de Rede ===");
                Console.WriteLine(" ");
                Console.WriteLine("Comando Disponíveis:");
                Console.WriteLine("> [PING] - Testar conexão");
                Console.WriteLine("> [RESET] - Reinicar servidor (Crítico)");
                Console.WriteLine("> [HELP] - Ajuda");
                Console.WriteLine("> [SAIR] - Fechar terminal");
                Console.WriteLine(" ");
                Console.Write("Digite um comando: ");
                
                string? comando = Console.ReadLine()?.ToUpper();
                
                switch (comando)
                {
                    case "PING":
                        PING();
                        break;
                    case "RESET":
                        RESET();
                        break;
                    case "HELP":
                        HELP();
                        break;
                    case "SAIR":
                        Console.Write("Fechando terminal");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(1000);
                        }
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando inválido. Por favor, digite um comando válido.");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }
            }
        }

        private void PING()
        {
            Console.Clear(); 
            Console.WriteLine("=== PING ===");
            Console.WriteLine(" ");
            Console.WriteLine("Formato esperado: 192.168.0.1 (Somente números e pontos)");
            Console.Write("Digite o IP de destino: ");
            string? ipDestino = Console.ReadLine();

            if (System.Net.IPAddress.TryParse(ipDestino, out _))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Enviando ping para {ipDestino}");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nResposta de {ipDestino}: bytes=32 tempo=20ms TTL=64");
                Console.ResetColor();
                Console.WriteLine("\nPressione qualquer tecla para voltar...");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("IP inválido. Certifique-se de digitar um endereço IP válido");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.ResetColor();
                PING(); 
            }
        }

        private void RESET()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!! AVISO DE SEGURANÇA !!!");
            Console.ResetColor();
            Console.WriteLine("Você solicitou o comando de reinício do servidor, este comando é crítico e pode causar perda de dados ou interrupção dos serviços.");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            // Heurística #5 (Prevenção de Erros)
            Console.Write("Tem certeza de que deseja continuar? (S/N): ");
            Console.ResetColor();

            string? resposta = Console.ReadLine()?.ToUpper();

            if (resposta == "S")
            {
                Console.Write("Reiniciando servidor");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("\nServidor reiniciado com sucesso.");
                Thread.Sleep(2000);
                
            }
            else if (resposta == "N")
            {
                Console.WriteLine("Operação de reinício cancelada.");
                Console.WriteLine("Deseja retornar ao menu principal? (S/N): ");
                string? retorno = Console.ReadLine()?.ToUpper();
                
                if (retorno == "N")
                {
                    Console.Write("Fechando terminal");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    Environment.Exit(0);
                }
                
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, digite 'S' para sim ou 'N' para não.");
                Thread.Sleep(2000);
                RESET();
            }
        }

        // Heurística #10 (Ajuda e Documentação):
        private void HELP()
        {
            Console.Clear();
            Console.WriteLine("=== CENTRAL DE AJUDA ===");
            Thread.Sleep(1000);
            Console.WriteLine("- PING: Verifica se um servidor esta respondendo.");
            Thread.Sleep(1000);
            Console.WriteLine("- RESET: Reinicia o servidor (Crítico)");
            Thread.Sleep(1000);
            Console.WriteLine("- SAIR: Fecha o terminal.");
            Thread.Sleep(1000);
            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal...");
            
            Console.ReadKey();
            Console.Write("Retornando ao menu principal");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000); 
            }
        }
    }
}