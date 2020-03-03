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
    public partial class FirstControl : UserControl
    {
        private readonly CurrencyRepository rep = new CurrencyRepository();
        readonly BindingSource bind = new BindingSource();
        int counterID = 0;
        int counterISO = 0;
        int counterName = 0;
        int counterRate = 0;
        int counterCount = 0;

        public FirstControl()
        {
            InitializeComponent();
        }

        private void FirstControl_MouseHover(object sender, EventArgs e)
        {
          
        }
        private void FirstControl_Load_1(object sender, EventArgs e)
        {
            bind.DataSource = rep.PullFromDataBase();
            gridCurrencies.DataSource = bind;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            rep.UpdateDataBase(rep.GetCurrenciesAPI());
            var currencies = rep.PullFromDataBase();
            bind.DataSource = currencies;
            gridCurrencies.DataSource = bind;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            if(inputName.Text == string.Empty)
            {
                bind.DataSource = rep.Filter(inputIso.Text, inputCount.Text);
            }
            else
            {
                bind.DataSource = rep.FilterName(inputName.Text);
            }
            gridCurrencies.DataSource = bind;
        }

        private void btnSortID_Click(object sender, EventArgs e)
        {
            counterID++;
            var currencies = rep.PullFromDataBase();
            if (counterID % 2 != 0)
            {
                var sortedList = currencies.OrderByDescending(x => x.CurrencyID).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;
               
            }
            else
            {
                var sortedList = currencies.OrderBy(x => x.CurrencyID).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }

          
        }

        private void btnSortISO_Click(object sender, EventArgs e)
        {
            counterISO++;
            var currencies = rep.PullFromDataBase();
            if (counterISO % 2 != 0)
            {
                var sortedList = currencies.OrderByDescending(x => x.IsoCode).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
            else
            {
                var sortedList = currencies.OrderBy(x => x.IsoCode).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            counterName++;
            var currencies = rep.PullFromDataBase();
            if (counterName % 2 != 0)
            {
                var sortedList = currencies.OrderByDescending(x => x.Name).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
            else
            {
                var sortedList = currencies.OrderBy(x => x.Name).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
        }

        private void btnSortRate_Click(object sender, EventArgs e)
        {
            counterRate++;
            var currencies = rep.PullFromDataBase();
            if (counterRate % 2 != 0)
            {
                var sortedList = currencies.OrderByDescending(x => x.Rate).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
            else
            {
                var sortedList = currencies.OrderBy(x => x.Rate).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
        }

        private void btnSortCount_Click(object sender, EventArgs e)
        {
            counterCount++;
            var currencies = rep.PullFromDataBase();
            if (counterCount % 2 != 0)
            {
                var sortedList = currencies.OrderByDescending(x => x.Country).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
            else
            {
                var sortedList = currencies.OrderBy(x => x.Country).ToList();
                bind.DataSource = sortedList;
                gridCurrencies.DataSource = bind;

            }
        }
    }
}
