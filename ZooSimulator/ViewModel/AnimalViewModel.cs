using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZooSimulator.Models;


namespace ZooSimulator.ViewModel
{
    public class AnimalViewModel
    {
        public List<Animal> Animal { get; internal set; }
        public Elephant Elephant { get; set; }
        public Monkey Monkey { get; set; }
        public Giraffe Giraffe { get; set; }
    }
}