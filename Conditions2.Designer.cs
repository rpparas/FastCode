namespace SampleApp
{
    partial class Conditions2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LocationCombo = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RightButton = new System.Windows.Forms.Button();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.LeftButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "EQUAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "OR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "AND";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 90);
            this.button4.TabIndex = 3;
            this.button4.Text = "NOT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(91, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 357);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.LocationCombo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Cancel);
            this.tabPage1.Controls.Add(this.GenerateButton);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.RightButton);
            this.tabPage1.Controls.Add(this.Operator);
            this.tabPage1.Controls.Add(this.LeftButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Format";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LocationCombo
            // 
            this.LocationCombo.FormattingEnabled = true;
            this.LocationCombo.Location = new System.Drawing.Point(70, 292);
            this.LocationCombo.Name = "LocationCombo";
            this.LocationCombo.Size = new System.Drawing.Size(121, 21);
            this.LocationCombo.TabIndex = 77;
            this.LocationCombo.Text = "[Select Method]";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(381, 287);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 28);
            this.Cancel.TabIndex = 36;
            this.Cancel.Text = "Close Form";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(282, 287);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(93, 28);
            this.GenerateButton.TabIndex = 35;
            this.GenerateButton.Text = "Generate Code";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(13, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(454, 207);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(304, 15);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(163, 53);
            this.RightButton.TabIndex = 33;
            this.RightButton.Text = "Click to add/edit expression.";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // Operator
            // 
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "is equal to",
            "is not equal to",
            "is greater than or equal",
            "is greater than",
            "is less than or equal",
            "is less than"});
            this.Operator.Location = new System.Drawing.Point(183, 32);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(115, 21);
            this.Operator.TabIndex = 32;
            this.Operator.Text = "is equal to";
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(13, 15);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(163, 53);
            this.LeftButton.TabIndex = 1;
            this.LeftButton.Text = "Click to add/edit expression.";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Location:";
            // 
            // Conditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 360);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Conditions";
            this.Text = "Conditions";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Conditions_MouseMove);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ComboBox LocationCombo;
        private System.Windows.Forms.Label label3;

    }
}