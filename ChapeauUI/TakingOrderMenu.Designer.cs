
namespace ChapeauUI
{
    partial class TakingOrderMenu
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
            this.Backbtn = new System.Windows.Forms.Button();
            this.MenuEntreesListView = new System.Windows.Forms.ListView();
            this.MenuMainListView = new System.Windows.Forms.ListView();
            this.MenuDessertListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(12, 659);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(145, 42);
            this.Backbtn.TabIndex = 6;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // MenuEntreesListView
            // 
            this.MenuEntreesListView.HideSelection = false;
            this.MenuEntreesListView.Location = new System.Drawing.Point(38, 52);
            this.MenuEntreesListView.Name = "MenuEntreesListView";
            this.MenuEntreesListView.Size = new System.Drawing.Size(446, 158);
            this.MenuEntreesListView.TabIndex = 7;
            this.MenuEntreesListView.UseCompatibleStateImageBehavior = false;
            this.MenuEntreesListView.SelectedIndexChanged += new System.EventHandler(this.MenuEntreesListView_SelectedIndexChanged);
            // 
            // MenuMainListView
            // 
            this.MenuMainListView.HideSelection = false;
            this.MenuMainListView.Location = new System.Drawing.Point(38, 274);
            this.MenuMainListView.Name = "MenuMainListView";
            this.MenuMainListView.Size = new System.Drawing.Size(446, 150);
            this.MenuMainListView.TabIndex = 8;
            this.MenuMainListView.UseCompatibleStateImageBehavior = false;
            // 
            // MenuDessertListView
            // 
            this.MenuDessertListView.HideSelection = false;
            this.MenuDessertListView.Location = new System.Drawing.Point(38, 488);
            this.MenuDessertListView.Name = "MenuDessertListView";
            this.MenuDessertListView.Size = new System.Drawing.Size(446, 136);
            this.MenuDessertListView.TabIndex = 9;
            this.MenuDessertListView.UseCompatibleStateImageBehavior = false;
            // 
            // TakingOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 713);
            this.Controls.Add(this.MenuDessertListView);
            this.Controls.Add(this.MenuMainListView);
            this.Controls.Add(this.MenuEntreesListView);
            this.Controls.Add(this.Backbtn);
            this.Name = "TakingOrderMenu";
            this.Text = "TakingOrderMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.ListView MenuEntreesListView;
        private System.Windows.Forms.ListView MenuMainListView;
        private System.Windows.Forms.ListView MenuDessertListView;
    }
}