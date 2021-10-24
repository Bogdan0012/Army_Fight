using System;
using System.Collections.Generic;
using Soldiers;

namespace CProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Squad> army1Squads = new List<Squad>();

            List<Soldier> army1Squad1soldirs = new List<Soldier>();
            army1Squad1soldirs.Add(new RomanSoldier ("Roma"));
            army1Squad1soldirs.Add(new SamuraiSoldier ("Goto Sodziro"));
            army1Squad1soldirs.Add(new Spearman ("Spearman"));
            //army1Squad1soldirs.Add(new Halberdier ("Halberdier"));
            //army1Squad1soldirs.Add(new Archer ("Archer"));
            //army1Squad1soldirs.Add(new Crossbowman ("Crossbowman"));

            army1Squads.Add(new Squad(army1Squad1soldirs, "num1"));
            Army army1 = new Army(army1Squads);



            
            List<Squad> army2Squads = new List<Squad>();

            List<Soldier> army2Squad1soldirs = new List<Soldier>();
            army2Squad1soldirs.Add(new RomanSoldier ("Roma2"));
            army2Squad1soldirs.Add(new SamuraiSoldier ("Goto Sodziro2"));
            //army2Squad1soldirs.Add(new Crossbowman ("Crossbowman"));

            army2Squads.Add(new Squad(army2Squad1soldirs, "num2"));
            Army army2 = new Army(army2Squads);


            while(army1.IsAlive() && army2.IsAlive()) {
                army1.Atack(army2);
                if (army2.IsAlive()) army2.Atack(army1);
            }
            if (army1.IsAlive()) 
                Console.WriteLine("Army1 won!");
            else 
                 Console.WriteLine("Army2 won!");
        }
    }
}
