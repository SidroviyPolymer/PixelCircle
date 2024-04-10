
namespace PixelCircles
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LB_D = new System.Windows.Forms.Label();
            this.LB_M = new System.Windows.Forms.Label();
            this.TB_D = new System.Windows.Forms.TextBox();
            this.TrBar_M = new System.Windows.Forms.TrackBar();
            this.PB_Canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrBar_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_D
            // 
            this.LB_D.AutoSize = true;
            this.LB_D.Location = new System.Drawing.Point(10, 10);
            this.LB_D.Name = "LB_D";
            this.LB_D.Size = new System.Drawing.Size(53, 13);
            this.LB_D.TabIndex = 0;
            this.LB_D.Text = "Диаметр";
            // 
            // LB_M
            // 
            this.LB_M.AutoSize = true;
            this.LB_M.Location = new System.Drawing.Point(10, 60);
            this.LB_M.Name = "LB_M";
            this.LB_M.Size = new System.Drawing.Size(53, 13);
            this.LB_M.TabIndex = 0;
            this.LB_M.Text = "Масштаб";
            // 
            // TB_D
            // 
            this.TB_D.Location = new System.Drawing.Point(10, 30);
            this.TB_D.Name = "TB_D";
            this.TB_D.Size = new System.Drawing.Size(100, 20);
            this.TB_D.TabIndex = 0;
            this.TB_D.TextChanged += new System.EventHandler(this.TB_D_TextChanged);
            // 
            // TrBar_M
            // 
            this.TrBar_M.Location = new System.Drawing.Point(10, 80);
            this.TrBar_M.Minimum = 1;
            this.TrBar_M.Name = "TrBar_M";
            this.TrBar_M.Size = new System.Drawing.Size(104, 45);
            this.TrBar_M.TabIndex = 0;
            this.TrBar_M.Value = 1;
            this.TrBar_M.ValueChanged += new System.EventHandler(this.TrBar_M_ValueChanged);
            // 
            // PB_Canvas
            // 
            this.PB_Canvas.BackColor = System.Drawing.Color.White;
            this.PB_Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Canvas.Location = new System.Drawing.Point(10, 130);
            this.PB_Canvas.Name = "PB_Canvas";
            this.PB_Canvas.Size = new System.Drawing.Size(380, 380);
            this.PB_Canvas.TabIndex = 0;
            this.PB_Canvas.TabStop = false;
            this.PB_Canvas.Click += new System.EventHandler(this.PB_Canvas_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 520);
            this.Controls.Add(this.LB_D);
            this.Controls.Add(this.LB_M);
            this.Controls.Add(this.TB_D);
            this.Controls.Add(this.TrBar_M);
            this.Controls.Add(this.PB_Canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PixelCircle";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrBar_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_D;
        private System.Windows.Forms.TextBox TB_D;
        private System.Windows.Forms.Label LB_M;
        private System.Windows.Forms.TrackBar TrBar_M;
        private System.Windows.Forms.PictureBox PB_Canvas;
    }
}

