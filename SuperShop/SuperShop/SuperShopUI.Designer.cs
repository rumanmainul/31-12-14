namespace SuperShop
{
    partial class SuperShopUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.add_Item_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.ShowDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Name:";
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Location = new System.Drawing.Point(138, 48);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.shopNameTextBox.TabIndex = 1;
            // 
            // add_Item_Button
            // 
            this.add_Item_Button.Location = new System.Drawing.Point(310, 287);
            this.add_Item_Button.Name = "add_Item_Button";
            this.add_Item_Button.Size = new System.Drawing.Size(75, 23);
            this.add_Item_Button.TabIndex = 2;
            this.add_Item_Button.Text = "Add Item";
            this.add_Item_Button.UseVisualStyleBackColor = true;
            this.add_Item_Button.Click += new System.EventHandler(this.add_Item_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Location = new System.Drawing.Point(138, 90);
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(247, 20);
            this.shopAddressTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product ID:";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(138, 207);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(247, 20);
            this.productIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(138, 249);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(247, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(310, 135);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(75, 23);
            this.save_Button.TabIndex = 2;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.Location = new System.Drawing.Point(196, 341);
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Size = new System.Drawing.Size(120, 23);
            this.ShowDetailsButton.TabIndex = 3;
            this.ShowDetailsButton.Text = "Show Details";
            this.ShowDetailsButton.UseVisualStyleBackColor = true;
            this.ShowDetailsButton.Click += new System.EventHandler(this.ShowDetailsButton_Click);
            // 
            // SuperShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 388);
            this.Controls.Add(this.ShowDetailsButton);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.add_Item_Button);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shopAddressTextBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shopNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SuperShopUI";
            this.Text = "SuperShopUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.Button add_Item_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button ShowDetailsButton;
    }
}

