
namespace WordApp
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtEnterWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtNoOfWord = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWordCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoOfPara = new System.Windows.Forms.TextBox();
            this.txtNoCharWithSpace = new System.Windows.Forms.TextBox();
            this.txtNoCharWithoutSpace = new System.Windows.Forms.TextBox();
            this.txtEnterText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Text";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(546, 236);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(111, 61);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find Word";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtEnterWord
            // 
            this.txtEnterWord.Location = new System.Drawing.Point(564, 87);
            this.txtEnterWord.Name = "txtEnterWord";
            this.txtEnterWord.Size = new System.Drawing.Size(210, 31);
            this.txtEnterWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(230, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count of words and characters";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(564, 178);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(210, 31);
            this.txtStatus.TabIndex = 5;
            // 
            // txtNoOfWord
            // 
            this.txtNoOfWord.Enabled = false;
            this.txtNoOfWord.Location = new System.Drawing.Point(360, 350);
            this.txtNoOfWord.Name = "txtNoOfWord";
            this.txtNoOfWord.Size = new System.Drawing.Size(81, 31);
            this.txtNoOfWord.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(663, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 61);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWordCount
            // 
            this.btnWordCount.Location = new System.Drawing.Point(607, 352);
            this.btnWordCount.Name = "btnWordCount";
            this.btnWordCount.Size = new System.Drawing.Size(123, 61);
            this.btnWordCount.TabIndex = 8;
            this.btnWordCount.Text = "Word Count";
            this.btnWordCount.UseVisualStyleBackColor = true;
            this.btnWordCount.Click += new System.EventHandler(this.btnWordCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(564, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(564, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of words";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of characters including spaces";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of paragraphs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number of characters without spaces";
            // 
            // txtNoOfPara
            // 
            this.txtNoOfPara.Enabled = false;
            this.txtNoOfPara.Location = new System.Drawing.Point(360, 470);
            this.txtNoOfPara.Name = "txtNoOfPara";
            this.txtNoOfPara.Size = new System.Drawing.Size(81, 31);
            this.txtNoOfPara.TabIndex = 15;
            // 
            // txtNoCharWithSpace
            // 
            this.txtNoCharWithSpace.Enabled = false;
            this.txtNoCharWithSpace.Location = new System.Drawing.Point(360, 390);
            this.txtNoCharWithSpace.Name = "txtNoCharWithSpace";
            this.txtNoCharWithSpace.Size = new System.Drawing.Size(81, 31);
            this.txtNoCharWithSpace.TabIndex = 16;
            // 
            // txtNoCharWithoutSpace
            // 
            this.txtNoCharWithoutSpace.Enabled = false;
            this.txtNoCharWithoutSpace.Location = new System.Drawing.Point(360, 430);
            this.txtNoCharWithoutSpace.Name = "txtNoCharWithoutSpace";
            this.txtNoCharWithoutSpace.Size = new System.Drawing.Size(81, 31);
            this.txtNoCharWithoutSpace.TabIndex = 17;
            // 
            // txtEnterText
            // 
            this.txtEnterText.Location = new System.Drawing.Point(30, 59);
            this.txtEnterText.Name = "txtEnterText";
            this.txtEnterText.Size = new System.Drawing.Size(510, 238);
            this.txtEnterText.TabIndex = 18;
            this.txtEnterText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.txtEnterText);
            this.Controls.Add(this.txtNoCharWithoutSpace);
            this.Controls.Add(this.txtNoCharWithSpace);
            this.Controls.Add(this.txtNoOfPara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWordCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNoOfWord);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnterWord);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtEnterWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtNoOfWord;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoOfPara;
        private System.Windows.Forms.TextBox txtNoCharWithSpace;
        private System.Windows.Forms.TextBox txtNoCharWithoutSpace;
        private System.Windows.Forms.RichTextBox txtEnterText;
    }
}

