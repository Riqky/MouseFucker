namespace MouseFucker
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
            this.click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xbox = new System.Windows.Forms.NumericUpDown();
            this.ybox = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ybox)).BeginInit();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(59, 81);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(75, 23);
            this.click.TabIndex = 2;
            this.click.Text = "Click";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // xbox
            // 
            this.xbox.Location = new System.Drawing.Point(16, 33);
            this.xbox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(68, 22);
            this.xbox.TabIndex = 5;
            // 
            // ybox
            // 
            this.ybox.Location = new System.Drawing.Point(106, 33);
            this.ybox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(68, 22);
            this.ybox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 121);
            this.Controls.Add(this.ybox);
            this.Controls.Add(this.xbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.click);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ybox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown xbox;
        private System.Windows.Forms.NumericUpDown ybox;
        private System.Windows.Forms.Timer timer1;
    }
}

