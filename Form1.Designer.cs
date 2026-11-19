namespace Dagongdong_Activity5
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGuide = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.txtBoxInitial = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1095, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME SALES TRACKING APPLICATION";
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGuide.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.Location = new System.Drawing.Point(100, 131);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(986, 42);
            this.lblGuide.TabIndex = 1;
            this.lblGuide.Text = "Salesperson Code : D - Danielle | E - Edward | F - Fatima";
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.BackColor = System.Drawing.Color.Snow;
            this.lblInitial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInitial.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitial.Location = new System.Drawing.Point(54, 260);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(440, 38);
            this.lblInitial.TabIndex = 2;
            this.lblInitial.Text = "Enter Sales Person Initial : ";
            // 
            // txtBoxInitial
            // 
            this.txtBoxInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxInitial.Location = new System.Drawing.Point(503, 260);
            this.txtBoxInitial.Multiline = true;
            this.txtBoxInitial.Name = "txtBoxInitial";
            this.txtBoxInitial.Size = new System.Drawing.Size(400, 43);
            this.txtBoxInitial.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Snow;
            this.lblAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(321, 309);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(160, 38);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount :";
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAmount.Location = new System.Drawing.Point(503, 309);
            this.txtBoxAmount.Multiline = true;
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(400, 43);
            this.txtBoxAmount.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(229, 421);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 48);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(522, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(829, 421);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 48);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOutput.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(229, 501);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(740, 140);
            this.lblOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 705);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtBoxInitial);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Sales Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.TextBox txtBoxInitial;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblOutput;
    }
}

