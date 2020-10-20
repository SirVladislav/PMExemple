namespace DataGridTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.buttonRand = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelMaxSum = new System.Windows.Forms.Label();
            this.labelFindMax = new System.Windows.Forms.Label();
            this.labelFindMin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelText1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(23, 240);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(180, 69);
            this.buttonMax.TabIndex = 0;
            this.buttonMax.Text = "Find Max/Min";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(308, 244);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(201, 65);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search For Max Sum";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeColumns = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(475, 134);
            this.dataGridViewMain.TabIndex = 3;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMain_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть кількість елементів:\r\n";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(236, 20);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownN.TabIndex = 7;
            this.numericUpDownN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.NumericUpDownN_ValueChanged);
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(316, 12);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(66, 33);
            this.buttonRand.TabIndex = 8;
            this.buttonRand.Text = "Random";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.ButtonRand_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.Salmon;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(483, 50);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(25, 134);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "remove";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelMaxSum
            // 
            this.labelMaxSum.AutoSize = true;
            this.labelMaxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxSum.Location = new System.Drawing.Point(354, 268);
            this.labelMaxSum.Name = "labelMaxSum";
            this.labelMaxSum.Size = new System.Drawing.Size(101, 16);
            this.labelMaxSum.TabIndex = 10;
            this.labelMaxSum.Text = "labelMaxSum";
            // 
            // labelFindMax
            // 
            this.labelFindMax.AutoSize = true;
            this.labelFindMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFindMax.Location = new System.Drawing.Point(57, 257);
            this.labelFindMax.Name = "labelFindMax";
            this.labelFindMax.Size = new System.Drawing.Size(101, 16);
            this.labelFindMax.TabIndex = 11;
            this.labelFindMax.Text = "labelFindMax";
            // 
            // labelFindMin
            // 
            this.labelFindMin.AutoSize = true;
            this.labelFindMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFindMin.Location = new System.Drawing.Point(57, 273);
            this.labelFindMin.Name = "labelFindMin";
            this.labelFindMin.Size = new System.Drawing.Size(97, 16);
            this.labelFindMin.TabIndex = 12;
            this.labelFindMin.Text = "labelFindMin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Знайти мінімальне та \r\nмаксимальне значення\r\n";
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText1.Location = new System.Drawing.Point(388, 14);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(67, 26);
            this.labelText1.TabIndex = 14;
            this.labelText1.Text = "Випадкові\r\nелементи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(324, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Знайти максимальну\r\nсумму поряд\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFindMin);
            this.Controls.Add(this.labelFindMax);
            this.Controls.Add(this.labelMaxSum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRand);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonMax);
            this.MaximumSize = new System.Drawing.Size(1000, 360);
            this.MinimumSize = new System.Drawing.Size(536, 360);
            this.Name = "Form1";
            this.Text = "DataGridAnalyser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelMaxSum;
        private System.Windows.Forms.Label labelFindMax;
        private System.Windows.Forms.Label labelFindMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Label label4;
    }
}

