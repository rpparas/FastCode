namespace SampleApp
{
    partial class NewVariable
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
            this.TransientCheck = new System.Windows.Forms.CheckBox();
            this.ProtectedRadio = new System.Windows.Forms.RadioButton();
            this.AccessGroup3 = new System.Windows.Forms.GroupBox();
            this.PublicRadio = new System.Windows.Forms.RadioButton();
            this.PrivateRadio = new System.Windows.Forms.RadioButton();
            this.radioButton49 = new System.Windows.Forms.RadioButton();
            this.AttributesGroup3 = new System.Windows.Forms.GroupBox();
            this.StaticCheck = new System.Windows.Forms.CheckBox();
            this.FinalCheck = new System.Windows.Forms.CheckBox();
            this.label100 = new System.Windows.Forms.Label();
            this.VariableType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VariableName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Comments = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GroupBox23 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.enclose = new System.Windows.Forms.CheckBox();
            this.InitialValue = new System.Windows.Forms.TextBox();
            this.MethodCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MethodRadio = new System.Windows.Forms.RadioButton();
            this.InstanceRadio = new System.Windows.Forms.RadioButton();
            this.AccessGroup3.SuspendLayout();
            this.AttributesGroup3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox23.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransientCheck
            // 
            this.TransientCheck.AutoSize = true;
            this.TransientCheck.Location = new System.Drawing.Point(112, 21);
            this.TransientCheck.Name = "TransientCheck";
            this.TransientCheck.Size = new System.Drawing.Size(66, 17);
            this.TransientCheck.TabIndex = 9;
            this.TransientCheck.Text = "transient";
            this.TransientCheck.UseVisualStyleBackColor = true;
            // 
            // ProtectedRadio
            // 
            this.ProtectedRadio.AutoSize = true;
            this.ProtectedRadio.Location = new System.Drawing.Point(13, 42);
            this.ProtectedRadio.Name = "ProtectedRadio";
            this.ProtectedRadio.Size = new System.Drawing.Size(70, 17);
            this.ProtectedRadio.TabIndex = 59;
            this.ProtectedRadio.Text = "protected";
            this.ProtectedRadio.UseVisualStyleBackColor = true;
            // 
            // AccessGroup3
            // 
            this.AccessGroup3.Controls.Add(this.ProtectedRadio);
            this.AccessGroup3.Controls.Add(this.PublicRadio);
            this.AccessGroup3.Controls.Add(this.PrivateRadio);
            this.AccessGroup3.Controls.Add(this.radioButton49);
            this.AccessGroup3.Location = new System.Drawing.Point(17, 86);
            this.AccessGroup3.Name = "AccessGroup3";
            this.AccessGroup3.Size = new System.Drawing.Size(214, 71);
            this.AccessGroup3.TabIndex = 66;
            this.AccessGroup3.TabStop = false;
            this.AccessGroup3.Text = "Access Modifier";
            // 
            // PublicRadio
            // 
            this.PublicRadio.AutoSize = true;
            this.PublicRadio.Location = new System.Drawing.Point(13, 19);
            this.PublicRadio.Name = "PublicRadio";
            this.PublicRadio.Size = new System.Drawing.Size(53, 17);
            this.PublicRadio.TabIndex = 6;
            this.PublicRadio.Text = "public";
            this.PublicRadio.UseVisualStyleBackColor = true;
            // 
            // PrivateRadio
            // 
            this.PrivateRadio.AutoSize = true;
            this.PrivateRadio.Location = new System.Drawing.Point(112, 19);
            this.PrivateRadio.Name = "PrivateRadio";
            this.PrivateRadio.Size = new System.Drawing.Size(57, 17);
            this.PrivateRadio.TabIndex = 7;
            this.PrivateRadio.Text = "private";
            this.PrivateRadio.UseVisualStyleBackColor = true;
            // 
            // radioButton49
            // 
            this.radioButton49.AutoSize = true;
            this.radioButton49.Checked = true;
            this.radioButton49.Location = new System.Drawing.Point(112, 42);
            this.radioButton49.Name = "radioButton49";
            this.radioButton49.Size = new System.Drawing.Size(57, 17);
            this.radioButton49.TabIndex = 8;
            this.radioButton49.TabStop = true;
            this.radioButton49.Text = "default";
            this.radioButton49.UseVisualStyleBackColor = true;
            // 
            // AttributesGroup3
            // 
            this.AttributesGroup3.Controls.Add(this.StaticCheck);
            this.AttributesGroup3.Controls.Add(this.FinalCheck);
            this.AttributesGroup3.Controls.Add(this.TransientCheck);
            this.AttributesGroup3.Location = new System.Drawing.Point(259, 90);
            this.AttributesGroup3.Name = "AttributesGroup3";
            this.AttributesGroup3.Size = new System.Drawing.Size(214, 69);
            this.AttributesGroup3.TabIndex = 67;
            this.AttributesGroup3.TabStop = false;
            this.AttributesGroup3.Text = "Attributes";
            // 
            // StaticCheck
            // 
            this.StaticCheck.AutoSize = true;
            this.StaticCheck.Location = new System.Drawing.Point(16, 44);
            this.StaticCheck.Name = "StaticCheck";
            this.StaticCheck.Size = new System.Drawing.Size(51, 17);
            this.StaticCheck.TabIndex = 11;
            this.StaticCheck.Text = "static";
            this.StaticCheck.UseVisualStyleBackColor = true;
            // 
            // FinalCheck
            // 
            this.FinalCheck.AutoSize = true;
            this.FinalCheck.Location = new System.Drawing.Point(16, 21);
            this.FinalCheck.Name = "FinalCheck";
            this.FinalCheck.Size = new System.Drawing.Size(45, 17);
            this.FinalCheck.TabIndex = 10;
            this.FinalCheck.Text = "final";
            this.FinalCheck.UseVisualStyleBackColor = true;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(14, 16);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(79, 13);
            this.label100.TabIndex = 64;
            this.label100.Text = "Variable Name:";
            // 
            // VariableType
            // 
            this.VariableType.FormattingEnabled = true;
            this.VariableType.Location = new System.Drawing.Point(93, 43);
            this.VariableType.Name = "VariableType";
            this.VariableType.Size = new System.Drawing.Size(109, 21);
            this.VariableType.TabIndex = 61;
            this.VariableType.SelectedIndexChanged += new System.EventHandler(this.DataTypeCombo_SelectedIndexChanged);
            this.VariableType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewVariable_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Data Type:";
            // 
            // VariableName
            // 
            this.VariableName.Location = new System.Drawing.Point(93, 13);
            this.VariableName.Name = "VariableName";
            this.VariableName.Size = new System.Drawing.Size(138, 20);
            this.VariableName.TabIndex = 60;
            this.VariableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewVariable_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.Comments);
            this.groupBox4.Location = new System.Drawing.Point(259, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 118);
            this.groupBox4.TabIndex = 69;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comments: (// maybe omitted)";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(106, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 17);
            this.radioButton3.TabIndex = 80;
            this.radioButton3.Text = "/**...*/";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 79;
            this.radioButton2.Text = "/*...*/";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "enclose in:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(106, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 78;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "default";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(10, 19);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(197, 53);
            this.Comments.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(398, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OK_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewVariable_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 73;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GroupBox23
            // 
            this.GroupBox23.Controls.Add(this.button5);
            this.GroupBox23.Controls.Add(this.enclose);
            this.GroupBox23.Controls.Add(this.InitialValue);
            this.GroupBox23.Location = new System.Drawing.Point(17, 171);
            this.GroupBox23.Name = "GroupBox23";
            this.GroupBox23.Size = new System.Drawing.Size(214, 115);
            this.GroupBox23.TabIndex = 76;
            this.GroupBox23.TabStop = false;
            this.GroupBox23.Text = "Initial Value:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 78;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // enclose
            // 
            this.enclose.AutoSize = true;
            this.enclose.Enabled = false;
            this.enclose.Location = new System.Drawing.Point(15, 90);
            this.enclose.Name = "enclose";
            this.enclose.Size = new System.Drawing.Size(128, 17);
            this.enclose.TabIndex = 15;
            this.enclose.Text = "enclose in quotes (\"\")";
            this.enclose.UseVisualStyleBackColor = true;
            // 
            // InitialValue
            // 
            this.InitialValue.Location = new System.Drawing.Point(10, 19);
            this.InitialValue.Multiline = true;
            this.InitialValue.Name = "InitialValue";
            this.InitialValue.Size = new System.Drawing.Size(198, 65);
            this.InitialValue.TabIndex = 14;
            // 
            // MethodCombo
            // 
            this.MethodCombo.FormattingEnabled = true;
            this.MethodCombo.Location = new System.Drawing.Point(83, 41);
            this.MethodCombo.Name = "MethodCombo";
            this.MethodCombo.Size = new System.Drawing.Size(125, 21);
            this.MethodCombo.TabIndex = 77;
            this.MethodCombo.Text = "[Select Method]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MethodRadio);
            this.groupBox1.Controls.Add(this.MethodCombo);
            this.groupBox1.Controls.Add(this.InstanceRadio);
            this.groupBox1.Location = new System.Drawing.Point(259, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 71);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scope of Variable";
            // 
            // MethodRadio
            // 
            this.MethodRadio.AutoSize = true;
            this.MethodRadio.Location = new System.Drawing.Point(13, 42);
            this.MethodRadio.Name = "MethodRadio";
            this.MethodRadio.Size = new System.Drawing.Size(64, 17);
            this.MethodRadio.TabIndex = 59;
            this.MethodRadio.Text = "Method:";
            this.MethodRadio.UseVisualStyleBackColor = true;
            this.MethodRadio.CheckedChanged += new System.EventHandler(this.MethodRadio_CheckedChanged);
            // 
            // InstanceRadio
            // 
            this.InstanceRadio.AutoSize = true;
            this.InstanceRadio.Checked = true;
            this.InstanceRadio.Location = new System.Drawing.Point(13, 19);
            this.InstanceRadio.Name = "InstanceRadio";
            this.InstanceRadio.Size = new System.Drawing.Size(143, 17);
            this.InstanceRadio.TabIndex = 8;
            this.InstanceRadio.TabStop = true;
            this.InstanceRadio.Text = "Instance / Class Variable";
            this.InstanceRadio.UseVisualStyleBackColor = true;
            this.InstanceRadio.CheckedChanged += new System.EventHandler(this.InstanceRadio_CheckedChanged);
            // 
            // NewVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox23);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AccessGroup3);
            this.Controls.Add(this.AttributesGroup3);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.VariableType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VariableName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NewVariable";
            this.Text = "Insert New Variable...";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewVariable_KeyPress);
            this.AccessGroup3.ResumeLayout(false);
            this.AccessGroup3.PerformLayout();
            this.AttributesGroup3.ResumeLayout(false);
            this.AttributesGroup3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBox23.ResumeLayout(false);
            this.GroupBox23.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TransientCheck;
        private System.Windows.Forms.RadioButton ProtectedRadio;
        private System.Windows.Forms.GroupBox AccessGroup3;
        private System.Windows.Forms.RadioButton PublicRadio;
        private System.Windows.Forms.RadioButton PrivateRadio;
        private System.Windows.Forms.RadioButton radioButton49;
        private System.Windows.Forms.GroupBox AttributesGroup3;
        private System.Windows.Forms.CheckBox StaticCheck;
        private System.Windows.Forms.CheckBox FinalCheck;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.ComboBox VariableType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VariableName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox GroupBox23;
        private System.Windows.Forms.TextBox InitialValue;
        private System.Windows.Forms.CheckBox enclose;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox MethodCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MethodRadio;
        private System.Windows.Forms.RadioButton InstanceRadio;
    }
}