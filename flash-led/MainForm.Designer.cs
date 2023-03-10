namespace flash_led
{
    partial class MainForm
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
            this.buttonFlash = new System.Windows.Forms.Button();
            this.led1 = new flash_led.LED();
            this.SuspendLayout();
            // 
            // buttonFlash
            // 
            this.buttonFlash.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFlash.Location = new System.Drawing.Point(12, 41);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(112, 43);
            this.buttonFlash.TabIndex = 1;
            this.buttonFlash.Text = "Flash";
            this.buttonFlash.UseVisualStyleBackColor = true;
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.DimGray;
            this.led1.Location = new System.Drawing.Point(141, 44);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(40, 40);
            this.led1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonFlash);
            this.Controls.Add(this.led1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFlash;
        private LED led1;
    }
}
