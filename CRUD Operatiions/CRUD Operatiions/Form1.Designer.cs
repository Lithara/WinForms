namespace CRUD_Operatiions
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
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.btnSubmit = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AccessibleName = "";
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(258, 97);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.Radius = 10;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(275, 61);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Enter ID";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AnimationHoverSpeed = 0.07F;
            this.btnSubmit.AnimationSpeed = 0.03F;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = null;
            this.btnSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSubmit.Location = new System.Drawing.Point(258, 179);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit.Radius = 10;
            this.btnSubmit.Size = new System.Drawing.Size(275, 59);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtID;
        private Guna.UI.WinForms.GunaButton btnSubmit;
    }
}

