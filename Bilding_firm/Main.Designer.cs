
namespace Bilding_firm
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonStuff = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonProject = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonSupplier);
            this.panel.Controls.Add(this.buttonStuff);
            this.panel.Controls.Add(this.buttonClients);
            this.panel.Controls.Add(this.buttonProject);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(215, 681);
            this.panel.TabIndex = 9;
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupplier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSupplier.Location = new System.Drawing.Point(0, 126);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(215, 45);
            this.buttonSupplier.TabIndex = 3;
            this.buttonSupplier.Text = "Поставщики";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonStuff
            // 
            this.buttonStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStuff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStuff.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStuff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStuff.Location = new System.Drawing.Point(0, 84);
            this.buttonStuff.Name = "buttonStuff";
            this.buttonStuff.Size = new System.Drawing.Size(215, 45);
            this.buttonStuff.TabIndex = 2;
            this.buttonStuff.Text = "Сотрудники";
            this.buttonStuff.UseVisualStyleBackColor = true;
            this.buttonStuff.Click += new System.EventHandler(this.buttonStuff_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClients.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClients.Location = new System.Drawing.Point(0, 42);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(215, 45);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Заказчики";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonProject
            // 
            this.buttonProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProject.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonProject.Location = new System.Drawing.Point(0, 0);
            this.buttonProject.Name = "buttonProject";
            this.buttonProject.Size = new System.Drawing.Size(215, 45);
            this.buttonProject.TabIndex = 0;
            this.buttonProject.Text = "Проекты";
            this.buttonProject.UseVisualStyleBackColor = true;
            this.buttonProject.Click += new System.EventHandler(this.buttonProject_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitApp.Location = new System.Drawing.Point(1033, 15);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(19, 18);
            this.ExitApp.TabIndex = 8;
            this.ExitApp.Text = "X";
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ExitApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonStuff;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonProject;
        private System.Windows.Forms.Label ExitApp;
    }
}

