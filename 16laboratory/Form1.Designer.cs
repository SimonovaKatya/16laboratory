namespace _16laboratory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxDays = new System.Windows.Forms.NumericUpDown();
            this.button1_Calculate = new System.Windows.Forms.Button();
            this.button3_Sell = new System.Windows.Forms.Button();
            this.button2_Buy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_box_euro = new System.Windows.Forms.TextBox();
            this.text_box_money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDays)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(88, 114);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "EURO";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(478, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(343, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Initial price";
            // 
            // inputPrice
            // 
            this.inputPrice.DecimalPlaces = 4;
            this.inputPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputPrice.Location = new System.Drawing.Point(454, 28);
            this.inputPrice.Margin = new System.Windows.Forms.Padding(2);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(90, 29);
            this.inputPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(351, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Max days";
            // 
            // MaxDays
            // 
            this.MaxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxDays.Location = new System.Drawing.Point(454, 64);
            this.MaxDays.Margin = new System.Windows.Forms.Padding(2);
            this.MaxDays.Name = "MaxDays";
            this.MaxDays.Size = new System.Drawing.Size(90, 29);
            this.MaxDays.TabIndex = 16;
            // 
            // button1_Calculate
            // 
            this.button1_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1_Calculate.Location = new System.Drawing.Point(601, 343);
            this.button1_Calculate.Margin = new System.Windows.Forms.Padding(2);
            this.button1_Calculate.Name = "button1_Calculate";
            this.button1_Calculate.Size = new System.Drawing.Size(165, 79);
            this.button1_Calculate.TabIndex = 18;
            this.button1_Calculate.Text = "Calculate";
            this.button1_Calculate.UseVisualStyleBackColor = false;
            this.button1_Calculate.Click += new System.EventHandler(this.button1_Calculate_Click);
            // 
            // button3_Sell
            // 
            this.button3_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3_Sell.Location = new System.Drawing.Point(601, 260);
            this.button3_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.button3_Sell.Name = "button3_Sell";
            this.button3_Sell.Size = new System.Drawing.Size(165, 58);
            this.button3_Sell.TabIndex = 20;
            this.button3_Sell.Text = "Sell";
            this.button3_Sell.UseVisualStyleBackColor = false;
            this.button3_Sell.Click += new System.EventHandler(this.button3_Sell_Click);
            // 
            // button2_Buy
            // 
            this.button2_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2_Buy.Location = new System.Drawing.Point(601, 173);
            this.button2_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.button2_Buy.Name = "button2_Buy";
            this.button2_Buy.Size = new System.Drawing.Size(165, 58);
            this.button2_Buy.TabIndex = 19;
            this.button2_Buy.Text = "Buy";
            this.button2_Buy.UseVisualStyleBackColor = false;
            this.button2_Buy.Click += new System.EventHandler(this.button2_Buy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(587, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "MONEY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(595, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "EURO";
            // 
            // text_box_euro
            // 
            this.text_box_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_euro.Location = new System.Drawing.Point(664, 64);
            this.text_box_euro.Margin = new System.Windows.Forms.Padding(2);
            this.text_box_euro.Name = "text_box_euro";
            this.text_box_euro.Size = new System.Drawing.Size(76, 29);
            this.text_box_euro.TabIndex = 22;
            // 
            // text_box_money
            // 
            this.text_box_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_money.Location = new System.Drawing.Point(664, 28);
            this.text_box_money.Margin = new System.Windows.Forms.Padding(2);
            this.text_box_money.Name = "text_box_money";
            this.text_box_money.Size = new System.Drawing.Size(76, 29);
            this.text_box_money.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Current Day";
            // 
            // Days
            // 
            this.Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Days.Location = new System.Drawing.Point(135, 31);
            this.Days.Margin = new System.Windows.Forms.Padding(2);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(76, 29);
            this.Days.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_box_euro);
            this.Controls.Add(this.text_box_money);
            this.Controls.Add(this.button3_Sell);
            this.Controls.Add(this.button2_Buy);
            this.Controls.Add(this.button1_Calculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MaxDays;
        private System.Windows.Forms.Button button1_Calculate;
        private System.Windows.Forms.Button button3_Sell;
        private System.Windows.Forms.Button button2_Buy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_box_euro;
        private System.Windows.Forms.TextBox text_box_money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.Timer timer1;
    }
}

