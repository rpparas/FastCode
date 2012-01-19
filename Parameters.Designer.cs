namespace SampleApp
{
    partial class Parameters
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SelectAllButton1b = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.RemoveButton1b = new System.Windows.Forms.Button();
            this.EditButton1b = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VariableType = new System.Windows.Forms.ComboBox();
            this.VariableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddButton1b = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.SelectAllButton1b);
            this.groupBox2.Controls.Add(this.MoveDownButton);
            this.groupBox2.Controls.Add(this.MoveUpButton);
            this.groupBox2.Controls.Add(this.RemoveButton1b);
            this.groupBox2.Controls.Add(this.EditButton1b);
            this.groupBox2.Location = new System.Drawing.Point(199, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(142, 173);
            this.listBox2.TabIndex = 1;
            // 
            // SelectAllButton1b
            // 
            this.SelectAllButton1b.Location = new System.Drawing.Point(161, 169);
            this.SelectAllButton1b.Name = "SelectAllButton1b";
            this.SelectAllButton1b.Size = new System.Drawing.Size(75, 23);
            this.SelectAllButton1b.TabIndex = 7;
            this.SelectAllButton1b.Text = "Select All";
            this.SelectAllButton1b.UseVisualStyleBackColor = true;
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Location = new System.Drawing.Point(161, 140);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(75, 23);
            this.MoveDownButton.TabIndex = 6;
            this.MoveDownButton.Text = "Move Down";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Location = new System.Drawing.Point(161, 111);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(75, 23);
            this.MoveUpButton.TabIndex = 5;
            this.MoveUpButton.Text = "Move Up";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton1b
            // 
            this.RemoveButton1b.Location = new System.Drawing.Point(161, 48);
            this.RemoveButton1b.Name = "RemoveButton1b";
            this.RemoveButton1b.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton1b.TabIndex = 4;
            this.RemoveButton1b.Text = "Remove";
            this.RemoveButton1b.UseVisualStyleBackColor = true;
            this.RemoveButton1b.Click += new System.EventHandler(this.RemoveButton1b_Click);
            // 
            // EditButton1b
            // 
            this.EditButton1b.Location = new System.Drawing.Point(161, 19);
            this.EditButton1b.Name = "EditButton1b";
            this.EditButton1b.Size = new System.Drawing.Size(75, 23);
            this.EditButton1b.TabIndex = 3;
            this.EditButton1b.Text = "Edit...";
            this.EditButton1b.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose from Existing Variables:";
            // 
            // VariableType
            // 
            this.VariableType.FormattingEnabled = true;
            this.VariableType.Location = new System.Drawing.Point(45, 48);
            this.VariableType.Name = "VariableType";
            this.VariableType.Size = new System.Drawing.Size(126, 21);
            this.VariableType.TabIndex = 28;
            // 
            // VariableName
            // 
            this.VariableName.Location = new System.Drawing.Point(45, 18);
            this.VariableName.Name = "VariableName";
            this.VariableName.Size = new System.Drawing.Size(127, 20);
            this.VariableName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddButton1b);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.VariableType);
            this.groupBox3.Controls.Add(this.VariableName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 103);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Variable:";
            // 
            // AddButton1b
            // 
            this.AddButton1b.Location = new System.Drawing.Point(120, 74);
            this.AddButton1b.Name = "AddButton1b";
            this.AddButton1b.Size = new System.Drawing.Size(51, 23);
            this.AddButton1b.TabIndex = 30;
            this.AddButton1b.Text = "Add";
            this.AddButton1b.UseVisualStyleBackColor = true;
            this.AddButton1b.Click += new System.EventHandler(this.AddButton1b_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(377, 225);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(67, 23);
            this.Cancel.TabIndex = 67;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(304, 225);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(67, 23);
            this.OK.TabIndex = 66;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 260);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Parameters";
            this.Text = "Parameters";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SelectAllButton1b;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button RemoveButton1b;
        private System.Windows.Forms.Button EditButton1b;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox VariableType;
        private System.Windows.Forms.TextBox VariableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddButton1b;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
    }
}