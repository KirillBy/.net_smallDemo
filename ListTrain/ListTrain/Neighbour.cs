using System;
using System.Collections.Generic;
using System.Text;

namespace ListTrain
{
    public class Neighbour
    {
        public  string Fullname { get; private set; }
        public ushort FlatNumber { get; private set; }
        public string PhoneNumber { get; private set; }

        public Neighbour(string fullname, ushort flatnumber, string phonenumber)
        {
            this.Fullname = fullname;
            this.FlatNumber = flatnumber;
            this.PhoneNumber = phonenumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Fullname} lives in flat № {FlatNumber}. His mobile {PhoneNumber}");
        }

    }
}
