﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06.Haustierverwaltung_1
{
    internal class Dog : Pet
    {
        public Dog() { }
        public Dog(string name, int age) : base (name, age)
        {
            Name = name;
            Age = age;
        }
    }
}
