
namespace SecureFileEraser
{
    partial class FormMain
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
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.checkedListBoxFilesAndFolders = new System.Windows.Forms.CheckedListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.comboBoxDeletionMethods = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddFolder.FlatAppearance.BorderSize = 0;
            this.buttonAddFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFolder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFolder.ForeColor = System.Drawing.Color.White;
            this.buttonAddFolder.Location = new System.Drawing.Point(118, 131);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(96, 26);
            this.buttonAddFolder.TabIndex = 32;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = false;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click_1);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddFile.FlatAppearance.BorderSize = 0;
            this.buttonAddFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFile.ForeColor = System.Drawing.Color.White;
            this.buttonAddFile.Location = new System.Drawing.Point(16, 131);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(96, 26);
            this.buttonAddFile.TabIndex = 31;
            this.buttonAddFile.Text = "Add File";
            this.buttonAddFile.UseVisualStyleBackColor = false;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // checkedListBoxFilesAndFolders
            // 
            this.checkedListBoxFilesAndFolders.FormattingEnabled = true;
            this.checkedListBoxFilesAndFolders.Location = new System.Drawing.Point(16, 31);
            this.checkedListBoxFilesAndFolders.Name = "checkedListBoxFilesAndFolders";
            this.checkedListBoxFilesAndFolders.Size = new System.Drawing.Size(624, 94);
            this.checkedListBoxFilesAndFolders.TabIndex = 30;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(299, 19);
            this.labelTitle.TabIndex = 29;
            this.labelTitle.Text = "Please Select a File or Folder to Delete";
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.BackColor = System.Drawing.Color.Maroon;
            this.buttonDeleteFile.FlatAppearance.BorderSize = 0;
            this.buttonDeleteFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonDeleteFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFile.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteFile.Location = new System.Drawing.Point(544, 280);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(96, 26);
            this.buttonDeleteFile.TabIndex = 28;
            this.buttonDeleteFile.Text = "Delete File";
            this.buttonDeleteFile.UseVisualStyleBackColor = false;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // comboBoxDeletionMethods
            // 
            this.comboBoxDeletionMethods.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeletionMethods.FormattingEnabled = true;
            this.comboBoxDeletionMethods.Items.AddRange(new object[] {
            "Quick delete (recommended)",
            "GOST R 50739-95, Russia",
            "Bruce Schneier Algorithm",
            "VSITR standard, Germany",
            "NAVSO P-5239-26 (MFM) standard, USA"});
            this.comboBoxDeletionMethods.Location = new System.Drawing.Point(220, 132);
            this.comboBoxDeletionMethods.Name = "comboBoxDeletionMethods";
            this.comboBoxDeletionMethods.Size = new System.Drawing.Size(420, 26);
            this.comboBoxDeletionMethods.TabIndex = 27;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 318);
            this.Controls.Add(this.buttonAddFolder);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.checkedListBoxFilesAndFolders);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonDeleteFile);
            this.Controls.Add(this.comboBoxDeletionMethods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Secure File Eraser";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilesAndFolders;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.ComboBox comboBoxDeletionMethods;
    }
}

