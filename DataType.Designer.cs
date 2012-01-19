namespace SampleApp
{
    partial class DataType
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
            this.label102 = new System.Windows.Forms.Label();
            this.OtherDataType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dimensions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ArrayCheck = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dimensions)).BeginInit();
            this.SuspendLayout();
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(12, 15);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(60, 13);
            this.label102.TabIndex = 26;
            this.label102.Text = "Data Type:";
            // 
            // OtherDataType
            // 
            this.OtherDataType.FormattingEnabled = true;
            this.OtherDataType.Location = new System.Drawing.Point(88, 12);
            this.OtherDataType.Name = "OtherDataType";
            this.OtherDataType.Size = new System.Drawing.Size(152, 21);
            this.OtherDataType.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dimensions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ArrayCheck);
            this.groupBox1.Location = new System.Drawing.Point(15, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 57);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treat as Data Structure";
            // 
            // Dimensions
            // 
            this.Dimensions.Location = new System.Drawing.Point(171, 24);
            this.Dimensions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.Size = new System.Drawing.Size(42, 20);
            this.Dimensions.TabIndex = 12;
            this.Dimensions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dimensions:";
            // 
            // ArrayCheck
            // 
            this.ArrayCheck.AutoSize = true;
            this.ArrayCheck.Location = new System.Drawing.Point(17, 25);
            this.ArrayCheck.Name = "ArrayCheck";
            this.ArrayCheck.Size = new System.Drawing.Size(49, 17);
            this.ArrayCheck.TabIndex = 10;
            this.ArrayCheck.Text = "array";
            this.ArrayCheck.UseVisualStyleBackColor = true;
            this.ArrayCheck.CheckedChanged += new System.EventHandler(this.ArrayCheck_CheckedChanged);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(165, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(84, 140);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 66;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // DataType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 175);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.OtherDataType);
            this.Name = "DataType";
            this.Text = "Object Data Type";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dimensions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.ComboBox OtherDataType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Dimensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ArrayCheck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OK;
    }
}