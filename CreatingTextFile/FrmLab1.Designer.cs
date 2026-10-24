namespace LabExer501
{
    partial class FrmLab1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(18, 23);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(284, 95);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            btnCreate.Location = new Point(18, 126);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 34);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(325, 170);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "FrmLab1";
            Text = "FrmLab1";
            Load += FrmLab1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCreate;
    }
}
