namespace Server
{
    partial class Server
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
            this.txbMessages = new System.Windows.Forms.TextBox();
            this.lsvMesseages = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(637, 362);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // txbMessages
            // 
            this.txbMessages.Location = new System.Drawing.Point(74, 363);
            this.txbMessages.Name = "txbMessages";
            this.txbMessages.Size = new System.Drawing.Size(533, 22);
            this.txbMessages.TabIndex = 4;
            // 
            // lsvMesseages
            // 
            this.lsvMesseages.HideSelection = false;
            this.lsvMesseages.Location = new System.Drawing.Point(74, 45);
            this.lsvMesseages.Name = "lsvMesseages";
            this.lsvMesseages.Size = new System.Drawing.Size(533, 287);
            this.lsvMesseages.TabIndex = 3;
            this.lsvMesseages.UseCompatibleStateImageBehavior = false;
            this.lsvMesseages.View = System.Windows.Forms.View.List;
            // 
            // Server
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.txbMessages);
            this.Controls.Add(this.lsvMesseages);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox txbMessages;
        private System.Windows.Forms.ListView lsvMesseages;
    }
}

