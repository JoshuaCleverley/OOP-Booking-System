namespace Booking_System
{
    partial class HomePage
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
            this.NewBookingButton = new System.Windows.Forms.Button();
            this.CurrentBookingButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewBookingButton
            // 
            this.NewBookingButton.Location = new System.Drawing.Point(219, 190);
            this.NewBookingButton.Name = "NewBookingButton";
            this.NewBookingButton.Size = new System.Drawing.Size(147, 71);
            this.NewBookingButton.TabIndex = 0;
            this.NewBookingButton.Text = "New Booking";
            this.NewBookingButton.UseVisualStyleBackColor = true;
            // 
            // CurrentBookingButton
            // 
            this.CurrentBookingButton.Location = new System.Drawing.Point(435, 190);
            this.CurrentBookingButton.Name = "CurrentBookingButton";
            this.CurrentBookingButton.Size = new System.Drawing.Size(147, 71);
            this.CurrentBookingButton.TabIndex = 1;
            this.CurrentBookingButton.Text = "Current Bookings";
            this.CurrentBookingButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(132, 47);
            this.quitButton.TabIndex = 29;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.CurrentBookingButton);
            this.Controls.Add(this.NewBookingButton);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewBookingButton;
        private System.Windows.Forms.Button CurrentBookingButton;
        private System.Windows.Forms.Button quitButton;
    }
}

