namespace Vecka3Övningar
{
    // Klass som representerar ett bankkonto
    internal class BankAccount
    {
        // Privat variabel som lagrar saldot
        // Eftersom den är private kan man inte ändra den direkt utifrån klassen
        private double balance;

        // Property som används för att läsa och ändra saldot
        public double Balance
        {
            // Hämtar det aktuella saldot
            get { return balance; }

            // Försöker ändra saldot
            set
            {
                // Kontrollerar att det nya saldot inte är negativt
                if (value >= 0)
                {
                    // Om värdet är 0 eller högre sparas det som nytt saldo
                    balance = value;
                }
            }
        }
    }
}
