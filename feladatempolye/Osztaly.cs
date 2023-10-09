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


        public Osztaly(string sor)
        {
            string[] szortir = sor.Split(';');
            Name = szortir[0];
            Age = int.Parse( szortir[1]);
            City = szortir[2];
            Department = szortir[3];
            Position = szortir[4];
            Gender = szortir[5];
            MarielStatus = szortir[6];
            Salery = double.Parse(szortir[7]);

        }


        public override string ToString() => $"{Name}név | {Age}életkor  | {City}Város  | {Department}department  | {Position}pozícó | {Gender}nem | {MarielStatus} családi állapott | {Salery} bevétel";
        
    }
}



