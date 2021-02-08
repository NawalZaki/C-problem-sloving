
namespace Project
{
    partial class frmCategory
    {/// <summary>
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
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.lstviwCategory = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddNewCategory.Location = new System.Drawing.Point(2, 251);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(184, 32);
            this.btnAddNewCategory.TabIndex = 4;
            this.btnAddNewCategory.Text = "Add New Category";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteCategory.Location = new System.Drawing.Point(186, 251);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(159, 31);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.AccessibleName = "";
            this.btnUpdateCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateCategory.Location = new System.Drawing.Point(347, 252);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(177, 30);
            this.btnUpdateCategory.TabIndex = 6;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNext.Location = new System.Drawing.Point(526, 252);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 30);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next >>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbTitle
            // 
            this.cmbTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(36, 90);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(198, 21);
            this.cmbTitle.TabIndex = 10;
            this.cmbTitle.SelectedIndexChanged += new System.EventHandler(this.cmbTitle_SelectedIndexChanged);
            // 
            // lstviwCategory
            // 
            this.lstviwCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Description});
            this.lstviwCategory.FullRowSelect = true;
            this.lstviwCategory.GridLines = true;
            this.lstviwCategory.HideSelection = false;
            this.lstviwCategory.Location = new System.Drawing.Point(480, 90);
            this.lstviwCategory.MultiSelect = false;
            this.lstviwCategory.Name = "lstviwCategory";
            this.lstviwCategory.Size = new System.Drawing.Size(195, 158);
            this.lstviwCategory.TabIndex = 16;
            this.lstviwCategory.UseCompatibleStateImageBehavior = false;
            this.lstviwCategory.View = System.Windows.Forms.View.Details;
            this.lstviwCategory.SelectedIndexChanged += new System.EventHandler(this.lstviwCategory_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 76;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(480, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Team :";
            // 
            // cmbTeam
            // 
            this.cmbTeam.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(555, 61);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(120, 21);
            this.cmbTeam.TabIndex = 19;
            this.cmbTeam.SelectedIndexChanged += new System.EventHandler(this.cmbTeam_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescription.Location = new System.Drawing.Point(36, 117);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(198, 128);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Text = "Description Of Category";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(687, 290);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstviwCategory);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddNewCategory);
            this.Name = "frmCategory";
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ListView lstviwCategory;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}