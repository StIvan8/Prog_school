﻿namespace Prog_school.Models
{
    partial class Form4
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ФИО_учителя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_предмета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_кабинета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(444, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 75);
            this.button3.TabIndex = 28;
            this.button3.Text = "Уволить учителя";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(272, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 75);
            this.button2.TabIndex = 27;
            this.button2.Text = "Добавить \r\n учителя";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(267, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Сведения об учителях";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО_учителя,
            this.Название_предмета,
            this.Номер_кабинета});
            this.dataGridView1.Location = new System.Drawing.Point(109, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 234);
            this.dataGridView1.TabIndex = 29;
            // 
            // ФИО_учителя
            // 
            this.ФИО_учителя.HeaderText = "ФИО_учителя";
            this.ФИО_учителя.MinimumWidth = 10;
            this.ФИО_учителя.Name = "ФИО_учителя";
            this.ФИО_учителя.Width = 200;
            // 
            // Название_предмета
            // 
            this.Название_предмета.HeaderText = "Название_предмета";
            this.Название_предмета.MinimumWidth = 10;
            this.Название_предмета.Name = "Название_предмета";
            this.Название_предмета.Width = 160;
            // 
            // Номер_кабинета
            // 
            this.Номер_кабинета.HeaderText = "Номер_кабинета";
            this.Номер_кабинета.MinimumWidth = 10;
            this.Номер_кабинета.Name = "Номер_кабинета";
            this.Номер_кабинета.Width = 160;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Учителя";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_учителя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_предмета;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_кабинета;
    }
}