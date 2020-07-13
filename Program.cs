using System;

namespace TransSurchg
{
    class Program
    {
        static void Main(string[] args)
        {
             while (true)
            {
                var transferAdvice = new TransferAdvice();
                var input = 0;

                Console.WriteLine("Enter amount to be transfered:\n");

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    var transferAmount = transferAdvice.GetAmountToTransfer(input);
                    var charge = TransFeeCalculator.CalculateFee(transferAmount);

                    Console.WriteLine(String.Format("{0, -60}","----------------------------------------------------------------------------------------"));
                    Console.WriteLine(String.Format("{0, -15}{1, -20}{2,-10}{3, -30}","Amount","TransferAmount","Charge","Debit Amount (Transfer Amount + Charge)"));
                    Console.WriteLine(String.Format("{0, -60}","----------------------------------------------------------------------------------------"));
                    Console.WriteLine("{0, -15}{1, -20}{2,-10}{3, -30}", input, transferAmount, charge, transferAmount + charge);
                    Console.WriteLine(String.Format("{0, -60}","----------------------------------------------------------------------------------------\n"));
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }

            Console.WriteLine("\nPress \'ctrl + c\' to exit");
            Console.ReadLine();
        }
    }
}
