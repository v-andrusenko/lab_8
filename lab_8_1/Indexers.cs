using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8_1
{
    class Indexers
    {
        string x, y, Else = "Опа! Элемента с данным индексом не существует."; 

        public Indexers(string theFirstValue, string theSecondValue)
        {
            this.x = theFirstValue;
            this.y = theSecondValue;
        }

        
        public string this[int index]
        {

            get 
            { 
                if (index == 0)
                {
                    return x;
                }
                if (index == -1)
                {
                    return y;
                }
                else
                {
                    return Else;
                }
            }
            set
            {
                if (index ==0)
                {
                    x = value;
                }
                else if (index ==-1)
                {
                    y = value;
                }
                else
                {
                    Else = value;
                }

            }
        }
    }
}
