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
    public partial class ExchangeControl : UserControl
    {
        private readonly CurrencyRepository rep = new CurrencyRepository();

        public ExchangeControl()
        {
            InitializeComponent();
        }

        private void picSwap_Click(object sender, EventArgs e)
        {
            var temp = comboBoxValuta1.SelectedItem;
            comboBoxValuta1.SelectedItem = comboBoxValuta2.SelectedItem;
            comboBoxValuta2.SelectedItem = temp;
        }

        private void picClear_Click(object sender, EventArgs e)
        {
            lblAmount.Text = string.Empty;
            lblAmountFirstIso.Text = string.Empty;
            lblEndIso.Text = string.Empty ;
            lblToFromDiff.Text = string.Empty;
            lblFromToDiff.Text = string.Empty;
            comboBoxValuta1.SelectedIndex = -1; comboBoxValuta2.SelectedIndex = -1;
            valutaIznos1.Value = 0;
        }

        private void ExchangeControl_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        private string Shorten(string fullname)
        {
            var sShort = "";
            for(var i = 0; i < 3; i++)
            {
                sShort += fullname[i];
            }
            return sShort;
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lblAmount.Text = Math.Round(rep.Exchange(Shorten(comboBoxValuta1.SelectedItem.ToString()), Shorten(comboBoxValuta2.SelectedItem.ToString()), Convert.ToDouble(valutaIznos1.Value)), 4).ToString();
            lblAmountFirstIso.Text = valutaIznos1.Value + " " + Shorten(comboBoxValuta1.SelectedItem.ToString()) + " =";
            lblEndIso.Text = Shorten(comboBoxValuta2.SelectedItem.ToString());
            lblEndIso.ForeColor = Color.FromArgb(26, 187, 154);
            lblToFromDiff.Text = "1 " + Shorten(comboBoxValuta2.SelectedItem.ToString()) + " = " + rep.Exchange(Shorten(comboBoxValuta2.SelectedItem.ToString()), Shorten(comboBoxValuta1.SelectedItem.ToString()), 1).ToString() + " " + Shorten(comboBoxValuta1.SelectedItem.ToString());
            lblFromToDiff.Text = "1 " + Shorten(comboBoxValuta1.SelectedItem.ToString()) + " = " + rep.Exchange(Shorten(comboBoxValuta1.SelectedItem.ToString()), Shorten(comboBoxValuta2.SelectedItem.ToString()), 1).ToString() + " " + Shorten(comboBoxValuta2.SelectedItem.ToString());
        }

      
        private void FillComboBoxes()
        {
            comboBoxValuta1.Items.Clear();
            comboBoxValuta2.Items.Clear();
            var iso = rep.PullFromDataBase();
            foreach (var a in iso)
            {
                string fullName = a.IsoCode + ": " + a.Name;
                comboBoxValuta1.Items.Add(fullName);
                comboBoxValuta2.Items.Add(fullName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillComboBoxes();

        }
    }
}
