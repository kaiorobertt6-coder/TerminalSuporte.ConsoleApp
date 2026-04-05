# Terminal de Suporte Proativo - Diagnóstico de Rede 

Este projeto é um protótipo funcional de um console de diagnóstico de rede, desenvolvido em **C# (.NET Console)**. Ele foi criado para substituir sistemas arcaicos por uma interface moderna, focada em **Acessibilidade**, **Prevenção de Erros** e **UX**.

## 👥 Equipe
* **ICARO FERREIRA DE OLIVEIRA**
* **KAIO ROBERTT MORREIRA ABREU**

---

## 🧠 Heurísticas de Nielsen Implementadas

O desenvolvimento seguiu rigorosamente os requisitos da missão propostos no cenário de TI:

### 1. Prevenção de Erros (Heurística #5)
Para evitar ações catastróficas por erro de digitação, o sistema protege operações críticas:
* **Confirmação Extra:** Antes de executar o comando `RESET`, o sistema entra em modo de alerta e exige uma confirmação clara ($S/N$) do técnico.
* **Validação de IP:** O comando `PING` valida a entrada de dados. Se o usuário digitar caracteres inválidos, o sistema sugere o formato correto: `XXX.XXX.XXX.XXX`.

### 2. Reconhecimento em vez de Recordação (Heurística #6) 
O técnico não precisa memorizar comandos extensos ou complexos:
* **Menu Fixo:** A tela principal exibe permanentemente um "Menu de Comandos Rápidos", permitindo que o usuário identifique as opções visualmente.

### 3. Ajuda e Documentação (Heurística #10) 
Implementação do comando `HELP`:
* **Documentação Contextual:** Oferece uma explicação breve de cada função (Ping, Reset e Sair) sem que o técnico precise sair da tela de operação atual.

---

## 🎨 Critérios de Avaliação de UX 

* **Gestão de Cores:** Uso estratégico para reduzir o tempo de reação e indicar estados:
    * **Verde:** Sucesso e operações finalizadas.
    * **Amarelo/Vermelho:** Estados de atenção e perigo em comandos críticos.
* **UX Writing:** Mensagens instrutivas e claras que guiam o usuário, abandonando o padrão rude de apenas dizer "Command Error".
* **Resiliência:** O programa foi desenvolvido para sobreviver a entradas de dados inesperadas, como letras em campos onde se esperam números ou IPs.

---

## 🚀 Instruções de Execução

1. Certifique-se de ter o ambiente .NET configurado.
2. Compile e execute a aplicação:
   ```bash
   dotnet run
   ```
