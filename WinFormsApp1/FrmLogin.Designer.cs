namespace WinFormsApp1
{
    partial class FrmLogin
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
            txtName = new TextBox();
            txtPassword = new TextBox();
            lblName = new Label();
            lblPassword = new Label();
            btnEnter = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(278, 169);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(278, 349);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(258, 27);
            txtPassword.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(115, 176);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 2;
            lblName.Text = "用户名";
            lblName.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(115, 349);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(51, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "密   码";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(278, 462);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 60);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "登录";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(442, 462);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 60);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "取消";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(782, 553);
            Controls.Add(btnQuit);
            Controls.Add(btnEnter);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "用户登录";
            Load += Form1_Load;
            KeyDown += FrmLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPassword;
        private Label lblName;
        private Label lblPassword;
        private Button btnEnter;
        private Button btnQuit;
    }
}