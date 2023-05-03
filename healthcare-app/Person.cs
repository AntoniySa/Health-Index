using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthcare_app
{
    class Person
    {
        private string name;
        private double weight;
        private double height;
        private double age;

        private double massIndex;
        private double waterNorm;
        private double calories;

        public Person(string name, decimal weight, decimal height, bool male, bool female, decimal age)
        {
            this.name = name;
            this.weight = Convert.ToDouble(weight);
            this.height = Convert.ToDouble(height);
            this.age = Convert.ToDouble(age);

            massIndex = this.weight / Math.Pow((this.height / 100), 2);
            waterNorm = this.weight * 0.03;

            if (male == true)
            {
                calories = (10 * this.weight) + (6.25 * this.height) - (5 * this.age) + 5;
            }

            if (female == true)
            {
                calories = (10 * this.weight) + (6.25 * this.height) - (5 * this.age) - 161;
            }
        }

        public double getAge()
        {
            return this.age;
        }

        public string getName()
        {
            return this.name;
        }

        public double getMassIndex()
        {
            return this.massIndex;
        }

        public double getWaterNorm()
        {
            return this.waterNorm;
        }

        public double getCalories()
        {
            return this.calories;
        }
    }
}
