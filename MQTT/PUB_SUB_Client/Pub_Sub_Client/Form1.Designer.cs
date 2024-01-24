namespace Pub_Sub_Client
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
            this.components = new System.ComponentModel.Container();
            this.btn_publish = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_topic_sub = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_topic_sub = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_topic_pub = new System.Windows.Forms.ListBox();
            this.chk_pub_auto = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pub_value = new System.Windows.Forms.TextBox();
            this.txt_topic_pub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_client_ID = new System.Windows.Forms.TextBox();
            this.txt_server_port = new System.Windows.Forms.TextBox();
            this.txt_server_address = new System.Windows.Forms.TextBox();
            this.timer_sub = new System.Windows.Forms.Timer(this.components);
            this.timer_pub = new System.Windows.Forms.Timer(this.components);
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_interval_pub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_pub_time = new System.Windows.Forms.CheckBox();
            this.btn_pub_timer_st = new System.Windows.Forms.Button();
            this.btn_pub_timer_stp = new System.Windows.Forms.Button();
            this.btn_clear_disp_sub = new System.Windows.Forms.Button();
            this.btn_clear_disp_pub = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_publish
            // 
            this.btn_publish.ForeColor = System.Drawing.Color.Black;
            this.btn_publish.Location = new System.Drawing.Point(344, 41);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(77, 19);
            this.btn_publish.TabIndex = 1;
            this.btn_publish.Text = "PUBLISH";
            this.btn_publish.UseVisualStyleBackColor = true;
            this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear_disp_sub);
            this.groupBox2.Controls.Add(this.lst_topic_sub);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_topic_sub);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(469, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUBSCRIBER";
            // 
            // lst_topic_sub
            // 
            this.lst_topic_sub.FormattingEnabled = true;
            this.lst_topic_sub.Location = new System.Drawing.Point(11, 67);
            this.lst_topic_sub.Name = "lst_topic_sub";
            this.lst_topic_sub.Size = new System.Drawing.Size(429, 186);
            this.lst_topic_sub.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "TOPIC";
            // 
            // txt_topic_sub
            // 
            this.txt_topic_sub.Location = new System.Drawing.Point(11, 41);
            this.txt_topic_sub.Name = "txt_topic_sub";
            this.txt_topic_sub.Size = new System.Drawing.Size(429, 20);
            this.txt_topic_sub.TabIndex = 2;
            this.txt_topic_sub.Text = "switch";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_clear_disp_pub);
            this.groupBox3.Controls.Add(this.btn_pub_timer_stp);
            this.groupBox3.Controls.Add(this.btn_pub_timer_st);
            this.groupBox3.Controls.Add(this.chk_pub_time);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_interval_pub);
            this.groupBox3.Controls.Add(this.lst_topic_pub);
            this.groupBox3.Controls.Add(this.chk_pub_auto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_pub_value);
            this.groupBox3.Controls.Add(this.txt_topic_pub);
            this.groupBox3.Controls.Add(this.btn_publish);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 300);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PUBLISHER";
            // 
            // lst_topic_pub
            // 
            this.lst_topic_pub.FormattingEnabled = true;
            this.lst_topic_pub.Location = new System.Drawing.Point(6, 67);
            this.lst_topic_pub.Name = "lst_topic_pub";
            this.lst_topic_pub.Size = new System.Drawing.Size(434, 186);
            this.lst_topic_pub.TabIndex = 5;
            // 
            // chk_pub_auto
            // 
            this.chk_pub_auto.AutoSize = true;
            this.chk_pub_auto.Checked = true;
            this.chk_pub_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_pub_auto.Location = new System.Drawing.Point(20, 269);
            this.chk_pub_auto.Name = "chk_pub_auto";
            this.chk_pub_auto.Size = new System.Drawing.Size(56, 17);
            this.chk_pub_auto.TabIndex = 4;
            this.chk_pub_auto.Text = "AUTO";
            this.chk_pub_auto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Topic Name";
            // 
            // txt_pub_value
            // 
            this.txt_pub_value.Location = new System.Drawing.Point(244, 41);
            this.txt_pub_value.Name = "txt_pub_value";
            this.txt_pub_value.Size = new System.Drawing.Size(94, 20);
            this.txt_pub_value.TabIndex = 2;
            this.txt_pub_value.Text = "1.0";
            // 
            // txt_topic_pub
            // 
            this.txt_topic_pub.Location = new System.Drawing.Point(6, 41);
            this.txt_topic_pub.Name = "txt_topic_pub";
            this.txt_topic_pub.Size = new System.Drawing.Size(232, 20);
            this.txt_topic_pub.TabIndex = 2;
            this.txt_topic_pub.Text = "switch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(381, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "MQTT PUB-SUB CLIENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pb_status);
            this.groupBox1.Controls.Add(this.btn_disconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_client_ID);
            this.groupBox1.Controls.Add(this.txt_server_port);
            this.groupBox1.Controls.Add(this.txt_server_address);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUBSCRIBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "STATUS";
            // 
            // pb_status
            // 
            this.pb_status.BackColor = System.Drawing.Color.Red;
            this.pb_status.Location = new System.Drawing.Point(809, 32);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(31, 28);
            this.pb_status.TabIndex = 3;
            this.pb_status.TabStop = false;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.ForeColor = System.Drawing.Color.Navy;
            this.btn_disconnect.Location = new System.Drawing.Point(612, 23);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(126, 49);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.ForeColor = System.Drawing.Color.Navy;
            this.btn_connect.Location = new System.Drawing.Point(513, 23);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(93, 49);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Client ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Address";
            // 
            // txt_client_ID
            // 
            this.txt_client_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_ID.Location = new System.Drawing.Point(311, 46);
            this.txt_client_ID.Name = "txt_client_ID";
            this.txt_client_ID.Size = new System.Drawing.Size(175, 26);
            this.txt_client_ID.TabIndex = 0;
            this.txt_client_ID.Text = "Lenovo-PC";
            // 
            // txt_server_port
            // 
            this.txt_server_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server_port.Location = new System.Drawing.Point(195, 46);
            this.txt_server_port.Name = "txt_server_port";
            this.txt_server_port.Size = new System.Drawing.Size(110, 26);
            this.txt_server_port.TabIndex = 0;
            this.txt_server_port.Text = "1883";
            // 
            // txt_server_address
            // 
            this.txt_server_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server_address.Location = new System.Drawing.Point(15, 46);
            this.txt_server_address.Name = "txt_server_address";
            this.txt_server_address.Size = new System.Drawing.Size(174, 26);
            this.txt_server_address.TabIndex = 0;
            this.txt_server_address.Text = "broker.hivemq.com";
            // 
            // timer_sub
            // 
            this.timer_sub.Enabled = true;
            this.timer_sub.Interval = 1;
            this.timer_sub.Tick += new System.EventHandler(this.timer_sub_Tick);
            // 
            // timer_pub
            // 
            this.timer_pub.Tick += new System.EventHandler(this.timer_pub_Tick);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(15, 29);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(877, 26);
            this.txt_msg.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_msg);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(17, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 73);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // txt_interval_pub
            // 
            this.txt_interval_pub.Location = new System.Drawing.Point(82, 272);
            this.txt_interval_pub.Name = "txt_interval_pub";
            this.txt_interval_pub.Size = new System.Drawing.Size(75, 20);
            this.txt_interval_pub.TabIndex = 6;
            this.txt_interval_pub.Text = "1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Interval(ms)";
            // 
            // chk_pub_time
            // 
            this.chk_pub_time.AutoSize = true;
            this.chk_pub_time.Checked = true;
            this.chk_pub_time.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_pub_time.Location = new System.Drawing.Point(163, 272);
            this.chk_pub_time.Name = "chk_pub_time";
            this.chk_pub_time.Size = new System.Drawing.Size(75, 17);
            this.chk_pub_time.TabIndex = 8;
            this.chk_pub_time.Text = "Time Data";
            this.chk_pub_time.UseVisualStyleBackColor = true;
            // 
            // btn_pub_timer_st
            // 
            this.btn_pub_timer_st.ForeColor = System.Drawing.Color.Black;
            this.btn_pub_timer_st.Location = new System.Drawing.Point(244, 262);
            this.btn_pub_timer_st.Name = "btn_pub_timer_st";
            this.btn_pub_timer_st.Size = new System.Drawing.Size(56, 29);
            this.btn_pub_timer_st.TabIndex = 9;
            this.btn_pub_timer_st.Text = "START";
            this.btn_pub_timer_st.UseVisualStyleBackColor = true;
            this.btn_pub_timer_st.Click += new System.EventHandler(this.btn_pub_timer_st_Click);
            // 
            // btn_pub_timer_stp
            // 
            this.btn_pub_timer_stp.ForeColor = System.Drawing.Color.Black;
            this.btn_pub_timer_stp.Location = new System.Drawing.Point(306, 259);
            this.btn_pub_timer_stp.Name = "btn_pub_timer_stp";
            this.btn_pub_timer_stp.Size = new System.Drawing.Size(56, 29);
            this.btn_pub_timer_stp.TabIndex = 9;
            this.btn_pub_timer_stp.Text = "STOP";
            this.btn_pub_timer_stp.UseVisualStyleBackColor = true;
            this.btn_pub_timer_stp.Click += new System.EventHandler(this.btn_pub_timer_stp_Click);
            // 
            // btn_clear_disp_sub
            // 
            this.btn_clear_disp_sub.ForeColor = System.Drawing.Color.Black;
            this.btn_clear_disp_sub.Location = new System.Drawing.Point(386, 266);
            this.btn_clear_disp_sub.Name = "btn_clear_disp_sub";
            this.btn_clear_disp_sub.Size = new System.Drawing.Size(54, 23);
            this.btn_clear_disp_sub.TabIndex = 6;
            this.btn_clear_disp_sub.Text = "Clear";
            this.btn_clear_disp_sub.UseVisualStyleBackColor = true;
            this.btn_clear_disp_sub.Click += new System.EventHandler(this.btn_clear_disp_sub_Click);
            // 
            // btn_clear_disp_pub
            // 
            this.btn_clear_disp_pub.ForeColor = System.Drawing.Color.Black;
            this.btn_clear_disp_pub.Location = new System.Drawing.Point(386, 265);
            this.btn_clear_disp_pub.Name = "btn_clear_disp_pub";
            this.btn_clear_disp_pub.Size = new System.Drawing.Size(54, 23);
            this.btn_clear_disp_pub.TabIndex = 6;
            this.btn_clear_disp_pub.Text = "Clear";
            this.btn_clear_disp_pub.UseVisualStyleBackColor = true;
            this.btn_clear_disp_pub.Click += new System.EventHandler(this.btn_clear_disp_pub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 527);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "MQTT Pub-Sub Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_server_port;
        private System.Windows.Forms.TextBox txt_server_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_topic_sub;
        private System.Windows.Forms.CheckBox chk_pub_auto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_topic_pub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Timer timer_sub;
        private System.Windows.Forms.Timer timer_pub;
        private System.Windows.Forms.ListBox lst_topic_sub;
        private System.Windows.Forms.ListBox lst_topic_pub;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_client_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pub_value;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_interval_pub;
        private System.Windows.Forms.Button btn_pub_timer_stp;
        private System.Windows.Forms.Button btn_pub_timer_st;
        private System.Windows.Forms.CheckBox chk_pub_time;
        private System.Windows.Forms.Button btn_clear_disp_sub;
        private System.Windows.Forms.Button btn_clear_disp_pub;
    }
}

