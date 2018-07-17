using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankCardGenerator
{
    public partial class BankCardGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        #region GeneratorControls
        protected void btngenerateVISA_Click(object sender, EventArgs e)
        {
            VisaCardGenerator();
        }

        protected void btngenerateMASTER_Click(object sender, EventArgs e)
        {
            MasterCardGenerator();
        }

        protected void btngenerateAmericanExpress_Click(object sender, EventArgs e)
        {
            AmericanExpressGenerator();
        }

        protected void btngenerateDISCOVER_Click(object sender, EventArgs e)
        {
            DiscoverCardGenerator();
        }

        protected void btngenerateBankInformation_Click(object sender, EventArgs e)
        {
            BankInformationGenerator();
        }

        #endregion


        #region VisaCard
        private void VisaCardGenerator()
        {
            VisaNameOnCard();
            VisaCardNumber();
            VisaCardCSV();
            VisaCardExpDate();
        }

        private void VisaNameOnCard()
        {
            string firstnameOnCard = txtFirstName.Text;
            string middleInitialOnCard = txtMiddleName.Text;
            string lastnameOnCard = txtlastname.Text;

            StringBuilder sb = new StringBuilder();

            if (middleInitialOnCard == " " || middleInitialOnCard == null)
            {

                sb.Append(firstnameOnCard);
                sb.Append(' ', 1);
                sb.Append(lastnameOnCard);

            }
            else
            {
                sb.Append(firstnameOnCard);
                sb.Append(' ', 1);
                sb.Append(middleInitialOnCard);
                sb.Append(' ', 1);
                sb.Append(lastnameOnCard);
            }

            lblFullNameOnVisa.Text = sb.ToString();

        }

        private void VisaCardNumber()
        {
            //Visa -- 4xxxxx **First Octet must be 4**

            StringBuilder OctetGroup1 = new StringBuilder();
            StringBuilder OctetGroup2 = new StringBuilder();
            StringBuilder OctetGroup3 = new StringBuilder();
            StringBuilder OctetGroup4 = new StringBuilder();

            StringBuilder CreditCardNumber = new StringBuilder();

            Random rnd = new Random();
            //Standard Visa Card First 4 Octets
            int standardOctet = 4;
            int Octet1 = rnd.Next(5, 10);
            int Octet2 = rnd.Next(0, 10);
            int Octet3 = rnd.Next(0, 10);

            OctetGroup1.Append(standardOctet);
            OctetGroup1.Append(Octet1);
            OctetGroup1.Append(Octet2);
            OctetGroup1.Append(Octet3);

            //Second set of Octets
            int Octet4 = rnd.Next(0, 10);
            int Octet5 = rnd.Next(0, 10);
            int Octet6 = rnd.Next(0, 10);
            int Octet7 = rnd.Next(0, 10);

            OctetGroup2.Append(Octet4);
            OctetGroup2.Append(Octet5);
            OctetGroup2.Append(Octet6);
            OctetGroup2.Append(Octet7);


            //Third set of Octets
            int Octet8 = rnd.Next(0, 10);
            int Octet9 = rnd.Next(0, 10);
            int Octet10 = rnd.Next(0, 10);
            int Octet11 = rnd.Next(0, 10);

            OctetGroup3.Append(Octet8);
            OctetGroup3.Append(Octet9);
            OctetGroup3.Append(Octet10);
            OctetGroup3.Append(Octet11);


            //Fourth set of Octets
            int Octet12 = rnd.Next(0, 10);
            int Octet13 = rnd.Next(0, 10);
            int Octet14 = rnd.Next(0, 10);
            int Octet15 = rnd.Next(0, 10);

            OctetGroup4.Append(Octet12);
            OctetGroup4.Append(Octet13);
            OctetGroup4.Append(Octet14);
            OctetGroup4.Append(Octet15);

            CreditCardNumber.Append(OctetGroup1);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup2);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup3);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup4);

            lblVisaCardNumber.Text = CreditCardNumber.ToString();

            //Console.WriteLine(CreditCardNumber);
        }

        private void VisaCardCSV()
        {
            StringBuilder CSVOctets = new StringBuilder();
            StringBuilder CSVNumber = new StringBuilder();
            Random rnd = new Random();

            int Octet1 = rnd.Next(1, 10);
            int Octet2 = rnd.Next(0, 10);
            int Octet3 = rnd.Next(0, 10);

            CSVOctets.Append(Octet1);
            CSVOctets.Append(Octet2);
            CSVOctets.Append(Octet3);

            CSVNumber.Append(CSVOctets);

            lblvisaCSVNumber.Text = CSVNumber.ToString();
            //Console.WriteLine(CSVNumber);
        }

        private void VisaCardExpDate()
        {
            StringBuilder ExpirationMonth = new StringBuilder();
            StringBuilder ExpirationYear = new StringBuilder();
            StringBuilder CreditCardExpiration = new StringBuilder();
            Random rnd = new Random();

            //int ExpMonth1 = rnd.Next(0, 1);
            int ExpMonth2 = rnd.Next(01, 13);
            int ExpYear = rnd.Next(20, 27);

            //ExpirationMonth.Append(ExpMonth1);
            ExpirationMonth.Append(ExpMonth2);
            ExpirationYear.Append(ExpYear);

            CreditCardExpiration.Append(ExpirationMonth);
            CreditCardExpiration.Append('/');
            CreditCardExpiration.Append(ExpirationYear);

            lblvisaExpDate.Text = CreditCardExpiration.ToString();
            //Console.WriteLine(CreditCardExpiration);
        }
        #endregion

        #region MasterCard
        private void MasterCardGenerator()
        {
            MasterNameOnCard();
            MasterCardNumber();
            MasterCardCSV();
            MasterCardExpDate();
        }

        private void MasterNameOnCard()
        {
            string firstnameOnCard = txtFirstName.Text;
            string middleInitialOnCard = txtMiddleName.Text;
            string lastnameOnCard = txtlastname.Text;

            StringBuilder sb = new StringBuilder();

            if (middleInitialOnCard == " " || middleInitialOnCard == null)
            {

                sb.Append(firstnameOnCard);
                sb.Append(' ', 1);
                sb.Append(lastnameOnCard);

            }
            else
            {
                sb.Append(firstnameOnCard);
                sb.Append(' ', 1);
                sb.Append(middleInitialOnCard);
                sb.Append(' ', 1);
                sb.Append(lastnameOnCard);
            }

            lblFullNameOnMaster.Text = sb.ToString();

        }

        private void MasterCardNumber()
        {

            //MasterCard -- 51xxxx-55xxxx  **First 2 Octets must be between (51 and 55)**
            StringBuilder OctetGroup1 = new StringBuilder();
            StringBuilder OctetGroup2 = new StringBuilder();
            StringBuilder OctetGroup3 = new StringBuilder();
            StringBuilder OctetGroup4 = new StringBuilder();

            StringBuilder CreditCardNumber = new StringBuilder();

            Random rnd = new Random();
            //Standard MasterCard First 2 Octets
            int standardOctet1 = 5;
            int standardOctet2 = rnd.Next(1, 5);
            int Octet2 = rnd.Next(0, 10);
            int Octet3 = rnd.Next(0, 10);

            OctetGroup1.Append(standardOctet1);
            OctetGroup1.Append(standardOctet2);
            OctetGroup1.Append(Octet2);
            OctetGroup1.Append(Octet3);

            //Second set of Octets
            int Octet4 = rnd.Next(0, 10);
            int Octet5 = rnd.Next(0, 10);
            int Octet6 = rnd.Next(0, 10);
            int Octet7 = rnd.Next(0, 10);

            OctetGroup2.Append(Octet4);
            OctetGroup2.Append(Octet5);
            OctetGroup2.Append(Octet6);
            OctetGroup2.Append(Octet7);


            //Third set of Octets
            int Octet8 = rnd.Next(0, 10);
            int Octet9 = rnd.Next(0, 10);
            int Octet10 = rnd.Next(0, 10);
            int Octet11 = rnd.Next(0, 10);

            OctetGroup3.Append(Octet8);
            OctetGroup3.Append(Octet9);
            OctetGroup3.Append(Octet10);
            OctetGroup3.Append(Octet11);


            //Fourth set of Octets
            int Octet12 = rnd.Next(0, 10);
            int Octet13 = rnd.Next(0, 10);
            int Octet14 = rnd.Next(0, 10);
            int Octet15 = rnd.Next(0, 10);

            OctetGroup4.Append(Octet12);
            OctetGroup4.Append(Octet13);
            OctetGroup4.Append(Octet14);
            OctetGroup4.Append(Octet15);

            CreditCardNumber.Append(OctetGroup1);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup2);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup3);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup4);

            lblmasterCardNumber.Text = CreditCardNumber.ToString();
            //Console.WriteLine(CreditCardNumber);
        }

        private void MasterCardCSV()
        {
            StringBuilder CSVOctets = new StringBuilder();
            StringBuilder CSVNumber = new StringBuilder();
            Random rnd = new Random();

            int Octet1 = rnd.Next(1, 10);
            int Octet2 = rnd.Next(0, 10);
            int Octet3 = rnd.Next(0, 10);

            CSVOctets.Append(Octet1);
            CSVOctets.Append(Octet2);
            CSVOctets.Append(Octet3);

            CSVNumber.Append(CSVOctets);

            lblmasterCSVNumber.Text = CSVNumber.ToString();
          
        }

        private void MasterCardExpDate()
        {
            StringBuilder ExpirationMonth = new StringBuilder();
            StringBuilder ExpirationYear = new StringBuilder();
            StringBuilder CreditCardExpiration = new StringBuilder();
            Random rnd = new Random();

            //int ExpMonth1 = rnd.Next(0, 1);
            int ExpMonth2 = rnd.Next(01, 13);
            int ExpYear = rnd.Next(20, 27);

            //ExpirationMonth.Append(ExpMonth1);
            ExpirationMonth.Append(ExpMonth2);
            ExpirationYear.Append(ExpYear);

            CreditCardExpiration.Append(ExpirationMonth);
            CreditCardExpiration.Append('/');
            CreditCardExpiration.Append(ExpirationYear);

            lblmasterExpDate.Text = CreditCardExpiration.ToString();

        }
        #endregion

        #region AmericanExpress
        private void AmericanExpressGenerator()
        {
            AmericanExpressNameOnCard();
            AmericanExpressCardNumber();
            AmericanExpressCardCSV();
            AmericanExpressCardExpDate();
        }

        private void AmericanExpressNameOnCard()
        {
            string firstnameOnCard = txtFirstName.Text;
            string middleInitialOnCard = txtMiddleName.Text;
            string lastnameOnCard = txtlastname.Text;

            StringBuilder sb = new StringBuilder();
        
            if (middleInitialOnCard == " " ||  middleInitialOnCard == null)
               {

                    sb.Append(firstnameOnCard);
                    sb.Append(' ', 1);
                    sb.Append(lastnameOnCard);

               }
               else
               {
                    sb.Append(firstnameOnCard);
                    sb.Append(' ', 1);
                    sb.Append(middleInitialOnCard);
                    sb.Append(' ', 1);
                    sb.Append(lastnameOnCard);
               }

            lblFullNameOnAmEx.Text = sb.ToString();

        }

        private void AmericanExpressCardNumber()
        {
            //American Express -- 34xxxx and 37xxxx **First 2 Octets must be between (34 and 37)** 

            StringBuilder OctetGroup1 = new StringBuilder();
            StringBuilder OctetGroup2 = new StringBuilder();
            StringBuilder OctetGroup3 = new StringBuilder();
            StringBuilder OctetGroup4 = new StringBuilder();

            StringBuilder CreditCardNumber = new StringBuilder();

            Random rnd = new Random();
            //Standard American Express First 4 Octets
            int standardOctet1 = 3;
            int standardOctet2 = rnd.Next(4, 8);
            int Octet2 = rnd.Next(0, 10);
            int Octet3 = rnd.Next(0, 10);

            OctetGroup1.Append(standardOctet1);
            OctetGroup1.Append(standardOctet2);
            OctetGroup1.Append(Octet2);
            OctetGroup1.Append(Octet3);

            //Second set of Octets
            int Octet4 = rnd.Next(0, 10);
            int Octet5 = rnd.Next(0, 10);
            int Octet6 = rnd.Next(0, 10);
            int Octet7 = rnd.Next(0, 10);

            OctetGroup2.Append(Octet4);
            OctetGroup2.Append(Octet5);
            OctetGroup2.Append(Octet6);
            OctetGroup2.Append(Octet7);


            //Third set of Octets
            int Octet8 = rnd.Next(0, 10);
            int Octet9 = rnd.Next(0, 10);
            int Octet10 = rnd.Next(0, 10);
            int Octet11 = rnd.Next(0, 10);

            OctetGroup3.Append(Octet8);
            OctetGroup3.Append(Octet9);
            OctetGroup3.Append(Octet10);
            OctetGroup3.Append(Octet11);


            //Fourth set of Octets
            int Octet12 = rnd.Next(0, 10);
            int Octet13 = rnd.Next(0, 10);
            int Octet14 = rnd.Next(0, 10);
            int Octet15 = rnd.Next(0, 10);

            OctetGroup4.Append(Octet12);
            OctetGroup4.Append(Octet13);
            OctetGroup4.Append(Octet14);
            OctetGroup4.Append(Octet15);

            CreditCardNumber.Append(OctetGroup1);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup2);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup3);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup4);

            lblAmExpNumber.Text = CreditCardNumber.ToString();

        }

        private void AmericanExpressCardCSV()
        {
            StringBuilder CSVOctets = new StringBuilder();
            StringBuilder CSVNumber = new StringBuilder();
            Random rnd = new Random();

            int Octet1 = rnd.Next(1, 10);
            int Octet2 = rnd.Next(0, 10);
            int Octet3 = rnd.Next(0, 10);

            CSVOctets.Append(Octet1);
            CSVOctets.Append(Octet2);
            CSVOctets.Append(Octet3);

            CSVNumber.Append(CSVOctets);


            lblAmExpCSVNumber.Text = CSVNumber.ToString();

        }

        private void AmericanExpressCardExpDate()
        {
            StringBuilder ExpirationMonth = new StringBuilder();
            StringBuilder ExpirationYear = new StringBuilder();
            StringBuilder CreditCardExpiration = new StringBuilder();
            Random rnd = new Random();

            //int ExpMonth1 = rnd.Next(0, 1);
            int ExpMonth2 = rnd.Next(01, 13);
            int ExpYear = rnd.Next(20, 27);

            //ExpirationMonth.Append(ExpMonth1);
            ExpirationMonth.Append(ExpMonth2);
            ExpirationYear.Append(ExpYear);

            CreditCardExpiration.Append(ExpirationMonth);
            CreditCardExpiration.Append('/');
            CreditCardExpiration.Append(ExpirationYear);

            lblAmExpExpDate.Text = CreditCardExpiration.ToString();

        }
        #endregion

        #region DiscoverCard
        private void DiscoverCardGenerator()
        {
            DiscoverNameOnCard();
            DiscoverCardNumber();
            DiscoverCardCSV();
            DiscoverCardExpDate();
        }

        private void DiscoverNameOnCard()
        {
            string firstnameOnCard = txtFirstName.Text;
            string middleInitialOnCard = txtMiddleName.Text;
            string lastnameOnCard = txtlastname.Text;

            StringBuilder sb = new StringBuilder();

            if (middleInitialOnCard == " " || middleInitialOnCard == null)
            {

                sb.Append(firstnameOnCard);
                sb.Append(' ', 1);
                sb.Append(lastnameOnCard);

            }
            else
            {
                sb.Append(firstnameOnCard);
                sb.Append(' ', 1);
                sb.Append(middleInitialOnCard);
                sb.Append(' ', 1);
                sb.Append(lastnameOnCard);
            }

            lblFullNameOnDiscover.Text = sb.ToString();

        }

        private void DiscoverCardNumber()
        {

            //Discover -- 6011xx -- **First 4 Octets must be 6011**
            StringBuilder OctetGroup1 = new StringBuilder();
            StringBuilder OctetGroup2 = new StringBuilder();
            StringBuilder OctetGroup3 = new StringBuilder();
            StringBuilder OctetGroup4 = new StringBuilder();

            StringBuilder CreditCardNumber = new StringBuilder();

            Random rnd = new Random();
            //Standard MasterCard First 4 Octets
            int standardOctet1 = 6;
            int standardOctet2 = 0;
            int standardOctet3 = 1;
            int standardOctet4 = 1;

            OctetGroup1.Append(standardOctet1);
            OctetGroup1.Append(standardOctet2);
            OctetGroup1.Append(standardOctet3);
            OctetGroup1.Append(standardOctet4);

            //Second set of Octets
            int Octet4 = rnd.Next(0, 10);
            int Octet5 = rnd.Next(0, 10);
            int Octet6 = rnd.Next(0, 10);
            int Octet7 = rnd.Next(0, 10);

            OctetGroup2.Append(Octet4);
            OctetGroup2.Append(Octet5);
            OctetGroup2.Append(Octet6);
            OctetGroup2.Append(Octet7);


            //Third set of Octets
            int Octet8 = rnd.Next(0, 10);
            int Octet9 = rnd.Next(0, 10);
            int Octet10 = rnd.Next(0, 10);
            int Octet11 = rnd.Next(0, 10);

            OctetGroup3.Append(Octet8);
            OctetGroup3.Append(Octet9);
            OctetGroup3.Append(Octet10);
            OctetGroup3.Append(Octet11);


            //Fourth set of Octets
            int Octet12 = rnd.Next(0, 10);
            int Octet13 = rnd.Next(0, 10);
            int Octet14 = rnd.Next(0, 10);
            int Octet15 = rnd.Next(0, 10);

            OctetGroup4.Append(Octet12);
            OctetGroup4.Append(Octet13);
            OctetGroup4.Append(Octet14);
            OctetGroup4.Append(Octet15);

            CreditCardNumber.Append(OctetGroup1);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup2);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup3);
            CreditCardNumber.Append('-');
            CreditCardNumber.Append(OctetGroup4);

            lbldiscoverCardNumber.Text = CreditCardNumber.ToString();

            //Console.WriteLine(CreditCardNumber);
        }

        private void DiscoverCardCSV()
        {
            StringBuilder CSVOctets = new StringBuilder();
            StringBuilder CSVNumber = new StringBuilder();
            Random rnd = new Random();

            int Octet1 = rnd.Next(1, 10);
            int Octet2 = rnd.Next(0, 10);
            int Octet3 = rnd.Next(0, 10);

            CSVOctets.Append(Octet1);
            CSVOctets.Append(Octet2);
            CSVOctets.Append(Octet3);

            CSVNumber.Append(CSVOctets);

            lbldiscoverCardCSVNumber.Text = CSVNumber.ToString();

        }

        private void DiscoverCardExpDate()
        {
            StringBuilder ExpirationMonth = new StringBuilder();
            StringBuilder ExpirationYear = new StringBuilder();
            StringBuilder CreditCardExpiration = new StringBuilder();
            Random rnd = new Random();

            //int ExpMonth1 = rnd.Next(0, 1);
            int ExpMonth2 = rnd.Next(01, 13);
            int ExpYear = rnd.Next(20, 27);

            //ExpirationMonth.Append(ExpMonth1);
            ExpirationMonth.Append(ExpMonth2);
            ExpirationYear.Append(ExpYear);

            CreditCardExpiration.Append(ExpirationMonth);
            CreditCardExpiration.Append('/');
            CreditCardExpiration.Append(ExpirationYear);

            lbldiscoverExpDate.Text = CreditCardExpiration.ToString();

        }
        #endregion

        #region BankInformation
        private void BankInformationGenerator()
        {
            BankRoutingNumber();
            BankAccountNumber();
        }

        private void BankRoutingNumber()
        {
            Random rnd = new Random();
            StringBuilder routingNumber = new StringBuilder();
            int digit0 = rnd.Next(0, 4);
            int digit1 = rnd.Next(0, 4);
            int digit2 = rnd.Next(0, 4);
            int digit3 = rnd.Next(0, 9);
            int digit4 = rnd.Next(0, 9);
            int digit5 = rnd.Next(0, 9);
            int digit6 = rnd.Next(0, 9);
            int digit7 = rnd.Next(5, 10);
            int digit8 = rnd.Next(5, 10);


            routingNumber.Append(digit0);
            routingNumber.Append(digit1);
            routingNumber.Append(digit2);
            routingNumber.Append(digit3);
            routingNumber.Append(digit4);
            routingNumber.Append(digit5);
            routingNumber.Append(digit6);
            routingNumber.Append(digit7);
            routingNumber.Append(digit8);

            lblbankRoutingNumber.Text = routingNumber.ToString();

            //Console.WriteLine(routingNumber);
        }

        private void BankAccountNumber()
        {
            Random rnd = new Random();
            StringBuilder accountNumber = new StringBuilder();
            int digit0 = rnd.Next(3, 10);
            int digit1 = rnd.Next(3, 10);
            int digit2 = rnd.Next(3, 10);
            int digit3 = rnd.Next(3, 10);
            int digit4 = rnd.Next(5, 10);
            int digit5 = rnd.Next(0, 10);
            int digit6 = rnd.Next(0, 10);
            int digit7 = rnd.Next(5, 10);
            int digit8 = rnd.Next(5, 10);
            int digit9 = rnd.Next(5, 10);
            int digit10 = rnd.Next(5, 10);
            int digit11 = rnd.Next(5, 10);


            accountNumber.Append(digit0);
            accountNumber.Append(digit1);
            accountNumber.Append(digit2);
            accountNumber.Append(digit3);
            accountNumber.Append(digit4);
            accountNumber.Append(digit5);
            accountNumber.Append(digit6);
            accountNumber.Append(digit7);
            accountNumber.Append(digit8);
            accountNumber.Append(digit9);
            accountNumber.Append(digit10);
            accountNumber.Append(digit11);

            lblbankAccountNumber.Text = accountNumber.ToString();
            //Console.WriteLine(accountNumber);
        }



        #endregion

        #region BankCardProperties
        //private void NameOnCard()
        //{
        //    string firstnameOnCard = txtFirstName.Text;
        //    string middleInitialOnCard = txtMiddleName.Text;
        //    string lastnameOnCard = txtLastName.Text;

        //}

        //private void CardCSV()
        //{
        //    StringBuilder CSVOctets = new StringBuilder();
        //    StringBuilder CSVNumber = new StringBuilder();
        //    Random rnd = new Random();

        //    int Octet1 = rnd.Next(1, 10);
        //    int Octet2 = rnd.Next(0, 10);
        //    int Octet3 = rnd.Next(0, 10);

        //    CSVOctets.Append(Octet1);
        //    CSVOctets.Append(Octet2);
        //    CSVOctets.Append(Octet3);

        //    CSVNumber.Append(CSVOctets);

        //    Console.WriteLine(CSVNumber);
        //}

        //private void CardExpiration()
        //{
        //    StringBuilder ExpirationMonth = new StringBuilder();
        //    StringBuilder ExpirationYear = new StringBuilder();
        //    StringBuilder CreditCardExpiration = new StringBuilder();
        //    Random rnd = new Random();

        //    //int ExpMonth1 = rnd.Next(0, 1);
        //    int ExpMonth2 = rnd.Next(01, 13);
        //    int ExpYear = rnd.Next(20, 27);

        //    //ExpirationMonth.Append(ExpMonth1);
        //    ExpirationMonth.Append(ExpMonth2);
        //    ExpirationYear.Append(ExpYear);

        //    CreditCardExpiration.Append(ExpirationMonth);
        //    CreditCardExpiration.Append('/');
        //    CreditCardExpiration.Append(ExpirationYear);


        //    Console.WriteLine(CreditCardExpiration);
        //}
        #endregion

        
    }
}