namespace FBF
{
    partial class Main
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
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lbToken = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pgComplete = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(65, 23);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(418, 20);
            this.txtToken.TabIndex = 0;
            // 
            // lbToken
            // 
            this.lbToken.AutoSize = true;
            this.lbToken.Location = new System.Drawing.Point(21, 26);
            this.lbToken.Name = "lbToken";
            this.lbToken.Size = new System.Drawing.Size(38, 13);
            this.lbToken.TabIndex = 1;
            this.lbToken.Text = "Token";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(280, 82);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(98, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(65, 56);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(418, 20);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(385, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pgComplete
            // 
            this.pgComplete.Location = new System.Drawing.Point(65, 117);
            this.pgComplete.Name = "pgComplete";
            this.pgComplete.Size = new System.Drawing.Size(418, 10);
            this.pgComplete.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 139);
            this.ControlBox = false;
            this.Controls.Add(this.pgComplete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lbToken);
            this.Controls.Add(this.txtToken);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FB Getfriends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lbToken;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar pgComplete;
    }
}

