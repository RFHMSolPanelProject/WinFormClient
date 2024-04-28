namespace WindowsFormsApp1
{
    partial class RaktarRend
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.ANev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roszlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RekeszID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Location = new System.Drawing.Point(140, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 65);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 454);
            this.panel1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(13, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 51);
            this.button4.TabIndex = 43;
            this.button4.Text = "Komponens neve";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(13, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 43;
            this.button1.Text = "Komponensek listázása";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 54);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Rekeszek";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(12, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Útvonaltervezés";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(13, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Összes komponens listázása";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ANev,
            this.Sor,
            this.Roszlop,
            this.Rsor,
            this.RekeszID});
            this.datagrid.Location = new System.Drawing.Point(140, 61);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(661, 393);
            this.datagrid.TabIndex = 41;
            // 
            // ANev
            // 
            this.ANev.HeaderText = "Név";
            this.ANev.Name = "ANev";
            this.ANev.ReadOnly = true;
            // 
            // Sor
            // 
            this.Sor.HeaderText = "Sor";
            this.Sor.Name = "Sor";
            this.Sor.ReadOnly = true;
            // 
            // Roszlop
            // 
            this.Roszlop.HeaderText = "Roszlop";
            this.Roszlop.Name = "Roszlop";
            this.Roszlop.ReadOnly = true;
            // 
            // Rsor
            // 
            this.Rsor.HeaderText = "Rsor";
            this.Rsor.Name = "Rsor";
            this.Rsor.ReadOnly = true;
            // 
            // RekeszID
            // 
            this.RekeszID.HeaderText = "RekeszID";
            this.RekeszID.Name = "RekeszID";
            this.RekeszID.ReadOnly = true;
            // 
            // RaktarRend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RaktarRend";
            this.Text = "RaktarRend";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roszlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RekeszID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}