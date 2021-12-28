using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_MetodosAbstratos.Entities
{
    class Company : Element
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double fee = 0.00;

            if (NumberOfEmployees > 10)
                fee = AnualIncome * 0.14;
            else
                fee = AnualIncome * 0.16;

            return fee;
        }
    }
}
