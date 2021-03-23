
namespace demoGym
{
    partial class startForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.backPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.backPanel.Controls.Add(this.exitButton);
            this.backPanel.Controls.Add(this.dataButton);
            this.backPanel.Controls.Add(this.registrationButton);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(800, 450);
            this.backPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(211)))), ((int)(((byte)(245)))));
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(234, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(344, 65);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выйти из приложения";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataButton
            // 
            this.dataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataButton.AutoSize = true;
            this.dataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(211)))), ((int)(((byte)(245)))));
            this.dataButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataButton.ForeColor = System.Drawing.Color.White;
            this.dataButton.Location = new System.Drawing.Point(234, 208);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(344, 65);
            this.dataButton.TabIndex = 1;
            this.dataButton.Text = "Клиентская база";
            this.dataButton.UseVisualStyleBackColor = false;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationButton.AutoSize = true;
            this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(211)))), ((int)(((byte)(245)))));
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.Location = new System.Drawing.Point(234, 119);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(344, 65);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Регистрация клиента";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome GymApp";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button exitButton;
    }
}

