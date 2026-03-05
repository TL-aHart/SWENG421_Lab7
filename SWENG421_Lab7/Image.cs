using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Image : IEntity, IReadOnly
    {
        private string image;
        public Image(string s) //accepts string
        {
            image = s;
        }
        public void Save()
        {
            Console.WriteLine("Image " + image + " is saved.");
        }

        public void Retrieve()
        {
            Console.WriteLine("Image " + image + " is retrieved.");
        }

        public void View()
        {
            Console.WriteLine("Image " + image + " is viewed.");
        }

        public void Edit()
        {
            Console.WriteLine("Image " + image + " is updated.");
        }

        public void Delete()
        {
            Console.WriteLine("Image" + image + " is deleted.");
        }
    }
}
