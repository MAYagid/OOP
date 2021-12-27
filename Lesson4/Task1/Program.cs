/*
Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). 
Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. 
Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. 
Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть статическое поле, 
которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля. 


 */
using System;

namespace Task1
{
    public class Building
    {
        private static int id = 0;
        private int height;
        private int lvls;
        private int flats;
        private int enters;

        public Building() {
            id++;
            }

        public int Id {
            get { return id; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Lvls
        {
            get { return lvls; }
            set { lvls = value; }
        }

        public int Flats
        {
            get { return flats; }
            set { flats = value; }
        }

        public int Enters
        {
            get { return enters; }
            set { enters = value; }
        }

        public double Lvl_Height()
        {
            return height / lvls;
        }

        public int Flats_count()
        {
            return flats / enters;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Building B1 = new Building();
            Building B2 = new Building();
            Console.WriteLine(B2.Id);

        }
    }
}
