using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421_Lab7
{
    abstract class EntityBase : IEntity, IReadOnly
    {
        protected List<IEntity> component = new List<IEntity>();

        public void Add(IEntity element)
        {
            if (this.GetType() == element.GetType())
            {
                Console.WriteLine("Invalid, cannot add same entity to self");
                return;
            }
            component.Add(element); 
        }

        public virtual void Save()
        {
            foreach (var c in component)
                c.Save();
        }

        public virtual void Retrieve()
        {
            foreach (var c in component)
                c.Retrieve();
        }

        public virtual void View()
        {
            foreach (var c in component)
                c.View();
        }

        public virtual void Edit()
        {
            foreach (var c in component)
                c.Edit();
        }

        public virtual void Delete()
        {
            foreach (var c in component)
                c.Delete();
            component.Clear();
        }
    }
}
