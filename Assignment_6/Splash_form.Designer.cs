namespace Assignment_6
{
    partial class Splash_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_form));
            this.Splash_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Splash_timer
            // 
            this.Splash_timer.Enabled = true;
            this.Splash_timer.Interval = 3000;
            this.Splash_timer.Tick += new System.EventHandler(this.Splash_timer_Tick);
            // 
            // Splash_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(652, 564);
            this.ControlBox = false;
            this.Name = "Splash_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Splash_timer;
    }
}