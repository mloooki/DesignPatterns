using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Fish : Animal
    {
        public int SizeInFt { get; set; }
        public bool CanEat { get; set; }
        public bool IsSwimming { get; set; }

        public Fish(int age, int wight, string gender, int sizeInFt, bool canEat, bool isSwimming)
        {
            Age = age;
            Weight = wight;
            Gender = gender;
            SizeInFt = sizeInFt;
            CanEat = canEat;
            IsSwimming = isSwimming;
        }
        public override string GetAllInfo()
        {
            return $"Fish Info: Gender = {this.Gender} SizeInFt = {this.SizeInFt} Age = {this.Age} Wieght = {this.Weight} CanEat = {this.CanEat} IsSwimming {this.IsSwimming}";

        }

        public override bool isMarmmal()
        {
            return false;
        }

        public void Swim()
        {
            IsSwimming = true;
        }
    }
}
