using System;
using static System.Console;
namespace CSC240_03_02_PhoneCall_pmm
{
    internal class PhoneCall
    {
       private static double CalcPhoneCallPrice(int minutes, double rate) 
        {
            const double BASE_FEE = 0.25;
            double callFEE;
            callFEE = BASE_FEE + minutes * rate;
            return callFEE;
        }
        static void Main()
        {
            int[] callLengths = { 2, 5 };
            double[] rates = { 0.03, 0.12 };
            double priceOfCall;

            WriteLine("{0, 10}{1, 10}{2, 10}",
                "Minutes", "Rate", "Price");
            for(int x = 0; x < callLengths.Length; ++x)
                for(int y = 0; y < rates.Length; ++y)
                {
                    priceOfCall = CalcPhoneCallPrice(callLengths[x], rates[y]);
                    WriteLine("{0, 10}{1, 10}{2, 10}",
                        callLengths[x], rates[y], priceOfCall.ToString("C"));
                }
        }
    }
}
