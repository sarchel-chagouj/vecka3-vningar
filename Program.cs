namespace Vecka3Övningar
{
    // Abstrakt basklass för alla former
    abstract class Shape
    {
        // Alla former måste ha en metod som räknar ut arean
        public abstract double CalculateArea();
    }

    // Circle ärver från Shape
    class Circle : Shape
    {
        // Cirkelns radie
        private double radius;

        // Konstruktor som tar emot radien
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Räknar ut cirkelns area
        // Formel: pi * radie * radie
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Rectangle ärver från Shape
    class Rectangle : Shape
    {
        // Rektangelns bredd och höjd
        private double width;
        private double height;

        // Konstruktor som tar emot bredd och höjd
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Räknar ut rektangelns area
        // Formel: bredd * höjd
        public override double CalculateArea()
        {
            return width * height;
        }
    }

    // Square ärver från Shape
    class Square : Shape
    {
        // Kvadratens sida
        private double side;

        // Konstruktor som tar emot sidans längd
        public Square(double side)
        {
            this.side = side;
        }

        // Räknar ut kvadratens area
        // Formel: sida * sida
        public override double CalculateArea()
        {
            return side * side;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren vilken form de vill räkna ut
            Console.WriteLine("Vilken form vill du räkna ut?");
            Console.WriteLine("1. Cirkel");
            Console.WriteLine("2. Rektangel");
            Console.WriteLine("3. Kvadrat");

            string? choice = Console.ReadLine();


            Shape shape;

            if (choice == "1")
            {
                // Användaren väljer cirkel
                Console.WriteLine("Skriv cirkelns radie:");
                double radius = Convert.ToDouble(Console.ReadLine());

                shape = new Circle(radius);
            }
            else if (choice == "2")
            {
                // Användaren väljer rektangel
                Console.WriteLine("Skriv rektangelns bredd:");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Skriv rektangelns höjd:");
                double height = Convert.ToDouble(Console.ReadLine());

                shape = new Rectangle(width, height);
            }
            else if (choice == "3")
            {
                // Användaren väljer kvadrat
                Console.WriteLine("Skriv kvadratens sida:");
                double side = Convert.ToDouble(Console.ReadLine());

                shape = new Square(side);
            }
            else
            {
                Console.WriteLine("Fel val.");
                return;
            }

            // Räknar ut och visar arean
            Console.WriteLine("Arean är: " + shape.CalculateArea());


            // -------------------------
            // ÖVNING 2 - BANKKONTO
            // -------------------------

            // Skapar ett nytt bankkonto
            BankAccount account = new BankAccount();

            // Frågar användaren hur mycket pengar de vill sätta in
            Console.WriteLine("Hur mycket vill du sätta in?");

            // Läser in användarens svar och gör om det till double
            double amount = Convert.ToDouble(Console.ReadLine());

            // Sätter beloppet som saldo
            account.Balance = amount;

            // Visar det nya saldot
            Console.WriteLine("Nytt saldo: " + account.Balance);
            // -------------------------
            // ÖVNING 3 - AI CHATBOT
            // -------------------------

            // Skapar en ny chatbot
            Chatbot chatbot = new Chatbot();

            // Frågar användaren efter en fråga
            Console.WriteLine("Ställ en fråga till chatboten:");

            // Läser in frågan
            string question = Console.ReadLine() ?? "";



            // Hämtar ett slumpmässigt svar från chatboten
            string response = chatbot.GetResponse(question);

            // Skriver ut chatbotens svar
            Console.WriteLine("Chatbot: " + response);

            // ÖVNING 4 - MINIRÄKNARE

            // Frågar användaren efter det första talet
            Console.WriteLine("Skriv första talet:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Frågar användaren efter det andra talet
            Console.WriteLine("Skriv andra talet:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Räknar ut addition
            double addition = number1 + number2;

            // Räknar ut subtraktion
            double subtraction = number1 - number2;

            // Räknar ut multiplikation
            double multiplication = number1 * number2;

            // Räknar ut division
            double division = number1 / number2;

            // Visar resultaten
            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Subtraktion: " + subtraction);
            Console.WriteLine("Multiplikation: " + multiplication);
            Console.WriteLine("Division: " + division);


        }
    }
}
