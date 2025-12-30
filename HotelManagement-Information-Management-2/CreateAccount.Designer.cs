
namespace HotelManagement_Information_Management_2
{
    partial class CreateAccount
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createBtn = new FontAwesome.Sharp.IconButton();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.fdaw = new System.Windows.Forms.Label();
            this.emergencyTxt = new System.Windows.Forms.TextBox();
            this.dad = new System.Windows.Forms.Label();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(267, 91);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(116, 20);
            this.usernameTxt.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // createBtn
            // 
            this.createBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.createBtn.IconColor = System.Drawing.Color.Black;
            this.createBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createBtn.Location = new System.Drawing.Point(228, 295);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(137, 48);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(267, 143);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(116, 20);
            this.passwordTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // contactTxt
            // 
            this.contactTxt.Location = new System.Drawing.Point(267, 189);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(116, 20);
            this.contactTxt.TabIndex = 7;
            // 
            // fdaw
            // 
            this.fdaw.AutoSize = true;
            this.fdaw.Location = new System.Drawing.Point(177, 189);
            this.fdaw.Name = "fdaw";
            this.fdaw.Size = new System.Drawing.Size(84, 13);
            this.fdaw.TabIndex = 6;
            this.fdaw.Text = "Contact Number";
            // 
            // emergencyTxt
            // 
            this.emergencyTxt.Location = new System.Drawing.Point(267, 230);
            this.emergencyTxt.Name = "emergencyTxt";
            this.emergencyTxt.Size = new System.Drawing.Size(116, 20);
            this.emergencyTxt.TabIndex = 9;
            // 
            // dad
            // 
            this.dad.AutoSize = true;
            this.dad.Location = new System.Drawing.Point(161, 230);
            this.dad.Name = "dad";
            this.dad.Size = new System.Drawing.Size(100, 13);
            this.dad.TabIndex = 8;
            this.dad.Text = "Emergency Contact";
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Location = new System.Drawing.Point(267, 46);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(116, 20);
            this.fullnameTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full Name";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.fullnameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emergencyTxt);
            this.Controls.Add(this.dad);
            this.Controls.Add(this.contactTxt);
            this.Controls.Add(this.fdaw);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private FontAwesome.Sharp.IconButton createBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.Label fdaw;
        private System.Windows.Forms.TextBox emergencyTxt;
        private System.Windows.Forms.Label dad;
        private System.Windows.Forms.TextBox fullnameTxt;
        private System.Windows.Forms.Label label3;
    }
}