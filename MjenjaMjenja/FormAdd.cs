using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MjenjaMjenja
{
    public partial class FormAdd : Form
    {
        private CRUDcontrol _backForm;
        private readonly CurrencyRepository rep = new CurrencyRepository();
        public FormAdd(CRUDcontrol back)
        {
            InitializeComponent();
            _backForm = back;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            var controls = new List<Control>{ txtAddIso, txtAddName, numAddRate, txtAddCountry};
            foreach(var a in controls)
            {
                if (a.Text == string.Empty)
                {
                    
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return;
                }
            }
            var currencies = rep.PullFromDataBase();
            var rnd = new Random();
            var newCur = new Currency()
            {
                CurrencyID = rnd.Next(currencies.Count+3, 999),
                IsoCode = txtAddIso.Text,
                Name = txtAddName.Text,
                Rate = numAddRate.Value,
                Country = txtAddCountry.Text
            };
            rep.InsertNewCurrency(newCur);
            MessageBox.Show("Valuta uspješno dodana!");
            _backForm.RefreshGrid();
            this.Close();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
