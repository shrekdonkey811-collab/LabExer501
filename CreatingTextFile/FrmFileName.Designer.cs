namespace LabExer501
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.BackColor = Color.White;
            txtFileName.Font = new Font("Segoe UI", 12F);
            txtFileName.ForeColor = Color.SteelBlue;
            txtFileName.Location = new Point(19, 42);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(279, 29);
            txtFileName.TabIndex = 0;
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.White;
            btnOkay.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOkay.ForeColor = SystemColors.ActiveCaptionText;
            btnOkay.Location = new Point(213, 103);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(85, 35);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "ENTER";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 2;
            label1.Text = "Enter File Name";
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(316, 156);
            Controls.Add(label1);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            Text = "FrmFileName";
            Load += FrmFileName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Button btnOkay;
        private Label label1;
    }
}