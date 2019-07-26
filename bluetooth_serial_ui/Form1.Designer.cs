namespace bluetooth_serial_ui
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bwd_image = new System.Windows.Forms.PictureBox();
            this.right_image = new System.Windows.Forms.PictureBox();
            this.left_image = new System.Windows.Forms.PictureBox();
            this.fwd_image = new System.Windows.Forms.PictureBox();
            this.arm = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bwd_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwd_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arm)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Command sent";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(659, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(828, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1048, 96);
            this.label1.TabIndex = 9;
            this.label1.Text = "Use WASD to move the robot around, and the J and L keys to move your arm\r\nup and " +
    "down.\r\nUse Z to start autonomous, and X to stop it.";
            // 
            // bwd_image
            // 
            this.bwd_image.Image = global::bluetooth_serial_ui.Properties.Resources.down_arrow;
            this.bwd_image.Location = new System.Drawing.Point(300, 300);
            this.bwd_image.Name = "bwd_image";
            this.bwd_image.Size = new System.Drawing.Size(100, 150);
            this.bwd_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bwd_image.TabIndex = 3;
            this.bwd_image.TabStop = false;
            // 
            // right_image
            // 
            this.right_image.Image = global::bluetooth_serial_ui.Properties.Resources.right_arrow;
            this.right_image.Location = new System.Drawing.Point(445, 225);
            this.right_image.Name = "right_image";
            this.right_image.Size = new System.Drawing.Size(150, 100);
            this.right_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.right_image.TabIndex = 2;
            this.right_image.TabStop = false;
            // 
            // left_image
            // 
            this.left_image.Image = global::bluetooth_serial_ui.Properties.Resources.left_arrow;
            this.left_image.Location = new System.Drawing.Point(100, 225);
            this.left_image.Name = "left_image";
            this.left_image.Size = new System.Drawing.Size(150, 100);
            this.left_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left_image.TabIndex = 1;
            this.left_image.TabStop = false;
            // 
            // fwd_image
            // 
            this.fwd_image.Image = global::bluetooth_serial_ui.Properties.Resources.up_arrow;
            this.fwd_image.Location = new System.Drawing.Point(300, 100);
            this.fwd_image.Name = "fwd_image";
            this.fwd_image.Size = new System.Drawing.Size(100, 150);
            this.fwd_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fwd_image.TabIndex = 0;
            this.fwd_image.TabStop = false;
            // 
            // arm
            // 
            this.arm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arm.Image = global::bluetooth_serial_ui.Properties.Resources.arm;
            this.arm.Location = new System.Drawing.Point(750, 200);
            this.arm.Name = "arm";
            this.arm.Size = new System.Drawing.Size(263, 161);
            this.arm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arm.TabIndex = 10;
            this.arm.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Auto Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1128, 586);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.arm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bwd_image);
            this.Controls.Add(this.right_image);
            this.Controls.Add(this.left_image);
            this.Controls.Add(this.fwd_image);
            this.Name = "Form1";
            this.Text = "Bluetooth Robot Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bwd_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwd_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox fwd_image;
        private System.Windows.Forms.PictureBox left_image;
        private System.Windows.Forms.PictureBox right_image;
        private System.Windows.Forms.PictureBox bwd_image;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox arm;
        private System.Windows.Forms.Label label4;
    }
}

