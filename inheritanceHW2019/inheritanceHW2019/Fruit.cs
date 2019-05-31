using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceHW2019
{
    public class Fruits
    {
        public string _fname { set; get; }
        public string _color { set; get; }

        public Fruits (string Fname, string color)
        {
            _fname = Fname;
            _color = color ;
            Console.WriteLine("Fresh fruit!");
        }
    }

    public class Banana : Fruits
    {
        public int _weight { set; get; }
            public string _flavor { set; get; }
        public Banana(string color, int Weight,string flavor, string Fname ) : base (Fname,color)
        {
            _fname = Fname;
            _color = color;
            _weight = Weight;
            _flavor = flavor;
        }

        public void Eaten(string fruitEaten)
        {
            Console.WriteLine("you ate {0}", _fname, fruitEaten);
        }

        public void peel(string PeeledFruit)
        {
            Console.WriteLine("you ate {0}", _fname, PeeledFruit);
        }
    }
}
