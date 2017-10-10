using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Common;

namespace Graph
{
    public partial class Form1 : Form
    {
        private List<IDataGenerator> data;
        private List<IStaticsFactory> factory;

        private IDataGenerator sData;
        private IStaticsFactory sFactory;

        private GraphWindowBuilder gwBuilder;
        public Form1()
        {
            InitializeComponent();

            data = new List<IDataGenerator>();
            factory = new List<IStaticsFactory>();
            gwBuilder = new GraphWindow1();

            data.Add(new RandomDataGenerator());
            data.Add(new PolynomicDataGenerator());
            data.Add(new UltimateDataGenerator());

            factory.Add(new AverageSortFactory());
            factory.Add(new AverageRootFactory());
            factory.Add(new AverageLogFactory());
            factory.Add(new StandardRootFactory());
            factory.Add(new StandardSortFactory());
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            GraphWindow graphWindow = gwBuilder.Build();
            GraphForm newForm = new GraphForm(graphWindow, this,sFactory,sData);
            newForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cB_Data.DataSource = data;
            cB_Factory.DataSource = factory;

            sData = data[0];
            sFactory = factory[0];
        }

        private void cB_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            sData = data[cB_Data.SelectedIndex];
        }

        private void cB_Factory_SelectedIndexChanged(object sender, EventArgs e)
        {
            sFactory = factory[cB_Factory.SelectedIndex];
        }
    }
}
