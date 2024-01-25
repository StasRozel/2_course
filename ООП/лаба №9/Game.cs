using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__9
{
    class Game : IEnumerable<Game>
    {
        public string? nameCharaster { get; private set; }
        private int healthCharaster;
        private int experienceCharaster;
        private int levelGame;

        private Random random = new Random();

        public Game(string name) { 
            nameCharaster = name;
            healthCharaster = 100;
            experienceCharaster = 0;
            levelGame = 1;
        }

        public void Start()
        {
            Console.WriteLine("Игра началась");
        }

        private void LevelUp()
        {
            healthCharaster = 100;
            levelGame++;
        }

        public void Attack()
        {
            int damage = random.Next(10, 30);
            int kill = random.Next(2);

            Console.WriteLine("Герой атакует");
            healthCharaster -= damage;
            if (healthCharaster > 0)
            {
                Console.WriteLine($"У героя осталось здоровья: {healthCharaster}");
                if (kill == 1)
                {
                    experienceCharaster += 10;
                    if (experienceCharaster >= 50)
                    {
                        LevelUp();
                    }
                }
            } else
            {
                Console.WriteLine("Ваш герой погиб");
                Stop();

            }
        }

        public void Heal()
        {
            int heal = random.Next(1, 10);

            healthCharaster += heal;
            if (healthCharaster > 100)
                Console.WriteLine($"Герой вылечился, его здоровье: {100}");
            else
                Console.WriteLine($"Герой вылечился, его здоровье: {healthCharaster}");
        }

        public void Stop()
        { 
            Console.WriteLine("Игра остановилась");
        }

        public IEnumerator<Game> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
