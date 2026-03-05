using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Editor
    {
        public void Save(IEntity element)
        { 
             element.Save();
        }

        public void Retrieve(IEntity element) 
        { 
            element.Retrieve();
        }

        public void Delete(IEntity element)
        {
            element.Delete();
        }
    }
}
