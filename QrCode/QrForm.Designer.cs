
namespace QrCode
{
    partial class QrForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_wifi = new System.Windows.Forms.Button();
            this.btn_youtube = new System.Windows.Forms.Button();
            this.btn_Call = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_wifi
            // 
            this.btn_wifi.Location = new System.Drawing.Point(505, 60);
            this.btn_wifi.Name = "btn_wifi";
            this.btn_wifi.Size = new System.Drawing.Size(125, 77);
            this.btn_wifi.TabIndex = 2;
            this.btn_wifi.Text = "WIFI";
            this.btn_wifi.UseVisualStyleBackColor = true;
            this.btn_wifi.Click += new System.EventHandler(this.btn_wifi_Click);
            // 
            // btn_youtube
            // 
            this.btn_youtube.Location = new System.Drawing.Point(505, 143);
            this.btn_youtube.Name = "btn_youtube";
            this.btn_youtube.Size = new System.Drawing.Size(125, 80);
            this.btn_youtube.TabIndex = 3;
            this.btn_youtube.Text = "YOUTUBE";
            this.btn_youtube.UseVisualStyleBackColor = true;
            this.btn_youtube.Click += new System.EventHandler(this.btn_youtube_Click);
            // 
            // btn_Call
            // 
            this.btn_Call.Location = new System.Drawing.Point(505, 229);
            this.btn_Call.Name = "btn_Call";
            this.btn_Call.Size = new System.Drawing.Size(125, 80);
            this.btn_Call.TabIndex = 4;
            this.btn_Call.Text = "CALL";
            this.btn_Call.UseVisualStyleBackColor = true;
            this.btn_Call.Click += new System.EventHandler(this.btn_Call_Click);
            // 
            // QrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 371);
            this.Controls.Add(this.btn_Call);
            this.Controls.Add(this.btn_youtube);
            this.Controls.Add(this.btn_wifi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QrForm";
            this.Text = "QrFrom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_wifi;
        private System.Windows.Forms.Button btn_youtube;
        private System.Windows.Forms.Button btn_Call;
    }
}

