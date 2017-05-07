using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityDemoLoan
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount
        {
            set
            {
                if (value < MINIMUM_LOAN)
                    loanAmount = MINIMUM_LOAN;
                else
                    loanAmount = value;
            }
            get
            {
                return loanAmount;
            }
        }
        public const double MINIMUM_LOAN = 5000;
        protected double loanAmount;
    }

    class CarLoan : Loan
    {
        public int Year
        {
            set
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                {
                    year = value;
                }
            }
            get
            {
                return year;
            }
        }
        public string Make { get; set; }

        public new int LoanNumber
        {
            get
            {
                return base.LoanNumber;
            }
            set
            {
                if (value < LOWEST_INVALID_NUM)
                    base.LoanNumber = value;
                else
                    base.LoanNumber = value % LOWEST_INVALID_NUM;
                
            }
        }

        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;
        private int year;



    }
}
