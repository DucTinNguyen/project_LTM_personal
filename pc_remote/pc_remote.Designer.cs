
namespace pc_remote
{
    partial class pc_remote
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listviewdisplay = new System.Windows.Forms.ListView();
            this.listviewconnect = new System.Windows.Forms.ListView();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn__connect = new System.Windows.Forms.Button();
            this.txt_linkfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Port";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(98, 61);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(156, 22);
            this.txt_port.TabIndex = 18;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(98, 33);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(156, 22);
            this.txt_ip.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ip ";
            // 
            // listviewdisplay
            // 
            this.listviewdisplay.HideSelection = false;
            this.listviewdisplay.Location = new System.Drawing.Point(149, 245);
            this.listviewdisplay.Name = "listviewdisplay";
            this.listviewdisplay.Size = new System.Drawing.Size(598, 177);
            this.listviewdisplay.TabIndex = 15;
            this.listviewdisplay.UseCompatibleStateImageBehavior = false;
            // 
            // listviewconnect
            // 
            this.listviewconnect.HideSelection = false;
            this.listviewconnect.Location = new System.Drawing.Point(407, 29);
            this.listviewconnect.Name = "listviewconnect";
            this.listviewconnect.Size = new System.Drawing.Size(340, 97);
            this.listviewconnect.TabIndex = 14;
            this.listviewconnect.UseCompatibleStateImageBehavior = false;
            this.listviewconnect.View = System.Windows.Forms.View.List;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(627, 162);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(103, 53);
            this.btn_send.TabIndex = 13;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn__connect
            // 
            this.btn__connect.Location = new System.Drawing.Point(90, 100);
            this.btn__connect.Name = "btn__connect";
            this.btn__connect.Size = new System.Drawing.Size(99, 50);
            this.btn__connect.TabIndex = 12;
            this.btn__connect.Text = "CONNECT";
            this.btn__connect.UseVisualStyleBackColor = true;
            this.btn__connect.Click += new System.EventHandler(this.btn__connect_Click);
            // 
            // txt_linkfile
            // 
            this.txt_linkfile.Location = new System.Drawing.Point(162, 179);
            this.txt_linkfile.Name = "txt_linkfile";
            this.txt_linkfile.Size = new System.Drawing.Size(375, 22);
            this.txt_linkfile.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "linkFile";
            // 
            // pc_remote
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
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "pc_remote";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listviewdisplay;
        private System.Windows.Forms.ListView listviewconnect;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn__connect;
        private System.Windows.Forms.TextBox txt_linkfile;
        private System.Windows.Forms.Label label1;
    }
}