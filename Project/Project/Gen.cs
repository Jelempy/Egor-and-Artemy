using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Project
{
    //Класс, отвечающий за "Генетику".

    class Gen
    {

    }

    //Класс, отвещающий за "Гены" одного существа.

    class GenUnit
    {
        // Сэнсоры
        
        // true - есть false - нет
        // sensors - 0 - слух 1 - зрение 2 - чуствительность 3 - обоняние

        bool[,] sensorsDom = new bool[4, 6]; // Доминирующие гены сэнсоров
        bool[,] sensorsPas = new bool[4, 6]; // Пасивные гены сэнсоров
        
        // Движители

        // mover - 0 - Движитель 1 - сила движителя 1 - 2 - сила движителя 2 - 3 - сила движителя 3 

        bool[,] moverDom = new bool[4, 6]; // Доминирующие гены движителей
        bool[,] moverPas = new bool[4, 6]; // Пасивные гены движителей

        // Цвет тела

        // color - 0 - Красный 1 - Зеленый 2 - Синий

        bool[,] ColorDom = new bool[3, 4]; // Доминирующий ген цвета
        bool[,] moverPas = new bool[3, 4]; // Пасивный ген цвета


    }
}
