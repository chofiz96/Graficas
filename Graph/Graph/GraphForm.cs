using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Core;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph
{
    public partial class GraphForm : Form
    {
        private Form parent;
        private double mean;
        private DCPrototype original;
        private DCPrototype modified;
        private GraphWindow graphWindow;
        public GraphForm(GraphWindow graphWindow, Form parent, IStaticsFactory factory, IDataGenerator data)
        {
            InitializeComponent();
            this.Closing += Form1_Closing;
            this.parent = parent;
            this.graphWindow = graphWindow;

            original = new DataContainer();
            original.Data = data.GenerateData();
            modified = original.Clone();
            mean = factory.GetMeanCalculator().CalculateMean(modified.Data);
            modified.Data = factory.GetDataTransformer().TransformData(modified.Data);
            
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            parent.Show();
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            chart1.Height = graphWindow.Graph.GraphHeight;
            chart1.Width = graphWindow.Graph.GraphWidth;
            lbl_mean.Font = new Font("Arial", graphWindow.Window.MeanFontSize, FontStyle.Bold);

            lbl_mean.Text = mean.ToString();

            Series Minimum = chart1.Series.Add("Original");
            Minimum.Points.DataBindY(original.Data);
            Minimum.ChartType = SeriesChartType.Line;
            Minimum.Color = Color.Red;
            Minimum.BorderWidth = 2;

            Series Modified = chart1.Series.Add("Modified");
            Modified.Points.DataBindY(modified.Data);
            Modified.ChartType = SeriesChartType.Line;
            Modified.Color = Color.Blue;
            Modified.BorderWidth = 2;
        }
    }
}
