bool success = false;
int ageNum = 0;
Random rnd = new Random();
int Money = rnd.Next(10,100);
Console.WriteLine($"du har {Money} riksdaler kvar");
while (success != true)
{

    Console.WriteLine("Ålder:");

    string age = Console.ReadLine();

    success = int.TryParse(age, out ageNum);

    if (success == false)
    {
        Console.WriteLine("Du Måste Skriva Ett Nummer!");
    }
}

if (ageNum >= 18)
{
    Console.WriteLine("Välkommen till Drugs n stuff!");
}
else
{
    Console.WriteLine($"Dra åt helvete ditt ollon!");
}

while(Money>0)
{
    Console.WriteLine("Välkommen till Drugs n Stuff, Vad är det du vill köpa?");
    Console.WriteLine("");
    //skriv vad dom vill köpa
}

Console.ReadLine();