﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project164Tamagotchi
{
    public class Food
    {
        //data members
        private string mName;
        private string mType;


        //properties
        public string Name { get => mName; set => mName = value; }
        public string Type { get => mType; set => mType = value; }




        //default constructor
        public Food()
        {
            mName = "";
            mType = "";

        }

        //overloaded constructor
        public Food(string Name, string Type, int Cost)
        {
            mName = Name;
            mType = Type;

        }

    }
}
