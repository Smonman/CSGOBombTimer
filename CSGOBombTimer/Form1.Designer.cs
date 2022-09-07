namespace CSGOBombTimer
{
    partial class Form_Main
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
            this.label_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_timer
            // 
            this.label_timer.BackColor = System.Drawing.SystemColors.Control;
            this.label_timer.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_timer.Location = new System.Drawing.Point(40, 10);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(200, 50);
            this.label_timer.TabIndex = 0;
            this.label_timer.Text = "##:##";
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.label_timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(1930, 930);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CSGO Bomb Timer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_timer;
    }
}

