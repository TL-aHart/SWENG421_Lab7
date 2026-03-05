using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Novel : EntityBase
    {
        public override void Save()
        {
            Console.WriteLine("One novel is saved.");
            base.Save();
        }

        public override void Retrieve()
        {
            Console.WriteLine("One novel is retrieved.");
            base.Retrieve();
        }

        public override void View()
        {
            base.View();
        }

        public override void Edit()
        {
            Console.WriteLine("One novel is updated.");
            base.Edit();
        }

        public override void Delete()
        {
            Console.WriteLine("One novel is deleted.");
            base.Delete();
        }
    }
}
