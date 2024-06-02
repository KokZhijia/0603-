namespace 記賬期末作業
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            textBoxAmount = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            dataGridView = new DataGridView();
            日期 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            金額 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            buttonCloth = new Button();
            button3 = new Button();
            buttontravel = new Button();
            buttonRental = new Button();
            buttonPlay = new Button();
            buttonMobile = new Button();
            buttonHairCut = new Button();
            buttonlxing = new Button();
            buttonBook = new Button();
            buttonRepair = new Button();
            buttonMedical = new Button();
            buttonPet = new Button();
            buttonExercise = new Button();
            buttonOther = new Button();
            totalExpensesLabel = new Label();
            labelTotal = new Label();
            buttonShowChart = new Button();
            buttonSearch = new Button();
            textBoxLImit = new TextBox();
            buttonSetLimit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(24, 201);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(119, 27);
            textBoxAmount.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(334, 72);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "添加";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(334, 107);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "刪除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(334, 142);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "保存";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { 日期, Column1, 金額 });
            dataGridView.GridColor = SystemColors.ActiveBorder;
            dataGridView.Location = new Point(455, 72);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridViewCellStyle1.Font = new Font("KaiTi", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(457, 408);
            dataGridView.TabIndex = 6;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // 日期
            // 
            日期.HeaderText = "日期";
            日期.MinimumWidth = 6;
            日期.Name = "日期";
            日期.Width = 170;
            // 
            // Column1
            // 
            Column1.HeaderText = "項目";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // 金額
            // 
            金額.HeaderText = "金額";
            金額.MinimumWidth = 6;
            金額.Name = "金額";
            金額.Width = 135;
            // 
            // button1
            // 
            button1.Location = new Point(22, 259);
            button1.Name = "button1";
            button1.Size = new Size(94, 51);
            button1.TabIndex = 9;
            button1.Text = "餐飲";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(122, 259);
            button2.Name = "button2";
            button2.Size = new Size(94, 51);
            button2.TabIndex = 10;
            button2.Text = "購物";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonCloth
            // 
            buttonCloth.BackColor = SystemColors.InactiveBorder;
            buttonCloth.Location = new Point(222, 259);
            buttonCloth.Name = "buttonCloth";
            buttonCloth.Size = new Size(94, 51);
            buttonCloth.TabIndex = 11;
            buttonCloth.Text = "服飾";
            buttonCloth.UseVisualStyleBackColor = false;
            buttonCloth.Click += buttonCloth_Click;
            // 
            // button3
            // 
            button3.Location = new Point(322, 259);
            button3.Name = "button3";
            button3.Size = new Size(94, 51);
            button3.TabIndex = 12;
            button3.Text = "日用";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttontravel
            // 
            buttontravel.Location = new Point(22, 316);
            buttontravel.Name = "buttontravel";
            buttontravel.Size = new Size(94, 51);
            buttontravel.TabIndex = 13;
            buttontravel.Text = "交通";
            buttontravel.UseVisualStyleBackColor = true;
            buttontravel.Click += buttontravel_Click;
            // 
            // buttonRental
            // 
            buttonRental.Location = new Point(122, 316);
            buttonRental.Name = "buttonRental";
            buttonRental.Size = new Size(94, 51);
            buttonRental.TabIndex = 14;
            buttonRental.Text = "住房";
            buttonRental.UseVisualStyleBackColor = true;
            buttonRental.Click += buttonRental_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(222, 316);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(94, 51);
            buttonPlay.TabIndex = 15;
            buttonPlay.Text = "娛樂";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonMobile
            // 
            buttonMobile.Location = new Point(322, 316);
            buttonMobile.Name = "buttonMobile";
            buttonMobile.Size = new Size(94, 51);
            buttonMobile.TabIndex = 16;
            buttonMobile.Text = "通訊";
            buttonMobile.UseVisualStyleBackColor = true;
            buttonMobile.Click += buttonMobile_Click;
            // 
            // buttonHairCut
            // 
            buttonHairCut.Location = new Point(22, 373);
            buttonHairCut.Name = "buttonHairCut";
            buttonHairCut.Size = new Size(94, 50);
            buttonHairCut.TabIndex = 17;
            buttonHairCut.Text = "美容";
            buttonHairCut.UseVisualStyleBackColor = true;
            buttonHairCut.Click += buttonHairCut_Click;
            // 
            // buttonlxing
            // 
            buttonlxing.Location = new Point(122, 373);
            buttonlxing.Name = "buttonlxing";
            buttonlxing.Size = new Size(94, 50);
            buttonlxing.TabIndex = 18;
            buttonlxing.Text = "旅行";
            buttonlxing.UseVisualStyleBackColor = true;
            buttonlxing.Click += buttonlxing_Click;
            // 
            // buttonBook
            // 
            buttonBook.Location = new Point(222, 373);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(94, 50);
            buttonBook.TabIndex = 19;
            buttonBook.Text = "書籍";
            buttonBook.UseVisualStyleBackColor = true;
            buttonBook.Click += buttonBook_Click;
            // 
            // buttonRepair
            // 
            buttonRepair.Location = new Point(322, 373);
            buttonRepair.Name = "buttonRepair";
            buttonRepair.Size = new Size(94, 50);
            buttonRepair.TabIndex = 20;
            buttonRepair.Text = "維修";
            buttonRepair.UseVisualStyleBackColor = true;
            buttonRepair.Click += buttonRepair_Click;
            // 
            // buttonMedical
            // 
            buttonMedical.Location = new Point(22, 429);
            buttonMedical.Name = "buttonMedical";
            buttonMedical.Size = new Size(94, 50);
            buttonMedical.TabIndex = 21;
            buttonMedical.Text = "醫療";
            buttonMedical.UseVisualStyleBackColor = true;
            buttonMedical.Click += buttonMedical_Click;
            // 
            // buttonPet
            // 
            buttonPet.Location = new Point(122, 429);
            buttonPet.Name = "buttonPet";
            buttonPet.Size = new Size(94, 50);
            buttonPet.TabIndex = 22;
            buttonPet.Text = "寵物";
            buttonPet.UseVisualStyleBackColor = true;
            buttonPet.Click += buttonPet_Click;
            // 
            // buttonExercise
            // 
            buttonExercise.Location = new Point(222, 429);
            buttonExercise.Name = "buttonExercise";
            buttonExercise.Size = new Size(94, 50);
            buttonExercise.TabIndex = 23;
            buttonExercise.Text = "運動";
            buttonExercise.UseVisualStyleBackColor = true;
            buttonExercise.Click += buttonExercise_Click;
            // 
            // buttonOther
            // 
            buttonOther.Location = new Point(322, 429);
            buttonOther.Name = "buttonOther";
            buttonOther.Size = new Size(94, 50);
            buttonOther.TabIndex = 24;
            buttonOther.Text = "其他";
            buttonOther.UseVisualStyleBackColor = true;
            buttonOther.Click += buttonOther_Click;
            // 
            // totalExpensesLabel
            // 
            totalExpensesLabel.AutoSize = true;
            totalExpensesLabel.Location = new Point(22, 126);
            totalExpensesLabel.Name = "totalExpensesLabel";
            totalExpensesLabel.Size = new Size(0, 20);
            totalExpensesLabel.TabIndex = 25;
            totalExpensesLabel.Click += label1_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(208, 207);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(50, 20);
            labelTotal.TabIndex = 26;
            labelTotal.Text = "label1";
            // 
            // buttonShowChart
            // 
            buttonShowChart.Location = new Point(799, 503);
            buttonShowChart.Name = "buttonShowChart";
            buttonShowChart.Size = new Size(113, 29);
            buttonShowChart.TabIndex = 27;
            buttonShowChart.Text = "查看消費統計";
            buttonShowChart.UseVisualStyleBackColor = true;
            buttonShowChart.Click += buttonShowChart_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Image = Properties.Resources.OOjs_UI_icon_search_ltr_svg;
            buttonSearch.Location = new Point(455, 25);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(66, 29);
            buttonSearch.TabIndex = 28;
            buttonSearch.Text = "查找";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxLImit
            // 
            textBoxLImit.Location = new Point(699, 25);
            textBoxLImit.Name = "textBoxLImit";
            textBoxLImit.Size = new Size(103, 27);
            textBoxLImit.TabIndex = 29;
            textBoxLImit.TextChanged += textBoxLImit_TextChanged;
            // 
            // buttonSetLimit
            // 
            buttonSetLimit.Location = new Point(818, 25);
            buttonSetLimit.Name = "buttonSetLimit";
            buttonSetLimit.Size = new Size(94, 29);
            buttonSetLimit.TabIndex = 30;
            buttonSetLimit.Text = "設置上限";
            buttonSetLimit.UseVisualStyleBackColor = true;
            buttonSetLimit.Click += buttonSetLimit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(933, 563);
            Controls.Add(buttonSetLimit);
            Controls.Add(textBoxLImit);
            Controls.Add(buttonSearch);
            Controls.Add(buttonShowChart);
            Controls.Add(labelTotal);
            Controls.Add(totalExpensesLabel);
            Controls.Add(buttonOther);
            Controls.Add(buttonExercise);
            Controls.Add(buttonPet);
            Controls.Add(buttonMedical);
            Controls.Add(buttonRepair);
            Controls.Add(buttonBook);
            Controls.Add(buttonlxing);
            Controls.Add(buttonHairCut);
            Controls.Add(buttonMobile);
            Controls.Add(buttonPlay);
            Controls.Add(buttonRental);
            Controls.Add(buttontravel);
            Controls.Add(button3);
            Controls.Add(buttonCloth);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAmount);
            Controls.Add(dateTimePicker1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "記賬好生活";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBoxItem;
        private TextBox textBoxAmount;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
        private DataGridView dataGridView;
        private TextBox textBoxSelectedCategory;
        private Button button1;
        private Button button2;
        private Button buttonCloth;
        private Button button3;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn 金額;
        private Button buttontravel;
        private Button buttonRental;
        private Button buttonPlay;
        private Button buttonMobile;
        private Button buttonHairCut;
        private Button buttonlxing;
        private Button buttonBook;
        private Button buttonRepair;
        private Button buttonMedical;
        private Button buttonPet;
        private Button buttonExercise;
        private Button buttonOther;
        private Label totalExpensesLabel;
        private Label labelTotal;
        private Button buttonShowChart;
        private Button buttonSearch;
        private TextBox textBoxLImit;
        private Button buttonSetLimit;
    }
}