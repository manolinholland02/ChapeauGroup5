namespace ChapeauUI
{
    partial class FeedbackSection
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
            this.tableNumber_lbl = new System.Windows.Forms.Label();
            this.employeeName_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFeedback_btn = new System.Windows.Forms.Button();
            this.goBack_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableNumber_lbl
            // 
            this.tableNumber_lbl.AutoSize = true;
            this.tableNumber_lbl.Location = new System.Drawing.Point(12, 9);
            this.tableNumber_lbl.Name = "tableNumber_lbl";
            this.tableNumber_lbl.Size = new System.Drawing.Size(57, 20);
            this.tableNumber_lbl.TabIndex = 0;
            this.tableNumber_lbl.Text = "Table X";
            // 
            // employeeName_lbl
            // 
            this.employeeName_lbl.AutoSize = true;
            this.employeeName_lbl.Location = new System.Drawing.Point(429, 9);
            this.employeeName_lbl.Name = "employeeName_lbl";
            this.employeeName_lbl.Size = new System.Drawing.Size(88, 20);
            this.employeeName_lbl.TabIndex = 1;
            this.employeeName_lbl.Text = "Employee X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 127);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feedback Section";
            // 
            // saveFeedback_btn
            // 
            this.saveFeedback_btn.Location = new System.Drawing.Point(179, 243);
            this.saveFeedback_btn.Name = "saveFeedback_btn";
            this.saveFeedback_btn.Size = new System.Drawing.Size(154, 40);
            this.saveFeedback_btn.TabIndex = 4;
            this.saveFeedback_btn.Text = "Save Feedback";
            this.saveFeedback_btn.UseVisualStyleBackColor = true;
            // 
            // goBack_btn
            // 
            this.goBack_btn.Location = new System.Drawing.Point(35, 342);
            this.goBack_btn.Name = "goBack_btn";
            this.goBack_btn.Size = new System.Drawing.Size(94, 29);
            this.goBack_btn.TabIndex = 5;
            this.goBack_btn.Text = "Back";
            this.goBack_btn.UseVisualStyleBackColor = true;
            // 
            // FeedbackSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 713);
            this.Controls.Add(this.goBack_btn);
            this.Controls.Add(this.saveFeedback_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.employeeName_lbl);
            this.Controls.Add(this.tableNumber_lbl);
            this.Name = "FeedbackSection";
            this.Text = "FeedbackSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableNumber_lbl;
        private System.Windows.Forms.Label employeeName_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveFeedback_btn;
        private System.Windows.Forms.Button goBack_btn;
    }
}