using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8_3
{
    class CharClass : IntClass
    {
        protected char[] charArray;
        public int[] result = new int[2];
        public CharClass() { }
        public CharClass(int length)
        {
            charArray = new char[length];
        }
        public char this[char index]
        {
            get
            {
                return charArray[index];
            }
            set
            {
                charArray[index] = value;
            }
        }
        public new int[] arrayLength
        {
            
            get
            {
                return arrayLength;
            }
            set
            {
                arrayLength[0] = base.intArray.Length;
                arrayLength[1] = charArray.Length;
            }
        }
    }
}

