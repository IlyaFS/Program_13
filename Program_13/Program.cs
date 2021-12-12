using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("улица Ленина дом 1", 100, 27, 15);
            MultiBuilding multiBuilding = new MultiBuilding("улица Ленина дом 1", 100, 27, 15, 5);

            multiBuilding.Print();
            Console.WriteLine();
            Console.Write("Нажмите на любого клавиша . . .");
            Console.ReadKey();
        }
    }
    class Building
    {
        public string A { get; set; }
        public double L { get; set; }
        public double B { get; set; }
        public double H { get; set; }
        public Building(string a, double l, double b, double h)
        {
            A = a;
            B = b;
            L = l;
            H = h;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", A);
            Console.WriteLine("Длина здания: {0}м", L);
            Console.WriteLine("Ширина здания: {0}м", B);
            Console.WriteLine("Высота здания: {0}м", H);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Z { get; set; }
        public MultiBuilding(string a, double l, double b, double h, int z)
        : base(a, l, b, h)
        {
            Z = z;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Этажность здания: {0}", Z);
        }

    }

}



//Задан класс Building, который описывает здание. Класс содержит следующие элементы:

//адрес здания;
//длина здания;
//ширина здания;
//высота здания.
//В классе Building нужно реализовать следующие методы:

//конструктор с 4 параметрами;
//свойства get/set для доступа к полям класса;
//метод Print(), который выводит информацию о здании.
//Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.
//В классе MultiBuilding реализовать следующие элементы:

//конструктор с 5 параметрами – реализует вызов конструктора базового класса;
//свойство get/set доступа к внутреннему полю класса;
//метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
//Класс MultiBuilding сделать таким, что не может быть унаследован.
