using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Repository;

namespace MjenjaMjenja
{
    public partial class GraphControl : UserControl
    {
        private readonly CurrencyRepository rep = new CurrencyRepository();
        private Currency _currency;
        public GraphControl()
        {
            InitializeComponent();
        }

        private void GraphControl_Load(object sender, EventArgs e)
        {
            var currencies = rep.PullFromDataBase();
            foreach(var a in currencies)
            {
                comboIso.Items.Add(a.IsoCode);
                comboCount.Items.Add(a.Country);
                comboIme.Items.Add(a.Name);
            }
            dateTimePicker1.MinDate = new DateTime(2019, 12, 1);
            dateTimePicker1.MaxDate = DateTime.Today;
        }
  
        private void comboIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currencies = rep.PullFromDataBase(); 
            foreach(var a in currencies)
            {
                if (comboIme.SelectedItem.ToString() == a.Name) _currency = a;
            }
            var fromDate = DateTime.Now.AddDays(-7);
            var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
            var toDate = DateTime.Now;
            var dates = rep.DateRange(fromDate, toDate);
            LoadGraph(_currency, historical, dates);
        }
        private void LoadGraph(Currency curr, List<double> rates, IEnumerable<DateTime> dates)
        {
            var xValues = new List<string>();
            var yValues = new List<double>();
            chart1.Series.Clear();
            chart1.Series.Add(curr.Name);
            chart1.Series[curr.Name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            int counter = 0;
            foreach (var day in dates)
            {
                xValues.Add($"{day:dd-MM-yyyy}");
                yValues.Add(rates[counter]);
                counter++;
            }
            chart1.ChartAreas[0].AxisY.Minimum = rates.Min();
            chart1.Series[curr.Name].Points.DataBindXY(xValues, yValues);
            chart1.Series[curr.Name].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart1.Series[curr.Name].MarkerSize = 7;
            var change = Math.Round(rep.Change(rates), 3);
            if (change > 0)
            {
                lblChange.Text = "+" + change + "%".ToString();
                lblChange.ForeColor = Color.Green;
            }
            else if (change < 0)
            {
                lblChange.Text = change + "%".ToString();
                lblChange.ForeColor = Color.Red;
            }
            else
            {
                lblChange.Text = change + "%".ToString();
                lblChange.ForeColor = new Color();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {         
            if(_currency != null)
            {
                var fromDate = dateTimePicker1.Value;
                chart1.Invalidate();
                var toDate = DateTime.Now;
                var dates = rep.DateRange(fromDate, toDate);
                var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
                LoadGraph(_currency, historical, dates);
            }
       
        }

        private void comboCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currencies = rep.PullFromDataBase();
            foreach (var a in currencies)
            {
                if (comboCount.SelectedItem.ToString() == a.Country) _currency = a;
            }
            var fromDate = DateTime.Now.AddDays(-7);
            var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
            var toDate = DateTime.Now;
            var dates = rep.DateRange(fromDate, toDate);
            LoadGraph(_currency, historical, dates);
        }

        private void comboIso_SelectedIndexChanged(object sender, EventArgs e)
        {

            var currencies = rep.PullFromDataBase();
            foreach (var a in currencies)
            {
                if (comboIso.SelectedItem.ToString() == a.IsoCode) _currency = a;
            }
            var fromDate = DateTime.Now.AddDays(-7);
            var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
            var toDate = DateTime.Now;
            var dates = rep.DateRange(fromDate, toDate);
            LoadGraph(_currency, historical, dates);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboCount.SelectedIndex = -1;
            comboIme.SelectedIndex = -1;
            comboIso.SelectedIndex = -1;
        }
    }
}
