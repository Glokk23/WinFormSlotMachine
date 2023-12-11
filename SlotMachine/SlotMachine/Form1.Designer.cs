namespace SlotMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            slotPictureBox1 = new PictureBox();
            slotPictureBox2 = new PictureBox();
            slotPictureBox3 = new PictureBox();
            spinButton = new Button();
            balanceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)slotPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slotPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slotPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // slotPictureBox1
            // 
            slotPictureBox1.Location = new Point(12, 23);
            slotPictureBox1.Name = "slotPictureBox1";
            slotPictureBox1.Size = new Size(101, 99);
            slotPictureBox1.TabIndex = 0;
            slotPictureBox1.TabStop = false;
            // 
            // slotPictureBox2
            // 
            slotPictureBox2.Location = new Point(141, 23);
            slotPictureBox2.Name = "slotPictureBox2";
            slotPictureBox2.Size = new Size(101, 99);
            slotPictureBox2.TabIndex = 1;
            slotPictureBox2.TabStop = false;
            // 
            // slotPictureBox3
            // 
            slotPictureBox3.Location = new Point(271, 23);
            slotPictureBox3.Name = "slotPictureBox3";
            slotPictureBox3.Size = new Size(100, 99);
            slotPictureBox3.TabIndex = 2;
            slotPictureBox3.TabStop = false;
            // 
            // spinButton
            // 
            spinButton.Location = new Point(97, 231);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(185, 167);
            spinButton.TabIndex = 3;
            spinButton.Text = "SPIN!";
            spinButton.UseVisualStyleBackColor = true;
            spinButton.Click += SpinButton_Click;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(97, 213);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(0, 15);
            balanceLabel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 450);
            Controls.Add(balanceLabel);
            Controls.Add(spinButton);
            Controls.Add(slotPictureBox3);
            Controls.Add(slotPictureBox2);
            Controls.Add(slotPictureBox1);
            Name = "Form1";
            Text = "Slot Machine";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)slotPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slotPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)slotPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox slotPictureBox1;
        private PictureBox slotPictureBox2;
        private PictureBox slotPictureBox3;
        private Button spinButton;
        private Label balanceLabel;
    }
}