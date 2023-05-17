namespace WindowsFormsApp7
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
            this.licensing1 = new Guna.UI.Licensing.Licensing();
            this.SuspendLayout();
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.White;
            this.licensing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.licensing1.Location = new System.Drawing.Point(174, 79);
            this.licensing1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.licensing1.MaximumSize = new System.Drawing.Size(464, 597);
            this.licensing1.MinimumSize = new System.Drawing.Size(464, 597);
            this.licensing1.Name = "licensing1";
            this.licensing1.Size = new System.Drawing.Size(464, 597);
            this.licensing1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.licensing1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.Licensing.Licensing licensing1;
    }
}

