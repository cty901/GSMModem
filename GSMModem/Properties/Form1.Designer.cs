namespace GSMModem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.lblTitilePending = new System.Windows.Forms.Label();
            this.lblTitileSend = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblTitileFailed = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(446, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSend.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(271, 157);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 42);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send SMS";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(278, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(207, 19);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Send SMS Alert to Donors";
            // 
            // PicTitle
            // 
            this.PicTitle.Image = ((System.Drawing.Image)(resources.GetObject("PicTitle.Image")));
            this.PicTitle.Location = new System.Drawing.Point(8, 8);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(232, 193);
            this.PicTitle.TabIndex = 3;
            this.PicTitle.TabStop = false;
            // 
            // lblTitilePending
            // 
            this.lblTitilePending.AutoSize = true;
            this.lblTitilePending.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitilePending.Location = new System.Drawing.Point(262, 72);
            this.lblTitilePending.Name = "lblTitilePending";
            this.lblTitilePending.Size = new System.Drawing.Size(96, 16);
            this.lblTitilePending.TabIndex = 4;
            this.lblTitilePending.Text = "Pending SMS :";
            // 
            // lblTitileSend
            // 
            this.lblTitileSend.AutoSize = true;
            this.lblTitileSend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitileSend.Location = new System.Drawing.Point(279, 98);
            this.lblTitileSend.Name = "lblTitileSend";
            this.lblTitileSend.Size = new System.Drawing.Size(79, 16);
            this.lblTitileSend.TabIndex = 5;
            this.lblTitileSend.Text = "Send SMS :";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(356, 72);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(22, 16);
            this.lblPending.TabIndex = 6;
            this.lblPending.Text = "39";
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSend.Location = new System.Drawing.Point(356, 98);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(22, 16);
            this.lblSend.TabIndex = 7;
            this.lblSend.Text = "20";
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailed.Location = new System.Drawing.Point(356, 125);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(15, 16);
            this.lblFailed.TabIndex = 9;
            this.lblFailed.Text = "4";
            // 
            // lblTitileFailed
            // 
            this.lblTitileFailed.AutoSize = true;
            this.lblTitileFailed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitileFailed.Location = new System.Drawing.Point(274, 125);
            this.lblTitileFailed.Name = "lblTitileFailed";
            this.lblTitileFailed.Size = new System.Drawing.Size(84, 16);
            this.lblTitileFailed.TabIndex = 8;
            this.lblTitileFailed.Text = "Failed SMS :";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConnect.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(363, 157);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(77, 42);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbCOM
            // 
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(363, 46);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(113, 21);
            this.cmbCOM.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Port Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(543, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCOM);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblFailed);
            this.Controls.Add(this.lblTitileFailed);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblTitileSend);
            this.Controls.Add(this.lblTitilePending);
            this.Controls.Add(this.PicTitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Send SMS Alert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.Label lblTitilePending;
        private System.Windows.Forms.Label lblTitileSend;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblTitileFailed;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbCOM;
        private System.Windows.Forms.Label label1;
    }
}

