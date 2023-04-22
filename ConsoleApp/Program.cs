﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alive alive = new Alive();
            Bear bear = new Bear("pooh");
            Bunny bunny = new Bunny("kenny");
            Wolf wolf = new Wolf("kyle");
            Rose rose = new Rose();
            Grass grass = new Grass();


            int number = InputNumber();

            int a = 0;
            int b = 1;

            Console.Write("Fibonacci numbers: ");
            Console.Write(a + " ");
            Console.Write(b + " ");

            while (a + b <= number)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.ReadKey();
        }

        static int InputNumber()
        {
            Console.Write("Enter a natural number: ");
            string input = "";
            int number = 0;
            bool isNaturalNumber = false;

            while (!isNaturalNumber )
            {
                input = Console.ReadLine();
                if (double.TryParse(input, out double value))
                {
                    number = (int)value;
                    isNaturalNumber = IsNatural(number);
                }
                else
                {
                    Console.WriteLine("The input is not a natural number.");    
                }
            }
            Console.WriteLine("The number value is " + number);
            return number;
        }

        static bool IsNatural(int number) {
            if (number < 0)
            {
                return false;
            }
            return true;
        }
    }

    internal class Bunny : Hervibore
    {
        public Bunny(string name) : base(name)
        {
        }
    }

    internal class Wolf : Carnivore
    {
        public Wolf(string name) : base(name) { }
    }

    internal class Bear : Animal
    {
        public Bear(string name) : base(name)
        {
        }
    }

    internal class Animal : Alive
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
            base.species = "animal";
        }
    }

    internal class Herbal : Alive
    {
        public Herbal() { base.species = "herbal"; }
    }

    internal class Alive
    {
        protected string species;
    }

    internal class Grass : Herbal{ }

    internal class Rose : Herbal { }

   

    internal class Carnivore : Animal
    {
        public Carnivore(string name) : base(name) { }
        public void Eat(Animal animal) { }
    }

    internal class Hervibore : Animal {
        public Hervibore(string name) : base(name) { }
        public void Eat(Herbal herbal) { }
    }
}
