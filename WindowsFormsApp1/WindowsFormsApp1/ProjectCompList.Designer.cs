﻿namespace WindowsFormsApp1
{
    partial class ProjectCompList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProjektKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzuksegesAlkatresz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oszlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rekesz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 452);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(30, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listázás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 95);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Projekthez tartozó\r\nalkatrészek";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Location = new System.Drawing.Point(167, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 56);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjektKod,
            this.SzuksegesAlkatresz,
            this.Sor,
            this.Oszlop,
            this.Polc,
            this.Rekesz});
            this.dataGridView1.Location = new System.Drawing.Point(167, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 399);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProjektKod
            // 
            this.ProjektKod.HeaderText = "ProjektKod";
            this.ProjektKod.Name = "ProjektKod";
            // 
            // SzuksegesAlkatresz
            // 
            this.SzuksegesAlkatresz.HeaderText = "SzuksegesAlkatresz";
            this.SzuksegesAlkatresz.Name = "SzuksegesAlkatresz";
            // 
            // Sor
            // 
            this.Sor.HeaderText = "Sor";
            this.Sor.Name = "Sor";
            // 
            // Oszlop
            // 
            this.Oszlop.HeaderText = "Oszlop";
            this.Oszlop.Name = "Oszlop";
            // 
            // Polc
            // 
            this.Polc.HeaderText = "Polc";
            this.Polc.Name = "Polc";
            // 
            // Rekesz
            // 
            this.Rekesz.HeaderText = "Rekesz";
            this.Rekesz.Name = "Rekesz";
            // 
            // ProjectCompList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectCompList";
            this.Text = "ProjectCompList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjektKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzuksegesAlkatresz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oszlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rekesz;
    }
}