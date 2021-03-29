namespace WSkills.Runer
{
    partial class RunnerResults
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.ageLoadLabel = new System.Windows.Forms.Label();
            this.genderLoadLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(12, 50);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(63, 16);
            this.labelTime.TabIndex = 30;
            this.labelTime.Text = "labelTime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 88);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 88);
            this.panel2.TabIndex = 40;
            // 
            // showButton
            // 
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.ForeColor = System.Drawing.Color.Black;
            this.showButton.Location = new System.Drawing.Point(254, 452);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(286, 30);
            this.showButton.TabIndex = 74;
            this.showButton.Text = "Показать все результаты";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // resultDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.resultDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultDataGrid.EnableHeadersVisualStyles = false;
            this.resultDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.resultDataGrid.Location = new System.Drawing.Point(0, 223);
            this.resultDataGrid.MultiSelect = false;
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.resultDataGrid.RowHeadersVisible = false;
            this.resultDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.resultDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.resultDataGrid.Size = new System.Drawing.Size(782, 212);
            this.resultDataGrid.TabIndex = 73;
            // 
            // ageLoadLabel
            // 
            this.ageLoadLabel.AutoSize = true;
            this.ageLoadLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLoadLabel.ForeColor = System.Drawing.Color.Black;
            this.ageLoadLabel.Location = new System.Drawing.Point(550, 184);
            this.ageLoadLabel.Name = "ageLoadLabel";
            this.ageLoadLabel.Size = new System.Drawing.Size(60, 22);
            this.ageLoadLabel.TabIndex = 72;
            this.ageLoadLabel.Text = "18-29";
            this.ageLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderLoadLabel
            // 
            this.genderLoadLabel.AutoSize = true;
            this.genderLoadLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLoadLabel.ForeColor = System.Drawing.Color.Black;
            this.genderLoadLabel.Location = new System.Drawing.Point(233, 184);
            this.genderLoadLabel.Name = "genderLoadLabel";
            this.genderLoadLabel.Size = new System.Drawing.Size(85, 22);
            this.genderLoadLabel.TabIndex = 71;
            this.genderLoadLabel.Text = "мужской";
            this.genderLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.ForeColor = System.Drawing.Color.Black;
            this.ageLabel.Location = new System.Drawing.Point(324, 184);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(229, 22);
            this.ageLabel.TabIndex = 70;
            this.ageLabel.Text = "Возрастная категория:";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.ForeColor = System.Drawing.Color.Black;
            this.sexLabel.Location = new System.Drawing.Point(182, 184);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(55, 22);
            this.sexLabel.TabIndex = 69;
            this.sexLabel.Text = "Пол:";
            this.sexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(120, 123);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(526, 51);
            this.descriptionLabel.TabIndex = 68;
            this.descriptionLabel.Text = "Это - список всех ваших прошлых результатов гонки для Marathom Skills.\r\nОбщее мес" +
    "то сравнивает всех бегунов\r\nМесто по категории compares runners in the same gend" +
    "er and age categories.\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(278, 91);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(215, 32);
            this.resultLabel.TabIndex = 67;
            this.resultLabel.Text = "Мои результаты";
            // 
            // RunnerResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 580);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.ageLoadLabel);
            this.Controls.Add(this.genderLoadLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RunnerResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - My race results";
            this.Load += new System.EventHandler(this.RunnerResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.Label ageLoadLabel;
        private System.Windows.Forms.Label genderLoadLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}