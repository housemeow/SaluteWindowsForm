namespace Salute
{
    partial class SaluteForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._closeButton = new System.Windows.Forms.Button();
            this._saluteTimer = new System.Windows.Forms.Timer(this.components);
            this._comportNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._connectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._arduinoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._comportNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._closeButton.Location = new System.Drawing.Point(259, 3);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(170, 23);
            this._closeButton.TabIndex = 0;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.ClickCloseButton);
            // 
            // _saluteTimer
            // 
            this._saluteTimer.Tick += new System.EventHandler(this.TickSaluteTimer);
            // 
            // _comportNumericUpDown
            // 
            this._comportNumericUpDown.Location = new System.Drawing.Point(3, 3);
            this._comportNumericUpDown.Name = "_comportNumericUpDown";
            this._comportNumericUpDown.Size = new System.Drawing.Size(67, 22);
            this._comportNumericUpDown.TabIndex = 1;
            this._comportNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _connectButton
            // 
            this._connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._connectButton.Location = new System.Drawing.Point(83, 3);
            this._connectButton.Name = "_connectButton";
            this._connectButton.Size = new System.Drawing.Size(170, 23);
            this._connectButton.TabIndex = 2;
            this._connectButton.Text = "Connect";
            this._connectButton.UseVisualStyleBackColor = true;
            this._connectButton.Click += new System.EventHandler(this.ClickConnect);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._closeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._comportNumericUpDown, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._connectButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // _arduinoTimer
            // 
            this._arduinoTimer.Enabled = true;
            this._arduinoTimer.Tick += new System.EventHandler(this.HandleArduinoThreadSafe);
            // 
            // SaluteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 260);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SaluteForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadForm);
            ((System.ComponentModel.ISupportInitialize)(this._comportNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.Timer _saluteTimer;
        private System.Windows.Forms.NumericUpDown _comportNumericUpDown;
        private System.Windows.Forms.Button _connectButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer _arduinoTimer;
    }
}

