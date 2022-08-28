namespace ShopRite
{
    partial class DeleteStaff
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
            this.surname = new System.Windows.Forms.TextBox();
            this.staffUsername = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Adminuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adminpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removeStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.White;
            this.surname.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(358, 8);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(252, 63);
            this.surname.TabIndex = 3;
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(20, 21);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(219, 39);
            this.staffUsername.TabIndex = 2;
            this.staffUsername.Text = "LAST NAME:";
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.White;
            this.firstname.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(358, 77);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(252, 63);
            this.firstname.TabIndex = 5;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "FIRST NAME:";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(358, 153);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(252, 59);
            this.username.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "USERNAME:";
            // 
            // Adminuser
            // 
            this.Adminuser.BackColor = System.Drawing.Color.White;
            this.Adminuser.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminuser.Location = new System.Drawing.Point(358, 218);
            this.Adminuser.Name = "Adminuser";
            this.Adminuser.Size = new System.Drawing.Size(252, 72);
            this.Adminuser.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "ADMIN USERNAME:";
            // 
            // Adminpass
            // 
            this.Adminpass.BackColor = System.Drawing.Color.White;
            this.Adminpass.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminpass.Location = new System.Drawing.Point(358, 296);
            this.Adminpass.Name = "Adminpass";
            this.Adminpass.PasswordChar = '#';
            this.Adminpass.Size = new System.Drawing.Size(252, 72);
            this.Adminpass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "ADMIN PASSWORD:";
            // 
            // removeStaff
            // 
            this.removeStaff.BackColor = System.Drawing.Color.Silver;
            this.removeStaff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStaff.Location = new System.Drawing.Point(391, 384);
            this.removeStaff.Name = "removeStaff";
            this.removeStaff.Size = new System.Drawing.Size(185, 48);
            this.removeStaff.TabIndex = 12;
            this.removeStaff.Text = "DEL STAFF";
            this.removeStaff.UseVisualStyleBackColor = false;
            this.removeStaff.Click += new System.EventHandler(this.removeStaff_Click);
            // 
            // DeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::ShopRite.Properties.Resources.shoprite_6;
            this.ClientSize = new System.Drawing.Size(622, 456);
            this.Controls.Add(this.removeStaff);
            this.Controls.Add(this.Adminpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adminuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.staffUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteStaff";
            this.Text = "DeleteStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Adminuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adminpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeStaff;
    }
}