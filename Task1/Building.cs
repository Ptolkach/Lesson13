using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        string address;
        int lenght;
        int width;
        int height;

        string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value == "")
                    address = "Адрес еще не назначен";
                else
                    address = value;
            }
        }
        int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 1)
                    lenght = 1;
                else
                    lenght = value;
            }
        }
        int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public Building(string address, int lenght, int width, int height)
        {
            Address = address;
            Lenght = lenght;
            Width = width;
            Height = height;
        }
        public string Print()
        {
            return $"Адрес: {address}; Длина здания: {lenght}; Ширина здания: {width}; Высота здания: {height}";
        }

    }
}
