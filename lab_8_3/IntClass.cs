﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8_3
{
    class IntClass
    {
        protected int[] intArray;
        public IntClass()
        {
            intArray = new int[26];
        }
        public int this[int index]
        {
            get
            {
                return intArray[index];
            }
            set
            {
                intArray[index] = value;
            }
        }
        public int arrayLength
        {
            get
            {
                return intArray.Length;
            }
        }
    }
}
