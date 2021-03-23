
namespace demoGym
{
    partial class registrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
            this.backPanel = new System.Windows.Forms.Panel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.backPanel.Controls.Add(this.firstNameLabel);
            this.backPanel.Controls.Add(this.lastNameLabel);
            this.backPanel.Controls.Add(this.backLabel);
            this.backPanel.Controls.Add(this.firstNameTextBox);
            this.backPanel.Controls.Add(this.lastNameTextBox);
            this.backPanel.Controls.Add(this.addButton);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(800, 450);
            this.backPanel.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(251, 207);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(46, 19);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "Имя:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(251, 133);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(83, 19);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.backLabel.Location = new System.Drawing.Point(12, 9);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(61, 19);
            this.backLabel.TabIndex = 3;
            this.backLabel.Text = "< Назад";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(255, 229);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(313, 39);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.Location = new System.Drawing.Point(255, 155);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(313, 39);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(211)))), ((int)(((byte)(245)))));
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(316, 350);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 61);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
    }
}