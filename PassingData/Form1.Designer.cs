
namespace PassingData
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
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.num3Textbox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.num3Label = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.ReturnValueBtn = new System.Windows.Forms.Button();
            this.GlobalDataBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(108, 122);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(125, 27);
            this.num1TextBox.TabIndex = 0;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(339, 122);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(125, 27);
            this.num2TextBox.TabIndex = 1;
            // 
            // num3Textbox
            // 
            this.num3Textbox.Location = new System.Drawing.Point(570, 122);
            this.num3Textbox.Name = "num3Textbox";
            this.num3Textbox.Size = new System.Drawing.Size(125, 27);
            this.num3Textbox.TabIndex = 2;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(339, 243);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(125, 27);
            this.answerTextBox.TabIndex = 3;
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Location = new System.Drawing.Point(108, 81);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(50, 20);
            this.num1Label.TabIndex = 4;
            this.num1Label.Text = "num 1";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(339, 81);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(50, 20);
            this.num2Label.TabIndex = 5;
            this.num2Label.Text = "num 2";
            // 
            // num3Label
            // 
            this.num3Label.AutoSize = true;
            this.num3Label.Location = new System.Drawing.Point(570, 81);
            this.num3Label.Name = "num3Label";
            this.num3Label.Size = new System.Drawing.Size(50, 20);
            this.num3Label.TabIndex = 6;
            this.num3Label.Text = "num 3";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(339, 200);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(55, 20);
            this.answerLabel.TabIndex = 7;
            this.answerLabel.Text = "answer";
            // 
            // ReturnValueBtn
            // 
            this.ReturnValueBtn.Location = new System.Drawing.Point(108, 362);
            this.ReturnValueBtn.Name = "ReturnValueBtn";
            this.ReturnValueBtn.Size = new System.Drawing.Size(131, 29);
            this.ReturnValueBtn.TabIndex = 8;
            this.ReturnValueBtn.Text = "Return Value";
            this.ReturnValueBtn.UseVisualStyleBackColor = true;
            this.ReturnValueBtn.Click += new System.EventHandler(this.ReturnValueBtn_Click);
            // 
            // GlobalDataBtn
            // 
            this.GlobalDataBtn.Location = new System.Drawing.Point(339, 362);
            this.GlobalDataBtn.Name = "GlobalDataBtn";
            this.GlobalDataBtn.Size = new System.Drawing.Size(125, 29);
            this.GlobalDataBtn.TabIndex = 9;
            this.GlobalDataBtn.Text = "Global Data";
            this.GlobalDataBtn.UseVisualStyleBackColor = true;
            this.GlobalDataBtn.Click += new System.EventHandler(this.GlobalDataBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(570, 362);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(144, 29);
            this.refBtn.TabIndex = 10;
            this.refBtn.Text = "Pass-by-Reference";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.GlobalDataBtn);
            this.Controls.Add(this.ReturnValueBtn);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.num3Label);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.num3Textbox);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.TextBox num3Textbox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Label num3Label;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button ReturnValueBtn;
        private System.Windows.Forms.Button GlobalDataBtn;
        private System.Windows.Forms.Button refBtn;
    }
}

