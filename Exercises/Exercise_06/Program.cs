using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit Riggers = new Unit();
            Riggers.UnitName = "1/507 PIR";
            Riggers.UnitSymbol = "FollowMe";
            Riggers.Size = 127;
            Riggers.FormatMe();
            Tank DeathRoller = new Tank();
            DeathRoller.ArmorLevel = 100;
            DeathRoller.NumOfSeats = 5;
            DeathRoller.PrintMe();
            Rifles M4 = new Rifles();
            M4.Damage = 24;
            M4.RoundSize = 5.56;
            M4.PrintMe();
            M4.shoot();
            M199 Humve = new M199();
            Humve.TopSpeed = 60;
            Humve.NumOfSeats = 4;
            Humve.PrintMe();
            Weapon Pistol = new Weapon();
            Pistol.Damage = 10;
            Pistol.RoundSize = 9;
            Pistol.shoot();
            Vehicles Tmp = new Vehicles();
            Tmp.NumOfSeats = 2;
            Tmp.ArmorLevel = 0;
            Tmp.PrintMe();

        }


    }


}