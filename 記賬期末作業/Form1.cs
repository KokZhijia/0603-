using System;
using System.Security.Cryptography.X509Certificates;


namespace 記賬期末作業
{
    public partial class Form1 : Form
    {
        private string currentMonth;
        private double monthlyTotal = 0;
        private double totalExpenses = 0;
        private string selectedCategory = "";
        private double spendingLimit = double.MaxValue;
        public Form1()
        {
            InitializeComponent();
            InitializeCategoryButtons();
            currentMonth = DateTime.Now.ToString("yyyy年MM月");
            monthlyTotal = 0; // 初始化本月总消费为 0
            labelTotal.Text = $"本月總計: {monthlyTotal} 元"; // 更新本月总计标签

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("請先選擇一個消費項目。"); // 如果没有选择消费类别就添加，就會显示提示信息
                return;
            }

            string date = dateTimePicker1.Value.ToString("yyyy年 MM月dd日");
            string month = dateTimePicker1.Value.ToString("yyyy年MM月");
            string item = selectedCategory;
            string amount = textBoxAmount.Text;

            if (month != currentMonth) //如果記錄不同月份就會跳出視窗顯示上個月份的總計并且會重置
            {
                MessageBox.Show($"上個月({currentMonth})你花了 {monthlyTotal} 元。"); //显示上个月的总消费
                currentMonth = month;
                monthlyTotal = 0;// 重置本月总消费
                dataGridView.Rows.Clear(); // 清空表格
            }

            if (double.TryParse(amount, out double parsedAmount))//(ChatGPT)
            {
                dataGridView.Rows.Add(date, item, parsedAmount); // 添加消费记录到表格
                monthlyTotal += parsedAmount; // 更新本月总消费
                totalExpenses += parsedAmount;  // 更新总消费
                labelTotal.Text = $"本月總計: {monthlyTotal} 元";  // 更新本月总计标签

                if (monthlyTotal > spendingLimit)
                {
                    MessageBox.Show($"你已經達到 {monthlyTotal} 元，請注意消費！");// 提示用戶消费已达上限
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的金額。"); // 如果沒有選取消費項目就會跳出提示：输入有效的金额
            }

            textBoxAmount.Clear();  // 清空金额输入框
            selectedCategory = ""; // 清空选择的消费项目

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                dataGridView.Rows.Remove(row);  // 删除选中的行
            }
            labelTotal.Text = $"本月總計: {monthlyTotal} 元";
        }

        private void buttonSave_Click(object sender, EventArgs e) //(ChatGPT)
        {
            using (StreamWriter sw = new StreamWriter("data.txt")) //會存儲在本機的data.txt裏面
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    string date = row.Cells[0].Value.ToString();
                    string item = row.Cells[1].Value.ToString();
                    string amount = row.Cells[2].Value.ToString();

                    sw.WriteLine($"{date},{item},{amount}");   // 保存记录到文件
                }
            }
            MessageBox.Show("保存成功！");
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                selectedCategory = clickedButton.Text;// 设置选择的消费类别
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeCategoryButtons()// 每个按钮绑定事件处理程序（通過ChatGPT 改進，一開始我們是每個按鈕都綁定在DataGridView裏面，通過gpt我們改爲現在目前的程式碼）
        {
            button1.Click += buttonCategory_Click;
            button2.Click += buttonCategory_Click;
            buttonCloth.Click += buttonCategory_Click;
            button3.Click += buttonCategory_Click;
            buttontravel.Click += buttonCategory_Click;
            buttonRental.Click += buttonCategory_Click;
            buttonPlay.Click += buttonCategory_Click;
            buttonMobile.Click += buttonCategory_Click;
            buttonHairCut.Click += buttonCategory_Click;
            buttonlxing.Click += buttonCategory_Click;
            buttonBook.Click += buttonCategory_Click;
            buttonRepair.Click += buttonCategory_Click;
            buttonMedical.Click += buttonCategory_Click;
            buttonPet.Click += buttonCategory_Click;
            buttonExercise.Click += buttonCategory_Click;
            buttonOther.Click += buttonCategory_Click;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCloth_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
         
        }

        private void buttontravel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRental_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMobile_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonHairCut_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonlxing_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonRepair_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonMedical_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonExercise_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateTotalExpensesLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalExpensesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            totalExpensesLabel.Text = $"本月總計: {monthlyTotal} 元"; // 更新本月总计标签
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)//(這裏是我們自己寫的有錯誤，我們使用系統推薦的更改）
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                dateTimePicker1.Value = DateTime.Parse(row.Cells[0].Value.ToString());  // 更新日期选择器的值
                selectedCategory = row.Cells[1].Value.ToString(); // 更新选择的消费类别
                textBoxAmount.Text = row.Cells[2].Value.ToString(); // 更新金额输入框的值

                
                dataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonShowChart_Click(object sender, EventArgs e)
        {
            ShowExpenseSummary();// 显示消费總計

        }

        private void buttonSearch_Click(object sender, EventArgs e) //（ChatGPT）
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox("请输入搜索关键词：", "搜索记录");
            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow && (row.Cells[1].Value.ToString().Contains(keyword) || row.Cells[2].Value.ToString().Contains(keyword)))
                    {
                        row.Selected = true;// 當用戶搜索到关键词就會選取
                    }
                    else
                    {
                        row.Selected = false; // 取消选中不包含关键词的行
                    }
                }
            }
        }

        private void buttonSetLimit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxLImit.Text, out double limit))
            {
                spendingLimit = limit; // 讓用戶设置消费上限
                MessageBox.Show($"消費上限已設置為 {spendingLimit} 元。");
            }
            else
            {
                MessageBox.Show("請輸入有效的消費上限。");
            }
            textBoxLImit.Clear();// 清空消费上限输入框
        }

        private void textBoxLImit_TextChanged(object sender, EventArgs e)
        {

        }


        private void ShowExpenseSummary()
        {
            // 用於存儲各項目的總金額
            Dictionary<string, double> categoryTotals = new Dictionary<string, double>();

            // 遍歷 dataGridView 中的每一行，計算各項目的總金額
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string item = row.Cells[1].Value.ToString();
                double amount = Convert.ToDouble(row.Cells[2].Value);

                if (categoryTotals.ContainsKey(item))
                {
                    categoryTotals[item] += amount;
                }
                else
                {
                    categoryTotals[item] = amount;
                }
            }

            // 構建顯示消費總額的字符串(ChatGPT)
            System.Text.StringBuilder summary = new System.Text.StringBuilder();
            foreach (var category in categoryTotals)
            {
                summary.AppendLine($"{category.Key}: 花了 {category.Value} 元");
            }

            // 顯示消費總額的彈出視窗
            MessageBox.Show(summary.ToString(), "消費總額統計");
        }
    }
}