using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApp
{
    public class Rectangle : ishape
    {
        private int a1;

        public int Geta()
        {
            return a1;
        }

        public void Seta(int value)
        {
            a1 = value;
        }

        private int b1;

        public int Getb()
        {
            return b1;
        }

        public void Setb(int value)
        {
            b1 = value;
        }

        private int c1;

        public int Getc()
        {
            return c1;
        }

        public void Setc(int value)
        {
            c1 = value;
        }

        private int d1;

        public int Getd()
        {
            return d1;
        }

        public void Setd(int value)
        {
            d1 = value;
        }

        public void get_points()
        {
            Console.WriteLine("the points you entered are: " + Geta() + Getb() + Getc() + Getd());
        }
        public int get_area()
        {
            int x = Geta() * Getc();
            return x;
        }
        public void draw()
        {
            Console.WriteLine("Some drawing");
        }
    }
    public class Square : ishape
    {
        private int a1;

        public int Geta()
        {
            return a1;
        }

        public void Seta(int value)
        {
            a1 = value;
        }

        private int b1;

        public int Getb()
        {
            return b1;
        }

        public void Setb(int value)
        {
            b1 = value;
        }

        private int c1;

        public int Getc()
        {
            return c1;
        }

        public void Setc(int value)
        {
            c1 = value;
        }

        private int d1;

        public int Getd()
        {
            return d1;
        }

        public void Setd(int value)
        {
            d1 = value;
        }

        public void get_points()
        {
            Console.WriteLine("the points you entered are: " + Geta() + Getb() + Getc() + Getd());
        }
        public int get_area()
        {
            int x = Geta() * Getc();
            return x;
        }
        public void draw()
        {
            Console.WriteLine("Some drawing");
        }
    }
}
