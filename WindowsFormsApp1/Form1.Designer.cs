namespace Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameUpdate = new System.Windows.Forms.Timer(this.components);
            this.TextTailLength = new System.Windows.Forms.Label();
            this.TailMeter = new System.Windows.Forms.Label();
            this.MaxTailLength = new System.Windows.Forms.Label();
            this.TailMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PauseLabel = new System.Windows.Forms.Label();
            this.LiveThree = new System.Windows.Forms.PictureBox();
            this.LiveTwo = new System.Windows.Forms.PictureBox();
            this.LiveOne = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LiveThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveOne)).BeginInit();
            this.SuspendLayout();
            // 
            // gameUpdate
            // 
            this.gameUpdate.Enabled = true;
            this.gameUpdate.Interval = 150;
            this.gameUpdate.Tick += new System.EventHandler(this.gameUpdate_Tick);
            // 
            // TextTailLength
            // 
            resources.ApplyResources(this.TextTailLength, "TextTailLength");
            this.TextTailLength.Name = "TextTailLength";
            // 
            // TailMeter
            // 
            resources.ApplyResources(this.TailMeter, "TailMeter");
            this.TailMeter.Name = "TailMeter";
            // 
            // MaxTailLength
            // 
            resources.ApplyResources(this.MaxTailLength, "MaxTailLength");
            this.MaxTailLength.Name = "MaxTailLength";
            // 
            // TailMax
            // 
            resources.ApplyResources(this.TailMax, "TailMax");
            this.TailMax.Name = "TailMax";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // PauseLabel
            // 
            resources.ApplyResources(this.PauseLabel, "PauseLabel");
            this.PauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.PauseLabel.Name = "PauseLabel";
            // 
            // LiveThree
            // 
            this.LiveThree.Image = global::WindowsFormsApp1.Images.Live;
            resources.ApplyResources(this.LiveThree, "LiveThree");
            this.LiveThree.InitialImage = global::WindowsFormsApp1.Images.Live;
            this.LiveThree.Name = "LiveThree";
            this.LiveThree.TabStop = false;
            // 
            // LiveTwo
            // 
            this.LiveTwo.Image = global::WindowsFormsApp1.Images.Live;
            resources.ApplyResources(this.LiveTwo, "LiveTwo");
            this.LiveTwo.InitialImage = global::WindowsFormsApp1.Images.Live;
            this.LiveTwo.Name = "LiveTwo";
            this.LiveTwo.TabStop = false;
            // 
            // LiveOne
            // 
            this.LiveOne.Image = global::WindowsFormsApp1.Images.Live;
            resources.ApplyResources(this.LiveOne, "LiveOne");
            this.LiveOne.InitialImage = global::WindowsFormsApp1.Images.Live;
            this.LiveOne.Name = "LiveOne";
            this.LiveOne.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PauseLabel);
            this.Controls.Add(this.LiveThree);
            this.Controls.Add(this.LiveTwo);
            this.Controls.Add(this.LiveOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TailMax);
            this.Controls.Add(this.MaxTailLength);
            this.Controls.Add(this.TailMeter);
            this.Controls.Add(this.TextTailLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LiveThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameUpdate;
        private System.Windows.Forms.Label TextTailLength;
        private System.Windows.Forms.Label TailMeter;
        private System.Windows.Forms.Label MaxTailLength;
        private System.Windows.Forms.Label TailMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox LiveOne;
        private System.Windows.Forms.PictureBox LiveTwo;
        private System.Windows.Forms.PictureBox LiveThree;
        private System.Windows.Forms.Label PauseLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

