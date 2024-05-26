using StrategyPattern.WinForms.Controller;

namespace StrategyPattern.WinForms
{
    public partial class Form1 : Form
    {
        private readonly SortProcess sortProcess;
        public Form1()
        {
            InitializeComponent();
            sortProcess = new SortProcess();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            
            if (cb_Sort_Method.SelectedItem is null)
            {
                lbl_warning.Visible = true;
                lbl_warning.Text = "Select Sort Method!";
            }

            else if(txt_userInput.Text == "")
            {
                lbl_warning.Visible = true;
                lbl_warning.Text = "Enter alphabet!";
            }

            else
            {
                lbl_warning.Visible = false;
                switch (cb_Sort_Method.SelectedItem)
                {
                    case "BubbleSort":
                        {
                            sortProcess.SetSortStrategy(new BubbleSort());
                            var result = sortProcess.Sorting(txt_userInput.Text);
                            lbl_Sort_Result.Visible = true;
                            lbl_Sort_Result.Text = $"Sort using BubbleSort\n{result}";
                            break;
                        }

                    case "QuickSort":
                        {
                            sortProcess.SetSortStrategy(new QuickSort());
                            var result = sortProcess.Sorting(txt_userInput.Text);
                            lbl_Sort_Result.Visible = true;
                            lbl_Sort_Result.Text = $"Sort using QuickSort\n{result}";
                            break;
                        }

                    case "MergeSort":
                        {
                            sortProcess.SetSortStrategy(new MergeSort());
                            var result = sortProcess.Sorting(txt_userInput.Text);
                            lbl_Sort_Result.Visible = true;
                            lbl_Sort_Result.Text = $"Sort using MergeSort\n{result}";
                            break;
                        }
                }
            }                     
        }
    }
}
