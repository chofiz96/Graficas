using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Core
{
    public class GraphWindow1 : GraphWindowBuilder
    {
        public override GraphWindow Build()
        {
            GraphWindow graphWindow = new GraphWindow();
            this.BuildGraph(graphWindow);
            this.BuildWindow(graphWindow);
            return graphWindow;
        }

        public override void BuildGraph(GraphWindow graphWindow)
        {
            graphWindow.Graph = new Graph();
            graphWindow.Graph.GraphHeight = 400;
            graphWindow.Graph.GraphWidth = 400;
        }

        public override void BuildWindow(GraphWindow graphWindow)
        {
            graphWindow.Window = new Window();
            graphWindow.Window.MeanFontSize = 10;
        }
    }
}
