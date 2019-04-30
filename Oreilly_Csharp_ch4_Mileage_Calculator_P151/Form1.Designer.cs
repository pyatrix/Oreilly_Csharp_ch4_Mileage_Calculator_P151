namespace chapter4_Mileage_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_startMile = new System.Windows.Forms.Label();
            this.label_endMile = new System.Windows.Forms.Label();
            this.label_amountOwed_name = new System.Windows.Forms.Label();
            this.label_amountOwed = new System.Windows.Forms.Label();
            this.startMile_UpDown = new System.Windows.Forms.NumericUpDown();
            this.endMileUpDown = new System.Windows.Forms.NumericUpDown();
            this.button_Calaulator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startMile_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label_startMile
            // 
            this.label_startMile.AutoSize = true;
            this.label_startMile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_startMile.Location = new System.Drawing.Point(12, 55);
            this.label_startMile.Name = "label_startMile";
            this.label_startMile.Size = new System.Drawing.Size(135, 21);
            this.label_startMile.TabIndex = 0;
            this.label_startMile.Text = "Starting Mileage";
            // 
            // label_endMile
            // 
            this.label_endMile.AutoSize = true;
            this.label_endMile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_endMile.Location = new System.Drawing.Point(12, 100);
            this.label_endMile.Name = "label_endMile";
            this.label_endMile.Size = new System.Drawing.Size(136, 21);
            this.label_endMile.TabIndex = 1;
            this.label_endMile.Text = "Ending   Mileage";
            // 
            // label_amountOwed_name
            // 
            this.label_amountOwed_name.AutoSize = true;
            this.label_amountOwed_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_amountOwed_name.Location = new System.Drawing.Point(12, 146);
            this.label_amountOwed_name.Name = "label_amountOwed_name";
            this.label_amountOwed_name.Size = new System.Drawing.Size(134, 21);
            this.label_amountOwed_name.TabIndex = 2;
            this.label_amountOwed_name.Text = "Amount    Owed";
            // 
            // label_amountOwed
            // 
            this.label_amountOwed.AutoSize = true;
            this.label_amountOwed.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_amountOwed.Location = new System.Drawing.Point(155, 138);
            this.label_amountOwed.Name = "label_amountOwed";
            this.label_amountOwed.Size = new System.Drawing.Size(181, 31);
            this.label_amountOwed.TabIndex = 3;
            this.label_amountOwed.Text = "Amount Owed";
            // 
            // startMile_UpDown
            // 
            this.startMile_UpDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startMile_UpDown.Location = new System.Drawing.Point(161, 54);
            this.startMile_UpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startMile_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMile_UpDown.Name = "startMile_UpDown";
            this.startMile_UpDown.Size = new System.Drawing.Size(175, 29);
            this.startMile_UpDown.TabIndex = 4;
            this.startMile_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMile_UpDown.ValueChanged += new System.EventHandler(this.StartMile_UpDown_ValueChanged);
            // 
            // endMileUpDown
            // 
            this.endMileUpDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endMileUpDown.Location = new System.Drawing.Point(161, 100);
            this.endMileUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endMileUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endMileUpDown.Name = "endMileUpDown";
            this.endMileUpDown.Size = new System.Drawing.Size(175, 29);
            this.endMileUpDown.TabIndex = 5;
            this.endMileUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Calaulator
            // 
            this.button_Calaulator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Calaulator.Location = new System.Drawing.Point(121, 182);
            this.button_Calaulator.Name = "button_Calaulator";
            this.button_Calaulator.Size = new System.Drawing.Size(110, 40);
            this.button_Calaulator.TabIndex = 6;
            this.button_Calaulator.Text = "Calculator";
            this.button_Calaulator.UseVisualStyleBackColor = true;
            this.button_Calaulator.Click += new System.EventHandler(this.Button_Calaulator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 234);
            this.Controls.Add(this.button_Calaulator);
            this.Controls.Add(this.endMileUpDown);
            this.Controls.Add(this.startMile_UpDown);
            this.Controls.Add(this.label_amountOwed);
            this.Controls.Add(this.label_amountOwed_name);
            this.Controls.Add(this.label_endMile);
            this.Controls.Add(this.label_startMile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startMile_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_startMile;
        private System.Windows.Forms.Label label_endMile;
        private System.Windows.Forms.Label label_amountOwed_name;
        private System.Windows.Forms.Label label_amountOwed;
        private System.Windows.Forms.NumericUpDown startMile_UpDown;
        private System.Windows.Forms.NumericUpDown endMileUpDown;
        private System.Windows.Forms.Button button_Calaulator;
    }
}

