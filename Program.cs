
   
        // Skapa en string-array med leksaker
        string[] toys = { "Barbie", "Lego", "Actionfigur", "Teddybjörn", "Brio Tåg" };

        // Skapa en string-array med klasskamraternas namn
        string[] classmates = { "Pelle", "Anna", "Lisa", "Erik", "Maja" };

        // Skapa en integer-array med betyg
        int[] ratings = { 5, 8, 6, 7, 9 };

        // Loop för att skriva ut leksakernas namn och betyg
        for (int i = 0; i < toys.Length; i++)
        {
            Console.WriteLine($"{classmates[i]} ger {toys[i]} betyget {ratings[i]}");
        }

        // Skapa en tom string-lista för städer
        List<string> cities = new List<string>();

        // Loop för att hämta städer från användaren
        while (true)
        {
            Console.Write("Skriv in en stad (eller 'exit' för att avsluta): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") break;

            cities.Add(input);
        }

        // Loop för att skriva ut alla städer
        Console.WriteLine("\nDu har sparat följande städer:");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }