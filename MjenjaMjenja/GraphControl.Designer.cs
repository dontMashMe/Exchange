namespace MjenjaMjenja
{
    partial class GraphControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphControl));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboIso = new System.Windows.Forms.ComboBox();
            this.comboCount = new System.Windows.Forms.ComboBox();
            this.comboIme = new System.Windows.Forms.ComboBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(13, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "ISO kod";
            this.button3.UseVisualStyleBackColor = true;
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
            this.button2.Location = new System.Drawing.Point(13, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Država";
            this.button2.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(13, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ime valute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboIso
            // 
            this.comboIso.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIso.FormattingEnabled = true;
            this.comboIso.Location = new System.Drawing.Point(13, 258);
            this.comboIso.Name = "comboIso";
            this.comboIso.Size = new System.Drawing.Size(193, 38);
            this.comboIso.TabIndex = 13;
            this.comboIso.SelectedIndexChanged += new System.EventHandler(this.comboIso_SelectedIndexChanged);
            // 
            // comboCount
            // 
            this.comboCount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCount.FormattingEnabled = true;
            this.comboCount.Location = new System.Drawing.Point(13, 160);
            this.comboCount.Name = "comboCount";
            this.comboCount.Size = new System.Drawing.Size(193, 38);
            this.comboCount.TabIndex = 14;
            this.comboCount.SelectedIndexChanged += new System.EventHandler(this.comboCount_SelectedIndexChanged);
            // 
            // comboIme
            // 
            this.comboIme.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIme.FormattingEnabled = true;
            this.comboIme.Location = new System.Drawing.Point(13, 65);
            this.comboIme.Name = "comboIme";
            this.comboIme.Size = new System.Drawing.Size(193, 38);
            this.comboIme.TabIndex = 15;
            this.comboIme.SelectedIndexChanged += new System.EventHandler(this.comboIme_SelectedIndexChanged);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(681, 334);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(22, 24);
            this.lblChange.TabIndex = 19;
            this.lblChange.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Promjena: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 29);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(240, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(584, 295);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // GraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboIme);
            this.Controls.Add(this.comboCount);
            this.Controls.Add(this.comboIso);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GraphControl";
            this.Size = new System.Drawing.Size(824, 407);
            this.Load += new System.EventHandler(this.GraphControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboIso;
        private System.Windows.Forms.ComboBox comboCount;
        private System.Windows.Forms.ComboBox comboIme;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
