namespace McWiFi
{
    partial class StartPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.ckbShowKey = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(120, 38);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(244, 22);
            this.txtSSID.TabIndex = 2;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(120, 88);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '☺';
            this.txtKey.Size = new System.Drawing.Size(244, 22);
            this.txtKey.TabIndex = 3;
            // 
            // ckbShowKey
            // 
            this.ckbShowKey.AutoSize = true;
            this.ckbShowKey.Location = new System.Drawing.Point(120, 137);
            this.ckbShowKey.Name = "ckbShowKey";
            this.ckbShowKey.Size = new System.Drawing.Size(104, 21);
            this.ckbShowKey.TabIndex = 4;
            this.ckbShowKey.Text = "Show Key ?";
            this.ckbShowKey.UseVisualStyleBackColor = true;
            this.ckbShowKey.CheckedChanged += new System.EventHandler(this.ckbShowKey_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(209, 176);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 42);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Save";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 249);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ckbShowKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start WiFi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.CheckBox ckbShowKey;
        private System.Windows.Forms.Button btnStart;
    }
}