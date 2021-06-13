
namespace PROJECT
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_listen = new System.Windows.Forms.Button();
            this.listViewcommand = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_listen
            // 
            this.btn_listen.Location = new System.Drawing.Point(539, 25);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(165, 70);
            this.btn_listen.TabIndex = 0;
            this.btn_listen.Text = "LISTEN";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // listViewcommand
            // 
            this.listViewcommand.HideSelection = false;
            this.listViewcommand.Location = new System.Drawing.Point(43, 144);
            this.listViewcommand.Name = "listViewcommand";
            this.listViewcommand.Size = new System.Drawing.Size(661, 256);
            this.listViewcommand.TabIndex = 1;
            this.listViewcommand.UseCompatibleStateImageBehavior = false;
            this.listViewcommand.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ip";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(74, 25);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(185, 27);
            this.txt_ip.TabIndex = 4;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(74, 61);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(185, 27);
            this.txt_port.TabIndex = 5;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewcommand);
            this.Controls.Add(this.btn_listen);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.ListView listViewcommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
    }
}

