
namespace Bilding_firm
{
    partial class add_employee
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
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.ExitApp = new System.Windows.Forms.Label();
            this.BackToMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(199, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "График работы";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 49;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // saveEmployee
            // 
            this.saveEmployee.Location = new System.Drawing.Point(536, 408);
            this.saveEmployee.Name = "saveEmployee";
            this.saveEmployee.Size = new System.Drawing.Size(106, 32);
            this.saveEmployee.TabIndex = 48;
            this.saveEmployee.Text = "Сохранить";
            this.saveEmployee.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(16, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Почта";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(12, 318);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(131, 20);
            this.mail.TabIndex = 46;
            // 
            // position
            // 
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Бригадир ",
            "Разноробочий",
            "Руководитель"});
            this.position.Location = new System.Drawing.Point(12, 278);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(131, 21);
            this.position.TabIndex = 45;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender.Location = new System.Drawing.Point(12, 238);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(131, 21);
            this.gender.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Пол";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(14, 199);
            this.phone.Mask = "(999) 000-0000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(129, 20);
            this.phone.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Фамилия";
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(14, 160);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(129, 20);
            this.middleName.TabIndex = 36;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(14, 121);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(129, 20);
            this.name.TabIndex = 35;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(14, 82);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(129, 20);
            this.surname.TabIndex = 34;
            // 
            // ExitApp
            // 
            this.ExitApp.AutoSize = true;
            this.ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitApp.Location = new System.Drawing.Point(772, 11);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(18, 18);
            this.ExitApp.TabIndex = 33;
            this.ExitApp.Text = "X";
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.AutoSize = true;
            this.BackToMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackToMenu.Location = new System.Drawing.Point(14, 11);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(176, 13);
            this.BackToMenu.TabIndex = 32;
            this.BackToMenu.Text = "< Вернуться в меню сотрудников";
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(196, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 275);
            this.panel1.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(3, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Выходных дней";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Рабочих дней";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(3, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Количество рабочих дней при 40 - часовой неделе";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(3, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Время перерывов";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(3, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Часовая ставка";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 176);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 48;
            // 
            // add_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveEmployee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.position);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.BackToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_employee";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.add_employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label ExitApp;
        private System.Windows.Forms.Label BackToMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
    }
}