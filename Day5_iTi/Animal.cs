using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_iTi
{
    class Animal
    {
        public int Age { get; set; }
        public Action<Animal> RemoveAnimals;

        public void Die()
        {
            if (RemoveAnimals != null)
            {
                RemoveAnimals(this);
            }
            
        }
    }

}
