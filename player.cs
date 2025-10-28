using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    internal class Player
    {
        private int level;
        private int health;

        public int Level
        {
            get { return level; }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentException("Уровень должен быть от 1 до 100!");
                level = value;
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                    health = 0; 
                else
                    health = value;
            }
        }
        public string Name { get; } 

        public bool IsAlive => Health > 0; 

        public Player(string name, int level, int health)
        {
            Name = name;
            Level = level; 
            Health = health; 
        }
        public void TakeDamage(int damage)
        {
            Health -= damage; 
            if (Health < 0) Health = 0; 
            Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {(IsAlive ? "да" : "нет")}");
        }
    }
}
