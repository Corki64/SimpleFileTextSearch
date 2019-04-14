namespace SimpleTextSearch
{
     partial class simpleTextSearch
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
               this.searchButton = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.searchTextBox = new System.Windows.Forms.TextBox();
               this.resultListBox = new System.Windows.Forms.ListBox();
               this.browseButton = new System.Windows.Forms.Button();
               this.browseFileDBox = new System.Windows.Forms.OpenFileDialog();
               this.fileLocation = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // searchButton
               // 
               this.searchButton.Location = new System.Drawing.Point(463, 111);
               this.searchButton.Name = "searchButton";
               this.searchButton.Size = new System.Drawing.Size(75, 23);
               this.searchButton.TabIndex = 0;
               this.searchButton.Text = "Search";
               this.searchButton.UseVisualStyleBackColor = true;
               this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 15);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(189, 13);
               this.label1.TabIndex = 1;
               this.label1.Text = "Please enter the keyword or sentence:";
               // 
               // searchTextBox
               // 
               this.searchTextBox.Location = new System.Drawing.Point(207, 12);
               this.searchTextBox.Name = "searchTextBox";
               this.searchTextBox.Size = new System.Drawing.Size(331, 20);
               this.searchTextBox.TabIndex = 2;
               // 
               // resultListBox
               // 
               this.resultListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.resultListBox.FormattingEnabled = true;
               this.resultListBox.Location = new System.Drawing.Point(0, 135);
               this.resultListBox.Name = "resultListBox";
               this.resultListBox.Size = new System.Drawing.Size(546, 173);
               this.resultListBox.TabIndex = 3;
               // 
               // browseButton
               // 
               this.browseButton.Location = new System.Drawing.Point(15, 111);
               this.browseButton.Name = "browseButton";
               this.browseButton.Size = new System.Drawing.Size(75, 23);
               this.browseButton.TabIndex = 4;
               this.browseButton.Text = "Browse";
               this.browseButton.UseVisualStyleBackColor = true;
               this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
               // 
               // browseFileDBox
               // 
               this.browseFileDBox.FileName = "openFileDialog1";
               // 
               // fileLocation
               // 
               this.fileLocation.AutoSize = true;
               this.fileLocation.Location = new System.Drawing.Point(96, 116);
               this.fileLocation.Name = "fileLocation";
               this.fileLocation.Size = new System.Drawing.Size(0, 13);
               this.fileLocation.TabIndex = 5;
               // 
               // simpleTextSearch
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(546, 308);
               this.Controls.Add(this.fileLocation);
               this.Controls.Add(this.browseButton);
               this.Controls.Add(this.resultListBox);
               this.Controls.Add(this.searchTextBox);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.searchButton);
               this.Name = "simpleTextSearch";
               this.Text = "Simple Text Search";
               this.Load += new System.EventHandler(this.simpleTextSearch_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Button searchButton;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox searchTextBox;
          private System.Windows.Forms.ListBox resultListBox;
          private System.Windows.Forms.Button browseButton;
          private System.Windows.Forms.OpenFileDialog browseFileDBox;
          private System.Windows.Forms.Label fileLocation;
     }
}

