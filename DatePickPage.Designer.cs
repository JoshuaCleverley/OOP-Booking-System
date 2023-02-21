namespace Booking_System
{
    partial class DatePickPage
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
            this.dateButtonOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateButtonTwo = new System.Windows.Forms.Button();
            this.dateButtonThree = new System.Windows.Forms.Button();
            this.dateButtonFour = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tourDatesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tourDatesContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateButtonOne
            // 
            this.dateButtonOne.Location = new System.Drawing.Point(3, 3);
            this.dateButtonOne.Name = "dateButtonOne";
            this.dateButtonOne.Size = new System.Drawing.Size(136, 40);
            this.dateButtonOne.TabIndex = 0;
            this.dateButtonOne.Text = "5th June 2023";
            this.dateButtonOne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose booking date";
            // 
            // dateButtonTwo
            // 
            this.dateButtonTwo.Location = new System.Drawing.Point(145, 3);
            this.dateButtonTwo.Name = "dateButtonTwo";
            this.dateButtonTwo.Size = new System.Drawing.Size(136, 40);
            this.dateButtonTwo.TabIndex = 2;
            this.dateButtonTwo.Text = "12th June 2023";
            this.dateButtonTwo.UseVisualStyleBackColor = true;
            // 
            // dateButtonThree
            // 
            this.dateButtonThree.Location = new System.Drawing.Point(287, 3);
            this.dateButtonThree.Name = "dateButtonThree";
            this.dateButtonThree.Size = new System.Drawing.Size(136, 40);
            this.dateButtonThree.TabIndex = 3;
            this.dateButtonThree.Text = "19th June 2023";
            this.dateButtonThree.UseVisualStyleBackColor = true;
            // 
            // dateButtonFour
            // 
            this.dateButtonFour.Location = new System.Drawing.Point(429, 3);
            this.dateButtonFour.Name = "dateButtonFour";
            this.dateButtonFour.Size = new System.Drawing.Size(136, 40);
            this.dateButtonFour.TabIndex = 4;
            this.dateButtonFour.Text = "26th June 2023";
            this.dateButtonFour.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 47);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(132, 47);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel Booking";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tourDatesContainer
            // 
            this.tourDatesContainer.Controls.Add(this.dateButtonOne);
            this.tourDatesContainer.Controls.Add(this.dateButtonTwo);
            this.tourDatesContainer.Controls.Add(this.dateButtonThree);
            this.tourDatesContainer.Controls.Add(this.dateButtonFour);
            this.tourDatesContainer.Location = new System.Drawing.Point(116, 120);
            this.tourDatesContainer.Name = "tourDatesContainer";
            this.tourDatesContainer.Size = new System.Drawing.Size(568, 239);
            this.tourDatesContainer.TabIndex = 30;
            // 
            // DatePickPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tourDatesContainer);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "DatePickPage";
            this.Text = "DatePickPage";
            this.tourDatesContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dateButtonOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dateButtonTwo;
        private System.Windows.Forms.Button dateButtonThree;
        private System.Windows.Forms.Button dateButtonFour;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FlowLayoutPanel tourDatesContainer;
    }
}