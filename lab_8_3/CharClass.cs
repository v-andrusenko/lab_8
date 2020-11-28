using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8_3
{
    class CharClass : IntClass
    {
        protected char[] charArray;
        public CharClass()
        {
            charArray = new char[26];
        }
        public void fillArray()
        {
            int k = 0;
            for (int i=97;i<=122;i++)
            {
                charArray[(char)k] = (char)i;
                k++;
            }
        }
        public char this[char index]
        {
            get
            {
                return charArray[Convert.ToChar(index)];
            }
            set
            {
                charArray[Convert.ToChar(index)] = value;
            }
        }
        public new int[] arrayLength
        {

            get
            {
                return new int[2] { base.arrayLength, charArray.Length };
            }
        }
    }
}

