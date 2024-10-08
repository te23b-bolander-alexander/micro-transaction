using System.Threading.Tasks.Dataflow;

bool success = false;
int ageNum = 0;
Random rnd = new Random();
int Money = rnd.Next(10, 100);
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
    Console.WriteLine("Välkommen till Drugs n Stuff!");
}
else
{
    Console.WriteLine($"Dra åt helvete ditt ollon!");
    Environment.Exit(0);
}

while (Money > 0)
{
    Console.WriteLine(" Vad är det du vill köpa?");
    Console.WriteLine("Kentucky homebrew 50kr, Fentanyl 200kr, Arla Snus 88kr");
    string vara = Console.ReadLine();

    int pricePer = 0;

    if (vara.ToUpper() == "FENTANYL")
    {
        pricePer = 200;
    }
    if (vara.ToUpper() == "KENTUCKY HOMEBREW")
    {
        pricePer = 50;
    }
    if (vara.ToUpper() == "SNUS")
    {
        pricePer = 88;
    }

    if (Money > pricePer)
    {
        Console.WriteLine("Du köper det du vill köpa och sedan går du hem");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Du har inte råd :(");
        Console.WriteLine("Du ser en gammal dam med en väska full med pengar");
        Console.WriteLine("Kommer du gå fram och försöka lura kärringen på pengar eller gå ut ur affären");
        String gåFram = Console.ReadLine();
        if (gåFram == "gå")
        {
            Console.WriteLine("Du går fram till damen och utmanar henne på en 50/50 spel där du kan dubbla dina pengar eller förlora allt");
            Console.WriteLine("Damen tar fram en klänypa och lägger den i en av sina händer bakom hennes rygg, Nådå väljer du höger eller vänster lilla du? säger Damen");
            String höger = Console.ReadLine();
            if (höger == "höger")
            {
                int pengar = rnd.Next(1, 2);
                if (pengar == 2)
                {
                    Money = Money + Money;
                }
                if (pengar == 1)
                {
                    Money = 0;
                    Console.WriteLine("Du har inga pengar kvar så du får gå hem");
                }

            }
            else
        {
            int pengar = rnd.Next(1, 2);
            if (pengar == 2)
                {
                    Money = Money + Money;
                }
                if (pengar == 1)
                {
                    Money = 0;
                    Console.WriteLine("Du har inga pengar kvar så du får gå hem");
                }
        }

        }
    }



}



Console.ReadLine();