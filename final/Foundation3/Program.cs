using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Jr. Jazmpampa", "Callao", "Lima", "Peru");
        Lecture lecture1 = new Lecture("From Atoms to Humans", "Discover the science behind the elements that make us who we are.", "04/26/2023", "5:00 PM", address1, "Juan Campos", 40);

        Address address2 = new Address("103 N 65th St.", "Kansas City", "Kansas", "USA");
        Reception reception1 = new Reception("Naina and Dhruv's Wedding", "Neelam & Ajit Kapoor request the honor of your presence at the wedding of their daughter.", "06/10/2023", "7:30 PM", address2, "na.kapoor@gmail.com");

        Address address3 = new Address("Los Nogales 235", "Peor es Nada", "Chimbarongo", "Chile");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Día de la Independencia", "Come share with us a tasty Asado in our backyard to conmemorate our Independence.", "09/18/2023", "11:00 AM", address3, "Sunny with clear skies.");
        
        Console.Clear();
        Console.WriteLine(lecture1.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.DisplayLectureDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.DisplayShortDescription());

        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine();

        Console.WriteLine(reception1.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.DisplayReceptionDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.DisplayShortDescription());

        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine();

        Console.WriteLine(outdoorGathering1.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.DisplayOutdoorDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.DisplayShortDescription());
    }
}