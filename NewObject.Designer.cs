namespace SampleApp
{
    partial class NewObject
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
            this.ObjectType = new System.Windows.Forms.ComboBox();
            this.label102 = new System.Windows.Forms.Label();
            this.ObjectName = new System.Windows.Forms.TextBox();
            this.access = new System.Windows.Forms.GroupBox();
            this.PublicRadio = new System.Windows.Forms.RadioButton();
            this.PrivateRadio = new System.Windows.Forms.RadioButton();
            this.DefaultRadio = new System.Windows.Forms.RadioButton();
            this.Inherit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConstructorCheck = new System.Windows.Forms.CheckBox();
            this.FinalCheck = new System.Windows.Forms.CheckBox();
            this.label100 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.access.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectType
            // 
            this.ObjectType.FormattingEnabled = true;
            this.ObjectType.Items.AddRange(new object[] {
            "class",
            "abstract class",
            "interface"});
            this.ObjectType.Location = new System.Drawing.Point(308, 12);
            this.ObjectType.Name = "ObjectType";
            this.ObjectType.Size = new System.Drawing.Size(156, 21);
            this.ObjectType.TabIndex = 60;
            this.ObjectType.Text = "class";
            this.ObjectType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(254, 15);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(34, 13);
            this.label102.TabIndex = 67;
            this.label102.Text = "Type:";
            // 
            // ObjectName
            // 
            this.ObjectName.Location = new System.Drawing.Point(94, 12);
            this.ObjectName.Name = "ObjectName";
            this.ObjectName.Size = new System.Drawing.Size(137, 20);
            this.ObjectName.TabIndex = 59;
            this.ObjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // access
            // 
            this.access.Controls.Add(this.PublicRadio);
            this.access.Controls.Add(this.PrivateRadio);
            this.access.Controls.Add(this.DefaultRadio);
            this.access.Location = new System.Drawing.Point(17, 92);
            this.access.Name = "access";
            this.access.Size = new System.Drawing.Size(214, 55);
            this.access.TabIndex = 69;
            this.access.TabStop = false;
            this.access.Text = "Access Modifier";
            // 
            // PublicRadio
            // 
            this.PublicRadio.AutoSize = true;
            this.PublicRadio.Location = new System.Drawing.Point(20, 19);
            this.PublicRadio.Name = "PublicRadio";
            this.PublicRadio.Size = new System.Drawing.Size(53, 17);
            this.PublicRadio.TabIndex = 65;
            this.PublicRadio.TabStop = true;
            this.PublicRadio.Text = "public";
            this.PublicRadio.UseVisualStyleBackColor = true;
            this.PublicRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // PrivateRadio
            // 
            this.PrivateRadio.AutoSize = true;
            this.PrivateRadio.Location = new System.Drawing.Point(83, 19);
            this.PrivateRadio.Name = "PrivateRadio";
            this.PrivateRadio.Size = new System.Drawing.Size(57, 17);
            this.PrivateRadio.TabIndex = 66;
            this.PrivateRadio.TabStop = true;
            this.PrivateRadio.Text = "private";
            this.PrivateRadio.UseVisualStyleBackColor = true;
            this.PrivateRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // DefaultRadio
            // 
            this.DefaultRadio.AutoSize = true;
            this.DefaultRadio.Location = new System.Drawing.Point(151, 19);
            this.DefaultRadio.Name = "DefaultRadio";
            this.DefaultRadio.Size = new System.Drawing.Size(57, 17);
            this.DefaultRadio.TabIndex = 8;
            this.DefaultRadio.TabStop = true;
            this.DefaultRadio.Text = "default";
            this.DefaultRadio.UseVisualStyleBackColor = true;
            this.DefaultRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // Inherit
            // 
            this.Inherit.FormattingEnabled = true;
            this.Inherit.Location = new System.Drawing.Point(94, 52);
            this.Inherit.Name = "Inherit";
            this.Inherit.Size = new System.Drawing.Size(137, 21);
            this.Inherit.TabIndex = 61;
            this.Inherit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Extends:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConstructorCheck);
            this.groupBox1.Controls.Add(this.FinalCheck);
            this.groupBox1.Location = new System.Drawing.Point(17, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 57);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // ConstructorCheck
            // 
            this.ConstructorCheck.AutoSize = true;
            this.ConstructorCheck.Location = new System.Drawing.Point(83, 23);
            this.ConstructorCheck.Name = "ConstructorCheck";
            this.ConstructorCheck.Size = new System.Drawing.Size(116, 17);
            this.ConstructorCheck.TabIndex = 75;
            this.ConstructorCheck.Text = "include constructor";
            this.ConstructorCheck.UseVisualStyleBackColor = true;
            // 
            // FinalCheck
            // 
            this.FinalCheck.AutoSize = true;
            this.FinalCheck.Location = new System.Drawing.Point(20, 23);
            this.FinalCheck.Name = "FinalCheck";
            this.FinalCheck.Size = new System.Drawing.Size(45, 17);
            this.FinalCheck.TabIndex = 10;
            this.FinalCheck.Text = "final";
            this.FinalCheck.UseVisualStyleBackColor = true;
            this.FinalCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(14, 15);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(74, 13);
            this.label100.TabIndex = 66;
            this.label100.Text = "Project Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comments);
            this.groupBox4.Location = new System.Drawing.Point(257, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 96);
            this.groupBox4.TabIndex = 73;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comments: (// maybe omitted)";
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(9, 21);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(192, 65);
            this.comments.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(166, 62);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(35, 13);
            this.linkLabel2.TabIndex = 63;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add...";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Click \"Add...\" to insert contents."});
            this.listBox2.Location = new System.Drawing.Point(10, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(191, 43);
            this.listBox2.TabIndex = 62;
            this.listBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(389, 264);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 65;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(308, 264);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 64;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            this.OK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Location = new System.Drawing.Point(257, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 83);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interface(s) to implement:";
            // 
            // NewObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(469, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ObjectType);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.ObjectName);
            this.Controls.Add(this.access);
            this.Controls.Add(this.Inherit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewObject";
            this.Text = "Insert New Object...";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewObject_KeyPress);
            this.access.ResumeLayout(false);
            this.access.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ObjectType;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TextBox ObjectName;
        private System.Windows.Forms.GroupBox access;
        private System.Windows.Forms.RadioButton DefaultRadio;
        private System.Windows.Forms.ComboBox Inherit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox FinalCheck;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton PublicRadio;
        private System.Windows.Forms.RadioButton PrivateRadio;
        private System.Windows.Forms.CheckBox ConstructorCheck;
    }
}