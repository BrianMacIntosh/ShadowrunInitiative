namespace ShadowrunInitiative
{
    partial class DelayAction
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.characterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.beforeRadioButton = new System.Windows.Forms.RadioButton();
            this.withRadioButton = new System.Windows.Forms.RadioButton();
            this.afterRadioButton = new System.Windows.Forms.RadioButton();
            this.charactersListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(16, 238);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(97, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Location = new System.Drawing.Point(13, 13);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(158, 13);
            this.characterLabel.TabIndex = 6;
            this.characterLabel.Text = "CHARNAME delays action until:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.afterRadioButton);
            this.panel1.Controls.Add(this.withRadioButton);
            this.panel1.Controls.Add(this.beforeRadioButton);
            this.panel1.Location = new System.Drawing.Point(13, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 79);
            this.panel1.TabIndex = 7;
            // 
            // beforeRadioButton
            // 
            this.beforeRadioButton.AutoSize = true;
            this.beforeRadioButton.Location = new System.Drawing.Point(4, 4);
            this.beforeRadioButton.Name = "beforeRadioButton";
            this.beforeRadioButton.Size = new System.Drawing.Size(56, 17);
            this.beforeRadioButton.TabIndex = 0;
            this.beforeRadioButton.TabStop = true;
            this.beforeRadioButton.Text = "Before";
            this.beforeRadioButton.UseVisualStyleBackColor = true;
            // 
            // withRadioButton
            // 
            this.withRadioButton.AutoSize = true;
            this.withRadioButton.Location = new System.Drawing.Point(4, 28);
            this.withRadioButton.Name = "withRadioButton";
            this.withRadioButton.Size = new System.Drawing.Size(47, 17);
            this.withRadioButton.TabIndex = 1;
            this.withRadioButton.TabStop = true;
            this.withRadioButton.Text = "With";
            this.withRadioButton.UseVisualStyleBackColor = true;
            // 
            // afterRadioButton
            // 
            this.afterRadioButton.AutoSize = true;
            this.afterRadioButton.Location = new System.Drawing.Point(4, 52);
            this.afterRadioButton.Name = "afterRadioButton";
            this.afterRadioButton.Size = new System.Drawing.Size(47, 17);
            this.afterRadioButton.TabIndex = 2;
            this.afterRadioButton.TabStop = true;
            this.afterRadioButton.Text = "After";
            this.afterRadioButton.UseVisualStyleBackColor = true;
            // 
            // charactersListBox
            // 
            this.charactersListBox.FormattingEnabled = true;
            this.charactersListBox.Location = new System.Drawing.Point(13, 116);
            this.charactersListBox.Name = "charactersListBox";
            this.charactersListBox.Size = new System.Drawing.Size(159, 108);
            this.charactersListBox.TabIndex = 8;
            // 
            // DelayAction
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(184, 273);
            this.Controls.Add(this.charactersListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelayAction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Delay Action";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton afterRadioButton;
        private System.Windows.Forms.RadioButton withRadioButton;
        private System.Windows.Forms.RadioButton beforeRadioButton;
        private System.Windows.Forms.ListBox charactersListBox;
    }
}