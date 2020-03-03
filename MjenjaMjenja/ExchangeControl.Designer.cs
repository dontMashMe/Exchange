namespace MjenjaMjenja
{
    partial class ExchangeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeControl));
            this.picClear = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.picSwap = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxValuta1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valutaIznos1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxValuta2 = new System.Windows.Forms.ComboBox();
            this.lblFromToDiff = new System.Windows.Forms.Label();
            this.lblEndIso = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmountFirstIso = new System.Windows.Forms.Label();
            this.lblToFromDiff = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSwap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valutaIznos1)).BeginInit();
            this.SuspendLayout();
            // 
            // picClear
            // 
            this.picClear.Location = new System.Drawing.Point(22, 127);
            this.picClear.Name = "picClear";
            this.picClear.Size = new System.Drawing.Size(54, 48);
            this.picClear.TabIndex = 19;
            this.picClear.Text = "C";
            this.picClear.UseVisualStyleBackColor = true;
            this.picClear.Click += new System.EventHandler(this.picClear_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(290, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 21);
            this.label16.TabIndex = 20;
            this.label16.Text = "Željena";
            // 
            // picSwap
            // 
            this.picSwap.Image = ((System.Drawing.Image)(resources.GetObject("picSwap.Image")));
            this.picSwap.Location = new System.Drawing.Point(222, 72);
            this.picSwap.Name = "picSwap";
            this.picSwap.Size = new System.Drawing.Size(49, 64);
            this.picSwap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSwap.TabIndex = 18;
            this.picSwap.TabStop = false;
            this.picSwap.Click += new System.EventHandler(this.picSwap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Početna";
            // 
            // comboBoxValuta1
            // 
            this.comboBoxValuta1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValuta1.FormattingEnabled = true;
            this.comboBoxValuta1.Location = new System.Drawing.Point(294, 59);
            this.comboBoxValuta1.Name = "comboBoxValuta1";
            this.comboBoxValuta1.Size = new System.Drawing.Size(325, 38);
            this.comboBoxValuta1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Iznos:";
            // 
            // valutaIznos1
            // 
            this.valutaIznos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valutaIznos1.Location = new System.Drawing.Point(22, 54);
            this.valutaIznos1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.valutaIznos1.Name = "valutaIznos1";
            this.valutaIznos1.Size = new System.Drawing.Size(164, 35);
            this.valutaIznos1.TabIndex = 17;
            // 
            // comboBoxValuta2
            // 
            this.comboBoxValuta2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValuta2.FormattingEnabled = true;
            this.comboBoxValuta2.Location = new System.Drawing.Point(294, 131);
            this.comboBoxValuta2.Name = "comboBoxValuta2";
            this.comboBoxValuta2.Size = new System.Drawing.Size(325, 38);
            this.comboBoxValuta2.TabIndex = 13;
            // 
            // lblFromToDiff
            // 
            this.lblFromToDiff.AutoSize = true;
            this.lblFromToDiff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromToDiff.Location = new System.Drawing.Point(290, 336);
            this.lblFromToDiff.Name = "lblFromToDiff";
            this.lblFromToDiff.Size = new System.Drawing.Size(0, 21);
            this.lblFromToDiff.TabIndex = 25;
            // 
            // lblEndIso
            // 
            this.lblEndIso.AutoSize = true;
            this.lblEndIso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndIso.Location = new System.Drawing.Point(478, 265);
            this.lblEndIso.Name = "lblEndIso";
            this.lblEndIso.Size = new System.Drawing.Size(0, 21);
            this.lblEndIso.TabIndex = 24;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(299, 234);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 58);
            this.lblAmount.TabIndex = 23;
            // 
            // lblAmountFirstIso
            // 
            this.lblAmountFirstIso.AutoSize = true;
            this.lblAmountFirstIso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountFirstIso.Location = new System.Drawing.Point(351, 210);
            this.lblAmountFirstIso.Name = "lblAmountFirstIso";
            this.lblAmountFirstIso.Size = new System.Drawing.Size(0, 24);
            this.lblAmountFirstIso.TabIndex = 22;
            // 
            // lblToFromDiff
            // 
            this.lblToFromDiff.AutoSize = true;
            this.lblToFromDiff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToFromDiff.Location = new System.Drawing.Point(290, 302);
            this.lblToFromDiff.Name = "lblToFromDiff";
            this.lblToFromDiff.Size = new System.Drawing.Size(0, 21);
            this.lblToFromDiff.TabIndex = 21;
            // 
            // btnChange
            // 
            this.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(648, 72);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(121, 81);
            this.btnChange.TabIndex = 26;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(581, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 48);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Osvježi";
            // 
            // ExchangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblFromToDiff);
            this.Controls.Add(this.lblEndIso);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountFirstIso);
            this.Controls.Add(this.lblToFromDiff);
            this.Controls.Add(this.picClear);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.picSwap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxValuta1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valutaIznos1);
            this.Controls.Add(this.comboBoxValuta2);
            this.Name = "ExchangeControl";
            this.Size = new System.Drawing.Size(824, 407);
            this.Load += new System.EventHandler(this.ExchangeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSwap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valutaIznos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button picClear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox picSwap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxValuta1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown valutaIznos1;
        private System.Windows.Forms.ComboBox comboBoxValuta2;
        private System.Windows.Forms.Label lblFromToDiff;
        private System.Windows.Forms.Label lblEndIso;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAmountFirstIso;
        private System.Windows.Forms.Label lblToFromDiff;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}
