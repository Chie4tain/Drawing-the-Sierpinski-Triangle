namespace Fractal_drawing
{
    partial class FSierpinski_Triangle
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
            this.PnlCanvas = new System.Windows.Forms.Panel();
            this.BtStart = new System.Windows.Forms.Button();
            this.numUpDownDepthSetter = new System.Windows.Forms.NumericUpDown();
            this.ColDLineColorControl = new System.Windows.Forms.ColorDialog();
            this.lbldepth = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.StStrip = new System.Windows.Forms.StatusStrip();
            this.PnlShowColor = new System.Windows.Forms.Panel();
            this.LblChooseColor = new System.Windows.Forms.Label();
            this.BtSave = new System.Windows.Forms.Button();
            this.SFDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDepthSetter)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCanvas
            // 
            this.PnlCanvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlCanvas.Location = new System.Drawing.Point(496, 0);
            this.PnlCanvas.Name = "PnlCanvas";
            this.PnlCanvas.Size = new System.Drawing.Size(842, 569);
            this.PnlCanvas.TabIndex = 0;
            this.PnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCanvas_Paint);
            // 
            // BtStart
            // 
            this.BtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtStart.Location = new System.Drawing.Point(12, 310);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(282, 110);
            this.BtStart.TabIndex = 1;
            this.BtStart.Text = "Drawing";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // numUpDownDepthSetter
            // 
            this.numUpDownDepthSetter.Location = new System.Drawing.Point(7, 187);
            this.numUpDownDepthSetter.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownDepthSetter.Name = "numUpDownDepthSetter";
            this.numUpDownDepthSetter.Size = new System.Drawing.Size(402, 22);
            this.numUpDownDepthSetter.TabIndex = 2;
            this.numUpDownDepthSetter.ValueChanged += new System.EventHandler(this.numUpDownDepthSetter_ValueChanged);
            // 
            // lbldepth
            // 
            this.lbldepth.AutoSize = true;
            this.lbldepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbldepth.Location = new System.Drawing.Point(12, 145);
            this.lbldepth.Name = "lbldepth";
            this.lbldepth.Size = new System.Drawing.Size(80, 20);
            this.lbldepth.TabIndex = 4;
            this.lbldepth.Text = "Set depth";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.BtSave);
            this.pnlSettings.Controls.Add(this.LblChooseColor);
            this.pnlSettings.Controls.Add(this.PnlShowColor);
            this.pnlSettings.Controls.Add(this.BtStart);
            this.pnlSettings.Controls.Add(this.numUpDownDepthSetter);
            this.pnlSettings.Controls.Add(this.lbldepth);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(471, 569);
            this.pnlSettings.TabIndex = 5;
            // 
            // StStrip
            // 
            this.StStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StStrip.Location = new System.Drawing.Point(471, 547);
            this.StStrip.Name = "StStrip";
            this.StStrip.Size = new System.Drawing.Size(25, 22);
            this.StStrip.TabIndex = 6;
            this.StStrip.Text = "statusStrip1";
            // 
            // PnlShowColor
            // 
            this.PnlShowColor.Location = new System.Drawing.Point(194, 12);
            this.PnlShowColor.Name = "PnlShowColor";
            this.PnlShowColor.Size = new System.Drawing.Size(116, 69);
            this.PnlShowColor.TabIndex = 5;
            this.PnlShowColor.Click += new System.EventHandler(this.PnlShowColor_Click);
            // 
            // LblChooseColor
            // 
            this.LblChooseColor.AutoSize = true;
            this.LblChooseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblChooseColor.Location = new System.Drawing.Point(12, 25);
            this.LblChooseColor.Name = "LblChooseColor";
            this.LblChooseColor.Size = new System.Drawing.Size(162, 29);
            this.LblChooseColor.TabIndex = 6;
            this.LblChooseColor.Text = "Choose Color";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(339, 310);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(111, 110);
            this.BtSave.TabIndex = 7;
            this.BtSave.Text = "Save....";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // SFDialog
            // 
            this.SFDialog.Filter = "Изображения (*.png)|*.png|Все файлы(*.*)|*.*";
            this.SFDialog.Title = "Save Image";
            // 
            // FSierpinski_Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 569);
            this.Controls.Add(this.StStrip);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.PnlCanvas);
            this.Name = "FSierpinski_Triangle";
            this.Text = "Sierpinski Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDepthSetter)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlCanvas;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.NumericUpDown numUpDownDepthSetter;
        private System.Windows.Forms.ColorDialog ColDLineColorControl;
        private System.Windows.Forms.Label lbldepth;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.StatusStrip StStrip;
        private System.Windows.Forms.Panel PnlShowColor;
        private System.Windows.Forms.Label LblChooseColor;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.SaveFileDialog SFDialog;
    }
}

