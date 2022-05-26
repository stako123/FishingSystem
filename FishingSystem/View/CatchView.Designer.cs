namespace FishingSystem.View
{
    partial class CatchView
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
            this.dgvCatch = new System.Windows.Forms.DataGridView();
            this.lblAmountOfCatch = new System.Windows.Forms.Label();
            this.lblTripStartDate = new System.Windows.Forms.Label();
            this.lblTripLenght = new System.Windows.Forms.Label();
            this.txtAmountOfCatch = new System.Windows.Forms.TextBox();
            this.txtTripLenght = new System.Windows.Forms.TextBox();
            this.txtTripStartDate = new System.Windows.Forms.TextBox();
            this.btnCreateCatch = new System.Windows.Forms.Button();
            this.btnUpdateCatch = new System.Windows.Forms.Button();
            this.btnDeleteCatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatch
            // 
            this.dgvCatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatch.Location = new System.Drawing.Point(41, 76);
            this.dgvCatch.Name = "dgvCatch";
            this.dgvCatch.Size = new System.Drawing.Size(193, 155);
            this.dgvCatch.TabIndex = 0;
            // 
            // lblAmountOfCatch
            // 
            this.lblAmountOfCatch.Location = new System.Drawing.Point(280, 76);
            this.lblAmountOfCatch.Name = "lblAmountOfCatch";
            this.lblAmountOfCatch.Size = new System.Drawing.Size(118, 44);
            this.lblAmountOfCatch.TabIndex = 1;
            this.lblAmountOfCatch.Text = "Amount of Catch";
            this.lblAmountOfCatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTripStartDate
            // 
            this.lblTripStartDate.Location = new System.Drawing.Point(280, 187);
            this.lblTripStartDate.Name = "lblTripStartDate";
            this.lblTripStartDate.Size = new System.Drawing.Size(118, 44);
            this.lblTripStartDate.TabIndex = 2;
            this.lblTripStartDate.Text = "Trip Start Date";
            this.lblTripStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTripLenght
            // 
            this.lblTripLenght.Location = new System.Drawing.Point(280, 132);
            this.lblTripLenght.Name = "lblTripLenght";
            this.lblTripLenght.Size = new System.Drawing.Size(118, 44);
            this.lblTripLenght.TabIndex = 3;
            this.lblTripLenght.Text = "Trip Lenght";
            this.lblTripLenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmountOfCatch
            // 
            this.txtAmountOfCatch.Location = new System.Drawing.Point(420, 76);
            this.txtAmountOfCatch.Multiline = true;
            this.txtAmountOfCatch.Name = "txtAmountOfCatch";
            this.txtAmountOfCatch.Size = new System.Drawing.Size(138, 44);
            this.txtAmountOfCatch.TabIndex = 4;
            // 
            // txtTripLenght
            // 
            this.txtTripLenght.Location = new System.Drawing.Point(420, 132);
            this.txtTripLenght.Multiline = true;
            this.txtTripLenght.Name = "txtTripLenght";
            this.txtTripLenght.Size = new System.Drawing.Size(138, 44);
            this.txtTripLenght.TabIndex = 5;
            // 
            // txtTripStartDate
            // 
            this.txtTripStartDate.Location = new System.Drawing.Point(420, 187);
            this.txtTripStartDate.Multiline = true;
            this.txtTripStartDate.Name = "txtTripStartDate";
            this.txtTripStartDate.Size = new System.Drawing.Size(138, 44);
            this.txtTripStartDate.TabIndex = 6;
            // 
            // btnCreateCatch
            // 
            this.btnCreateCatch.Location = new System.Drawing.Point(598, 76);
            this.btnCreateCatch.Name = "btnCreateCatch";
            this.btnCreateCatch.Size = new System.Drawing.Size(129, 44);
            this.btnCreateCatch.TabIndex = 7;
            this.btnCreateCatch.Text = "Create";
            this.btnCreateCatch.UseVisualStyleBackColor = true;
            this.btnCreateCatch.Click += new System.EventHandler(this.btnCreateCatch_Click);
            // 
            // btnUpdateCatch
            // 
            this.btnUpdateCatch.Location = new System.Drawing.Point(598, 188);
            this.btnUpdateCatch.Name = "btnUpdateCatch";
            this.btnUpdateCatch.Size = new System.Drawing.Size(129, 44);
            this.btnUpdateCatch.TabIndex = 8;
            this.btnUpdateCatch.Text = "Update";
            this.btnUpdateCatch.UseVisualStyleBackColor = true;
            this.btnUpdateCatch.Click += new System.EventHandler(this.btnUpdateCatch_Click);
            // 
            // btnDeleteCatch
            // 
            this.btnDeleteCatch.Location = new System.Drawing.Point(598, 132);
            this.btnDeleteCatch.Name = "btnDeleteCatch";
            this.btnDeleteCatch.Size = new System.Drawing.Size(129, 44);
            this.btnDeleteCatch.TabIndex = 9;
            this.btnDeleteCatch.Text = "Delete";
            this.btnDeleteCatch.UseVisualStyleBackColor = true;
            this.btnDeleteCatch.Click += new System.EventHandler(this.btnDeleteCatch_Click);
            // 
            // CatchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCatch);
            this.Controls.Add(this.btnUpdateCatch);
            this.Controls.Add(this.btnCreateCatch);
            this.Controls.Add(this.txtTripStartDate);
            this.Controls.Add(this.txtTripLenght);
            this.Controls.Add(this.txtAmountOfCatch);
            this.Controls.Add(this.lblTripLenght);
            this.Controls.Add(this.lblTripStartDate);
            this.Controls.Add(this.lblAmountOfCatch);
            this.Controls.Add(this.dgvCatch);
            this.Name = "CatchView";
            this.Text = "CatchView";
            this.Load += new System.EventHandler(this.CatchView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatch;
        private System.Windows.Forms.Label lblAmountOfCatch;
        private System.Windows.Forms.Label lblTripStartDate;
        private System.Windows.Forms.Label lblTripLenght;
        private System.Windows.Forms.TextBox txtAmountOfCatch;
        private System.Windows.Forms.TextBox txtTripLenght;
        private System.Windows.Forms.TextBox txtTripStartDate;
        private System.Windows.Forms.Button btnCreateCatch;
        private System.Windows.Forms.Button btnUpdateCatch;
        private System.Windows.Forms.Button btnDeleteCatch;
    }
}