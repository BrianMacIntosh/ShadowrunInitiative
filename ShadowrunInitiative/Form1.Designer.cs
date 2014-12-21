namespace ShadowrunInitiative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.charactersListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edgeNumeric = new System.Windows.Forms.NumericUpDown();
            this.reactNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.intuitNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.characterBox = new System.Windows.Forms.GroupBox();
            this.delayButton = new System.Windows.Forms.Button();
            this.incapacitatedCheckBox = new System.Windows.Forms.CheckBox();
            this.pcCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.interruptXButton = new System.Windows.Forms.Button();
            this.interrupt10Button = new System.Windows.Forms.Button();
            this.interrupt5Button = new System.Windows.Forms.Button();
            this.removeCharacterButton = new System.Windows.Forms.Button();
            this.initNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newCombatButton = new System.Windows.Forms.Button();
            this.addCharacterButton = new System.Windows.Forms.Button();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.currentTurnStaticLabel = new System.Windows.Forms.Label();
            this.currentCharLabel = new System.Windows.Forms.Label();
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.combatTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edgeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intuitNumeric)).BeginInit();
            this.characterBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Characters:";
            // 
            // charactersListBox
            // 
            this.charactersListBox.FormattingEnabled = true;
            this.charactersListBox.Location = new System.Drawing.Point(12, 115);
            this.charactersListBox.Name = "charactersListBox";
            this.charactersListBox.Size = new System.Drawing.Size(150, 251);
            this.charactersListBox.TabIndex = 1;
            this.charactersListBox.SelectedIndexChanged += new System.EventHandler(this.charactersListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "&EDGE";
            // 
            // edgeNumeric
            // 
            this.edgeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeNumeric.Location = new System.Drawing.Point(57, 43);
            this.edgeNumeric.Name = "edgeNumeric";
            this.edgeNumeric.Size = new System.Drawing.Size(51, 20);
            this.edgeNumeric.TabIndex = 16;
            this.edgeNumeric.ValueChanged += new System.EventHandler(this.edgeNumeric_ValueChanged);
            // 
            // reactNumeric
            // 
            this.reactNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactNumeric.Location = new System.Drawing.Point(57, 69);
            this.reactNumeric.Name = "reactNumeric";
            this.reactNumeric.Size = new System.Drawing.Size(51, 20);
            this.reactNumeric.TabIndex = 18;
            this.reactNumeric.ValueChanged += new System.EventHandler(this.reactNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "&REACT";
            // 
            // intuitNumeric
            // 
            this.intuitNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intuitNumeric.Location = new System.Drawing.Point(57, 95);
            this.intuitNumeric.Name = "intuitNumeric";
            this.intuitNumeric.Size = new System.Drawing.Size(51, 20);
            this.intuitNumeric.TabIndex = 20;
            this.intuitNumeric.ValueChanged += new System.EventHandler(this.intuitNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "I&NTUIT";
            // 
            // characterBox
            // 
            this.characterBox.Controls.Add(this.delayButton);
            this.characterBox.Controls.Add(this.incapacitatedCheckBox);
            this.characterBox.Controls.Add(this.pcCheckbox);
            this.characterBox.Controls.Add(this.groupBox3);
            this.characterBox.Controls.Add(this.removeCharacterButton);
            this.characterBox.Controls.Add(this.initNumeric);
            this.characterBox.Controls.Add(this.label5);
            this.characterBox.Controls.Add(this.edgeNumeric);
            this.characterBox.Controls.Add(this.intuitNumeric);
            this.characterBox.Controls.Add(this.label2);
            this.characterBox.Controls.Add(this.label4);
            this.characterBox.Controls.Add(this.label3);
            this.characterBox.Controls.Add(this.reactNumeric);
            this.characterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterBox.Location = new System.Drawing.Point(168, 97);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(150, 267);
            this.characterBox.TabIndex = 9;
            this.characterBox.TabStop = false;
            this.characterBox.Text = "Character Name";
            // 
            // delayButton
            // 
            this.delayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayButton.Location = new System.Drawing.Point(38, 176);
            this.delayButton.Name = "delayButton";
            this.delayButton.Size = new System.Drawing.Size(75, 23);
            this.delayButton.TabIndex = 24;
            this.delayButton.Text = "Delay";
            this.delayButton.UseVisualStyleBackColor = true;
            this.delayButton.Click += new System.EventHandler(this.delayButton_Click);
            // 
            // incapacitatedCheckBox
            // 
            this.incapacitatedCheckBox.AutoSize = true;
            this.incapacitatedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incapacitatedCheckBox.Location = new System.Drawing.Point(54, 20);
            this.incapacitatedCheckBox.Name = "incapacitatedCheckBox";
            this.incapacitatedCheckBox.Size = new System.Drawing.Size(91, 17);
            this.incapacitatedCheckBox.TabIndex = 14;
            this.incapacitatedCheckBox.Text = "Incapacitated";
            this.incapacitatedCheckBox.UseVisualStyleBackColor = true;
            this.incapacitatedCheckBox.CheckedChanged += new System.EventHandler(this.incapacitatedCheckBox_CheckedChanged);
            // 
            // pcCheckbox
            // 
            this.pcCheckbox.AutoSize = true;
            this.pcCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcCheckbox.Location = new System.Drawing.Point(7, 20);
            this.pcCheckbox.Name = "pcCheckbox";
            this.pcCheckbox.Size = new System.Drawing.Size(40, 17);
            this.pcCheckbox.TabIndex = 13;
            this.pcCheckbox.Text = "PC";
            this.pcCheckbox.UseVisualStyleBackColor = true;
            this.pcCheckbox.CheckedChanged += new System.EventHandler(this.pcCheckbox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.interruptXButton);
            this.groupBox3.Controls.Add(this.interrupt10Button);
            this.groupBox3.Controls.Add(this.interrupt5Button);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 54);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interrupt";
            // 
            // interruptXButton
            // 
            this.interruptXButton.Location = new System.Drawing.Point(94, 20);
            this.interruptXButton.Name = "interruptXButton";
            this.interruptXButton.Size = new System.Drawing.Size(38, 23);
            this.interruptXButton.TabIndex = 26;
            this.interruptXButton.Text = "-X";
            this.interruptXButton.UseVisualStyleBackColor = true;
            this.interruptXButton.Click += new System.EventHandler(this.interruptXButton_Click);
            // 
            // interrupt10Button
            // 
            this.interrupt10Button.Location = new System.Drawing.Point(51, 20);
            this.interrupt10Button.Name = "interrupt10Button";
            this.interrupt10Button.Size = new System.Drawing.Size(38, 23);
            this.interrupt10Button.TabIndex = 25;
            this.interrupt10Button.Text = "-10";
            this.interrupt10Button.UseVisualStyleBackColor = true;
            this.interrupt10Button.Click += new System.EventHandler(this.interrupt10Button_Click);
            // 
            // interrupt5Button
            // 
            this.interrupt5Button.Location = new System.Drawing.Point(7, 20);
            this.interrupt5Button.Name = "interrupt5Button";
            this.interrupt5Button.Size = new System.Drawing.Size(38, 23);
            this.interrupt5Button.TabIndex = 24;
            this.interrupt5Button.Text = "-5";
            this.interrupt5Button.UseVisualStyleBackColor = true;
            this.interrupt5Button.Click += new System.EventHandler(this.interrupt5Button_Click);
            // 
            // removeCharacterButton
            // 
            this.removeCharacterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCharacterButton.Location = new System.Drawing.Point(38, 147);
            this.removeCharacterButton.Name = "removeCharacterButton";
            this.removeCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.removeCharacterButton.TabIndex = 23;
            this.removeCharacterButton.Text = "Remove";
            this.removeCharacterButton.UseVisualStyleBackColor = true;
            this.removeCharacterButton.Click += new System.EventHandler(this.removeCharacterButton_Click);
            // 
            // initNumeric
            // 
            this.initNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initNumeric.Location = new System.Drawing.Point(57, 121);
            this.initNumeric.Name = "initNumeric";
            this.initNumeric.Size = new System.Drawing.Size(51, 20);
            this.initNumeric.TabIndex = 22;
            this.initNumeric.ValueChanged += new System.EventHandler(this.initNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "&Init";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newCombatButton);
            this.groupBox1.Controls.Add(this.addCharacterButton);
            this.groupBox1.Location = new System.Drawing.Point(168, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // newCombatButton
            // 
            this.newCombatButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newCombatButton.Location = new System.Drawing.Point(11, 48);
            this.newCombatButton.Name = "newCombatButton";
            this.newCombatButton.Size = new System.Drawing.Size(127, 23);
            this.newCombatButton.TabIndex = 1;
            this.newCombatButton.Text = "Reset";
            this.newCombatButton.UseVisualStyleBackColor = true;
            this.newCombatButton.Click += new System.EventHandler(this.newCombatButton_Click);
            // 
            // addCharacterButton
            // 
            this.addCharacterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addCharacterButton.Location = new System.Drawing.Point(11, 19);
            this.addCharacterButton.Name = "addCharacterButton";
            this.addCharacterButton.Size = new System.Drawing.Size(127, 23);
            this.addCharacterButton.TabIndex = 0;
            this.addCharacterButton.Text = "&Add Character";
            this.addCharacterButton.UseVisualStyleBackColor = true;
            this.addCharacterButton.Click += new System.EventHandler(this.addCharacterButton_Click);
            // 
            // logListBox
            // 
            this.logListBox.BackColor = System.Drawing.Color.DimGray;
            this.logListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logListBox.ForeColor = System.Drawing.Color.Lime;
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 16;
            this.logListBox.Items.AddRange(new object[] {
            "TURN: Chris",
            "TURN: Brian",
            "-5: Chris spends interrupt.",
            "",
            "---- NEW TURN ----",
            "TURN: Mop Man",
            "",
            "-+-+ NEW ROUND +-+-",
            "TURN: Chris"});
            this.logListBox.Location = new System.Drawing.Point(324, 35);
            this.logListBox.Name = "logListBox";
            this.logListBox.ScrollAlwaysVisible = true;
            this.logListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logListBox.Size = new System.Drawing.Size(273, 324);
            this.logListBox.TabIndex = 11;
            this.logListBox.TabStop = false;
            // 
            // currentTurnStaticLabel
            // 
            this.currentTurnStaticLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentTurnStaticLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentTurnStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTurnStaticLabel.Location = new System.Drawing.Point(14, 10);
            this.currentTurnStaticLabel.Name = "currentTurnStaticLabel";
            this.currentTurnStaticLabel.Size = new System.Drawing.Size(124, 15);
            this.currentTurnStaticLabel.TabIndex = 12;
            this.currentTurnStaticLabel.Text = "Current Turn:";
            this.currentTurnStaticLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentCharLabel
            // 
            this.currentCharLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentCharLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentCharLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCharLabel.Location = new System.Drawing.Point(3, 26);
            this.currentCharLabel.Name = "currentCharLabel";
            this.currentCharLabel.Size = new System.Drawing.Size(144, 23);
            this.currentCharLabel.TabIndex = 13;
            this.currentCharLabel.Text = ">> Brian <<";
            this.currentCharLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nextTurnButton.Location = new System.Drawing.Point(6, 49);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(141, 23);
            this.nextTurnButton.TabIndex = 0;
            this.nextTurnButton.Text = "Begin Combat";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            this.nextTurnButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.currentTurnStaticLabel);
            this.panel1.Controls.Add(this.currentCharLabel);
            this.panel1.Controls.Add(this.nextTurnButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 79);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Combat Duration:";
            // 
            // combatTimeLabel
            // 
            this.combatTimeLabel.AutoSize = true;
            this.combatTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatTimeLabel.Location = new System.Drawing.Point(414, 13);
            this.combatTimeLabel.Name = "combatTimeLabel";
            this.combatTimeLabel.Size = new System.Drawing.Size(41, 13);
            this.combatTimeLabel.TabIndex = 17;
            this.combatTimeLabel.Text = "TEMP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 375);
            this.Controls.Add(this.combatTimeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.characterBox);
            this.Controls.Add(this.charactersListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Shadowrun Initiative";
            ((System.ComponentModel.ISupportInitialize)(this.edgeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intuitNumeric)).EndInit();
            this.characterBox.ResumeLayout(false);
            this.characterBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.initNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox charactersListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edgeNumeric;
        private System.Windows.Forms.NumericUpDown reactNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intuitNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox characterBox;
        private System.Windows.Forms.Button removeCharacterButton;
        private System.Windows.Forms.NumericUpDown initNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newCombatButton;
        private System.Windows.Forms.Button addCharacterButton;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Label currentTurnStaticLabel;
        private System.Windows.Forms.Label currentCharLabel;
        private System.Windows.Forms.Button nextTurnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button interruptXButton;
        private System.Windows.Forms.Button interrupt10Button;
        private System.Windows.Forms.Button interrupt5Button;
        private System.Windows.Forms.CheckBox pcCheckbox;
        private System.Windows.Forms.CheckBox incapacitatedCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label combatTimeLabel;
        private System.Windows.Forms.Button delayButton;
    }
}

