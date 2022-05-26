namespace FishingSystem.View
{
    partial class HomeScreenView
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
            this.btnCatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatch
            // 
            this.btnCatch.Location = new System.Drawing.Point(107, 137);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(181, 119);
            this.btnCatch.TabIndex = 0;
            this.btnCatch.Text = "Catch";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.btnCatch_Click);
            // 
            // HomeScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCatch);
            this.Name = "HomeScreenView";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatch;
    }
}