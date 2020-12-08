namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.FNchB = new System.Windows.Forms.CheckBox();
            this.LNchB = new System.Windows.Forms.CheckBox();
            this.FACchB = new System.Windows.Forms.CheckBox();
            this.SPECchB = new System.Windows.Forms.CheckBox();
            this.CRSchB = new System.Windows.Forms.CheckBox();
            this.RMchB = new System.Windows.Forms.CheckBox();
            this.CHINchB = new System.Windows.Forms.CheckBox();
            this.comBoxFn = new System.Windows.Forms.ComboBox();
            this.comBoxLn = new System.Windows.Forms.ComboBox();
            this.comBoxFac = new System.Windows.Forms.ComboBox();
            this.comBoxSpec = new System.Windows.Forms.ComboBox();
            this.comBoxCourse = new System.Windows.Forms.ComboBox();
            this.comBoxRoom = new System.Windows.Forms.ComboBox();
            this.comBoxCheckIn = new System.Windows.Forms.ComboBox();
            this.SaxBtn = new System.Windows.Forms.RadioButton();
            this.toHtml = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.DomBtn = new System.Windows.Forms.RadioButton();
            this.LinqBtn = new System.Windows.Forms.RadioButton();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FNchB
            // 
            this.FNchB.AutoSize = true;
            this.FNchB.Location = new System.Drawing.Point(26, 45);
            this.FNchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FNchB.Name = "FNchB";
            this.FNchB.Size = new System.Drawing.Size(102, 24);
            this.FNchB.TabIndex = 1;
            this.FNchB.Text = "First Name";
            this.FNchB.UseVisualStyleBackColor = true;
            // 
            // LNchB
            // 
            this.LNchB.AutoSize = true;
            this.LNchB.Location = new System.Drawing.Point(26, 93);
            this.LNchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LNchB.Name = "LNchB";
            this.LNchB.Size = new System.Drawing.Size(101, 24);
            this.LNchB.TabIndex = 1;
            this.LNchB.Text = "Last Name";
            this.LNchB.UseVisualStyleBackColor = true;
            // 
            // FACchB
            // 
            this.FACchB.AutoSize = true;
            this.FACchB.Location = new System.Drawing.Point(26, 138);
            this.FACchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FACchB.Name = "FACchB";
            this.FACchB.Size = new System.Drawing.Size(76, 24);
            this.FACchB.TabIndex = 1;
            this.FACchB.Text = "Faculty";
            this.FACchB.UseVisualStyleBackColor = true;
            // 
            // SPECchB
            // 
            this.SPECchB.AutoSize = true;
            this.SPECchB.Location = new System.Drawing.Point(26, 184);
            this.SPECchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SPECchB.Name = "SPECchB";
            this.SPECchB.Size = new System.Drawing.Size(124, 24);
            this.SPECchB.TabIndex = 1;
            this.SPECchB.Text = "Specialization";
            this.SPECchB.UseVisualStyleBackColor = true;
            // 
            // CRSchB
            // 
            this.CRSchB.AutoSize = true;
            this.CRSchB.Location = new System.Drawing.Point(26, 227);
            this.CRSchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRSchB.Name = "CRSchB";
            this.CRSchB.Size = new System.Drawing.Size(76, 24);
            this.CRSchB.TabIndex = 1;
            this.CRSchB.Text = "Course";
            this.CRSchB.UseVisualStyleBackColor = true;
            // 
            // RMchB
            // 
            this.RMchB.AutoSize = true;
            this.RMchB.Location = new System.Drawing.Point(26, 274);
            this.RMchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RMchB.Name = "RMchB";
            this.RMchB.Size = new System.Drawing.Size(71, 24);
            this.RMchB.TabIndex = 1;
            this.RMchB.Text = "Room";
            this.RMchB.UseVisualStyleBackColor = true;
            // 
            // CHINchB
            // 
            this.CHINchB.AutoSize = true;
            this.CHINchB.Location = new System.Drawing.Point(26, 321);
            this.CHINchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHINchB.Name = "CHINchB";
            this.CHINchB.Size = new System.Drawing.Size(159, 24);
            this.CHINchB.TabIndex = 1;
            this.CHINchB.Text = "When Checked Into";
            this.CHINchB.UseVisualStyleBackColor = true;
            // 
            // comBoxFn
            // 
            this.comBoxFn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxFn.FormattingEnabled = true;
            this.comBoxFn.Location = new System.Drawing.Point(209, 43);
            this.comBoxFn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBoxFn.Name = "comBoxFn";
            this.comBoxFn.Size = new System.Drawing.Size(228, 28);
            this.comBoxFn.TabIndex = 2;
            // 
            // comBoxLn
            // 
            this.comBoxLn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLn.FormattingEnabled = true;
            this.comBoxLn.Location = new System.Drawing.Point(209, 91);
            this.comBoxLn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBoxLn.Name = "comBoxLn";
            this.comBoxLn.Size = new System.Drawing.Size(228, 28);
            this.comBoxLn.TabIndex = 2;
            // 
            // comBoxFac
            // 
            this.comBoxFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxFac.FormattingEnabled = true;
            this.comBoxFac.Location = new System.Drawing.Point(209, 135);
            this.comBoxFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBoxFac.Name = "comBoxFac";
            this.comBoxFac.Size = new System.Drawing.Size(228, 28);
            this.comBoxFac.TabIndex = 2;
            // 
            // comBoxSpec
            // 
            this.comBoxSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSpec.FormattingEnabled = true;
            this.comBoxSpec.Location = new System.Drawing.Point(209, 182);
            this.comBoxSpec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBoxSpec.Name = "comBoxSpec";
            this.comBoxSpec.Size = new System.Drawing.Size(228, 28);
            this.comBoxSpec.TabIndex = 2;
            // 
            // comBoxCourse
            // 
            this.comBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCourse.FormattingEnabled = true;
            this.comBoxCourse.Location = new System.Drawing.Point(209, 225);
            this.comBoxCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBoxCourse.Name = "comBoxCourse";
            this.comBoxCourse.Size = new System.Drawing.Size(228, 28);
            this.comBoxCourse.TabIndex = 2;
            // 
            // comBoxRoom
            // 
            this.comBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxRoom.FormattingEnabled = true;
            this.comBoxRoom.Location = new System.Drawing.Point(209, 272);
            this.comBoxRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBoxRoom.Name = "comBoxRoom";
            this.comBoxRoom.Size = new System.Drawing.Size(228, 28);
            this.comBoxRoom.TabIndex = 2;
            // 
            // comBoxCheckIn
            // 
            this.comBoxCheckIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCheckIn.FormattingEnabled = true;
            this.comBoxCheckIn.Location = new System.Drawing.Point(209, 318);
            this.comBoxCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBoxCheckIn.Name = "comBoxCheckIn";
            this.comBoxCheckIn.Size = new System.Drawing.Size(228, 28);
            this.comBoxCheckIn.TabIndex = 2;
            // 
            // SaxBtn
            // 
            this.SaxBtn.AutoSize = true;
            this.SaxBtn.Location = new System.Drawing.Point(341, 378);
            this.SaxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaxBtn.Name = "SaxBtn";
            this.SaxBtn.Size = new System.Drawing.Size(57, 24);
            this.SaxBtn.TabIndex = 3;
            this.SaxBtn.TabStop = true;
            this.SaxBtn.Text = "SAX";
            this.SaxBtn.UseVisualStyleBackColor = true;
            // 
            // toHtml
            // 
            this.toHtml.Location = new System.Drawing.Point(166, 461);
            this.toHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toHtml.Name = "toHtml";
            this.toHtml.Size = new System.Drawing.Size(126, 42);
            this.toHtml.TabIndex = 4;
            this.toHtml.Text = "To HTML";
            this.toHtml.UseVisualStyleBackColor = true;
            this.toHtml.Click += new System.EventHandler(this.toHtml_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(492, 22);
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(839, 515);
            this.TextBox.TabIndex = 6;
            this.TextBox.Text = "";
            // 
            // DomBtn
            // 
            this.DomBtn.AutoSize = true;
            this.DomBtn.Location = new System.Drawing.Point(199, 378);
            this.DomBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DomBtn.Name = "DomBtn";
            this.DomBtn.Size = new System.Drawing.Size(65, 24);
            this.DomBtn.TabIndex = 3;
            this.DomBtn.TabStop = true;
            this.DomBtn.Text = "DOM";
            this.DomBtn.UseVisualStyleBackColor = true;
            // 
            // LinqBtn
            // 
            this.LinqBtn.AutoSize = true;
            this.LinqBtn.Location = new System.Drawing.Point(52, 378);
            this.LinqBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinqBtn.Name = "LinqBtn";
            this.LinqBtn.Size = new System.Drawing.Size(63, 24);
            this.LinqBtn.TabIndex = 3;
            this.LinqBtn.TabStop = true;
            this.LinqBtn.Text = "LINQ";
            this.LinqBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(26, 461);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(117, 42);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(311, 462);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 42);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear table";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 562);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.toHtml);
            this.Controls.Add(this.DomBtn);
            this.Controls.Add(this.LinqBtn);
            this.Controls.Add(this.SaxBtn);
            this.Controls.Add(this.comBoxCheckIn);
            this.Controls.Add(this.comBoxRoom);
            this.Controls.Add(this.comBoxCourse);
            this.Controls.Add(this.comBoxSpec);
            this.Controls.Add(this.comBoxFac);
            this.Controls.Add(this.comBoxLn);
            this.Controls.Add(this.comBoxFn);
            this.Controls.Add(this.CHINchB);
            this.Controls.Add(this.RMchB);
            this.Controls.Add(this.CRSchB);
            this.Controls.Add(this.SPECchB);
            this.Controls.Add(this.FACchB);
            this.Controls.Add(this.LNchB);
            this.Controls.Add(this.FNchB);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button ClearButton;

        private System.Windows.Forms.Button toHtml;

        private System.Windows.Forms.RichTextBox TextBox;

        private System.Windows.Forms.ComboBox comBoxCheckIn;
        private System.Windows.Forms.ComboBox comBoxCourse;
        private System.Windows.Forms.ComboBox comBoxFac;
        private System.Windows.Forms.ComboBox comBoxLn;
        private System.Windows.Forms.ComboBox comBoxRoom;
        private System.Windows.Forms.ComboBox comBoxSpec;

        private System.Windows.Forms.ComboBox comBoxFn;

        #endregion

        private System.Windows.Forms.CheckBox FNchB;
        private System.Windows.Forms.CheckBox LNchB;
        private System.Windows.Forms.CheckBox FACchB;
        private System.Windows.Forms.CheckBox SPECchB;
        private System.Windows.Forms.CheckBox CRSchB;
        private System.Windows.Forms.CheckBox RMchB;
        private System.Windows.Forms.CheckBox CHINchB;
        private System.Windows.Forms.RadioButton SaxBtn;
        private System.Windows.Forms.RadioButton DomBtn;
        private System.Windows.Forms.RadioButton LinqBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}