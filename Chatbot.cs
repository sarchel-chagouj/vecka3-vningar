namespace Vecka3Övningar
{
    // Klass som fungerar som vår enkla AI-chatbot
    internal class Chatbot
    {
        // Skapar ett Random-objekt som används för att välja slumpmässigt
        private Random random = new Random();

        // Metod som tar emot användarens fråga
        public string GetResponse(string question)
        {
            // Olika svar som chatboten kan ge
            string[] responses =
            {
                "Det var en intressant fråga!",
                "Jag tror att svaret är ja.",
                "Jag behöver tänka lite på det.",
                "Det låter som en bra fråga!",
                "Jag håller med dig!",
                "Intressant! Berätta mer."
            };

            // Slumpar fram ett nummer mellan 0 och antalet svar
            int index = random.Next(responses.Length);

            // Returnerar det slumpmässigt valda svaret
            return responses[index];
        }
    }
}
