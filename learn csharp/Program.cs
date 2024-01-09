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

/*
string[] fradulentosOrderIDs = new string[3];

fradulentosOrderIDs[0] = "A123";
fradulentosOrderIDs[1] = "B456";
fradulentosOrderIDs[2] = "C789";
//fradulentosOrderIDs[3] = "3222";

Console.WriteLine($"First: {fradulentosOrderIDs[0]}");
Console.WriteLine($"Second: {fradulentosOrderIDs[1]}");
Console.WriteLine($"Third: {fradulentosOrderIDs[2]}");

fradulentosOrderIDs[0] = "F000";

Console.WriteLine($"Resassign First: {fradulentosOrderIDs[0]}");
*/

string[] fraudulentOrderIDs = {"A", "B", "C"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

string[] names = {"Rosa", "Robin", "Bao"};

foreach(string name in names){
       Console.WriteLine(name);
}


int[] numbersfor = {1, 2, 3, 4};

foreach(int numeberfor in numbersfor){
       Console.WriteLine(numeberfor);
}

int[] inventory = {1, 2, 3, 4, 5, 6};

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");
 
 string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

int first = 2;
string second = "4";
string result2 = first + second;

string first2 = "5";
string second2 = "7";

int sum2 = int.Parse(first2) + int.Parse(second2);

string value3 = "102";
int result3 = 0;
if (int.TryParse(value3, out result3))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine(result2);

Console.WriteLine(sum2);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

















 // Aguarda a, entrada, do usuário antes de encerrar o programa.
        Console.ReadLine();
