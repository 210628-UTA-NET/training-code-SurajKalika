using System;

namespace HouseFunction
{
    public class House
    {
        private string _color;
        private int _price;
        //This is a constructor (special method that is called upon when an object is initialized)
        public House()
        {
            Console.WriteLine("That constructor of this class was used");
            _color ="Red";
        }

        public string Name{get; set;}
        public int Price
        {   //This is the implementation details to how you can get that naming field
            get
            {
                return _price;
            }
            //This is the implementation details to how you can set that naming field
            set
            {
                _price = value;
            }
        }

        //Java way to getting information from fields
        public string getColor()
        {
            return _color;
        }

        //Some methods have parameters to send information
        public void setColor(string p_color) //p_ naming convention in C# for properties
        {
            _color = p_color;
        }
    }
}