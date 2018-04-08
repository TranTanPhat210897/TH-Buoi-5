namespace Server
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
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnImages = new System.Windows.Forms.Button();
            this.BtnMusics = new System.Windows.Forms.Button();
            this.BtnFiles = new System.Windows.Forms.Button();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.txtboxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSend.Location = new System.Drawing.Point(602, 376);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(80, 72);
            this.BtnSend.TabIndex = 17;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnImages
            // 
            this.BtnImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnImages.Location = new System.Drawing.Point(602, 227);
            this.BtnImages.Name = "BtnImages";
            this.BtnImages.Size = new System.Drawing.Size(80, 51);
            this.BtnImages.TabIndex = 16;
            this.BtnImages.Text = "Images";
            this.BtnImages.UseVisualStyleBackColor = true;
            // 
            // BtnMusics
            // 
            this.BtnMusics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMusics.Location = new System.Drawing.Point(602, 150);
            this.BtnMusics.Name = "BtnMusics";
            this.BtnMusics.Size = new System.Drawing.Size(80, 51);
            this.BtnMusics.TabIndex = 15;
            this.BtnMusics.Text = "Musics";
            this.BtnMusics.UseVisualStyleBackColor = true;
            // 
            // BtnFiles
            // 
            this.BtnFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnFiles.Location = new System.Drawing.Point(602, 71);
            this.BtnFiles.Name = "BtnFiles";
            this.BtnFiles.Size = new System.Drawing.Size(80, 51);
            this.BtnFiles.TabIndex = 14;
            this.BtnFiles.Text = "Files";
            this.BtnFiles.UseVisualStyleBackColor = true;
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.Location = new System.Drawing.Point(34, 376);
            this.txtboxMessage.Multiline = true;
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.Size = new System.Drawing.Size(544, 95);
            this.txtboxMessage.TabIndex = 13;
            this.txtboxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxMessage_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(31, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Message";
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 16;
            this.Listbox.Location = new System.Drawing.Point(34, 71);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(544, 260);
            this.Listbox.TabIndex = 11;
            // 
            // txtboxIP
            // 
            this.txtboxIP.Location = new System.Drawing.Point(106, 13);
            this.txtboxIP.Multiline = true;
            this.txtboxIP.Name = "txtboxIP";
            this.txtboxIP.Size = new System.Drawing.Size(267, 30);
            this.txtboxIP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Client IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 492);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnImages);
            this.Controls.Add(this.BtnMusics);
            this.Controls.Add(this.BtnFiles);
            this.Controls.Add(this.txtboxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Listbox);
            this.Controls.Add(this.txtboxIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnImages;
        private System.Windows.Forms.Button BtnMusics;
        private System.Windows.Forms.Button BtnFiles;
        private System.Windows.Forms.TextBox txtboxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.TextBox txtboxIP;
        private System.Windows.Forms.Label label1;
    }
}

