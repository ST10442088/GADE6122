namespace GADE
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
            displayLabel = new Label();
            upButton = new Button();
            rightButton = new Button();
            downButton = new Button();
            leftButton = new Button();
            SuspendLayout();
            // 
            // displayLabel
            // 
            displayLabel.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLabel.ForeColor = SystemColors.ActiveCaptionText;
            displayLabel.Location = new Point(12, 9);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(359, 372);
            displayLabel.TabIndex = 0;
            displayLabel.Text = "label1";
            // 
            // upButton
            // 
            upButton.BackColor = SystemColors.HotTrack;
            upButton.Location = new Point(583, 46);
            upButton.Name = "upButton";
            upButton.Size = new Size(106, 51);
            upButton.TabIndex = 1;
            upButton.Text = "UP";
            upButton.UseVisualStyleBackColor = false;
            upButton.Click += upButton_Click;
            // 
            // rightButton
            // 
            rightButton.BackColor = SystemColors.HotTrack;
            rightButton.Location = new Point(550, 118);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(165, 47);
            rightButton.TabIndex = 2;
            rightButton.Text = "RIGHT";
            rightButton.UseVisualStyleBackColor = false;
            rightButton.Click += rightButton_Click;
            // 
            // downButton
            // 
            downButton.BackColor = SystemColors.HotTrack;
            downButton.Location = new Point(583, 186);
            downButton.Name = "downButton";
            downButton.Size = new Size(106, 52);
            downButton.TabIndex = 3;
            downButton.Text = "DOWN";
            downButton.UseVisualStyleBackColor = false;
            downButton.Click += downButton_Click;
            // 
            // leftButton
            // 
            leftButton.BackColor = SystemColors.HotTrack;
            leftButton.Location = new Point(550, 263);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(165, 50);
            leftButton.TabIndex = 4;
            leftButton.Text = "LEFT";
            leftButton.UseVisualStyleBackColor = false;
            leftButton.Click += leftButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(leftButton);
            Controls.Add(downButton);
            Controls.Add(rightButton);
            Controls.Add(upButton);
            Controls.Add(displayLabel);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label displayLabel;
        private Button upButton;
        private Button rightButton;
        private Button downButton;
        private Button leftButton;
    }
}
