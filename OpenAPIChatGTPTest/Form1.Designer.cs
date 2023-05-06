namespace OpenAPIChatGTPTest
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Questiontxt = new System.Windows.Forms.TextBox();
            this.Responsetxt = new System.Windows.Forms.TextBox();
            this.lblChatGPTResponse = new System.Windows.Forms.Label();
            this.lblWhatQuestion = new System.Windows.Forms.Label();
            this.Languages = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitBtn.Location = new System.Drawing.Point(1000, 102);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(175, 24);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Ask";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Questiontxt
            // 
            this.Questiontxt.Location = new System.Drawing.Point(36, 102);
            this.Questiontxt.Name = "Questiontxt";
            this.Questiontxt.Size = new System.Drawing.Size(958, 23);
            this.Questiontxt.TabIndex = 1;
            // 
            // Responsetxt
            // 
            this.Responsetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Responsetxt.Location = new System.Drawing.Point(36, 176);
            this.Responsetxt.Multiline = true;
            this.Responsetxt.Name = "Responsetxt";
            this.Responsetxt.Size = new System.Drawing.Size(1139, 576);
            this.Responsetxt.TabIndex = 2;
            // 
            // lblChatGPTResponse
            // 
            this.lblChatGPTResponse.AutoSize = true;
            this.lblChatGPTResponse.Location = new System.Drawing.Point(36, 158);
            this.lblChatGPTResponse.Name = "lblChatGPTResponse";
            this.lblChatGPTResponse.Size = new System.Drawing.Size(253, 15);
            this.lblChatGPTResponse.TabIndex = 3;
            this.lblChatGPTResponse.Text = "Answer                                                                     ";
            // 
            // lblWhatQuestion
            // 
            this.lblWhatQuestion.AutoSize = true;
            this.lblWhatQuestion.Location = new System.Drawing.Point(36, 84);
            this.lblWhatQuestion.Name = "lblWhatQuestion";
            this.lblWhatQuestion.Size = new System.Drawing.Size(194, 15);
            this.lblWhatQuestion.TabIndex = 4;
            this.lblWhatQuestion.Text = "What Question do you want to ask?";
            // 
            // Languages
            // 
            this.Languages.FormattingEnabled = true;
            this.Languages.Location = new System.Drawing.Point(36, 38);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(162, 23);
            this.Languages.TabIndex = 5;
            this.Languages.SelectedIndexChanged += new System.EventHandler(this.Languages_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(36, 20);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(109, 15);
            this.lblLanguage.TabIndex = 6;
            this.lblLanguage.Text = "Selected Language:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 790);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.lblWhatQuestion);
            this.Controls.Add(this.lblChatGPTResponse);
            this.Controls.Add(this.Responsetxt);
            this.Controls.Add(this.Questiontxt);
            this.Controls.Add(this.SubmitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SubmitBtn;
        private TextBox Questiontxt;
        private TextBox Responsetxt;
        private Label lblChatGPTResponse;
        private Label lblWhatQuestion;
        private ComboBox Languages;
        private Label lblLanguage;
    }
}