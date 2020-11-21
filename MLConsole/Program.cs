using System;
using MLConsoleML.Model;

namespace MLConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput();
            input.SentimentText = "work at enjaz";
            ModelOutput modelOutput = ConsumeModel.Predict(input);
            Console.WriteLine($"Text:{input.SentimentText}\nIs Toxic:{modelOutput.Prediction}");
            Console.ReadKey();
        }
    }
}
