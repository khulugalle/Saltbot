namespace Saltbot.ConsoleApp
{
    partial class Error
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
            this.errorText = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.Location = new System.Drawing.Point(12, 53);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(300, 18);
            this.errorText.TabIndex = 0;
            this.errorText.Text = "An event source for this needs to be created!";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(254, 107);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button_OnClick);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 142);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.errorText);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Button closeButton;
    }
}