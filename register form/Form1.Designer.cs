namespace register_form
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
            button1 = new Button();
            UsernametextBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            PasswordtextBox2 = new TextBox();
            label3 = new Label();
            EmailtextBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(126, 260);
            button1.Name = "button1";
            button1.Size = new Size(126, 41);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UsernametextBox1
            // 
            UsernametextBox1.Location = new Point(126, 58);
            UsernametextBox1.Name = "UsernametextBox1";
            UsernametextBox1.Size = new Size(126, 23);
            UsernametextBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 27);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 173);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // PasswordtextBox2
            // 
            PasswordtextBox2.Location = new Point(126, 204);
            PasswordtextBox2.Name = "PasswordtextBox2";
            PasswordtextBox2.Size = new Size(126, 23);
            PasswordtextBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 99);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // EmailtextBox3
            // 
            EmailtextBox3.Location = new Point(126, 130);
            EmailtextBox3.Name = "EmailtextBox3";
            EmailtextBox3.Size = new Size(126, 23);
            EmailtextBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 331);
            Controls.Add(label3);
            Controls.Add(EmailtextBox3);
            Controls.Add(label1);
            Controls.Add(PasswordtextBox2);
            Controls.Add(label2);
            Controls.Add(UsernametextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox UsernametextBox1;
        private Label label2;
        private Label label1;
        private TextBox PasswordtextBox2;
        private Label label3;
        private TextBox EmailtextBox3;
    }
}
