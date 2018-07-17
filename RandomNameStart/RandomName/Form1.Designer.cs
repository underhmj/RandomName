namespace RandomName
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
            this.btnGenerateName = new System.Windows.Forms.Button();
            this.lblGeneratedName = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGenerateName
            // 
            this.btnGenerateName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerateName.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateName.Location = new System.Drawing.Point(615, 336);
            this.btnGenerateName.Name = "btnGenerateName";
            this.btnGenerateName.Size = new System.Drawing.Size(738, 318);
            this.btnGenerateName.TabIndex = 0;
            this.btnGenerateName.Text = "Gimme A Name";
            this.btnGenerateName.UseVisualStyleBackColor = false;
            this.btnGenerateName.Click += new System.EventHandler(this.btnGenerateName_Click);
            // 
            // lblGeneratedName
            // 
            this.lblGeneratedName.AutoSize = true;
            this.lblGeneratedName.Font = new System.Drawing.Font("Perpetua Titling MT", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratedName.Location = new System.Drawing.Point(151, 805);
            this.lblGeneratedName.Name = "lblGeneratedName";
            this.lblGeneratedName.Size = new System.Drawing.Size(0, 57);
            this.lblGeneratedName.TabIndex = 1;
            this.lblGeneratedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGeneratedName.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(668, 655);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(893, 306);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1025);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblGeneratedName);
            this.Controls.Add(this.btnGenerateName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateName;
        private System.Windows.Forms.Label lblGeneratedName;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

