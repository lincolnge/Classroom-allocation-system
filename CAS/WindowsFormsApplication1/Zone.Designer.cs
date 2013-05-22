namespace WindowsFormsApplication1
{
    partial class Zone
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
            this.button5 = new System.Windows.Forms.Button();
            this.zone_A = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(841, 618);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // zone_A
            // 
            this.zone_A.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.A;
            this.zone_A.Location = new System.Drawing.Point(596, 559);
            this.zone_A.Name = "zone_A";
            this.zone_A.Size = new System.Drawing.Size(35, 34);
            this.zone_A.TabIndex = 9;
            this.zone_A.UseVisualStyleBackColor = true;
            this.zone_A.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.B;
            this.button7.Location = new System.Drawing.Point(698, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 34);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.C;
            this.button8.Location = new System.Drawing.Point(551, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 34);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.D;
            this.button9.Location = new System.Drawing.Point(275, 277);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 34);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.E1;
            this.button10.Location = new System.Drawing.Point(190, 439);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 34);
            this.button10.TabIndex = 13;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.F;
            this.button11.Location = new System.Drawing.Point(462, 444);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 34);
            this.button11.TabIndex = 14;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Blue;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(748, 618);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(59, 30);
            this.exit.TabIndex = 15;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Zone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.UIC2;
            this.ClientSize = new System.Drawing.Size(926, 666);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.zone_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button zone_A;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button exit;
    }
}