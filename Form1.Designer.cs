namespace laboratorna4
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
            this.ButtonResTab1 = new System.Windows.Forms.Button();
            this.ResLab = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelResult2 = new System.Windows.Forms.Label();
            this.txt2DArray = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonResTab1
            // 
            this.ButtonResTab1.Location = new System.Drawing.Point(17, 270);
            this.ButtonResTab1.Name = "ButtonResTab1";
            this.ButtonResTab1.Size = new System.Drawing.Size(75, 23);
            this.ButtonResTab1.TabIndex = 0;
            this.ButtonResTab1.Text = "Ок";
            this.ButtonResTab1.UseVisualStyleBackColor = true;
            this.ButtonResTab1.Click += new System.EventHandler(this.ButtonResTab1_Click);
            // 
            // ResLab
            // 
            this.ResLab.AutoSize = true;
            this.ResLab.Location = new System.Drawing.Point(216, 270);
            this.ResLab.Name = "ResLab";
            this.ResLab.Size = new System.Drawing.Size(0, 13);
            this.ResLab.TabIndex = 1;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(168, 222);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(136, 20);
            this.txtArray.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть массив числел\r\n\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 406);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ButtonResTab1);
            this.tabPage1.Controls.Add(this.ResLab);
            this.tabPage1.Controls.Add(this.txtArray);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1 завдання";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.LabelResult2);
            this.tabPage2.Controls.Add(this.txt2DArray);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2 завдання";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введіть числа двохмірного масиву\r\n";
            // 
            // LabelResult2
            // 
            this.LabelResult2.AutoSize = true;
            this.LabelResult2.Location = new System.Drawing.Point(171, 270);
            this.LabelResult2.Name = "LabelResult2";
            this.LabelResult2.Size = new System.Drawing.Size(0, 13);
            this.LabelResult2.TabIndex = 3;
            // 
            // txt2DArray
            // 
            this.txt2DArray.Location = new System.Drawing.Point(220, 203);
            this.txt2DArray.Name = "txt2DArray";
            this.txt2DArray.Size = new System.Drawing.Size(226, 20);
            this.txt2DArray.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::laboratorna4.Properties.Resources.Снимок_экрана_2024_04_03_203929;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 221);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::laboratorna4.Properties.Resources.Снимок_экрана_2024_04_03_203956;
            this.pictureBox2.Location = new System.Drawing.Point(108, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(610, 142);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonResTab1;
        private System.Windows.Forms.Label ResLab;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt2DArray;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelResult2;
        private System.Windows.Forms.Label label2;
    }
}

