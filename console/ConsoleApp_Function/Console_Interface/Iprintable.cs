using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Interface
{
    internal interface Iprintable
    {

        // only abstract methods and properties are ther e
        //oposite to abstract class no fields are  here 
        // no public word required for method access
        // why? becoz its publicaly available

        void print();
        void showDate();

    }
}
