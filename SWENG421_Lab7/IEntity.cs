using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    interface IEntity
    {
        void Save();
        void Retrieve();
        void View();
        void Edit();
        void Delete();
    }
}
