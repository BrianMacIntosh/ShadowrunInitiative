namespace ShadowrunInitiative
{
    partial class MatrixLevelPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hotsimRadioButton = new System.Windows.Forms.RadioButton();
            this.coldsimRadioButton = new System.Windows.Forms.RadioButton();
            this.arRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.hotsimRadioButton);
            this.groupBox2.Controls.Add(this.coldsimRadioButton);
            this.groupBox2.Controls.Add(this.arRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 66);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrix Level";
            // 
            // hotsimRadioButton
            // 
            this.hotsimRadioButton.AutoSize = true;
            this.hotsimRadioButton.Location = new System.Drawing.Point(7, 43);
            this.hotsimRadioButton.Name = "hotsimRadioButton";
            this.hotsimRadioButton.Size = new System.Drawing.Size(62, 17);
            this.hotsimRadioButton.TabIndex = 2;
            this.hotsimRadioButton.TabStop = true;
            this.hotsimRadioButton.Text = "Hot Sim";
            this.hotsimRadioButton.UseVisualStyleBackColor = true;
            this.hotsimRadioButton.CheckedChanged += new System.EventHandler(this.matrixLevelChanged);
            // 
            // coldsimRadioButton
            // 
            this.coldsimRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coldsimRadioButton.AutoSize = true;
            this.coldsimRadioButton.Location = new System.Drawing.Point(74, 20);
            this.coldsimRadioButton.Name = "coldsimRadioButton";
            this.coldsimRadioButton.Size = new System.Drawing.Size(66, 17);
            this.coldsimRadioButton.TabIndex = 1;
            this.coldsimRadioButton.TabStop = true;
            this.coldsimRadioButton.Text = "Cold Sim";
            this.coldsimRadioButton.UseVisualStyleBackColor = true;
            this.coldsimRadioButton.CheckedChanged += new System.EventHandler(this.matrixLevelChanged);
            // 
            // arRadioButton
            // 
            this.arRadioButton.AutoSize = true;
            this.arRadioButton.Location = new System.Drawing.Point(7, 20);
            this.arRadioButton.Name = "arRadioButton";
            this.arRadioButton.Size = new System.Drawing.Size(40, 17);
            this.arRadioButton.TabIndex = 0;
            this.arRadioButton.TabStop = true;
            this.arRadioButton.Text = "AR";
            this.arRadioButton.UseVisualStyleBackColor = true;
            this.arRadioButton.CheckedChanged += new System.EventHandler(this.matrixLevelChanged);
            // 
            // MatrixLevelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "MatrixLevelPanel";
            this.Size = new System.Drawing.Size(150, 66);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton hotsimRadioButton;
        private System.Windows.Forms.RadioButton coldsimRadioButton;
        private System.Windows.Forms.RadioButton arRadioButton;
    }
}
