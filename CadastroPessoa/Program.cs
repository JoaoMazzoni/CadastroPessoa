
string telefone, celular, email;
Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();
Pessoa pessoa3 = new Pessoa();

Pessoa criarPessoa()
{
    Pessoa pessoa = new Pessoa();
    pessoa.Nome = pessoa.definirNome(); //Sem parâmetros com retorno
    pessoa.Sobrenome = pessoa.definirSobrenome(); // Sem parâmetros com retorno
    pessoa.Idade = pessoa.definirIdade(); //Sem parâmetros com retorno

    Console.WriteLine("Informe o telefone: "); //Com parêmetros usando "this"
    telefone = Console.ReadLine();
    pessoa.definirTelefone(telefone);

    Console.WriteLine("Informe o celular: "); //Com parêmetros usando "this"
    celular = Console.ReadLine();
    pessoa.definirCelular(celular);


    Console.WriteLine("Informe o email: ");//Com parêmetros usando "this"
    email = Console.ReadLine();
    pessoa.definirEmail(email);

    return pessoa;
}

pessoa1 = criarPessoa();
pessoa2 = criarPessoa();
pessoa3 = criarPessoa();

Console.WriteLine("\nPrimeiro cadastro: ");
pessoa1.mostrarDados();

Console.WriteLine("\nSegundo cadastro: ");
pessoa2.mostrarDados();

Console.WriteLine("\nTerceiro cadastro: ");
pessoa3.mostrarDados();