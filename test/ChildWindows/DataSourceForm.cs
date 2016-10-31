using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace ChildWindows
{
    public partial class DataSourceForm : Form
    {
        public DataSourceForm()
        {
            InitializeComponent();
        }


        public class ChartData
        {
            public ChartData(int a, int b, int c)
            {
                New = a;
                Closed = b;
                Canceled = c;
            }
            public int New
            {
                get;
                set;
            }

            public int Closed
            {
                get;
                set;
            }

            public int Canceled
            {
                get;
                set;
            }
        }

        
        
        private void DataSourceForm_Load(object sender, EventArgs e)
        {
            List<ChartData> data = new List<ChartData>() { new ChartData(1,2,3),new ChartData(2,4,2),new ChartData(2,3,3)};
            // fill with random int values
            chart1.DataSource = data;

            chart1.Series.Add("New").YValueMembers = "New";
            chart1.Series["New"].ChartType = SeriesChartType.Bar;
            chart1.Series["New"].XValueType = ChartValueType.Int32;
            chart1.Series["New"].YValueType = ChartValueType.Int32;
/*
            chart1.Series.Add("Canceled").YValueMembers = "Canceled";
            chart1.Series["Canceled"].ChartType = SeriesChartType.Bar;
            chart1.Series["Canceled"].XValueType = ChartValueType.Int32;
            chart1.Series["Canceled"].YValueType = ChartValueType.Int32;

            chart1.Series.Add("Closed").YValueMembers = "Closed";
            chart1.Series["Closed"].ChartType = SeriesChartType.Bar;
            chart1.Series["Closed"].XValueType = ChartValueType.Int32;
            chart1.Series["Closed"].YValueType = ChartValueType.Int32;*/

            chart1.DataBind();

        }
    }
}
