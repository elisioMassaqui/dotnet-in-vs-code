﻿// See https://aka.ms/new-console-template for more information e voltamos tudo bem kkk
//Adicionamos o gitignore pra igonrar coisas que não se devem no visual studio
Console.WriteLine("Hello, World!");

int numero = 28;

Console.WriteLine(numero);

Random dice = new Random();
//Conjunto de numeros inteiros vai aarmazenar numero aleatorio de 1 a 7
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First Roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
//Directamente sem atribuir a uma variavel.
Console.WriteLine(dice.Next(1, 7));

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

int firsValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firsValue, secondValue);
Console.WriteLine(largerValue);


 // Aguarda a entrada do usuário antes de encerrar o programa.
        Console.ReadLine();
