namespace MjenjaMjenja
{
    partial class CRUDcontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDcontrol));
            this.gridCurrencies = new System.Windows.Forms.DataGridView();
            this.CurrencyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTemp = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.inputSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCurrencies
            // 
            this.gridCurrencies.AllowUserToAddRows = false;
            this.gridCurrencies.AllowUserToDeleteRows = false;
            this.gridCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCurrencies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyID,
            this.iso,
            this.curName,
            this.curRate,
            this.curCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCurrencies.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCurrencies.Location = new System.Drawing.Point(16, 60);
            this.gridCurrencies.Name = "gridCurrencies";
            this.gridCurrencies.ReadOnly = true;
            this.gridCurrencies.Size = new System.Drawing.Size(795, 337);
            this.gridCurrencies.TabIndex = 1;
            this.gridCurrencies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCurrencies_CellContentClick);
            // 
            // CurrencyID
            // 
            this.CurrencyID.DataPropertyName = "CurrencyID";
            this.CurrencyID.HeaderText = "ID";
            this.CurrencyID.Name = "CurrencyID";
            this.CurrencyID.ReadOnly = true;
            // 
            // iso
            // 
            this.iso.DataPropertyName = "IsoCode";
            this.iso.HeaderText = "ISO kod";
            this.iso.Name = "iso";
            this.iso.ReadOnly = true;
            // 
            // curName
            // 
            this.curName.DataPropertyName = "Name";
            this.curName.HeaderText = "Ime Valute";
            this.curName.Name = "curName";
            this.curName.ReadOnly = true;
            // 
            // curRate
            // 
            this.curRate.DataPropertyName = "Rate";
            this.curRate.HeaderText = "Tečaj / Dolar";
            this.curRate.Name = "curRate";
            this.curRate.ReadOnly = true;
            // 
            // curCount
            // 
            this.curCount.DataPropertyName = "Country";
            this.curCount.HeaderText = "Država";
            this.curCount.Name = "curCount";
            this.curCount.ReadOnly = true;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(776, 3);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(35, 13);
            this.labelTemp.TabIndex = 2;
            this.labelTemp.Text = "label1";
            this.labelTemp.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(154)))));
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.Location = new System.Drawing.Point(16, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(168, 51);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Dodaj valutu";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Osvježi";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(757, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 36);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(154)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(408, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 43);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSearch.Location = new System.Drawing.Point(255, 15);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(147, 29);
            this.inputSearch.TabIndex = 32;
            // 
            // CRUDcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.gridCurrencies);
            this.Name = "CRUDcontrol";
            this.Size = new System.Drawing.Size(824, 407);
            this.Load += new System.EventHandler(this.CRUDcontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCurrencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iso;
        private System.Windows.Forms.DataGridViewTextBoxColumn curName;
        private System.Windows.Forms.DataGridViewTextBoxColumn curRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn curCount;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox inputSearch;
    }
}
