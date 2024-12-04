namespace Autó_átengedő
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
            this.sorompo = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sorompo
            // 
            this.sorompo.Location = new System.Drawing.Point(291, 39);
            this.sorompo.Name = "sorompo";
            this.sorompo.Size = new System.Drawing.Size(40, 120);
            this.sorompo.TabIndex = 0;
            this.sorompo.UseVisualStyleBackColor = true;
            this.sorompo.Click += new System.EventHandler(this.sorompo_Click);
            // 
            // Train
            // 
            this.Train.Enabled = true;
            this.Train.Interval = 10;
            this.Train.Tick += new System.EventHandler(this.Train_Tick);
            // 
            // Car
            // 
            this.Car.Enabled = true;
            this.Car.Interval = 25;
            this.Car.Tick += new System.EventHandler(this.Car_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 508);
            this.Controls.Add(this.sorompo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sorompo;
        private System.Windows.Forms.Timer Train;
        private System.Windows.Forms.Timer Car;
    }
}

