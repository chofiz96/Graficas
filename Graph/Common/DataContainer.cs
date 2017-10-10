using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public abstract class DCPrototype
    {
        public List<double> Data { get; set; }
        public abstract DCPrototype Clone();
    }
    public class DataContainer : DCPrototype
    {
        
        public override DCPrototype Clone()
        {
            DataContainer copy = new DataContainer();
            copy.Data = new List<double>(Data);
            return copy;
        }
    }
}
