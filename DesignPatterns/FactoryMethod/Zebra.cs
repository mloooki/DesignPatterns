using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Zebra : Animal
    {
        public bool IsWild { get; set; }

        public Zebra(int age, int wight, string gender, bool isWild)
        {
            Age = age;
            Weight = wight;
            Gender = gender;
            IsWild = isWild;
        }
        public override string GetAllInfo()
        {
            return $"Zebra Info: Gender = {this.Gender} IsWild = {this.IsWild} Age = {this.Age} Wieght = {this.Weight}";

        }

        public override bool isMarmmal()
        {
            return true;
        }

        public void Run()
        {
            var x = "I'm running";
        }
    }
}
