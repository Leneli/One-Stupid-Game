using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Stupid_Game
{
    class Nature
    {
        //Состояние объекта
        public string natureName;

        //Конструкторы
        //Связывание конструторов в цепочку
        public Nature() : this("Some Object") { }
        //Главный констркутор
        public Nature(string name)
        {
            natureName = name;
        }

        //Функциональность

    }
}
