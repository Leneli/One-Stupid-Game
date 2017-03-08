using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Stupid_Game
{
    class Creatures
    {
        //Состояние объекта
        public string creatureName; //имя существа
        public int healthPoints, manaPoints, staminaPoints; //здоровье, мана, выносливость
        public int creatureDamage; //наносимый урон

        //Конструкторы
        //Связывание конструторов в цепочку
        public Creatures() { }

        public Creatures(string name) : this(name, 100, 100, 100, 10) { }
        public Creatures(string name, int hp) : this(name, hp, 100, 100, 10) { }
        public Creatures(string name, int hp, int mp) : this(name, hp, mp, 100, 10) { }
        public Creatures(string name, int hp, int mp, int sp) : this(name, hp, mp, sp, 10) { }

        public Creatures(int hp) : this("Someone", hp, 100, 100, 10) { }
        public Creatures(int hp, int mp) : this("Someone", hp, mp, 100, 10) { }
        public Creatures(int hp, int mp, int sp) : this("Someone", hp, mp, sp, 10) { }
        public Creatures(int hp, int mp, int sp, int damage) : this("Someone", hp, mp, sp, damage) { }

        //Главный констркутор
        public Creatures(string name, int hp, int mp, int sp, int damage) {
            creatureName = name;
            healthPoints = hp;
            manaPoints = mp;
            staminaPoints = sp;
            creatureDamage = damage;
        }

        //Функциональность
        public void saiHI(string Text)
        {
            Console.WriteLine("Hello, player! I am {0}. {1}", creatureName, Text);
        }
    }
}
