namespace MjenjaMjenja
{
    partial class FirstControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstControl));
            this.gridCurrencies = new System.Windows.Forms.DataGridView();
            this.CurrencyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputCount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.inputIso = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.btnSortID = new System.Windows.Forms.Button();
            this.btnSortISO = new System.Windows.Forms.Button();
            this.btnSortRate = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCurrencies
            // 
            this.gridCurrencies.AllowUserToAddRows = false;
            this.gridCurrencies.AllowUserToDeleteRows = false;
            this.gridCurrencies.AllowUserToOrderColumns = true;
            this.gridCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCurrencies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyID,
            this.iso,
            this.curName,
            this.curRate,
            this.curCount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCurrencies.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCurrencies.Location = new System.Drawing.Point(213, 40);
            this.gridCurrencies.Name = "gridCurrencies";
            this.gridCurrencies.ReadOnly = true;
            this.gridCurrencies.Size = new System.Drawing.Size(593, 351);
            this.gridCurrencies.TabIndex = 0;
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
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ime valute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(24, 101);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(147, 29);
            this.inputName.TabIndex = 2;
            // 
            // inputCount
            // 
            this.inputCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCount.Location = new System.Drawing.Point(24, 196);
            this.inputCount.Name = "inputCount";
            this.inputCount.Size = new System.Drawing.Size(147, 29);
            this.inputCount.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(14, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Država";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inputIso
            // 
            this.inputIso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIso.Location = new System.Drawing.Point(24, 294);
            this.inputIso.Name = "inputIso";
            this.inputIso.Size = new System.Drawing.Size(147, 29);
            this.inputIso.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "ISO kod";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter";
            // 
            // MyToolTip
            // 
            this.MyToolTip.ForeColor = System.Drawing.Color.Black;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(152, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 36);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeach.FlatAppearance.BorderSize = 0;
            this.btnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeach.Image = ((System.Drawing.Image)(resources.GetObject("btnSeach.Image")));
            this.btnSeach.Location = new System.Drawing.Point(70, 329);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(64, 47);
            this.btnSeach.TabIndex = 11;
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // btnSortID
            // 
            this.btnSortID.FlatAppearance.BorderSize = 0;
            this.btnSortID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortID.Image = ((System.Drawing.Image)(resources.GetObject("btnSortID.Image")));
            this.btnSortID.Location = new System.Drawing.Point(272, 14);
            this.btnSortID.Name = "btnSortID";
            this.btnSortID.Size = new System.Drawing.Size(75, 23);
            this.btnSortID.TabIndex = 12;
            this.btnSortID.UseVisualStyleBackColor = true;
            this.btnSortID.Click += new System.EventHandler(this.btnSortID_Click);
            // 
            // btnSortISO
            // 
            this.btnSortISO.FlatAppearance.BorderSize = 0;
            this.btnSortISO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortISO.Image = ((System.Drawing.Image)(resources.GetObject("btnSortISO.Image")));
            this.btnSortISO.Location = new System.Drawing.Point(367, 14);
            this.btnSortISO.Name = "btnSortISO";
            this.btnSortISO.Size = new System.Drawing.Size(75, 23);
            this.btnSortISO.TabIndex = 13;
            this.btnSortISO.UseVisualStyleBackColor = true;
            this.btnSortISO.Click += new System.EventHandler(this.btnSortISO_Click);
            // 
            // btnSortRate
            // 
            this.btnSortRate.FlatAppearance.BorderSize = 0;
            this.btnSortRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortRate.Image = ((System.Drawing.Image)(resources.GetObject("btnSortRate.Image")));
            this.btnSortRate.Location = new System.Drawing.Point(588, 14);
            this.btnSortRate.Name = "btnSortRate";
            this.btnSortRate.Size = new System.Drawing.Size(75, 23);
            this.btnSortRate.TabIndex = 15;
            this.btnSortRate.UseVisualStyleBackColor = true;
            this.btnSortRate.Click += new System.EventHandler(this.btnSortRate_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.FlatAppearance.BorderSize = 0;
            this.btnSortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortName.Image = ((System.Drawing.Image)(resources.GetObject("btnSortName.Image")));
            this.btnSortName.Location = new System.Drawing.Point(481, 14);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(75, 23);
            this.btnSortName.TabIndex = 14;
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortCount
            // 
            this.btnSortCount.FlatAppearance.BorderSize = 0;
            this.btnSortCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortCount.Image = ((System.Drawing.Image)(resources.GetObject("btnSortCount.Image")));
            this.btnSortCount.Location = new System.Drawing.Point(690, 14);
            this.btnSortCount.Name = "btnSortCount";
            this.btnSortCount.Size = new System.Drawing.Size(75, 23);
            this.btnSortCount.TabIndex = 16;
            this.btnSortCount.UseVisualStyleBackColor = true;
            this.btnSortCount.Click += new System.EventHandler(this.btnSortCount_Click);
            // 
            // FirstControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnSortCount);
            this.Controls.Add(this.btnSortRate);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnSortISO);
            this.Controls.Add(this.btnSortID);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputIso);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.inputCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridCurrencies);
            this.Name = "FirstControl";
            this.Size = new System.Drawing.Size(824, 407);
            this.Load += new System.EventHandler(this.FirstControl_Load_1);
            this.MouseHover += new System.EventHandler(this.FirstControl_MouseHover);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputIso;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnSortID;
        private System.Windows.Forms.Button btnSortISO;
        private System.Windows.Forms.Button btnSortRate;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortCount;
    }
}
