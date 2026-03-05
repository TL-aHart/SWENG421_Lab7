using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    class Writer
    {
        public void View(IReadOnly element)
        {
            element.View();
        }

        public void Edit(IReadOnly element)
        { 
            element.Edit();
        }
    }
}
