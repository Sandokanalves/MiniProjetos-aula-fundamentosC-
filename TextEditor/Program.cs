﻿// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir Arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch(option){

            case 0:  System.Environment.Exit(0); break;
            case 1: Abrir();break;
            case 2: Editar();break;
            default: Menu();break;

    }

}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual o Caminho?");
    var path = Console.ReadLine();

    using(var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }
    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}

static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para Sair)");
    Console.WriteLine("--------------------------------------");
    string text = "";


    do //faça
    {
        text += Console.ReadLine();
        text += Environment.NewLine;

    }
    while(Console.ReadKey().Key != ConsoleKey.Escape); //enquanto
    Console.Write(text);

    Salvar(text);
}

static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("Qual o caminho para salvar o arquivo?");
    var path = Console.ReadLine();

    using(var file = new StreamWriter(path))
    {
        file.Write(text);
    }
    Console.WriteLine($"Arquivo {path} Salvo com sucesso! ");
    Console.ReadLine();
    Menu();
}   