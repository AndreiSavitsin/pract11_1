using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract11_1_Savitsin
{
    class Student
    {
        public string name;
        public double height;
        public double weight;
        public double foodWeight;
        public Student(double weight1)
        {
            weight = weight1;
        }
        public void Stud1(double weight1)
        {
            weight = weight1;
        }
        public void SetEat(double food)
        {
            if (food >= 10)
            {
                height -= 2;
                weight += 0.5 * (food * 1000 - 1800) / 1000;
            }
            else
            {
                if (food > 5)
                {
                    height -= 1;
                    weight += 0.7 * (food * 1000 - 1600) / 1000;
                }
                else
                {
                    weight += food;
                }
            }
        }
        public double GetEat()
        {
            return weight;
        }
    }
}

