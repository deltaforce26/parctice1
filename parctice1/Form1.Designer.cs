namespace parctice1
{
    partial class Form1
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
            label_usename = new Label();
            textBox_userName = new TextBox();
            textBox_passord = new TextBox();
            label_password = new Label();
            button_login = new Button();
            SuspendLayout();
            // 
            // label_usename
            // 
            label_usename.AutoSize = true;
            label_usename.Location = new Point(297, 82);
            label_usename.Name = "label_usename";
            label_usename.Size = new Size(77, 20);
            label_usename.TabIndex = 0;
            label_usename.Text = "user name";
            // 
            // textBox_userName
            // 
            textBox_userName.Location = new Point(415, 82);
            textBox_userName.Name = "textBox_userName";
            textBox_userName.Size = new Size(125, 27);
            textBox_userName.TabIndex = 1;
            // 
            // textBox_passord
            // 
            textBox_passord.Location = new Point(415, 166);
            textBox_passord.Name = "textBox_passord";
            textBox_passord.Size = new Size(125, 27);
            textBox_passord.TabIndex = 2;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(297, 173);
            label_password.Name = "label_password";
            label_password.Size = new Size(72, 20);
            label_password.TabIndex = 3;
            label_password.Text = "password";
            // 
            // button_login
            // 
            button_login.Location = new Point(427, 255);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 4;
            button_login.Text = "login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(label_password);
            Controls.Add(textBox_passord);
            Controls.Add(textBox_userName);
            Controls.Add(label_usename);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_usename;
        private TextBox textBox_userName;
        private TextBox textBox_passord;
        private Label label_password;
        private Button button_login;
    }
}
