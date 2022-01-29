using System;

namespace _27._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double MoniinUSD = double.Parse(Console.ReadLine());
            double BTCpriceinUSD = double.Parse(Console.ReadLine());
            double SatoshionByte = double.Parse(Console.ReadLine());
            double BTCavailabletoBuy = MoniinUSD / BTCpriceinUSD;
            double TotalTransactionCostinBTC = BTCavailabletoBuy *(SatoshionByte * 1024) / 100000000;
            double BTCbought = BTCavailabletoBuy - TotalTransactionCostinBTC;
            double USDspendOnTax = TotalTransactionCostinBTC * BTCpriceinUSD;
            double progamerCom = BTCbought * (10.0 / 100);
            double BTCafterExp = BTCbought - progamerCom;
            Console.WriteLine($"Total BTC after exp:{BTCafterExp:F5}BTC");
            Console.WriteLine($"Tax:{USDspendOnTax:F2}USD");
            Console.WriteLine($"Programmer`s payment: {progamerCom:F5} BTC");
        }
    }
}
