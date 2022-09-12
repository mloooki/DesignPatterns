using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Duck : Animal
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set
            {
                if (value != "Yellow")
                {
                    this.color = "Yellow";
                }
            }
        }

        public Duck(string color, string gender, int age, int weight)
        {
            Color = color;
            Gender = gender;
            Age = age;
            Weight = weight;
        }
        public override bool isMarmmal()
        {

            return false;
        }

        public override string GetAllInfo()
        {
            return $"Duck Info: Gender = {this.Gender} Color = {this.Color} Age = {this.Age} Wieght = {this.Weight}";
        }

        public string Quack()
        {
            return "Quack Quack Quack !!";
        }
    }
}
