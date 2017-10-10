using System;
using System.Collections.Generic;
using System.Text;
using Common;
namespace Core
{
    public abstract class GraphWindowBuilder
    {
        public abstract void BuildGraph(GraphWindow graphWindow);
        public abstract void BuildWindow(GraphWindow graphWindow);
        public abstract GraphWindow Build();
    }
}
