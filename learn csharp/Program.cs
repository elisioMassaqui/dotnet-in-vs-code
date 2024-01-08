// See https://aka.ms/new-console-template for more information e voltamos tudo bem kkk
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

int totalRoll = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {totalRoll}");

if (totalRoll >= 15)
{
       Console.WriteLine("You Win");
}

else
{
       Console.WriteLine("Sorry, You Lose");
}

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


string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
       Console.WriteLine("What does the fox say kkk");
}

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
       Console.WriteLine("You rolled doubles! +2 bonus to total!");
       totalRoll += 2;
}

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
       Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
       Console.WriteLine("Your subscription expires in _ days");
       Console.WriteLine("Renew and save 10%");
}
else if(daysUntilExpiration == 1){
       Console.WriteLine("Your subscription expires within days");
       Console.WriteLine("Renew and save 20%");
}
else if(daysUntilExpiration > 10){
       Console.WriteLine();
}
if(daysUntilExpiration == 0){
       Console.WriteLine("Your subscription has expired.");
}
 // Aguarda a, entrada, do usuário antes de encerrar o programa.
        Console.ReadLine();
