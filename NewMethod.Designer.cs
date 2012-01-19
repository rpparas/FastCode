namespace SampleApp
{
    partial class NewMethod
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
            this.Parameters = new System.Windows.Forms.ListBox();
            this.Comments = new System.Windows.Forms.TextBox();
            this.StaticCheck = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PublicRadio = new System.Windows.Forms.RadioButton();
            this.PrivateRadio = new System.Windows.Forms.RadioButton();
            this.DefaultRadio = new System.Windows.Forms.RadioButton();
            this.FinalCheck = new System.Windows.Forms.CheckBox();
            this.MethodName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProtectedRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SynchronizedCheck = new System.Windows.Forms.CheckBox();
            this.AbstractCheck = new System.Windows.Forms.CheckBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnType = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Exceptions = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Code = new System.Windows.Forms.RichTextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parameters
            // 
            this.Parameters.FormattingEnabled = true;
            this.Parameters.Items.AddRange(new object[] {
            "Click on \"Add...\" to insert contents."});
            this.Parameters.Location = new System.Drawing.Point(9, 21);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(194, 56);
            this.Parameters.TabIndex = 12;
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(9, 21);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(198, 65);
            this.Comments.TabIndex = 14;
            // 
            // StaticCheck
            // 
            this.StaticCheck.AutoSize = true;
            this.StaticCheck.Location = new System.Drawing.Point(112, 19);
            this.StaticCheck.Name = "StaticCheck";
            this.StaticCheck.Size = new System.Drawing.Size(51, 17);
            this.StaticCheck.TabIndex = 11;
            this.StaticCheck.Text = "static";
            this.StaticCheck.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(179, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Comments);
            this.groupBox4.Location = new System.Drawing.Point(16, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 96);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comments: (// maybe omitted)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.Parameters);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 85);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(395, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OK_Click);
            // 
            // PublicRadio
            // 
            this.PublicRadio.AutoSize = true;
            this.PublicRadio.Location = new System.Drawing.Point(13, 19);
            this.PublicRadio.Name = "PublicRadio";
            this.PublicRadio.Size = new System.Drawing.Size(53, 17);
            this.PublicRadio.TabIndex = 6;
            this.PublicRadio.TabStop = true;
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
            this.PrivateRadio.TabStop = true;
            this.PrivateRadio.Text = "private";
            this.PrivateRadio.UseVisualStyleBackColor = true;
            // 
            // DefaultRadio
            // 
            this.DefaultRadio.AutoSize = true;
            this.DefaultRadio.Location = new System.Drawing.Point(112, 42);
            this.DefaultRadio.Name = "DefaultRadio";
            this.DefaultRadio.Size = new System.Drawing.Size(57, 17);
            this.DefaultRadio.TabIndex = 8;
            this.DefaultRadio.TabStop = true;
            this.DefaultRadio.Text = "default";
            this.DefaultRadio.UseVisualStyleBackColor = true;
            // 
            // FinalCheck
            // 
            this.FinalCheck.AutoSize = true;
            this.FinalCheck.Location = new System.Drawing.Point(13, 43);
            this.FinalCheck.Name = "FinalCheck";
            this.FinalCheck.Size = new System.Drawing.Size(45, 17);
            this.FinalCheck.TabIndex = 10;
            this.FinalCheck.Text = "final";
            this.FinalCheck.UseVisualStyleBackColor = true;
            // 
            // MethodName
            // 
            this.MethodName.Location = new System.Drawing.Point(88, 12);
            this.MethodName.Name = "MethodName";
            this.MethodName.Size = new System.Drawing.Size(142, 20);
            this.MethodName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProtectedRadio);
            this.groupBox3.Controls.Add(this.PublicRadio);
            this.groupBox3.Controls.Add(this.PrivateRadio);
            this.groupBox3.Controls.Add(this.DefaultRadio);
            this.groupBox3.Location = new System.Drawing.Point(16, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 71);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Access Modifier";
            // 
            // ProtectedRadio
            // 
            this.ProtectedRadio.AutoSize = true;
            this.ProtectedRadio.Location = new System.Drawing.Point(13, 42);
            this.ProtectedRadio.Name = "ProtectedRadio";
            this.ProtectedRadio.Size = new System.Drawing.Size(70, 17);
            this.ProtectedRadio.TabIndex = 59;
            this.ProtectedRadio.TabStop = true;
            this.ProtectedRadio.Text = "protected";
            this.ProtectedRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SynchronizedCheck);
            this.groupBox1.Controls.Add(this.StaticCheck);
            this.groupBox1.Controls.Add(this.FinalCheck);
            this.groupBox1.Controls.Add(this.AbstractCheck);
            this.groupBox1.Location = new System.Drawing.Point(16, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 69);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // SynchronizedCheck
            // 
            this.SynchronizedCheck.AutoSize = true;
            this.SynchronizedCheck.Location = new System.Drawing.Point(112, 43);
            this.SynchronizedCheck.Name = "SynchronizedCheck";
            this.SynchronizedCheck.Size = new System.Drawing.Size(88, 17);
            this.SynchronizedCheck.TabIndex = 12;
            this.SynchronizedCheck.Text = "synchronized";
            this.SynchronizedCheck.UseVisualStyleBackColor = true;
            // 
            // AbstractCheck
            // 
            this.AbstractCheck.AutoSize = true;
            this.AbstractCheck.Location = new System.Drawing.Point(13, 20);
            this.AbstractCheck.Name = "AbstractCheck";
            this.AbstractCheck.Size = new System.Drawing.Size(64, 17);
            this.AbstractCheck.TabIndex = 9;
            this.AbstractCheck.Text = "abstract";
            this.AbstractCheck.UseVisualStyleBackColor = true;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(13, 15);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(77, 13);
            this.label100.TabIndex = 44;
            this.label100.Text = "Method Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Return Type:";
            // 
            // ReturnType
            // 
            this.ReturnType.FormattingEnabled = true;
            this.ReturnType.Items.AddRange(new object[] {
            "boolean",
            "byte",
            "char",
            "double",
            "float",
            "int",
            "long",
            "short"});
            this.ReturnType.Location = new System.Drawing.Point(88, 49);
            this.ReturnType.Name = "ReturnType";
            this.ReturnType.Size = new System.Drawing.Size(116, 21);
            this.ReturnType.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel2);
            this.groupBox5.Controls.Add(this.Exceptions);
            this.groupBox5.Location = new System.Drawing.Point(256, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 86);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exceptions Thrown:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(179, -2);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(35, 13);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add...";
            // 
            // Exceptions
            // 
            this.Exceptions.FormattingEnabled = true;
            this.Exceptions.Items.AddRange(new object[] {
            "Click on \"Add...\" to insert contents."});
            this.Exceptions.Location = new System.Drawing.Point(9, 21);
            this.Exceptions.Name = "Exceptions";
            this.Exceptions.Size = new System.Drawing.Size(194, 56);
            this.Exceptions.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Code);
            this.groupBox6.Controls.Add(this.linkLabel3);
            this.groupBox6.Location = new System.Drawing.Point(256, 196);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 94);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Statements: {...}";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(9, 16);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(199, 68);
            this.Code.TabIndex = 14;
            this.Code.Text = "";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(174, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(40, 13);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "More...";
            // 
            // NewMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(485, 329);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MethodName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label100);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewMethod";
            this.Text = "Insert New Method...";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Parameters;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.CheckBox StaticCheck;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton PublicRadio;
        private System.Windows.Forms.RadioButton PrivateRadio;
        private System.Windows.Forms.RadioButton DefaultRadio;
        private System.Windows.Forms.CheckBox FinalCheck;
        private System.Windows.Forms.TextBox MethodName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox AbstractCheck;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ReturnType;
        private System.Windows.Forms.RadioButton ProtectedRadio;
        private System.Windows.Forms.CheckBox SynchronizedCheck;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ListBox Exceptions;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox Code;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}