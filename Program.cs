using System;

namespace Electricity_bill
{
    internal class Program
    {
       static double StandardPriceperUnit = 1.2, GeneratedBill, units;
       static int PrevUnits, CurrentUnits;
        static int AskUserForUsedUnits(string when) 
        {
            Console.Write($"\nEnter {when} month recorded units ");
            string usrChoice = Console.ReadLine();
            return int.Parse(usrChoice);
        }

        static double CalculateBill(double units)
        {
            //• If number of units are less than 100 then standard price per unit will be applied.
            if (units < 100) return units * StandardPriceperUnit;

            //• If it is less than or equal to 300 units then Rs. 2 will be charged for number of units over and above 100 units.
            else if (units <= 300) return (100 * 1.2) + (units - 100) * 2;

            //• If it is greater 300 units then Rs. 2 will charged for additional 200 units above 100 units and Rs. 3 will be charged for additional units above 300.
            
            return (100 * 1.2) + (200 * 2) + (units - 300) * 3;

        }
        static void Main()
        {
            //The standard price per unit is Rs. 1.20



            PrevUnits = AskUserForUsedUnits("Previous");
            CurrentUnits = AskUserForUsedUnits("This");

            units = CurrentUnits - PrevUnits;
            
            GeneratedBill = CalculateBill(units);
            Console.WriteLine($"\nThe Electricity Bill for this month is {GeneratedBill}");
            
            
        }
    }
}
