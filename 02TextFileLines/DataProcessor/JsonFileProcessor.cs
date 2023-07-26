using System;
using System.IO;

namespace DataProcessor
{
    public class JsonFileProcessor
    {
   
  
        public string InputFilePath { get; }
        public string OutputFilePath { get; }

        public JsonFileProcessor(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        public void Process()
        {
            //// Using read all text
            //string originalText = File.ReadAllText(InputFilePath);
            //string processedText = originalText.ToUpperInvariant();
            //File.WriteAllText(OutputFilePath, processedText);

            // Using read all lines
            string originalText = File.ReadAllText(InputFilePath);
            string processedText = originalText.ToUpperInvariant();
            ///lines[1] = lines[1].ToUpperInvariant(); // Assumes there is a line 2 in the file
            File.WriteAllText(OutputFilePath, processedText);///a

        }
    }

    // Define la clase que representa la estructura de tus datos JSON
    public class YourClass
    {
        public string Propiedad1 { get; set; }
        public int Propiedad2 { get; set; }
        // Agrega más propiedades según la estructura de tus datos JSON
    }
}

