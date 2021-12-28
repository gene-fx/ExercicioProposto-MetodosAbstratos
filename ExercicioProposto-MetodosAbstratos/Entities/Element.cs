using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_MetodosAbstratos.Entities
{
    abstract class Element
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Element(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
