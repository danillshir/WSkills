namespace WSkills.MoreInformation
{
    partial class PreviousRaceResults
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeNumberLabel = new System.Windows.Forms.Label();
            this.finishNumberLabel = new System.Windows.Forms.Label();
            this.runnerNumberLabel = new System.Windows.Forms.Label();
            this.raceDataGrid = new System.Windows.Forms.DataGridView();
            this.timeLabel = new System.Windows.Forms.Label();
            this.finishLabel = new System.Windows.Forms.Label();
            this.runnersLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.distanceComboBox = new System.Windows.Forms.ComboBox();
            this.marathonComboBox = new System.Windows.Forms.ComboBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.marathonLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 43;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 88);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 88);
            this.panel2.TabIndex = 57;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(12, 60);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 18);
            this.labelTime.TabIndex = 27;
            this.labelTime.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeNumberLabel
            // 
            this.timeNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.timeNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.timeNumberLabel.Location = new System.Drawing.Point(829, 264);
            this.timeNumberLabel.Name = "timeNumberLabel";
            this.timeNumberLabel.Size = new System.Drawing.Size(82, 22);
            this.timeNumberLabel.TabIndex = 74;
            this.timeNumberLabel.Text = "...";
            // 
            // finishNumberLabel
            // 
            this.finishNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.finishNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.finishNumberLabel.Location = new System.Drawing.Point(578, 264);
            this.finishNumberLabel.Name = "finishNumberLabel";
            this.finishNumberLabel.Size = new System.Drawing.Size(96, 22);
            this.finishNumberLabel.TabIndex = 73;
            this.finishNumberLabel.Text = "...";
            // 
            // runnerNumberLabel
            // 
            this.runnerNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.runnerNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.runnerNumberLabel.Location = new System.Drawing.Point(227, 264);
            this.runnerNumberLabel.Name = "runnerNumberLabel";
            this.runnerNumberLabel.Size = new System.Drawing.Size(72, 22);
            this.runnerNumberLabel.TabIndex = 72;
            this.runnerNumberLabel.Text = "...";
            // 
            // raceDataGrid
            // 
            this.raceDataGrid.AllowUserToAddRows = false;
            this.raceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.raceDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.raceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raceDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.raceDataGrid.EnableHeadersVisualStyles = false;
            this.raceDataGrid.Location = new System.Drawing.Point(85, 289);
            this.raceDataGrid.Name = "raceDataGrid";
            this.raceDataGrid.RowHeadersVisible = false;
            this.raceDataGrid.Size = new System.Drawing.Size(826, 218);
            this.raceDataGrid.TabIndex = 71;
            this.raceDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.raceDataGrid_CellContentClick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(669, 264);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(154, 22);
            this.timeLabel.TabIndex = 70;
            this.timeLabel.Text = "Среднее время:";
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.finishLabel.ForeColor = System.Drawing.Color.Black;
            this.finishLabel.Location = new System.Drawing.Point(297, 264);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(279, 22);
            this.finishLabel.TabIndex = 69;
            this.finishLabel.Text = "Всего бегунов финишировало:";
            // 
            // runnersLabel
            // 
            this.runnersLabel.AutoSize = true;
            this.runnersLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.runnersLabel.ForeColor = System.Drawing.Color.Black;
            this.runnersLabel.Location = new System.Drawing.Point(75, 264);
            this.runnersLabel.Name = "runnersLabel";
            this.runnersLabel.Size = new System.Drawing.Size(146, 22);
            this.runnersLabel.TabIndex = 68;
            this.runnersLabel.Text = "Всего бегунов: ";
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(772, 192);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 29);
            this.searchButton.TabIndex = 58;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.genderComboBox.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(582, 155);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(184, 30);
            this.genderComboBox.TabIndex = 67;
            // 
            // ageComboBox
            // 
            this.ageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ageComboBox.ForeColor = System.Drawing.Color.Black;
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Location = new System.Drawing.Point(582, 189);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(184, 30);
            this.ageComboBox.TabIndex = 66;
            // 
            // distanceComboBox
            // 
            this.distanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distanceComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.distanceComboBox.ForeColor = System.Drawing.Color.Black;
            this.distanceComboBox.FormattingEnabled = true;
            this.distanceComboBox.Location = new System.Drawing.Point(255, 189);
            this.distanceComboBox.Name = "distanceComboBox";
            this.distanceComboBox.Size = new System.Drawing.Size(198, 30);
            this.distanceComboBox.TabIndex = 65;
            // 
            // marathonComboBox
            // 
            this.marathonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marathonComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.marathonComboBox.ForeColor = System.Drawing.Color.Black;
            this.marathonComboBox.FormattingEnabled = true;
            this.marathonComboBox.Location = new System.Drawing.Point(255, 158);
            this.marathonComboBox.Name = "marathonComboBox";
            this.marathonComboBox.Size = new System.Drawing.Size(198, 30);
            this.marathonComboBox.TabIndex = 64;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ageLabel.ForeColor = System.Drawing.Color.Black;
            this.ageLabel.Location = new System.Drawing.Point(479, 192);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(104, 22);
            this.ageLabel.TabIndex = 63;
            this.ageLabel.Text = "Категория:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.sexLabel.ForeColor = System.Drawing.Color.Black;
            this.sexLabel.Location = new System.Drawing.Point(529, 158);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(49, 22);
            this.sexLabel.TabIndex = 62;
            this.sexLabel.Text = "Пол:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.distanceLabel.ForeColor = System.Drawing.Color.Black;
            this.distanceLabel.Location = new System.Drawing.Point(148, 192);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(107, 22);
            this.distanceLabel.TabIndex = 61;
            this.distanceLabel.Text = "Дистанция:";
            // 
            // marathonLabel
            // 
            this.marathonLabel.AutoSize = true;
            this.marathonLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.marathonLabel.ForeColor = System.Drawing.Color.Black;
            this.marathonLabel.Location = new System.Drawing.Point(159, 158);
            this.marathonLabel.Name = "marathonLabel";
            this.marathonLabel.Size = new System.Drawing.Size(98, 22);
            this.marathonLabel.TabIndex = 60;
            this.marathonLabel.Text = "Марафон:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 21.75F);
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(295, 96);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(420, 33);
            this.resultLabel.TabIndex = 59;
            this.resultLabel.Text = "Результаты предыдущих гонок";
            // 
            // PreviousRaceResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 616);
            this.Controls.Add(this.timeNumberLabel);
            this.Controls.Add(this.finishNumberLabel);
            this.Controls.Add(this.runnerNumberLabel);
            this.Controls.Add(this.raceDataGrid);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.finishLabel);
            this.Controls.Add(this.runnersLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.distanceComboBox);
            this.Controls.Add(this.marathonComboBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.marathonLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PreviousRaceResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviousRaceResults";
            this.Load += new System.EventHandler(this.PreviousRaceResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label timeNumberLabel;
        private System.Windows.Forms.Label finishNumberLabel;
        private System.Windows.Forms.Label runnerNumberLabel;
        private System.Windows.Forms.DataGridView raceDataGrid;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label finishLabel;
        private System.Windows.Forms.Label runnersLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.ComboBox distanceComboBox;
        private System.Windows.Forms.ComboBox marathonComboBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label marathonLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}