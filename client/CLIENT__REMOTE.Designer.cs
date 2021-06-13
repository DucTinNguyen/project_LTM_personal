
namespace client
{
    partial class CLIENT__REMOTE
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
            this.txt_linkfile = new System.Windows.Forms.TextBox();
            this.btn__connect = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.listviewconnect = new System.Windows.Forms.ListView();
            this.listviewdisplay = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "linkFile";
            // 
            // txt_linkfile
            // 
            this.txt_linkfile.Location = new System.Drawing.Point(121, 162);
            this.txt_linkfile.Name = "txt_linkfile";
            this.txt_linkfile.Size = new System.Drawing.Size(375, 22);
            this.txt_linkfile.TabIndex = 1;
            // 
            // btn__connect
            // 
            this.btn__connect.Location = new System.Drawing.Point(49, 83);
            this.btn__connect.Name = "btn__connect";
            this.btn__connect.Size = new System.Drawing.Size(99, 50);
            this.btn__connect.TabIndex = 2;
            this.btn__connect.Text = "CONNECT";
            this.btn__connect.UseVisualStyleBackColor = true;
            this.btn__connect.Click += new System.EventHandler(this.btn__connect_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(586, 145);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(103, 53);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // listviewconnect
            // 
            this.listviewconnect.HideSelection = false;
            this.listviewconnect.Location = new System.Drawing.Point(366, 12);
            this.listviewconnect.Name = "listviewconnect";
            this.listviewconnect.Size = new System.Drawing.Size(340, 97);
            this.listviewconnect.TabIndex = 4;
            this.listviewconnect.UseCompatibleStateImageBehavior = false;
            // 
            // listviewdisplay
            // 
            this.listviewdisplay.HideSelection = false;
            this.listviewdisplay.Location = new System.Drawing.Point(108, 228);
            this.listviewdisplay.Name = "listviewdisplay";
            this.listviewdisplay.Size = new System.Drawing.Size(598, 177);
            this.listviewdisplay.TabIndex = 5;
            this.listviewdisplay.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ip ";
        
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(57, 16);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(156, 22);
            this.txt_ip.TabIndex = 7;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(57, 44);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(156, 22);
            this.txt_port.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // CLIENT__REMOTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listviewdisplay);
            this.Controls.Add(this.listviewconnect);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn__connect);
            this.Controls.Add(this.txt_linkfile);
            this.Controls.Add(this.label1);
            this.Name = "CLIENT__REMOTE";
            this.Text = "CLIENT__REMOTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_linkfile;
        private System.Windows.Forms.Button btn__connect;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListView listviewconnect;
        private System.Windows.Forms.ListView listviewdisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label3;
    }
}