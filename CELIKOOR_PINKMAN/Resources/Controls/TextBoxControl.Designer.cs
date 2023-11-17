namespace CELIKOOR_PINKMAN.Resources.Controls
{
    partial class TextBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDesign = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDesign
            // 
            this.textBoxDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDesign.Location = new System.Drawing.Point(7, 7);
            this.textBoxDesign.Name = "textBoxDesign";
            this.textBoxDesign.Size = new System.Drawing.Size(236, 22);
            this.textBoxDesign.TabIndex = 0;
            // 
            // TextBoxControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBoxDesign);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "TextBoxControl";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDesign;
    }
}
