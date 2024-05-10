using System.ComponentModel.DataAnnotations;

namespace FutureCalculator.Models
{
    public class FutureValueCalc
    {
        //Data Members
        [Required(ErrorMessage = "Please enter Monthly Investment Amount")]
        public decimal monthlyInvestment { get; set; }
        [Required(ErrorMessage = "Please enter Yearly Intrest Rate")]
        public decimal yearlyIntrestRate { get; set; }
        [Required(ErrorMessage = "Please enter Number of Years")]
        public int numberOfYears { get; set; }

        public decimal  calculateFutureValue()
        {
            int? months = numberOfYears * 12;
            decimal monthlyInterestRate =(yearlyIntrestRate / 12) / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) *
                (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
