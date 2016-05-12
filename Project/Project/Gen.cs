using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Project
{
    //Класс, отвечающий за "Генетику".

    class Gen
    {
        public GenUnit GetGenAB(GenUnit UnitOne, GenUnit UnitTwo) // Метод скрещивания двух генов и получения 3-его гена
        {

            
            GenUnit NewGen = new GenUnit();

            NewGen = GenHelp(UnitOne, UnitTwo, NewGen);
           
            
            // Проверка хромосомы Сенсоров
            for (int i = 0; i < 4; i++)
            {
                 int T = 0; 
                 for (int j = 0; j < 6; j++)
                 {
                 
                 if (NewGen.sensorsDom[i, j] == true)
                     T++;
                 if (T >= 2)
                 {

                     NewGen = null;
                     NewGen = GenHelp(UnitOne, UnitTwo, NewGen);

                 }
                 }
			}

            

            // Проверка хромосомы Движения
            for (int i = 1; i < 4; i++)
            {
                int T = 0;
                for (int j = 0; j < 6; j++)
                {
                    
                    if (NewGen.moverDom[i, j] == true)
                        T++;
                    if (T >= 2)
                        ;
                }
            }
            
            //  Цвет будет поже

            return NewGen;
        }

        GenUnit GenHelp(GenUnit UnitOne, GenUnit UnitTwo, GenUnit NewGen) // метод скрещивания генов
        {
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)// Цикл для перебора генов слуха
            {


                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.sensorsDom[0, i] = UnitOne.sensorsDom[0, i]; break;
                    case 1: NewGen.sensorsDom[0, i] = UnitTwo.sensorsDom[0, i]; break;
                }
            }
            for (int i = 0; i < 6; i++)// Цикл для перебора генов зрения
            {

                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.sensorsDom[1, i] = UnitOne.sensorsDom[1, i]; break;
                    case 1: NewGen.sensorsDom[1, i] = UnitTwo.sensorsDom[1, i]; break;
                }
            }
            for (int i = 0; i < 6; i++)// Цикл для перебора генов чуствительности
            {

                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.sensorsDom[2, i] = UnitOne.sensorsDom[2, i]; break;
                    case 1: NewGen.sensorsDom[2, i] = UnitTwo.sensorsDom[2, i]; break;
                }
            }
            for (int i = 0; i < 6; i++)// Цикл для перебора генов обоняния
            {

                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.sensorsDom[3, i] = UnitOne.sensorsDom[3, i]; break;
                    case 1: NewGen.sensorsDom[3, i] = UnitTwo.sensorsDom[3, i]; break;
                }
            }

            for (int i = 0; i < 6; i++)// Цикл для перебора генов Движителей
            {

                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.moverDom[0, i] = UnitOne.moverDom[0, i]; break;
                    case 1: NewGen.moverDom[0, i] = UnitTwo.moverDom[0, i]; break;
                }
            }
            for (int i = 0; i < 6; i++)// Цикл для перебора генов Силы движения 1
            {

                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.moverDom[1, i] = UnitOne.moverDom[1, i]; break;
                    case 1: NewGen.moverDom[1, i] = UnitTwo.moverDom[1, i]; break;
                }
            }
            for (int i = 0; i < 6; i++)// Цикл для перебора генов Силы движения 2
            {

                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.moverDom[2, i] = UnitOne.moverDom[2, i]; break;
                    case 1: NewGen.moverDom[2, i] = UnitTwo.moverDom[2, i]; break;
                }
            }
            for (int i = 0; i < 6; i++)// Цикл для перебора генов Силы движения 3
            {

                switch (rnd.Next(0, 1))
                {
                    case 0: NewGen.moverDom[3, i] = UnitOne.moverDom[3, i]; break;
                    case 1: NewGen.moverDom[3, i] = UnitTwo.moverDom[3, i]; break;
                }
            }

            return NewGen;
        }

    }

    //Класс, отвещающий за "Гены" одного существа.

    class GenUnit
    {
        // Сэнсоры

        // true - есть false - нет
        // sensors - 0 - слух 1 - зрение 2 - чуствительность 3 - обоняние

        public bool[,] sensorsDom = new bool[4, 6]; // Доминирующие гены сэнсоров
        //public bool[,] sensorsPas = new bool[4, 6]; // Пасивные гены сэнсоров

        // Движители

        // mover - 0 - Движитель 1 - сила движителя 1 - 2 - сила движителя 2 - 3 - сила движителя 3 

        public bool[,] moverDom = new bool[4, 6]; // Доминирующие гены движителей
        //public bool[,] moverPas = new bool[4, 6]; // Пасивные гены движителей

        // Цвет тела

        // color - 0 - Красный 1 - Зеленый 2 - Синий

        public bool[,] ColorDom = new bool[3, 4]; // Доминирующий ген цвета
        //public bool[,] moverPas = new bool[3, 4]; // Пасивный ген цвета


    }

    
}
