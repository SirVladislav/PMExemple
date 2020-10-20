namespace QuadEquationWinForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.textBoxRes1 = new System.Windows.Forms.TextBox();
            this.textBoxRes2 = new System.Windows.Forms.TextBox();
            this.labelKoreni = new System.Windows.Forms.Label();
            this.labelRes1 = new System.Windows.Forms.Label();
            this.labelRes2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelKorenivNema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть коефіцієнти квадратного рівняння";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(131, 65);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(68, 20);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.TextBoxA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Коеф А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Коеф B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Коеф C";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(131, 94);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(68, 20);
            this.textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(131, 129);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(68, 20);
            this.textBoxC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Рівняння типу";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(24, 198);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(127, 20);
            this.labelRes.TabIndex = 9;
            this.labelRes.Text = "AX^2+BX+C=0";
            this.labelRes.Click += new System.EventHandler(this.LabelRes_Click);
            // 
            // textBoxRes1
            // 
            this.textBoxRes1.Location = new System.Drawing.Point(100, 316);
            this.textBoxRes1.Name = "textBoxRes1";
            this.textBoxRes1.Size = new System.Drawing.Size(68, 20);
            this.textBoxRes1.TabIndex = 10;
            this.textBoxRes1.Visible = false;
            // 
            // textBoxRes2
            // 
            this.textBoxRes2.Location = new System.Drawing.Point(244, 316);
            this.textBoxRes2.Name = "textBoxRes2";
            this.textBoxRes2.Size = new System.Drawing.Size(68, 20);
            this.textBoxRes2.TabIndex = 11;
            this.textBoxRes2.Visible = false;
            // 
            // labelKoreni
            // 
            this.labelKoreni.AutoSize = true;
            this.labelKoreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKoreni.Location = new System.Drawing.Point(144, 280);
            this.labelKoreni.Name = "labelKoreni";
            this.labelKoreni.Size = new System.Drawing.Size(64, 20);
            this.labelKoreni.TabIndex = 12;
            this.labelKoreni.Text = "Корені";
            this.labelKoreni.Visible = false;
            // 
            // labelRes1
            // 
            this.labelRes1.AutoSize = true;
            this.labelRes1.Location = new System.Drawing.Point(62, 319);
            this.labelRes1.Name = "labelRes1";
            this.labelRes1.Size = new System.Drawing.Size(32, 13);
            this.labelRes1.TabIndex = 13;
            this.labelRes1.Text = "Х1 = ";
            this.labelRes1.Visible = false;
            // 
            // labelRes2
            // 
            this.labelRes2.AutoSize = true;
            this.labelRes2.Location = new System.Drawing.Point(206, 319);
            this.labelRes2.Name = "labelRes2";
            this.labelRes2.Size = new System.Drawing.Size(32, 13);
            this.labelRes2.TabIndex = 14;
            this.labelRes2.Text = "Х2 = ";
            this.labelRes2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(210, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дискримінант";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.Location = new System.Drawing.Point(240, 198);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(42, 20);
            this.labelD.TabIndex = 16;
            this.labelD.Text = "D = ";
            // 
            // labelKorenivNema
            // 
            this.labelKorenivNema.AutoSize = true;
            this.labelKorenivNema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKorenivNema.ForeColor = System.Drawing.Color.DarkRed;
            this.labelKorenivNema.Location = new System.Drawing.Point(100, 316);
            this.labelKorenivNema.Name = "labelKorenivNema";
            this.labelKorenivNema.Size = new System.Drawing.Size(156, 24);
            this.labelKorenivNema.TabIndex = 17;
            this.labelKorenivNema.Text = "Коренів Немає";
            this.labelKorenivNema.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 370);
            this.Controls.Add(this.labelKorenivNema);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelRes2);
            this.Controls.Add(this.labelRes1);
            this.Controls.Add(this.labelKoreni);
            this.Controls.Add(this.textBoxRes2);
            this.Controls.Add(this.textBoxRes1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "QuadEquation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TextBox textBoxRes1;
        private System.Windows.Forms.TextBox textBoxRes2;
        private System.Windows.Forms.Label labelKoreni;
        private System.Windows.Forms.Label labelRes1;
        private System.Windows.Forms.Label labelRes2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelKorenivNema;
    }
}

