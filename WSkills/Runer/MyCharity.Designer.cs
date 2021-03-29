namespace WSkills.Runer
{
    partial class MyCharity
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.linePanel = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.sponsorTextLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(797, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(326, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Мои Спонсоры";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(293, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Здесь показаны ваши спонсоры";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 88);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 88);
            this.panel2.TabIndex = 43;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(12, 48);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 18);
            this.labelTime.TabIndex = 28;
            this.labelTime.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(513, 199);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(302, 146);
            this.flowLayoutPanel.TabIndex = 59;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(513, 378);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(302, 27);
            this.totalLabel.TabIndex = 58;
            this.totalLabel.Text = "Всего";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.Silver;
            this.linePanel.Location = new System.Drawing.Point(513, 351);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(302, 10);
            this.linePanel.TabIndex = 57;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.moneyLabel.ForeColor = System.Drawing.Color.Black;
            this.moneyLabel.Location = new System.Drawing.Point(738, 168);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(77, 27);
            this.moneyLabel.TabIndex = 56;
            this.moneyLabel.Text = "Взнос";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sponsorTextLabel
            // 
            this.sponsorTextLabel.AutoSize = true;
            this.sponsorTextLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.sponsorTextLabel.ForeColor = System.Drawing.Color.Black;
            this.sponsorTextLabel.Location = new System.Drawing.Point(516, 168);
            this.sponsorTextLabel.Name = "sponsorTextLabel";
            this.sponsorTextLabel.Size = new System.Drawing.Size(107, 27);
            this.sponsorTextLabel.TabIndex = 55;
            this.sponsorTextLabel.Text = "Спонсор";
            this.sponsorTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 227);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(365, 134);
            this.descriptionTextBox.TabIndex = 54;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(7, 154);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(370, 54);
            this.infoLabel.TabIndex = 52;
            this.infoLabel.Text = "Наименование\r\nблаготворительной организации\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyCharity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 590);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.sponsorTextLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MyCharity";
            this.Text = "MyCharity";
            this.Load += new System.EventHandler(this.MyCharity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label sponsorTextLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label infoLabel;
    }
}