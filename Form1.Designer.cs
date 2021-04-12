namespace PhoneCopyer
{
    partial class Form1
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
            this.Folder1loc = new System.Windows.Forms.Button();
            this.Folder2loc = new System.Windows.Forms.Button();
            this.copyiedfiles = new System.Windows.Forms.RichTextBox();
            this.Movebtn = new System.Windows.Forms.Button();
            this.Copybtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Folder1loc
            // 
            this.Folder1loc.Location = new System.Drawing.Point(44, 25);
            this.Folder1loc.Name = "Folder1loc";
            this.Folder1loc.Size = new System.Drawing.Size(166, 53);
            this.Folder1loc.TabIndex = 0;
            this.Folder1loc.Text = "Intial directory";
            this.Folder1loc.UseVisualStyleBackColor = true;
            this.Folder1loc.Click += new System.EventHandler(this.phoneloc_Click);
            // 
            // Folder2loc
            // 
            this.Folder2loc.Location = new System.Drawing.Point(298, 25);
            this.Folder2loc.Name = "Folder2loc";
            this.Folder2loc.Size = new System.Drawing.Size(168, 53);
            this.Folder2loc.TabIndex = 1;
            this.Folder2loc.Text = "Target directory";
            this.Folder2loc.UseVisualStyleBackColor = true;
            this.Folder2loc.Click += new System.EventHandler(this.button2_Click);
            // 
            // copyiedfiles
            // 
            this.copyiedfiles.Location = new System.Drawing.Point(44, 148);
            this.copyiedfiles.Name = "copyiedfiles";
            this.copyiedfiles.Size = new System.Drawing.Size(422, 301);
            this.copyiedfiles.TabIndex = 2;
            this.copyiedfiles.Text = "";
            // 
            // Movebtn
            // 
            this.Movebtn.Location = new System.Drawing.Point(43, 502);
            this.Movebtn.Name = "Movebtn";
            this.Movebtn.Size = new System.Drawing.Size(167, 51);
            this.Movebtn.TabIndex = 3;
            this.Movebtn.Text = "Move";
            this.Movebtn.UseVisualStyleBackColor = true;
            this.Movebtn.Click += new System.EventHandler(this.Movebtn_Click);
            // 
            // Copybtn
            // 
            this.Copybtn.Location = new System.Drawing.Point(321, 502);
            this.Copybtn.Name = "Copybtn";
            this.Copybtn.Size = new System.Drawing.Size(145, 51);
            this.Copybtn.TabIndex = 4;
            this.Copybtn.Text = "Copy";
            this.Copybtn.UseVisualStyleBackColor = true;
            this.Copybtn.Click += new System.EventHandler(this.Copybtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(201, 585);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(118, 60);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 691);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Copybtn);
            this.Controls.Add(this.Movebtn);
            this.Controls.Add(this.copyiedfiles);
            this.Controls.Add(this.Folder2loc);
            this.Controls.Add(this.Folder1loc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Folder1loc;
        private System.Windows.Forms.Button Folder2loc;
        private System.Windows.Forms.Button Movebtn;
        private System.Windows.Forms.Button Copybtn;
        protected internal System.Windows.Forms.RichTextBox copyiedfiles;
        private System.Windows.Forms.Button deletebtn;
    }
}

