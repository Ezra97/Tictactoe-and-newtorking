namespace tictactoe_networking
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
            this.button_0_0 = new System.Windows.Forms.Button();
            this.button_2_0 = new System.Windows.Forms.Button();
            this.button_1_2 = new System.Windows.Forms.Button();
            this.button_1_1 = new System.Windows.Forms.Button();
            this.button_1_0 = new System.Windows.Forms.Button();
            this.button_0_2 = new System.Windows.Forms.Button();
            this.button_0_1 = new System.Windows.Forms.Button();
            this.button_2_1 = new System.Windows.Forms.Button();
            this.button_2_2 = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_host = new System.Windows.Forms.Button();
            this.label_host = new System.Windows.Forms.Label();
            this.textBox_connect = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_0_0
            // 
            this.button_0_0.Location = new System.Drawing.Point(113, 153);
            this.button_0_0.Name = "button_0_0";
            this.button_0_0.Size = new System.Drawing.Size(100, 100);
            this.button_0_0.TabIndex = 0;
            this.button_0_0.UseVisualStyleBackColor = true;
            this.button_0_0.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_2_0
            // 
            this.button_2_0.Location = new System.Drawing.Point(113, 365);
            this.button_2_0.Name = "button_2_0";
            this.button_2_0.Size = new System.Drawing.Size(100, 100);
            this.button_2_0.TabIndex = 1;
            this.button_2_0.UseVisualStyleBackColor = true;
            this.button_2_0.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_1_2
            // 
            this.button_1_2.Location = new System.Drawing.Point(325, 259);
            this.button_1_2.Name = "button_1_2";
            this.button_1_2.Size = new System.Drawing.Size(100, 100);
            this.button_1_2.TabIndex = 2;
            this.button_1_2.UseVisualStyleBackColor = true;
            this.button_1_2.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_1_1
            // 
            this.button_1_1.Location = new System.Drawing.Point(219, 259);
            this.button_1_1.Name = "button_1_1";
            this.button_1_1.Size = new System.Drawing.Size(100, 100);
            this.button_1_1.TabIndex = 3;
            this.button_1_1.UseVisualStyleBackColor = true;
            this.button_1_1.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_1_0
            // 
            this.button_1_0.Location = new System.Drawing.Point(113, 259);
            this.button_1_0.Name = "button_1_0";
            this.button_1_0.Size = new System.Drawing.Size(100, 100);
            this.button_1_0.TabIndex = 4;
            this.button_1_0.UseVisualStyleBackColor = true;
            this.button_1_0.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_0_2
            // 
            this.button_0_2.Location = new System.Drawing.Point(325, 153);
            this.button_0_2.Name = "button_0_2";
            this.button_0_2.Size = new System.Drawing.Size(100, 100);
            this.button_0_2.TabIndex = 5;
            this.button_0_2.UseVisualStyleBackColor = true;
            this.button_0_2.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_0_1
            // 
            this.button_0_1.Location = new System.Drawing.Point(219, 153);
            this.button_0_1.Name = "button_0_1";
            this.button_0_1.Size = new System.Drawing.Size(100, 100);
            this.button_0_1.TabIndex = 6;
            this.button_0_1.UseVisualStyleBackColor = true;
            this.button_0_1.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_2_1
            // 
            this.button_2_1.Location = new System.Drawing.Point(219, 365);
            this.button_2_1.Name = "button_2_1";
            this.button_2_1.Size = new System.Drawing.Size(100, 100);
            this.button_2_1.TabIndex = 7;
            this.button_2_1.UseVisualStyleBackColor = true;
            this.button_2_1.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_2_2
            // 
            this.button_2_2.Location = new System.Drawing.Point(325, 365);
            this.button_2_2.Name = "button_2_2";
            this.button_2_2.Size = new System.Drawing.Size(100, 100);
            this.button_2_2.TabIndex = 8;
            this.button_2_2.UseVisualStyleBackColor = true;
            this.button_2_2.Click += new System.EventHandler(this.whichwasclicked);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(34, 28);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 9;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.onconnect);
            // 
            // button_host
            // 
            this.button_host.Location = new System.Drawing.Point(34, 76);
            this.button_host.Name = "button_host";
            this.button_host.Size = new System.Drawing.Size(75, 23);
            this.button_host.TabIndex = 10;
            this.button_host.Text = "Host";
            this.button_host.UseVisualStyleBackColor = true;
            this.button_host.Click += new System.EventHandler(this.onhost);
            // 
            // label_host
            // 
            this.label_host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_host.Location = new System.Drawing.Point(176, 76);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(263, 23);
            this.label_host.TabIndex = 11;
            this.label_host.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_connect
            // 
            this.textBox_connect.Location = new System.Drawing.Point(176, 31);
            this.textBox_connect.Name = "textBox_connect";
            this.textBox_connect.Size = new System.Drawing.Size(263, 20);
            this.textBox_connect.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.ongetdata);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 506);
            this.Controls.Add(this.textBox_connect);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.button_host);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.button_2_2);
            this.Controls.Add(this.button_2_1);
            this.Controls.Add(this.button_0_1);
            this.Controls.Add(this.button_0_2);
            this.Controls.Add(this.button_1_0);
            this.Controls.Add(this.button_1_1);
            this.Controls.Add(this.button_1_2);
            this.Controls.Add(this.button_2_0);
            this.Controls.Add(this.button_0_0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onload);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_0_0;
        private System.Windows.Forms.Button button_2_0;
        private System.Windows.Forms.Button button_1_2;
        private System.Windows.Forms.Button button_1_1;
        private System.Windows.Forms.Button button_1_0;
        private System.Windows.Forms.Button button_0_2;
        private System.Windows.Forms.Button button_0_1;
        private System.Windows.Forms.Button button_2_1;
        private System.Windows.Forms.Button button_2_2;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_host;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.TextBox textBox_connect;
        private System.Windows.Forms.Timer timer1;
    }
}

