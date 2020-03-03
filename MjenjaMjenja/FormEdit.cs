using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MjenjaMjenja
{
    public partial class FormEdit : Form
    {
        private readonly CurrencyRepository rep = new CurrencyRepository();
        private Currency _currency;
        private CRUDcontrol _backForm;

        public FormEdit(Currency curr, CRUDcontrol back)
        {
            _currency = curr;
            _backForm = back;
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
          
            txtEditIso.Text = _currency.IsoCode;
            txtEditName.Text = _currency.Name;
            txtEditCountry.Text = _currency.Country;
            numEditRate.Value = _currency.Rate;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            var curr = new Currency
            {
                CurrencyID = _currency.CurrencyID,
                IsoCode = txtEditIso.Text,
                Name = txtEditName.Text,
                Country = txtEditCountry.Text,
                Rate = numEditRate.Value
            };
            rep.UpdateCurrency(curr);
            _backForm.RefreshGrid();
            MessageBox.Show("Valuta uspješno spremljena!");
            this.Close();
        }
    }
}
