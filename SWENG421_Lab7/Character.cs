using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Character : IEntity, IReadOnly
    {
        private char value;
        public Character(char c) //accepts char
        {
            value = c;
        }
        public void Save()
        {
            Console.WriteLine("Character " + value + " is saved.");
            
        }

        public void Retrieve()
        {
            Console.WriteLine("Character " + value + " is retrieved.");
        }

        public void View()
        {
            Console.Write(value);
        }

        public void Edit()
        {
            Console.WriteLine("Character " + value + " is updated."); 
        }

        public void Delete()
        {
            Console.WriteLine("Character " + value + " is deleted.");
        }
    }
}
