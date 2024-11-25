namespace Task_1
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
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.btn_Welcome = new System.Windows.Forms.Button();
            this.pb_Smile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Smile)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Input
            // 
            this.tb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Input.Location = new System.Drawing.Point(41, 205);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(150, 31);
            this.tb_Input.TabIndex = 1;
            // 
            // btn_Welcome
            // 
            this.btn_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Welcome.Location = new System.Drawing.Point(41, 254);
            this.btn_Welcome.Name = "btn_Welcome";
            this.btn_Welcome.Size = new System.Drawing.Size(150, 36);
            this.btn_Welcome.TabIndex = 2;
            this.btn_Welcome.Text = "Привіт";
            this.btn_Welcome.UseVisualStyleBackColor = true;
            this.btn_Welcome.Click += new System.EventHandler(this.btn_Welcome_Click);
            // 
            // pb_Smile
            // 
            this.pb_Smile.Image = global::Task_1.Properties.Resources.smiley__1_;
            this.pb_Smile.Location = new System.Drawing.Point(41, 34);
            this.pb_Smile.Name = "pb_Smile";
            this.pb_Smile.Size = new System.Drawing.Size(150, 150);
            this.pb_Smile.TabIndex = 0;
            this.pb_Smile.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 327);
            this.Controls.Add(this.btn_Welcome);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.pb_Smile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Smile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Smile;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Button btn_Welcome;
    }
}

