namespace ShadowrunInitiative
{
    partial class CombatSituationPanel
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
            this.matrixRadioButton = new System.Windows.Forms.RadioButton();
            this.astralRadioButton = new System.Windows.Forms.RadioButton();
            this.physicalRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.matrixRadioButton);
            this.groupBox2.Controls.Add(this.astralRadioButton);
            this.groupBox2.Controls.Add(this.physicalRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 66);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combat Situation";
            // 
            // matrixRadioButton
            // 
            this.matrixRadioButton.AutoSize = true;
            this.matrixRadioButton.Location = new System.Drawing.Point(7, 43);
            this.matrixRadioButton.Name = "matrixRadioButton";
            this.matrixRadioButton.Size = new System.Drawing.Size(53, 17);
            this.matrixRadioButton.TabIndex = 2;
            this.matrixRadioButton.TabStop = true;
            this.matrixRadioButton.Text = "Matrix";
            this.matrixRadioButton.UseVisualStyleBackColor = true;
            this.matrixRadioButton.CheckedChanged += new System.EventHandler(this.combatSituationChanged);
            // 
            // astralRadioButton
            // 
            this.astralRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.astralRadioButton.AutoSize = true;
            this.astralRadioButton.Location = new System.Drawing.Point(77, 19);
            this.astralRadioButton.Name = "astralRadioButton";
            this.astralRadioButton.Size = new System.Drawing.Size(51, 17);
            this.astralRadioButton.TabIndex = 1;
            this.astralRadioButton.TabStop = true;
            this.astralRadioButton.Text = "Astral";
            this.astralRadioButton.UseVisualStyleBackColor = true;
            this.astralRadioButton.CheckedChanged += new System.EventHandler(this.combatSituationChanged);
            // 
            // physicalRadioButton
            // 
            this.physicalRadioButton.AutoSize = true;
            this.physicalRadioButton.Location = new System.Drawing.Point(7, 20);
            this.physicalRadioButton.Name = "physicalRadioButton";
            this.physicalRadioButton.Size = new System.Drawing.Size(64, 17);
            this.physicalRadioButton.TabIndex = 0;
            this.physicalRadioButton.TabStop = true;
            this.physicalRadioButton.Text = "Physical";
            this.physicalRadioButton.UseVisualStyleBackColor = true;
            this.physicalRadioButton.CheckedChanged += new System.EventHandler(this.combatSituationChanged);
            // 
            // CombatSituationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "CombatSituationPanel";
            this.Size = new System.Drawing.Size(150, 66);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton matrixRadioButton;
        private System.Windows.Forms.RadioButton astralRadioButton;
        private System.Windows.Forms.RadioButton physicalRadioButton;
    }
}
