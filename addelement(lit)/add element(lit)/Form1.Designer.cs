namespace add_element_lit_
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
            this.AddButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DupButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.UniqueButton = new System.Windows.Forms.Button();
            this.ascendingButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.oddButton = new System.Windows.Forms.Button();
            this.newValueButton = new System.Windows.Forms.Button();
            this.AvarageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(302, 44);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(166, 29);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(69, 49);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(214, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(69, 99);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(214, 270);
            this.showRichTextBox.TabIndex = 2;
            this.showRichTextBox.Text = "";
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(302, 79);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(166, 25);
            this.SumButton.TabIndex = 3;
            this.SumButton.Text = "SUM";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(302, 110);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(166, 32);
            this.reverseButton.TabIndex = 4;
            this.reverseButton.Text = "Revers";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(302, 148);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(166, 33);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // DupButton
            // 
            this.DupButton.Location = new System.Drawing.Point(302, 187);
            this.DupButton.Name = "DupButton";
            this.DupButton.Size = new System.Drawing.Size(166, 33);
            this.DupButton.TabIndex = 6;
            this.DupButton.Text = "Duplicate";
            this.DupButton.UseVisualStyleBackColor = true;
            this.DupButton.Click += new System.EventHandler(this.DupButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(302, 265);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(166, 36);
            this.SortButton.TabIndex = 7;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // UniqueButton
            // 
            this.UniqueButton.Location = new System.Drawing.Point(302, 226);
            this.UniqueButton.Name = "UniqueButton";
            this.UniqueButton.Size = new System.Drawing.Size(166, 33);
            this.UniqueButton.TabIndex = 8;
            this.UniqueButton.Text = "Uniqe";
            this.UniqueButton.UseVisualStyleBackColor = true;
            this.UniqueButton.Click += new System.EventHandler(this.UniqueButton_Click);
            // 
            // ascendingButton
            // 
            this.ascendingButton.Location = new System.Drawing.Point(302, 307);
            this.ascendingButton.Name = "ascendingButton";
            this.ascendingButton.Size = new System.Drawing.Size(166, 38);
            this.ascendingButton.TabIndex = 9;
            this.ascendingButton.Text = "Ascending & Decending";
            this.ascendingButton.UseVisualStyleBackColor = true;
            this.ascendingButton.Click += new System.EventHandler(this.ascendingButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(474, 44);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(151, 25);
            this.maxButton.TabIndex = 10;
            this.maxButton.Text = "Maximum & Minimun";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // oddButton
            // 
            this.oddButton.Location = new System.Drawing.Point(474, 81);
            this.oddButton.Name = "oddButton";
            this.oddButton.Size = new System.Drawing.Size(151, 23);
            this.oddButton.TabIndex = 11;
            this.oddButton.Text = "Odd & Even";
            this.oddButton.UseVisualStyleBackColor = true;
            this.oddButton.Click += new System.EventHandler(this.oddButton_Click);
            // 
            // newValueButton
            // 
            this.newValueButton.Location = new System.Drawing.Point(474, 118);
            this.newValueButton.Name = "newValueButton";
            this.newValueButton.Size = new System.Drawing.Size(151, 24);
            this.newValueButton.TabIndex = 12;
            this.newValueButton.Text = "New Value";
            this.newValueButton.UseVisualStyleBackColor = true;
            this.newValueButton.Click += new System.EventHandler(this.newValueButton_Click);
            // 
            // AvarageButton
            // 
            this.AvarageButton.Location = new System.Drawing.Point(475, 149);
            this.AvarageButton.Name = "AvarageButton";
            this.AvarageButton.Size = new System.Drawing.Size(150, 32);
            this.AvarageButton.TabIndex = 13;
            this.AvarageButton.Text = "Avareage";
            this.AvarageButton.UseVisualStyleBackColor = true;
            this.AvarageButton.Click += new System.EventHandler(this.AvarageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 436);
            this.Controls.Add(this.AvarageButton);
            this.Controls.Add(this.newValueButton);
            this.Controls.Add(this.oddButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.ascendingButton);
            this.Controls.Add(this.UniqueButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DupButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DupButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button UniqueButton;
        private System.Windows.Forms.Button ascendingButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button oddButton;
        private System.Windows.Forms.Button newValueButton;
        private System.Windows.Forms.Button AvarageButton;
    }
}

