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
        }
    }
}
