
namespace Bilding_firm
{
    partial class staff
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
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addEmployee = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Label();
            this.ExitApp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(291, 52);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 14;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 386);
            this.dataGridView1.TabIndex = 13;
            // 
            // addEmployee
            // 
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmployee.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addEmployee.Location = new System.Drawing.Point(669, 395);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(119, 45);
            this.addEmployee.TabIndex = 12;
            this.addEmployee.Text = "Добавить сотрудника";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.AutoSize = true;
            this.BackToMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackToMenu.Location = new System.Drawing.Point(13, 15);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(132, 13);
            this.BackToMenu.TabIndex = 11;
            this.BackToMenu.Text = "< Вернуться  на главную";
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.AutoSize = true;
            this.ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitApp.Location = new System.Drawing.Point(770, 11);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(18, 18);
            this.ExitApp.TabIndex = 10;
            this.ExitApp.Text = "X";
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.ExitApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label BackToMenu;
        private System.Windows.Forms.Label ExitApp;
    }
}