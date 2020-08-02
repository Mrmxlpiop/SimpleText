namespace SimpleText
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirW = new System.Windows.Forms.TextBox();
            this.btnWebOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direction:";
            // 
            // txtDirW
            // 
            this.txtDirW.Location = new System.Drawing.Point(87, 27);
            this.txtDirW.Name = "txtDirW";
            this.txtDirW.Size = new System.Drawing.Size(701, 20);
            this.txtDirW.TabIndex = 1;
            this.txtDirW.Text = "http://";
            // 
            // btnWebOpen
            // 
            this.btnWebOpen.Location = new System.Drawing.Point(713, 68);
            this.btnWebOpen.Name = "btnWebOpen";
            this.btnWebOpen.Size = new System.Drawing.Size(75, 23);
            this.btnWebOpen.TabIndex = 2;
            this.btnWebOpen.Text = "Open";
            this.btnWebOpen.UseVisualStyleBackColor = true;
            this.btnWebOpen.Click += new System.EventHandler(this.btnWebOpen_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 103);
            this.Controls.Add(this.btnWebOpen);
            this.Controls.Add(this.txtDirW);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirW;
        private System.Windows.Forms.Button btnWebOpen;
    }
}