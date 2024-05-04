namespace Client
{
    partial class FormPlaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaying));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelSide0 = new System.Windows.Forms.Label();
            this.labelSide1 = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Azure;
            this.buttonStart.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStart.Location = new System.Drawing.Point(619, 583);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(211, 64);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Ready";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(596, 552);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSend.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSend.Location = new System.Drawing.Point(811, 533);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(43, 46);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "➤";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelSide0
            // 
            this.labelSide0.BackColor = System.Drawing.Color.Transparent;
            this.labelSide0.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSide0.ForeColor = System.Drawing.Color.Red;
            this.labelSide0.Location = new System.Drawing.Point(592, 38);
            this.labelSide0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSide0.Name = "labelSide0";
            this.labelSide0.Size = new System.Drawing.Size(264, 21);
            this.labelSide0.TabIndex = 7;
            this.labelSide0.Text = "labelSide0";
            // 
            // labelSide1
            // 
            this.labelSide1.BackColor = System.Drawing.Color.Transparent;
            this.labelSide1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSide1.ForeColor = System.Drawing.Color.Red;
            this.labelSide1.Location = new System.Drawing.Point(592, 80);
            this.labelSide1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSide1.Name = "labelSide1";
            this.labelSide1.Size = new System.Drawing.Size(264, 28);
            this.labelSide1.TabIndex = 8;
            this.labelSide1.Text = "labelSide1";
            // 
            // labelOrder
            // 
            this.labelOrder.BackColor = System.Drawing.Color.Transparent;
            this.labelOrder.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.ForeColor = System.Drawing.Color.Red;
            this.labelOrder.Location = new System.Drawing.Point(591, 130);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(273, 77);
            this.labelOrder.TabIndex = 9;
            this.labelOrder.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 648);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPlaying_MouseDown);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Lavender;
            this.listBox.ForeColor = System.Drawing.Color.Black;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(593, 291);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(261, 238);
            this.listBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(591, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 81);
            this.label1.TabIndex = 9;
            this.label1.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Client.Properties.Resources.winImage;
            this.pictureBox2.Location = new System.Drawing.Point(269, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = global::Client.Properties.Resources.lose;
            this.pictureBox3.Location = new System.Drawing.Point(252, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(297, 239);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // FormPlaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Client.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(875, 646);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelSide1);
            this.Controls.Add(this.labelSide0);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPlaying";
            this.Text = "Cờ tướng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromPlaying_FormClosing);
            this.Load += new System.EventHandler(this.FromPlaying_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelSide0;
        private System.Windows.Forms.Label labelSide1;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}