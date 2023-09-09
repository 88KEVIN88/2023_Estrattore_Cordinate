using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Percorso del file CSV di origine
        string sourceFilePath = "relitti1.csv";

        // Percorso del file CSV di destinazione
        string destinationFilePath = "output.csv";

        try
        {
            using (var reader = new StreamReader(sourceFilePath))
            {
                using (var writer = new StreamWriter(destinationFilePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Dividi la riga in campi utilizzando la virgola come separatore
                        string[] fields = line.Split(';');

                        // Verifica che ci siano almeno 9 campi nella riga
                        if (fields.Length >= 9)
                        {
                            // Estrai gli ultimi due campi (campo 8 e campo 9)
                            string lastTwoFields = fields[7] + "," + fields[8];

                            // Scrivi gli ultimi due campi nel file di destinazione
                            writer.WriteLine(lastTwoFields);
                            

                        }
                    }
                }
            }
           

            Console.WriteLine("Dati estratti e salvati con successo nel file CSV di destinazione.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Si è verificato un errore durante l'elaborazione: {ex.Message}");
        }
    }
}
