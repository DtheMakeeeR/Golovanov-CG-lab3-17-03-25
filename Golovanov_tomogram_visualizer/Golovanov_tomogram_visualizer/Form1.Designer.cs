namespace Golovanov_tomogram_visualizer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.minTF = new System.Windows.Forms.TrackBar();
            this.shirinaTF = new System.Windows.Forms.TrackBar();
            this.minTFLabel = new System.Windows.Forms.Label();
            this.shirinaTFLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.glControl1 = new OpenTK.GLControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirinaTF)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Загрузить";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar1.Location = new System.Drawing.Point(17, 496);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 0;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(528, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Четырёхугольники",
            "Текстура"});
            this.comboBox1.Location = new System.Drawing.Point(620, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // minTF
            // 
            this.minTF.Location = new System.Drawing.Point(620, 151);
            this.minTF.Margin = new System.Windows.Forms.Padding(4);
            this.minTF.Maximum = 254;
            this.minTF.Name = "minTF";
            this.minTF.Size = new System.Drawing.Size(139, 56);
            this.minTF.TabIndex = 6;
            this.minTF.Scroll += new System.EventHandler(this.minTF_Scroll);
            // 
            // shirinaTF
            // 
            this.shirinaTF.Location = new System.Drawing.Point(620, 214);
            this.shirinaTF.Margin = new System.Windows.Forms.Padding(4);
            this.shirinaTF.Maximum = 255;
            this.shirinaTF.Minimum = 1;
            this.shirinaTF.Name = "shirinaTF";
            this.shirinaTF.Size = new System.Drawing.Size(139, 56);
            this.shirinaTF.TabIndex = 7;
            this.shirinaTF.Value = 255;
            this.shirinaTF.Scroll += new System.EventHandler(this.shirinaTF_Scroll);
            // 
            // minTFLabel
            // 
            this.minTFLabel.AutoSize = true;
            this.minTFLabel.Location = new System.Drawing.Point(788, 151);
            this.minTFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minTFLabel.Name = "minTFLabel";
            this.minTFLabel.Size = new System.Drawing.Size(14, 16);
            this.minTFLabel.TabIndex = 3;
            this.minTFLabel.Text = "0";
            // 
            // shirinaTFLabel
            // 
            this.shirinaTFLabel.AutoSize = true;
            this.shirinaTFLabel.Location = new System.Drawing.Point(787, 220);
            this.shirinaTFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shirinaTFLabel.Name = "shirinaTFLabel";
            this.shirinaTFLabel.Size = new System.Drawing.Size(28, 16);
            this.shirinaTFLabel.TabIndex = 3;
            this.shirinaTFLabel.Text = "255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1003, -124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "label1";
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 34);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(586, 442);
            this.glControl1.TabIndex = 1;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.shirinaTF);
            this.Controls.Add(this.minTF);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shirinaTFLabel);
            this.Controls.Add(this.minTFLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirinaTF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar minTF;
        private System.Windows.Forms.TrackBar shirinaTF;
        private System.Windows.Forms.Label minTFLabel;
        private System.Windows.Forms.Label shirinaTFLabel;
        private System.Windows.Forms.Label label4;
        private OpenTK.GLControl glControl1;
    }
}

