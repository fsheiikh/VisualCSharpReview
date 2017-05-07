using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityDemoLoan
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan();
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoanAmount = 1000.0;

            Console.WriteLine("Loan #{0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));


            CarLoan aCarLoan = new CarLoan();
            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jasnsen";
            aCarLoan.LoanAmount = 2000.0;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;

            Console.WriteLine("Loan #{0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
            Console.WriteLine("Loan #{0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);


            Console.ReadKey();
        }
    }
}
