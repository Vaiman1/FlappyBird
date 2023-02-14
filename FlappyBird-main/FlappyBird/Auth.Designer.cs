namespace FlappyBird
{
    partial class AucForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterAuthData = new System.Windows.Forms.Button();
            this.PasswordL1 = new System.Windows.Forms.MaskedTextBox();
            this.LoginL1 = new System.Windows.Forms.MaskedTextBox();
            this.DesignPanelHead = new System.Windows.Forms.Label();
            this.ShowPasswordCheck = new System.Windows.Forms.CheckBox();
            this.DesignLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterAuthData
            // 
            this.EnterAuthData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EnterAuthData.BackColor = System.Drawing.Color.DarkGray;
            this.EnterAuthData.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterAuthData.Location = new System.Drawing.Point(117, 282);
            this.EnterAuthData.Name = "EnterAuthData";
            this.EnterAuthData.Size = new System.Drawing.Size(120, 47);
            this.EnterAuthData.TabIndex = 1;
            this.EnterAuthData.Text = "Further";
            this.EnterAuthData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EnterAuthData.UseVisualStyleBackColor = false;
            this.EnterAuthData.Click += new System.EventHandler(this.EnterAuthData_Click);
            this.EnterAuthData.MouseEnter += new System.EventHandler(this.EnterAuthData_MouseEnter);
            this.EnterAuthData.MouseLeave += new System.EventHandler(this.EnterAuthData_MouseLeave);
            // 
            // PasswordL1
            // 
            this.PasswordL1.BackColor = System.Drawing.Color.DarkGray;
            this.PasswordL1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordL1.Location = new System.Drawing.Point(27, 189);
            this.PasswordL1.Name = "PasswordL1";
            this.PasswordL1.PromptChar = ' ';
            this.PasswordL1.Size = new System.Drawing.Size(192, 33);
            this.PasswordL1.TabIndex = 2;
            this.PasswordL1.UseSystemPasswordChar = true;
            // 
            // LoginL1
            // 
            this.LoginL1.BackColor = System.Drawing.Color.DarkGray;
            this.LoginL1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginL1.Location = new System.Drawing.Point(27, 120);
            this.LoginL1.Name = "LoginL1";
            this.LoginL1.PromptChar = ' ';
            this.LoginL1.Size = new System.Drawing.Size(192, 33);
            this.LoginL1.TabIndex = 1;
            // 
            // DesignPanelHead
            // 
            this.DesignPanelHead.AutoSize = true;
            this.DesignPanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DesignPanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.DesignPanelHead.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesignPanelHead.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.DesignPanelHead.Location = new System.Drawing.Point(0, 0);
            this.DesignPanelHead.Name = "DesignPanelHead";
            this.DesignPanelHead.Size = new System.Drawing.Size(367, 65);
            this.DesignPanelHead.TabIndex = 0;
            this.DesignPanelHead.Text = "Authentication";
            // 
            // ShowPasswordCheck
            // 
            this.ShowPasswordCheck.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowPasswordCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShowPasswordCheck.Font = new System.Drawing.Font("Arial Narrow", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPasswordCheck.ForeColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheck.Location = new System.Drawing.Point(212, 240);
            this.ShowPasswordCheck.Name = "ShowPasswordCheck";
            this.ShowPasswordCheck.Size = new System.Drawing.Size(25, 36);
            this.ShowPasswordCheck.TabIndex = 3;
            this.ShowPasswordCheck.UseVisualStyleBackColor = false;
            this.ShowPasswordCheck.CheckedChanged += new System.EventHandler(this.ShowPasswordCheck_CheckedChanged);
            // 
            // DesignLabel2
            // 
            this.DesignLabel2.AutoSize = true;
            this.DesignLabel2.BackColor = System.Drawing.Color.Transparent;
            this.DesignLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.DesignLabel2.Location = new System.Drawing.Point(228, 246);
            this.DesignLabel2.Name = "DesignLabel2";
            this.DesignLabel2.Size = new System.Drawing.Size(124, 21);
            this.DesignLabel2.TabIndex = 4;
            this.DesignLabel2.Text = "Show password";
            // 
            // AucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(364, 341);
            this.Controls.Add(this.DesignLabel2);
            this.Controls.Add(this.ShowPasswordCheck);
            this.Controls.Add(this.DesignPanelHead);
            this.Controls.Add(this.LoginL1);
            this.Controls.Add(this.PasswordL1);
            this.Controls.Add(this.EnterAuthData);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AucForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AucForm_FormClosed);
            this.Load += new System.EventHandler(this.AucForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnterAuthData;
        private System.Windows.Forms.MaskedTextBox PasswordL1;
        private System.Windows.Forms.MaskedTextBox LoginL1;
        private System.Windows.Forms.Label DesignPanelHead;
        private System.Windows.Forms.CheckBox ShowPasswordCheck;
        private System.Windows.Forms.Label DesignLabel2;
    }
}

