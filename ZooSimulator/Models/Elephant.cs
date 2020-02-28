using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZooSimulator.ViewModel;

namespace ZooSimulator.Models
{
    public class Elephant : Animal
    {
        public Elephant()
        {
            Name = "Elephant";
            Health = 100;
            IsDead = false;
        }

        public void AddHealth(float value)
        {
            if (!IsDead)
            {
                Health = Health + value;
            }
        }

        public void TakeHealth(float value)
        {
            Health = Health - value;
            if (Health < 70)
            {
                IsDead = true;
            }
        }

        public string Name { get; set; }
        public float Health { get; set; }
        public bool IsDead { get; set; }
    }
}
