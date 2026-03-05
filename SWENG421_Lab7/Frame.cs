using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Frame : EntityBase
    {
        public override void Save()
        {
            Console.WriteLine("One frame is saved.");
            base.Save();
        }

        public override void Retrieve()
        {
            Console.WriteLine("One frame is retrieved.");
            base.Retrieve();
        }

        public override void View()
        {
            base.View();

        }

        public override void Edit()
        {
            Console.WriteLine("One frame is updated.");
            base.Edit();
        }

        public override void Delete()
        {
            Console.WriteLine("One frame is deleted.");
            base.Delete();
        }
    }
}
