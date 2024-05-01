namespace WindowsFormsApp1
{
    partial class ProjectList
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.projectListGrid = new System.Windows.Forms.DataGridView();
            this.Projektkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Helyszin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statusz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 447);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(140, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 79);
            this.panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(4, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Projektlista";
            // 
            // projectListGrid
            // 
            this.projectListGrid.AllowUserToAddRows = false;
            this.projectListGrid.AllowUserToDeleteRows = false;
            this.projectListGrid.AllowUserToResizeRows = false;
            this.projectListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Projektkod,
            this.Helyszin,
            this.Leiras,
            this.Statusz});
            this.projectListGrid.Location = new System.Drawing.Point(140, 61);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.ReadOnly = true;
            this.projectListGrid.Size = new System.Drawing.Size(661, 393);
            this.projectListGrid.TabIndex = 41;
            // 
            // Projektkod
            // 
            this.Projektkod.HeaderText = "Projektkod";
            this.Projektkod.Name = "Projektkod";
            this.Projektkod.ReadOnly = true;
            this.Projektkod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Helyszin
            // 
            this.Helyszin.HeaderText = "Helyszin";
            this.Helyszin.Name = "Helyszin";
            this.Helyszin.ReadOnly = true;
            this.Helyszin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Leiras
            // 
            this.Leiras.HeaderText = "Leiras";
            this.Leiras.Name = "Leiras";
            this.Leiras.ReadOnly = true;
            this.Leiras.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Statusz
            // 
            this.Statusz.HeaderText = "Statusz";
            this.Statusz.Name = "Statusz";
            this.Statusz.ReadOnly = true;
            this.Statusz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(29, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listázás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectListGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ProjectList";
            this.Text = "ProjectList";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView projectListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projektkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Helyszin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statusz;
        private System.Windows.Forms.Button button1;
    }
}