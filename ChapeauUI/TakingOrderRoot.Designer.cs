
namespace ChapeauUI
{
    partial class TakingOrderRoot
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
            this.LunchMenubtn = new System.Windows.Forms.Button();
            this.DinnerMenubtn = new System.Windows.Forms.Button();
            this.EmployeeNamelbl = new System.Windows.Forms.Label();
            this.TableNumberlbl = new System.Windows.Forms.Label();
            this.DrinkMenubtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.SeeOrderbtn = new System.Windows.Forms.Button();
            this.NewOrderItemsCountlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LunchMenubtn
            // 
            this.LunchMenubtn.Location = new System.Drawing.Point(132, 201);
            this.LunchMenubtn.Name = "LunchMenubtn";
            this.LunchMenubtn.Size = new System.Drawing.Size(229, 73);
            this.LunchMenubtn.TabIndex = 0;
            this.LunchMenubtn.Text = "Lunch Menu";
            this.LunchMenubtn.UseVisualStyleBackColor = true;
            this.LunchMenubtn.Click += new System.EventHandler(this.LunchMenubtn_Click);
            // 
            // DinnerMenubtn
            // 
            this.DinnerMenubtn.Location = new System.Drawing.Point(132, 303);
            this.DinnerMenubtn.Name = "DinnerMenubtn";
            this.DinnerMenubtn.Size = new System.Drawing.Size(229, 77);
            this.DinnerMenubtn.TabIndex = 1;
            this.DinnerMenubtn.Text = "Dinner Menu";
            this.DinnerMenubtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeNamelbl
            // 
            this.EmployeeNamelbl.AutoSize = true;
            this.EmployeeNamelbl.Location = new System.Drawing.Point(409, 3);
            this.EmployeeNamelbl.Name = "EmployeeNamelbl";
            this.EmployeeNamelbl.Size = new System.Drawing.Size(119, 20);
            this.EmployeeNamelbl.TabIndex = 2;
            this.EmployeeNamelbl.Text = "Employee Name";
            // 
            // TableNumberlbl
            // 
            this.TableNumberlbl.AutoSize = true;
            this.TableNumberlbl.Location = new System.Drawing.Point(12, 3);
            this.TableNumberlbl.Name = "TableNumberlbl";
            this.TableNumberlbl.Size = new System.Drawing.Size(53, 20);
            this.TableNumberlbl.TabIndex = 3;
            this.TableNumberlbl.Text = "TableX";
            // 
            // DrinkMenubtn
            // 
            this.DrinkMenubtn.Location = new System.Drawing.Point(132, 418);
            this.DrinkMenubtn.Name = "DrinkMenubtn";
            this.DrinkMenubtn.Size = new System.Drawing.Size(229, 79);
            this.DrinkMenubtn.TabIndex = 4;
            this.DrinkMenubtn.Text = "Drink Menu";
            this.DrinkMenubtn.UseVisualStyleBackColor = true;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(12, 659);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(145, 42);
            this.Backbtn.TabIndex = 5;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // SeeOrderbtn
            // 
            this.SeeOrderbtn.Location = new System.Drawing.Point(132, 92);
            this.SeeOrderbtn.Name = "SeeOrderbtn";
            this.SeeOrderbtn.Size = new System.Drawing.Size(229, 52);
            this.SeeOrderbtn.TabIndex = 6;
            this.SeeOrderbtn.Text = "See TableX Order";
            this.SeeOrderbtn.UseVisualStyleBackColor = true;
            // 
            // NewOrderItemsCountlbl
            // 
            this.NewOrderItemsCountlbl.AutoSize = true;
            this.NewOrderItemsCountlbl.Location = new System.Drawing.Point(415, 37);
            this.NewOrderItemsCountlbl.Name = "NewOrderItemsCountlbl";
            this.NewOrderItemsCountlbl.Size = new System.Drawing.Size(89, 20);
            this.NewOrderItemsCountlbl.TabIndex = 7;
            this.NewOrderItemsCountlbl.Text = "X new items";
            // 
            // TakingOrderRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 713);
            this.Controls.Add(this.NewOrderItemsCountlbl);
            this.Controls.Add(this.SeeOrderbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.DrinkMenubtn);
            this.Controls.Add(this.TableNumberlbl);
            this.Controls.Add(this.EmployeeNamelbl);
            this.Controls.Add(this.DinnerMenubtn);
            this.Controls.Add(this.LunchMenubtn);
            this.Name = "TakingOrderRoot";
            this.Text = "Menus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LunchMenubtn;
        private System.Windows.Forms.Button DinnerMenubtn;
        private System.Windows.Forms.Label EmployeeNamelbl;
        private System.Windows.Forms.Label TableNumberlbl;
        private System.Windows.Forms.Button DrinkMenubtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button SeeOrderbtn;
        private System.Windows.Forms.Label NewOrderItemsCountlbl;
    }
}