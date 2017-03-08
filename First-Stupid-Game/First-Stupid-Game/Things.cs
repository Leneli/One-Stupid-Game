using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Stupid_Game
{
    class Things
    {
        //Состояние объекта
        public string thingName;

        //Конструкторы
        //Связывание конструторов в цепочку
        public Things() : this("Some Thing") { }
        //Главный констркутор
        public Things(string name)
        {
            thingName = name;
        }

        //Функциональность
    }
}
