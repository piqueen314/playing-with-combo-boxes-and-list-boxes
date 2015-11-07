namespace Playing_with_comboBox_listBox
{
    partial class stateForm
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
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "District Of Columbia",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois"});
            this.stateComboBox.Location = new System.Drawing.Point(12, 71);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 0;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(12, 52);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(74, 13);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "Select a State";
            // 
            // stateListBox
            // 
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.Location = new System.Drawing.Point(162, 71);
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.Size = new System.Drawing.Size(135, 303);
            this.stateListBox.TabIndex = 2;
            // 
            // stateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 395);
            this.Controls.Add(this.stateListBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Name = "stateForm";
            this.Text = "Select a State";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ListBox stateListBox;
    }
}

