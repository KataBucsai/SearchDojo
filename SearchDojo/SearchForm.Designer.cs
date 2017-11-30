namespace SearchDojo
{
    partial class SearchForm
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
            this.textBoxMatched = new System.Windows.Forms.TextBox();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.labelMatched = new System.Windows.Forms.Label();
            this.labelPattern = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMatched
            // 
            this.textBoxMatched.Enabled = false;
            this.textBoxMatched.Location = new System.Drawing.Point(350, 49);
            this.textBoxMatched.Multiline = true;
            this.textBoxMatched.Name = "textBoxMatched";
            this.textBoxMatched.Size = new System.Drawing.Size(236, 179);
            this.textBoxMatched.TabIndex = 0;
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Location = new System.Drawing.Point(27, 49);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.Size = new System.Drawing.Size(237, 179);
            this.textBoxInputText.TabIndex = 1;
            this.textBoxInputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validate_search_input);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(92, 302);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(172, 20);
            this.textBoxPattern.TabIndex = 2;
            this.textBoxPattern.TextChanged += new System.EventHandler(this.validate_search_input);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.ForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Location = new System.Drawing.Point(350, 302);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(24, 30);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Text";
            // 
            // labelMatched
            // 
            this.labelMatched.AutoSize = true;
            this.labelMatched.Location = new System.Drawing.Point(347, 30);
            this.labelMatched.Name = "labelMatched";
            this.labelMatched.Size = new System.Drawing.Size(49, 13);
            this.labelMatched.TabIndex = 5;
            this.labelMatched.Text = "Matched";
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(36, 307);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(41, 13);
            this.labelPattern.TabIndex = 6;
            this.labelPattern.Text = "Pattern";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 360);
            this.Controls.Add(this.labelPattern);
            this.Controls.Add(this.labelMatched);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxPattern);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.textBoxMatched);
            this.Name = "SearchForm";
            this.Text = "Magic Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatched;
        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelMatched;
        private System.Windows.Forms.Label labelPattern;
    }
}

