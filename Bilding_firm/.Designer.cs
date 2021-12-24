
namespace Bilding_firm
{
    partial class addProject
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
            this.ExitApp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.site_address = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SaveProj = new System.Windows.Forms.Button();
            this.lable2 = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.lable1 = new System.Windows.Forms.Label();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.NameProj = new System.Windows.Forms.TextBox();
            this.responsible_person = new System.Windows.Forms.TextBox();
            this.TypeObj = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitApp
            // 
            this.ExitApp.BackColor = System.Drawing.Color.White;
            this.ExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitApp.Location = new System.Drawing.Point(766, 19);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(19, 18);
            this.ExitApp.TabIndex = 6;
            this.ExitApp.Text = "X";
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Адрес строительного участка";
            // 
            // site_address
            // 
            this.site_address.Location = new System.Drawing.Point(171, 103);
            this.site_address.Name = "site_address";
            this.site_address.Size = new System.Drawing.Size(143, 20);
            this.site_address.TabIndex = 30;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cancel.Location = new System.Drawing.Point(638, 354);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(143, 45);
            this.cancel.TabIndex = 29;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SaveProj
            // 
            this.SaveProj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.SaveProj.Location = new System.Drawing.Point(489, 354);
            this.SaveProj.Name = "SaveProj";
            this.SaveProj.Size = new System.Drawing.Size(143, 45);
            this.SaveProj.TabIndex = 28;
            this.SaveProj.Text = "Сохранить";
            this.SaveProj.UseVisualStyleBackColor = true;
            this.SaveProj.Click += new System.EventHandler(this.SaveProj_Click);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(411, 75);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(96, 26);
            this.lable2.TabIndex = 27;
            this.lable2.Text = "Врема окончания\r\nстроительства";
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(355, 103);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(200, 20);
            this.EndTime.TabIndex = 26;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(411, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(82, 26);
            this.lable1.TabIndex = 25;
            this.lable1.Text = "Врема начала\r\nстроительства";
            // 
            // TimeStart
            // 
            this.TimeStart.Location = new System.Drawing.Point(355, 52);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(200, 20);
            this.TimeStart.TabIndex = 24;
            // 
            // NameProj
            // 
            this.NameProj.Location = new System.Drawing.Point(12, 52);
            this.NameProj.Name = "NameProj";
            this.NameProj.Size = new System.Drawing.Size(121, 20);
            this.NameProj.TabIndex = 23;
            // 
            // responsible_person
            // 
            this.responsible_person.Location = new System.Drawing.Point(12, 103);
            this.responsible_person.Name = "responsible_person";
            this.responsible_person.Size = new System.Drawing.Size(121, 20);
            this.responsible_person.TabIndex = 22;
            // 
            // TypeObj
            // 
            this.TypeObj.FormattingEnabled = true;
            this.TypeObj.Items.AddRange(new object[] {
            "Здание",
            "Строение",
            "Сооружение",
            "Объект незавершенного строительства",
            "Линейные объекты",
            "Некапитальные строения"});
            this.TypeObj.Location = new System.Drawing.Point(171, 51);
            this.TypeObj.Name = "TypeObj";
            this.TypeObj.Size = new System.Drawing.Size(143, 21);
            this.TypeObj.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тип объекта \r\nстроительства ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Отвественное лицо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название проекта";
            // 
            // addProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.site_address);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.SaveProj);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.NameProj);
            this.Controls.Add(this.responsible_person);
            this.Controls.Add(this.TypeObj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.addProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ExitApp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox site_address;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button SaveProj;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.DateTimePicker TimeStart;
        private System.Windows.Forms.TextBox NameProj;
        private System.Windows.Forms.TextBox responsible_person;
        private System.Windows.Forms.ComboBox TypeObj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}