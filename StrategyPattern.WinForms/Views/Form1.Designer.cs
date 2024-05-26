namespace StrategyPattern.WinForms
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
            txt_userInput = new TextBox();
            lbl_User_Input = new Label();
            cb_Sort_Method = new ComboBox();
            btn_Sort = new Button();
            lbl_Sort_Result = new Label();
            lbl_warning = new Label();
            SuspendLayout();
            // 
            // txt_userInput
            // 
            txt_userInput.Location = new Point(12, 67);
            txt_userInput.Multiline = true;
            txt_userInput.Name = "txt_userInput";
            txt_userInput.Size = new Size(230, 34);
            txt_userInput.TabIndex = 0;
            // 
            // lbl_User_Input
            // 
            lbl_User_Input.AutoSize = true;
            lbl_User_Input.Location = new Point(12, 35);
            lbl_User_Input.Name = "lbl_User_Input";
            lbl_User_Input.Size = new Size(106, 20);
            lbl_User_Input.TabIndex = 1;
            lbl_User_Input.Text = "Enter alphabet";
            // 
            // cb_Sort_Method
            // 
            cb_Sort_Method.FormattingEnabled = true;
            cb_Sort_Method.Items.AddRange(new object[] { "BubbleSort", "QuickSort", "MergeSort" });
            cb_Sort_Method.Location = new Point(12, 128);
            cb_Sort_Method.Name = "cb_Sort_Method";
            cb_Sort_Method.Size = new Size(230, 28);
            cb_Sort_Method.TabIndex = 2;
            cb_Sort_Method.Text = "Select sort method";
            // 
            // btn_Sort
            // 
            btn_Sort.Location = new Point(12, 184);
            btn_Sort.Name = "btn_Sort";
            btn_Sort.Size = new Size(118, 29);
            btn_Sort.TabIndex = 3;
            btn_Sort.Text = "Sort";
            btn_Sort.UseVisualStyleBackColor = true;
            btn_Sort.Click += btn_Sort_Click;
            // 
            // lbl_Sort_Result
            // 
            lbl_Sort_Result.AutoSize = true;
            lbl_Sort_Result.Font = new Font("Segoe UI", 13.8F);
            lbl_Sort_Result.Location = new Point(460, 67);
            lbl_Sort_Result.Name = "lbl_Sort_Result";
            lbl_Sort_Result.Size = new Size(76, 31);
            lbl_Sort_Result.TabIndex = 4;
            lbl_Sort_Result.Text = "label1";
            lbl_Sort_Result.Visible = false;
            // 
            // lbl_warning
            // 
            lbl_warning.AutoSize = true;
            lbl_warning.Font = new Font("Segoe UI", 13.8F);
            lbl_warning.Location = new Point(460, 122);
            lbl_warning.Name = "lbl_warning";
            lbl_warning.Size = new Size(76, 31);
            lbl_warning.TabIndex = 5;
            lbl_warning.Text = "label1";
            lbl_warning.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_warning);
            Controls.Add(lbl_Sort_Result);
            Controls.Add(btn_Sort);
            Controls.Add(cb_Sort_Method);
            Controls.Add(lbl_User_Input);
            Controls.Add(txt_userInput);
            Name = "Form1";
            Text = "Sort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_userInput;
        private Label lbl_User_Input;
        private ComboBox cb_Sort_Method;
        private Button btn_Sort;
        private Label lbl_Sort_Result;
        private Label lbl_warning;
    }
}
