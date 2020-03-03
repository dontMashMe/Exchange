namespace MjenjaMjenja
{
    partial class FormRedisgn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRedisgn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnCrude = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFace = new System.Windows.Forms.Button();
            this.btnTwit = new System.Windows.Forms.Button();
            this.btnInsta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableControl1 = new MjenjaMjenja.TableControl();
            this.graphControl1 = new MjenjaMjenja.GraphControl();
            this.exchangeControl1 = new MjenjaMjenja.ExchangeControl();
            this.FirstControl = new MjenjaMjenja.FirstControl();
            this.cruDcontrol1 = new MjenjaMjenja.CRUDcontrol();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.picIzlaz);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTable);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnGraph);
            this.panel1.Controls.Add(this.btnCrude);
            this.panel1.Controls.Add(this.btnExchange);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 583);
            this.panel1.TabIndex = 0;
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(12, 516);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(58, 55);
            this.picIzlaz.TabIndex = 6;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(77, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Izlaz";
            // 
            // btnTable
            // 
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTable.Image = ((System.Drawing.Image)(resources.GetObject("btnTable.Image")));
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(0, 422);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(175, 43);
            this.btnTable.TabIndex = 5;
            this.btnTable.Text = "    Tablični tečaj";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnGraph
            // 
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnGraph.Image")));
            this.btnGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.Location = new System.Drawing.Point(0, 363);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(175, 43);
            this.btnGraph.TabIndex = 3;
            this.btnGraph.Text = "Graf";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnCrude
            // 
            this.btnCrude.FlatAppearance.BorderSize = 0;
            this.btnCrude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrude.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrude.Image = ((System.Drawing.Image)(resources.GetObject("btnCrude.Image")));
            this.btnCrude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrude.Location = new System.Drawing.Point(0, 304);
            this.btnCrude.Name = "btnCrude";
            this.btnCrude.Size = new System.Drawing.Size(175, 43);
            this.btnCrude.TabIndex = 2;
            this.btnCrude.Text = "CRUD";
            this.btnCrude.UseVisualStyleBackColor = true;
            this.btnCrude.Click += new System.EventHandler(this.btnCrude_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnExchange.Image")));
            this.btnExchange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExchange.Location = new System.Drawing.Point(0, 245);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(175, 43);
            this.btnExchange.TabIndex = 1;
            this.btnExchange.Text = "Zamjena";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(1, 185);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(175, 43);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Pregled ";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(154)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 21);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(154)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(257, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 150);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(47, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošli!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFace
            // 
            this.btnFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFace.FlatAppearance.BorderSize = 0;
            this.btnFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFace.Image = ((System.Drawing.Image)(resources.GetObject("btnFace.Image")));
            this.btnFace.Location = new System.Drawing.Point(935, 35);
            this.btnFace.Name = "btnFace";
            this.btnFace.Size = new System.Drawing.Size(55, 36);
            this.btnFace.TabIndex = 4;
            this.btnFace.UseVisualStyleBackColor = true;
            this.btnFace.Click += new System.EventHandler(this.btnFace_Click);
            // 
            // btnTwit
            // 
            this.btnTwit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTwit.FlatAppearance.BorderSize = 0;
            this.btnTwit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwit.Image = ((System.Drawing.Image)(resources.GetObject("btnTwit.Image")));
            this.btnTwit.Location = new System.Drawing.Point(827, 35);
            this.btnTwit.Name = "btnTwit";
            this.btnTwit.Size = new System.Drawing.Size(55, 36);
            this.btnTwit.TabIndex = 5;
            this.btnTwit.UseVisualStyleBackColor = true;
            this.btnTwit.Click += new System.EventHandler(this.btnTwit_Click);
            // 
            // btnInsta
            // 
            this.btnInsta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsta.FlatAppearance.BorderSize = 0;
            this.btnInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsta.Image = ((System.Drawing.Image)(resources.GetObject("btnInsta.Image")));
            this.btnInsta.Location = new System.Drawing.Point(884, 35);
            this.btnInsta.Name = "btnInsta";
            this.btnInsta.Size = new System.Drawing.Size(55, 36);
            this.btnInsta.TabIndex = 6;
            this.btnInsta.UseVisualStyleBackColor = true;
            this.btnInsta.Click += new System.EventHandler(this.btnInsta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 78);
            this.label5.TabIndex = 8;
            this.label5.Text = "ExChange";
            // 
            // tableControl1
            // 
            this.tableControl1.Location = new System.Drawing.Point(178, 176);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.Size = new System.Drawing.Size(824, 407);
            this.tableControl1.TabIndex = 11;
            // 
            // graphControl1
            // 
            this.graphControl1.Location = new System.Drawing.Point(178, 176);
            this.graphControl1.Name = "graphControl1";
            this.graphControl1.Size = new System.Drawing.Size(824, 407);
            this.graphControl1.TabIndex = 10;
            // 
            // exchangeControl1
            // 
            this.exchangeControl1.Location = new System.Drawing.Point(178, 176);
            this.exchangeControl1.Name = "exchangeControl1";
            this.exchangeControl1.Size = new System.Drawing.Size(824, 407);
            this.exchangeControl1.TabIndex = 9;
            // 
            // FirstControl
            // 
            this.FirstControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstControl.Location = new System.Drawing.Point(178, 174);
            this.FirstControl.Name = "FirstControl";
            this.FirstControl.Size = new System.Drawing.Size(824, 409);
            this.FirstControl.TabIndex = 2;
            // 
            // cruDcontrol1
            // 
            this.cruDcontrol1.Location = new System.Drawing.Point(178, 174);
            this.cruDcontrol1.Name = "cruDcontrol1";
            this.cruDcontrol1.Size = new System.Drawing.Size(824, 407);
            this.cruDcontrol1.TabIndex = 12;
            // 
            // FormRedisgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1002, 583);
            this.ControlBox = false;
            this.Controls.Add(this.cruDcontrol1);
            this.Controls.Add(this.tableControl1);
            this.Controls.Add(this.graphControl1);
            this.Controls.Add(this.exchangeControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsta);
            this.Controls.Add(this.btnTwit);
            this.Controls.Add(this.btnFace);
            this.Controls.Add(this.FirstControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRedisgn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRedisgn";
            this.Load += new System.EventHandler(this.FormRedisgn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnCrude;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FirstControl FirstControl;
        private System.Windows.Forms.Button btnFace;
        private System.Windows.Forms.Button btnTwit;
        private System.Windows.Forms.Button btnInsta;
        private System.Windows.Forms.Label label5;
        private ExchangeControl exchangeControl1;
        private GraphControl graphControl1;
        private TableControl tableControl1;
        private CRUDcontrol cruDcontrol1;
    }
}