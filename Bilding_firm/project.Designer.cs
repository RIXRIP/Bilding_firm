
namespace Bilding_firm
{
    partial class project
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
            this.SearchProject = new System.Windows.Forms.TextBox();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Label();
            this.ExitProgram = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_project = new System.Windows.Forms.Button();
            this.dataAddProj = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddProj)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchProject
            // 
            this.SearchProject.Location = new System.Drawing.Point(-468, 93);
            this.SearchProject.Name = "SearchProject";
            this.SearchProject.Size = new System.Drawing.Size(164, 20);
            this.SearchProject.TabIndex = 8;
            this.SearchProject.Text = "Поиск ";
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProject.Location = new System.Drawing.Point(-468, 46);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(164, 41);
            this.buttonAddProject.TabIndex = 7;
            this.buttonAddProject.Text = "Добавить проект";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.BackToMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackToMenu.Location = new System.Drawing.Point(-468, 11);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(116, 32);
            this.BackToMenu.TabIndex = 6;
            this.BackToMenu.Text = "< На главную";
            // 
            // ExitProgram
            // 
            this.ExitProgram.AutoSize = true;
            this.ExitProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitProgram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitProgram.Location = new System.Drawing.Point(1049, 9);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(19, 18);
            this.ExitProgram.TabIndex = 5;
            this.ExitProgram.Text = "X";
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "< На главную";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_project
            // 
            this.add_project.Location = new System.Drawing.Point(904, 667);
            this.add_project.Name = "add_project";
            this.add_project.Size = new System.Drawing.Size(164, 41);
            this.add_project.TabIndex = 12;
            this.add_project.Text = "Добавить проект";
            this.add_project.UseVisualStyleBackColor = true;
            this.add_project.Click += new System.EventHandler(this.add_project_Click);
            // 
            // dataAddProj
            // 
            this.dataAddProj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAddProj.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataAddProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAddProj.Location = new System.Drawing.Point(15, 73);
            this.dataAddProj.Name = "dataAddProj";
            this.dataAddProj.Size = new System.Drawing.Size(490, 558);
            this.dataAddProj.TabIndex = 13;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(186, 46);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 20);
            this.search_button.TabIndex = 14;
            this.search_button.Text = "Найти";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.dataAddProj);
            this.Controls.Add(this.add_project);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchProject);
            this.Controls.Add(this.buttonAddProject);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.ExitProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAddProj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchProject;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Label BackToMenu;
        private System.Windows.Forms.Label ExitProgram;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_project;
        private System.Windows.Forms.DataGridView dataAddProj;
        private System.Windows.Forms.Button search_button;
    }
}