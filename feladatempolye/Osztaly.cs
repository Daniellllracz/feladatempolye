using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladatempolye
{
    class Osztaly
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string MarielStatus { get; set; }
        public double Salery { get; set; }


        public Osztaly(string sor, string name, int age, string city, string department, string position, string gender, string marielStatus, int salery)
        {
            string[] szortir = sor.Split(';');
            Name = name;
            Age = age;
            City = city;
            Department = department;
            Position = position;
            Gender = gender;
            MarielStatus = marielStatus;
            Salery = salery;

        }
        public override string ToString() 
        {
            return $"{Name}név | {Age}életkor  | {City}Város  | {Department}department  | {Position}pozícó | {Gender}nem | {MarielStatus} családi állapott | {Salery} bevétel";
        }
    }
}
