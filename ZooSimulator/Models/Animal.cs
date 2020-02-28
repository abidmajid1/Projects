using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooSimulator.Models
{
    public interface Animal
    {
        float Health { get; set; }
        bool IsDead { get; set; }
        string Name { get; set; }
    }
}