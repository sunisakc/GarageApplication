﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Verhicle
    {
        private int registerNumber;
        private string color;
        private int numberOfWheel;


        public int RegistNumber
        {
            get
            {
                return registerNumber;
            }
            set
            {
                registerNumber = value;
            }
        }
        public string Color {
            get
            {
                return color;
            }
             set
             {
                    color = value;
             }
            }
        public int NumberofWheel {
             get
            {
                return numberOfWheel;
            }
              set
            {
                numberOfWheel = value;
            }
                
              }

        public Verhicle () { }

        public Verhicle( int registerNumber, string color, int numberofWheel)
        {
            RegistNumber = registerNumber;
            Color = color;
            NumberofWheel = numberofWheel;
        }
        
    }
}
