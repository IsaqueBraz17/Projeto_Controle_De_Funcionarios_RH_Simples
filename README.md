# Projeto_Controle_De_Funcionarios_RH_Simples

# 🧩 Sistema de Controle de Funcionários – RH  
<br>

🚀 Projeto desenvolvido em **C# (.NET Console Application)** com o objetivo de colocar em prática conceitos fundamentais de **Programação Orientada a Objetos (POO)** e **lógica de programação**.  
<br>

Este sistema simula um controle de funcionários para o setor de RH, permitindo **cadastrar, atualizar, listar e excluir** registros diretamente pelo console.  
<br><br>

---

## 💻 Funcionalidades  
<br>

❎ **Cadastrar funcionário** — adiciona um novo colaborador com dados como nome, CPF, RH, e-mail, telefone e data de admissão.  
❎ **Atualizar funcionário** — permite editar informações já cadastradas.  
❎ **Listar funcionários** — exibe todos os registros salvos de forma organizada.  
❎ **Deletar funcionário** — remove um funcionário da lista.  
❎ **Encerrar o programa** — finaliza a execução da aplicação.  
<br><br>

---

## 📚 Conceitos aplicados  
<br>

❎ Classes e objetos  
❎ Métodos e parâmetros  
❎ Listas genéricas (`List<Funcionario>`)  
❎ Estruturas condicionais e de repetição  
❎ Manipulação de dados via console  
❎ Organização e legibilidade de código  
<br><br>

---

## 🧠 Aprendizados  
<br>

Durante o desenvolvimento desse projeto, pude:  
❎ Consolidar minha base em **C# e POO**  
❎ Entender melhor a **responsabilidade de cada classe e método**  
❎ Praticar a **lógica de programação aplicada em um caso real**  
❎ Melhorar a **estrutura, modularização e clareza do código**  
<br><br>

---

## 🧩 Estrutura da Classe `Funcionario`  
<br>

```csharp
class Funcionario
{
    public string Nome;
    public string CPF;
    public string RH;
    public string Email;
    public string Telefone;
    public DateTime Data_Admissao;
}
