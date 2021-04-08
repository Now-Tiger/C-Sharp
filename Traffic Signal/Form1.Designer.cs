
namespace Traffic_Signal_Form
{
    partial class TrafficSig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficSig));
            this.RedStop = new System.Windows.Forms.PictureBox();
            this.YellowWait = new System.Windows.Forms.PictureBox();
            this.GreenGo = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RedStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenGo)).BeginInit();
            this.SuspendLayout();
            // 
            // RedStop
            // 
            this.RedStop.Image = ((System.Drawing.Image)(resources.GetObject("RedStop.Image")));
            this.RedStop.Location = new System.Drawing.Point(269, 91);
            this.RedStop.Name = "RedStop";
            this.RedStop.Size = new System.Drawing.Size(134, 273);
            this.RedStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedStop.TabIndex = 0;
            this.RedStop.TabStop = false;
            // 
            // YellowWait
            // 
            this.YellowWait.Image = ((System.Drawing.Image)(resources.GetObject("YellowWait.Image")));
            this.YellowWait.Location = new System.Drawing.Point(269, 91);
            this.YellowWait.Name = "YellowWait";
            this.YellowWait.Size = new System.Drawing.Size(134, 273);
            this.YellowWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YellowWait.TabIndex = 1;
            this.YellowWait.TabStop = false;
            // 
            // GreenGo
            // 
            this.GreenGo.Image = ((System.Drawing.Image)(resources.GetObject("GreenGo.Image")));
            this.GreenGo.Location = new System.Drawing.Point(269, 91);
            this.GreenGo.Name = "GreenGo";
            this.GreenGo.Size = new System.Drawing.Size(134, 273);
            this.GreenGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenGo.TabIndex = 2;
            this.GreenGo.TabStop = false;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(485, 155);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 63);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(504, 258);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(93, 51);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrafficSig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 480);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.GreenGo);
            this.Controls.Add(this.YellowWait);
            this.Controls.Add(this.RedStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrafficSig";
            this.Text = "Traffic Signal ";
            ((System.ComponentModel.ISupportInitialize)(this.RedStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenGo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RedStop;
        private System.Windows.Forms.PictureBox YellowWait;
        private System.Windows.Forms.PictureBox GreenGo;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer1;
    }
}

