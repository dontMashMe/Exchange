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
    public partial class TableControl : UserControl
    {
        private readonly CurrencyRepository rep = new CurrencyRepository();
        private Currency _currency;
        public TableControl()
        {
            InitializeComponent();
        }

        private void TableControl_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(2019, 12, 1);
            dateTimePicker1.MaxDate = DateTime.Today;
            var currencies = rep.PullFromDataBase(); 
            foreach(var a in currencies)
            {
                comboCount.Items.Add(a.Country);
                comboIme.Items.Add(a.Name);
                comboIso.Items.Add(a.IsoCode);
            }

        }

        private void comboIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currencies = rep.PullFromDataBase();
            foreach(var a in currencies)
            {
                if (a.Name == comboIme.SelectedItem.ToString()) _currency = a;

            }
            dataGridViewHistorical.Rows.Clear();
            var fromDate = DateTime.Now.AddDays(-7);
            var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
            var toDate = DateTime.Now;
            var dates = rep.DateRange(fromDate, toDate);
            SetUpTable(historical, dates);
            
        }

        private void SetUpTable(List<double> historical, IEnumerable<DateTime> dates)
        {
            int counter = 0;
            foreach (var day in dates)
            {
                dataGridViewHistorical.Rows.Add($"{day:dd-MM-yyyy}", historical[counter]);
                counter++;
            }
            var change = Math.Round(rep.Change(historical), 3);
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
            lblDateOne.Text = $"{dates.First():dd-MM-yyyy}".ToString();
            lblDateTwo.Text = $"{dates.Last():dd-MM-yyyy}".ToString();
            lblValue.Text = Math.Round(historical.First(), 2).ToString();
            lblValueTwo.Text = Math.Round(historical.Last(), 2).ToString();
            labelValutaIme.Text = _currency.Name.ToString();
            lblHigh.Text = "Najviši: " + historical.Max().ToString();
            lblLow.Text = "Najniži: " + historical.Min().ToString();
            lblSr.Text = "Srednja vrijednost: " + Math.Round((historical.Sum() / historical.Count), 4).ToString();

        }

        private void comboCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currencies = rep.PullFromDataBase(); 
            foreach(var a in currencies)
            {
                if (comboCount.SelectedItem.ToString() == a.Country) _currency = a;
            }
            dataGridViewHistorical.Rows.Clear();
            var fromDate = DateTime.Now.AddDays(-7);
            var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
            var toDate = DateTime.Now;
            var dates = rep.DateRange(fromDate, toDate);
            SetUpTable(historical, dates);

        }

        private void comboIso_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currencies = rep.PullFromDataBase();
            foreach (var a in currencies)
            {
                if (comboIso.SelectedItem.ToString() == a.IsoCode) _currency = a;
            }
            dataGridViewHistorical.Rows.Clear();
            var fromDate = DateTime.Now.AddDays(-7);
            var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
            var toDate = DateTime.Now;
            var dates = rep.DateRange(fromDate, toDate);
            SetUpTable(historical, dates);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(_currency != null)
            {
                dataGridViewHistorical.Rows.Clear();
                var fromDate = dateTimePicker1.Value;
                var historical = rep.GetHistoricalRatesAPI(_currency.IsoCode, fromDate);
                var toDate = DateTime.Now;
                var dates = rep.DateRange(fromDate, toDate);
                SetUpTable(historical, dates);
               
            }
        }
    }
}
