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
    public partial class CRUDcontrol : UserControl
    {
        private readonly CurrencyRepository rep = new CurrencyRepository();
        readonly BindingSource bind = new BindingSource();
        public CRUDcontrol()
        {
            InitializeComponent();
        }

        private void CRUDcontrol_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            var buttonEdit = new DataGridViewImageColumn
            {
                Image = Image.FromFile("edit2.png"),
                Width = 40,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            gridCurrencies.Columns.Add(buttonEdit);
            gridCurrencies.AutoGenerateColumns = false;


            var buttonDelete = new DataGridViewImageColumn
            {
                Image = Image.FromFile("delete.png"),
                Width = 40,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            gridCurrencies.Columns.Add(buttonDelete);
            gridCurrencies.AutoGenerateColumns = false;
        }

        private void gridCurrencies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currencies = rep.PullFromDataBase();
            gridCurrencies.Rows[e.RowIndex].Selected = true;
            if(gridCurrencies.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex!= -1)
            {
                labelTemp.Text = gridCurrencies.Rows[e.RowIndex].Cells["iso"].Value.ToString();
                var curr = new Currency();
                foreach (var a in currencies)
                {
                    if (labelTemp.Text == a.IsoCode) curr = a;
                }

                FormEdit forma = new FormEdit(curr, this);
                forma.Show();
                gridCurrencies.DataSource = rep.PullFromDataBase();
                //edit
            }
            if (gridCurrencies.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                labelTemp.Text = gridCurrencies.Rows[e.RowIndex].Cells["iso"].Value.ToString();
                string message = "Jeste li sigurni da želite obrisati: " + rep.NameFromIso(labelTemp.Text) + "?";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    rep.DeleteCurrency(labelTemp.Text);
                    MessageBox.Show("Valuta uspješno obrisana!");
                }
                gridCurrencies.DataSource = rep.PullFromDataBase();
                
            }
        }

        public void RefreshGrid()
        {
            bind.DataSource = rep.PullFromDataBase();

            gridCurrencies.DataSource = bind;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var forma = new FormAdd(this);
            forma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bind.DataSource = rep.FilterCRUD(inputSearch.Text);
            gridCurrencies.DataSource = bind;
        }
    }
}
