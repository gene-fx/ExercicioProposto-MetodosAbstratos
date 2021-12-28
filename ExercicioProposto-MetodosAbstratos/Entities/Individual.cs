using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_MetodosAbstratos.Entities
{
    class Individual : Element
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double fee = 0.00;

            if(AnualIncome < 20000)
                fee = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            else
                fee = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);

            return fee;
        }
    }
}
