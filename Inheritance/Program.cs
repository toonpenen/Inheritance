﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Class1
    {
    public string Name { get; set; }

    public void Show1()
    {
        Console.WriteLine("I'm class1 method show1");
    }
    public void Show2()
    {
        Console.WriteLine("I'm class2 method show2");
    }
}
    public class Class2:Class1
    {
        public int Age { get; set; }
        
        public Class2() 
        {
            Console.WriteLine("I'm class2 constructor");
        }
        public void Show3()
        {
            Console.WriteLine("I'm class1 method show3"); ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c = new Class2();
            c.Show1();
            c.Show2();
            c.Show3();
           

            Class1 p = new Class1();
            
        }
    }
}
