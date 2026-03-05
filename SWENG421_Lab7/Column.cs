using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Column : EntityBase
    {
        public override void Save()
        {
            Console.WriteLine("One column is saved.");
            base.Save();
        }

        public override void Retrieve()
        {
            Console.WriteLine("One column is retrieved.");
            base.Retrieve();
        }

        public override void View()
        {
            base.View();

        }

        public override void Edit()
        {
            Console.WriteLine("One column is updated.");
            base.Edit();
        }

        public override void Delete()
        {
            Console.WriteLine("One column is deleted.");
            base.Delete();
        }
    }
}
