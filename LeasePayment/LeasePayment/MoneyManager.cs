using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasePayment
{




    class MoneyManager
    {
        //declaring variables
        double stickerPrice;
        double residualVal;      
        double invoiceVal;
        double incentiveAmount;
        int leaseTerm;
        double moneyFactor;
        double taxPercent;

        public void Kickoff()
        {
            GetSticker();
            GetResidual();
            GetInvoice();
            GetIncentives();
            GetLeaseMonths();
            GetMoneyFactor();
            GetTaxPercentage();
            LeasePayment(stickerPrice,residualVal,invoiceVal,incentiveAmount,leaseTerm,moneyFactor,taxPercent);
            
        }
        public void GetSticker()
        {
            Console.WriteLine("Enter the High Sticker price of the vehicle...example: 26300 or 36500");
            string sticker = Console.ReadLine();

            bool isValidSticker = false;
            // int userChoice = int.Parse(ans);
            isValidSticker = double.TryParse(sticker, out stickerPrice);

            while (isValidSticker == false || (stickerPrice <= 12000 || stickerPrice >= 50000))
            {
                Console.WriteLine("Price invalid or you typed Gibberish!!!...Enter a Price between 12K & 50K!!!");
                sticker = Console.ReadLine();
                //userChoice = int.Parse(ans);
                double.TryParse(sticker, out stickerPrice);
            }
        }
   
    public void GetResidual()
        {
            Console.WriteLine("Enter the Residual Value...example: .45 or .58");
            string residual = Console.ReadLine();
            bool isValidResidual = false;
       
            isValidResidual = double.TryParse(residual, out residualVal);

            while (isValidResidual == false || (residualVal <= .30 || residualVal >= .65))
            {
                Console.WriteLine("Residual invalid or you typed Gibberish!!!...Enter a Residual between .30 & .65 !!!");
                residual = Console.ReadLine();
                //userChoice = int.Parse(ans);
                double.TryParse(residual, out residualVal);
            }
        }

        public void GetInvoice()
        {
            Console.WriteLine("Enter the Invoice of the Vehicle...example: 22500 or 36000");
            string invoice = Console.ReadLine();             
            bool isValidInvoice = false;

            isValidInvoice = double.TryParse(invoice, out invoiceVal);

            while (isValidInvoice == false || (invoiceVal <= 15000 || invoiceVal >= 50000))
            {
                Console.WriteLine("Invoice value invalid or you typed Gibberish!!!...Enter a Invoice value between 15000 & 50000 !!!");
                invoice = Console.ReadLine();              
                double.TryParse(invoice, out invoiceVal);
            }

        }

        public void GetIncentives()
        {
            Console.WriteLine("Enter the Incentives...example: 500 or 2250");
            string incentives = Console.ReadLine();
            bool isValidIncetives = false;

            isValidIncetives = double.TryParse(incentives, out incentiveAmount);

            while (isValidIncetives == false || (incentiveAmount <= 500 || incentiveAmount >= 15000))
            {
                Console.WriteLine("Incentive amount invalid or you typed Gibberish!!!...Enter a Incentive amount between 500 & 15000 !!!");
                incentives = Console.ReadLine();
                //userChoice = int.Parse(ans);
                double.TryParse(incentives, out incentiveAmount);
            }
        }

        public void GetLeaseMonths()
        {            
            Console.WriteLine("Enter the Lease # of Months...example:24 or 36");
            string lease = Console.ReadLine();
            bool isValidLeaseTime = false;
           
            isValidLeaseTime = int.TryParse(lease, out leaseTerm);

            while (isValidLeaseTime == false || (leaseTerm <= 24 || leaseTerm >= 60))
            {
                Console.WriteLine("Lease # of Months are invalid or you typed Gibberish!!!...Enter a Lease Term between 24 & 60 Months!!!");
                lease = Console.ReadLine();              
                int.TryParse(lease, out leaseTerm);
            }
            
        }

        public void GetMoneyFactor()
        {

            Console.WriteLine("Enter the Money Factor...example: .00125 or .00158");
            string mFactor = Console.ReadLine();
            bool isValidMoneyFactor = false;

            isValidMoneyFactor = double.TryParse(mFactor, out moneyFactor);

            while (isValidMoneyFactor == false || (moneyFactor <= .00100 || moneyFactor >= .00150))
            {
                Console.WriteLine("Money Factor invalid or you typed Gibberish!!!...Enter a Money Factor between .00100 & .00150!!!");
                mFactor = Console.ReadLine();
                double.TryParse(mFactor, out moneyFactor);
            }


        }
        public void GetTaxPercentage()
        {
            Console.WriteLine("Enter the tax % where you Live...example:1.08 or 1.65");
            string countyTax = Console.ReadLine();
            bool isValidTaxPercent = false;

            isValidTaxPercent = double.TryParse(countyTax, out taxPercent);

            while (isValidTaxPercent == false || (taxPercent <= 1.05 || taxPercent >= 1.10))
            {
                Console.WriteLine("Tax % invalid or you typed Gibberish!!!...Enter a Tax % between 1.05 & 1.10 !!!");
                countyTax = Console.ReadLine();

                double.TryParse(countyTax, out taxPercent);
            }
        }

        public void LeasePayment(double stickerPrice, double residualValuePercentage, double invoiceVal, double incentiveAmount, int leaseTerm, double moneyFactor, double taxPercent)
        {
            double residualVehicleAmount = stickerPrice * residualValuePercentage;
            double invoiceMinusIncents = invoiceVal - incentiveAmount;   //net capitalized cost
            double depreciation = invoiceMinusIncents - residualVehicleAmount;
            double baseMonthlyPayment = depreciation / leaseTerm;
            double leaseTimeMoneyFactor = invoiceVal * incentiveAmount;
            double capPlusResidual = invoiceMinusIncents + residualVehicleAmount;
            double interest = (invoiceMinusIncents + residualVehicleAmount) * moneyFactor;
            double totalPaymentBeforeTaxes = baseMonthlyPayment + interest;
            double taxTotal = taxPercent * .001;
            double paymentWithTaxes = totalPaymentBeforeTaxes * taxPercent;

            Console.WriteLine($"The High sticker price of {stickerPrice} times the residual value % of {residualValuePercentage} aka the Depreciation \n equals {residualVehicleAmount} ");
            Console.WriteLine($"The depreciation of {depreciation} divided by {leaseTerm} months gives you a base monthly payment of {baseMonthlyPayment} \n ");
            Console.WriteLine($"The Net Cap cost of {invoiceMinusIncents} plus the residual of {residualVehicleAmount} equals {capPlusResidual} times the money factor of {moneyFactor } equals \n  a monthly interest amount of {interest}  \n ");
            Console.WriteLine($"The monthly interest payment is {interest} plus the monthly base payment of {baseMonthlyPayment} gives you a base monthly payment of {totalPaymentBeforeTaxes} \n BEFORE TAXES!! ");
            Console.WriteLine($"The before tax amount of {totalPaymentBeforeTaxes} times the tax percentage of {taxPercent} gets you to a grand total of {paymentWithTaxes}  \n ");
            Console.ReadKey();
        }
    }
}


