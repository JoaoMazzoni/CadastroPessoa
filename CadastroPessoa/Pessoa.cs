using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pessoa
{
    public string Nome;
    public string Sobrenome;
    public int Idade;
    public string Telefone;
    public string Celular;
    public string Email;


    public Pessoa()
    {
    

    }

    public string definirNome() //Com retorno
    {
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine("Informe o nome: "); 
        return Console.ReadLine();
    }
    public string definirSobrenome() //Com retorno
    {
        Console.WriteLine("Informe o sobrenome: "); 
        return Console.ReadLine();
    }

    public int definirIdade() //Com retorno
    {
        Console.WriteLine("Informe a Idade: "); 
        return int.Parse(Console.ReadLine());
    }

    public void definirTelefone(string telefone) //Com parâmetro
    {
        this.Telefone = telefone; //Usando "this"
    }

    public void definirCelular(string celular) //Com parâmetro
    {
        this.Celular = celular;

    }

    public void definirEmail(string email) //Com parâmetro
    { 
        this.Email = email;
    }
    
    public void mostrarDados()
    {
        Console.WriteLine($"\n\nNome: {Nome}", this.Nome);
        Console.WriteLine($"Sobrenome: {Sobrenome}", this.Sobrenome);
        Console.WriteLine("Idade: " + this.Idade);
        Console.WriteLine("Telefone: " + this.Telefone);
        Console.WriteLine($"Celular: {Celular}", this.Celular);
        Console.WriteLine($"Email: {Email}", this.Email);

    }
}