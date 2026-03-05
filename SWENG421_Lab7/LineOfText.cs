using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class LineOfText : EntityBase
    {
        public override void Save()
        {
            Console.WriteLine("A line of text is saved.");
            base.Save();
        }

        public override void Retrieve()
        {
            Console.WriteLine("A line of text is retrieved.");
            base.Retrieve();
        }

        public override void View()
        {
            base.View();
        }

        public override void Edit()
        {
            Console.WriteLine("A line of text is updated.");
            base.Edit();
        }

        public override void Delete()
        {
            Console.WriteLine("A line of text is deleted.");
            base.Delete();
        }
    }
}
