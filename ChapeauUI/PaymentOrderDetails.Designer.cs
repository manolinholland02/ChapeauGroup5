namespace ChapeauUI
{
    partial class PaymentOrderDetails
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
            this.listViewOrderDetails = new System.Windows.Forms.ListView();
            this.payedAmount_btn = new System.Windows.Forms.Button();
            this.payedAmount_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNumber = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.totalAmountPayed_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.subTotal_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tip_lbl = new System.Windows.Forms.Label();
            this.serviceVAT_lbl = new System.Windows.Forms.Label();
            this.alcholVAT_lbl = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.itemPrice = new System.Windows.Forms.ColumnHeader();
            this.itemQuantity = new System.Windows.Forms.ColumnHeader();
            this.cashPayment_btn = new System.Windows.Forms.Button();
            this.debitCreditPayment_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOrderDetails
            // 
            this.listViewOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.itemPrice,
            this.itemQuantity});
            this.listViewOrderDetails.HideSelection = false;
            this.listViewOrderDetails.Location = new System.Drawing.Point(66, 95);
            this.listViewOrderDetails.Name = "listViewOrderDetails";
            this.listViewOrderDetails.Size = new System.Drawing.Size(407, 338);
            this.listViewOrderDetails.TabIndex = 0;
            this.listViewOrderDetails.UseCompatibleStateImageBehavior = false;
            this.listViewOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // payedAmount_btn
            // 
            this.payedAmount_btn.Location = new System.Drawing.Point(396, 438);
            this.payedAmount_btn.Name = "payedAmount_btn";
            this.payedAmount_btn.Size = new System.Drawing.Size(94, 29);
            this.payedAmount_btn.TabIndex = 1;
            this.payedAmount_btn.Text = "Enter";
            this.payedAmount_btn.UseVisualStyleBackColor = true;
            // 
            // payedAmount_txtbox
            // 
            this.payedAmount_txtbox.Location = new System.Drawing.Point(211, 439);
            this.payedAmount_txtbox.Name = "payedAmount_txtbox";
            this.payedAmount_txtbox.Size = new System.Drawing.Size(170, 27);
            this.payedAmount_txtbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount to be Payed:";
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSize = true;
            this.tableNumber.Location = new System.Drawing.Point(12, 9);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(57, 20);
            this.tableNumber.TabIndex = 4;
            this.tableNumber.Text = "Table X";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(429, 9);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(88, 20);
            this.employeeName.TabIndex = 5;
            this.employeeName.Text = "Employee X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 631);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total:";
            // 
            // totalAmountPayed_lbl
            // 
            this.totalAmountPayed_lbl.AutoSize = true;
            this.totalAmountPayed_lbl.Location = new System.Drawing.Point(394, 631);
            this.totalAmountPayed_lbl.Name = "totalAmountPayed_lbl";
            this.totalAmountPayed_lbl.Size = new System.Drawing.Size(52, 20);
            this.totalAmountPayed_lbl.TabIndex = 16;
            this.totalAmountPayed_lbl.Text = "$00.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subTotal_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tip_lbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.serviceVAT_lbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.alcholVAT_lbl, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 473);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 145);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub-Total:";
            // 
            // subTotal_lbl
            // 
            this.subTotal_lbl.AutoSize = true;
            this.subTotal_lbl.Location = new System.Drawing.Point(228, 0);
            this.subTotal_lbl.Name = "subTotal_lbl";
            this.subTotal_lbl.Size = new System.Drawing.Size(52, 20);
            this.subTotal_lbl.TabIndex = 1;
            this.subTotal_lbl.Text = "$00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "VAT(6%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Alc. VAT(21%)";
            // 
            // tip_lbl
            // 
            this.tip_lbl.AutoSize = true;
            this.tip_lbl.Location = new System.Drawing.Point(228, 36);
            this.tip_lbl.Name = "tip_lbl";
            this.tip_lbl.Size = new System.Drawing.Size(52, 20);
            this.tip_lbl.TabIndex = 5;
            this.tip_lbl.Text = "$00.00";
            // 
            // serviceVAT_lbl
            // 
            this.serviceVAT_lbl.AutoSize = true;
            this.serviceVAT_lbl.Location = new System.Drawing.Point(228, 72);
            this.serviceVAT_lbl.Name = "serviceVAT_lbl";
            this.serviceVAT_lbl.Size = new System.Drawing.Size(52, 20);
            this.serviceVAT_lbl.TabIndex = 6;
            this.serviceVAT_lbl.Text = "$00.00";
            // 
            // alcholVAT_lbl
            // 
            this.alcholVAT_lbl.AutoSize = true;
            this.alcholVAT_lbl.Location = new System.Drawing.Point(228, 108);
            this.alcholVAT_lbl.Name = "alcholVAT_lbl";
            this.alcholVAT_lbl.Size = new System.Drawing.Size(52, 20);
            this.alcholVAT_lbl.TabIndex = 7;
            this.alcholVAT_lbl.Text = "$00.00";
            // 
            // itemName
            // 
            this.itemName.Text = "Item";
            this.itemName.Width = 200;
            // 
            // itemPrice
            // 
            this.itemPrice.Text = "Price";
            // 
            // itemQuantity
            // 
            this.itemQuantity.Text = "Quantity";
            this.itemQuantity.Width = 100;
            // 
            // cashPayment_btn
            // 
            this.cashPayment_btn.Location = new System.Drawing.Point(95, 667);
            this.cashPayment_btn.Name = "cashPayment_btn";
            this.cashPayment_btn.Size = new System.Drawing.Size(133, 29);
            this.cashPayment_btn.TabIndex = 19;
            this.cashPayment_btn.Text = "Pay with Cash";
            this.cashPayment_btn.UseVisualStyleBackColor = true;
            // 
            // debitCreditPayment_btn
            // 
            this.debitCreditPayment_btn.Location = new System.Drawing.Point(287, 667);
            this.debitCreditPayment_btn.Name = "debitCreditPayment_btn";
            this.debitCreditPayment_btn.Size = new System.Drawing.Size(159, 29);
            this.debitCreditPayment_btn.TabIndex = 20;
            this.debitCreditPayment_btn.Text = "Pay with Debit/Credit";
            this.debitCreditPayment_btn.UseVisualStyleBackColor = true;
            // 
            // PaymentOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 713);
            this.Controls.Add(this.debitCreditPayment_btn);
            this.Controls.Add(this.cashPayment_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.totalAmountPayed_lbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payedAmount_txtbox);
            this.Controls.Add(this.payedAmount_btn);
            this.Controls.Add(this.listViewOrderDetails);
            this.Name = "PaymentOrderDetails";
            this.Text = "PaymentOrderDetails";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrderDetails;
        private System.Windows.Forms.Button payedAmount_btn;
        private System.Windows.Forms.TextBox payedAmount_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tableNumber;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalAmountPayed_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subTotal_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tip_lbl;
        private System.Windows.Forms.Label serviceVAT_lbl;
        private System.Windows.Forms.Label alcholVAT_lbl;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.ColumnHeader itemQuantity;
        private System.Windows.Forms.Button cashPayment_btn;
        private System.Windows.Forms.Button debitCreditPayment_btn;
    }
}