using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Page : EntityBase
    {
        public override void Save()
        {
            Console.WriteLine("A page is saved.");
            base.Save();
        }

        public override void Retrieve()
        {
            Console.WriteLine("A page is retrieved.");
            base.Retrieve();
        }

        public override void View()
        {
            base.View();

        }

        public override void Edit()
        {
            Console.WriteLine("A page is updated.");
            base.Edit();
        }

        public override void Delete()
        {
            Console.WriteLine("A page is deleted.");
            base.Delete();
        }
    }
}
