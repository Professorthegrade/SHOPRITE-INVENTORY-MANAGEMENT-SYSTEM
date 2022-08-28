namespace ShopRite
{
    partial class StaffPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.addtocart = new System.Windows.Forms.Button();
            this.preView = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.DataGridView();
            this.namee = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "FIND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "BARCODE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "NUMBER:";
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeText.Location = new System.Drawing.Point(645, 31);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(135, 33);
            this.barcodeText.TabIndex = 4;
            this.barcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityText
            // 
            this.quantityText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.Location = new System.Drawing.Point(645, 89);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(135, 33);
            this.quantityText.TabIndex = 5;
            this.quantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addtocart
            // 
            this.addtocart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocart.Location = new System.Drawing.Point(513, 317);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(267, 56);
            this.addtocart.TabIndex = 6;
            this.addtocart.Text = "ADD-TO-CART";
            this.addtocart.UseVisualStyleBackColor = true;
            // 
            // preView
            // 
            this.preView.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preView.Location = new System.Drawing.Point(513, 240);
            this.preView.Name = "preView";
            this.preView.Size = new System.Drawing.Size(267, 56);
            this.preView.TabIndex = 7;
            this.preView.Text = "PREVIEW";
            this.preView.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(284, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 54);
            this.name.TabIndex = 10;
            // 
            // search
            // 
            this.search.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search.Location = new System.Drawing.Point(12, 114);
            this.search.Name = "search";
            this.search.RowHeadersWidth = 51;
            this.search.RowTemplate.Height = 24;
            this.search.Size = new System.Drawing.Size(484, 282);
            this.search.TabIndex = 11;
            // 
            // namee
            // 
            this.namee.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namee.Location = new System.Drawing.Point(645, 135);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(135, 33);
            this.namee.TabIndex = 13;
            this.namee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(550, 139);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(63, 22);
            this.Product.TabIndex = 12;
            this.Product.Text = "ITEM:";
            // 
            // StaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::ShopRite.Properties.Resources.shoprite_3;
            this.ClientSize = new System.Drawing.Size(833, 408);
            this.Controls.Add(this.namee);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.search);
            this.Controls.Add(this.name);
            this.Controls.Add(this.preView);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.barcodeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "StaffPage";
            this.Text = "Home page ";
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.Button preView;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView search;
        private System.Windows.Forms.TextBox namee;
        private System.Windows.Forms.Label Product;
    }
}