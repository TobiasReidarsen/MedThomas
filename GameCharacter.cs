using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedThomas
{
    internal class GameCharacter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Strenght { get; private set; }
        public int Stamina { get; private set; }

        public void Fight(GameCharacter Enemy)
        {
            int originalStrenght = Enemy.Strenght;
            InitBossStrength(Enemy.Strenght);
            int originalStamina = 0;
            // Påvirker Health og Stamina
            
            if ((this.Health >= 0 && this.Stamina >= 0) && (Enemy.Health >= 0 ))
            {
                Enemy.Health -= this.Strenght;
                this.Stamina -= 10;
                originalStamina = originalStamina + 10;
                Console.WriteLine("Original Stamina: " + originalStamina);
                Console.WriteLine(Enemy.Name + " har " + Enemy.Health + " health");
            }
            else if (!(this.Stamina >= 0))
            {
                while (this.Stamina <= originalStamina)
                {
                    Recharge();
                }
            }

            Enemy.Strenght = originalStrenght;

                
        }

        public void Recharge()
        {
            // Påvirker Health og Stamina
            this.Stamina = this.Stamina + 10;
            Console.WriteLine(this.Name +" now has " + this.Stamina);
            Thread.Sleep(2000);

        }


        public void InitBossStrength(int ogStrenght)
        {
            //int Strength = Random.Next(0, n + 1);
            Random n = new Random();
            int strength = n.Next(0, ogStrenght + 1);
            ogStrenght = strength;
        }


        public GameCharacter(string name, int health, int stamina, int strenght)
        {
            Name = name;
            Health = health;
            Strenght = strenght;
            Stamina = stamina;
        }

    }
}
