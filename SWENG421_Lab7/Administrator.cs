using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SWENG421_Lab7
{
    class Administrator
    {
        public void Save(IEntity element)
        {
            element.Save();
        }
        public void Retrieve(IEntity element)
        {
            element.Retrieve();
        }
        public void View(IEntity element)
        {
            element.View();
        }
        public void Edit(IEntity element)
        {
            element.Edit();
        }

        public void Delete(IEntity element)
        {
            element.Delete();
        }
    }
}
