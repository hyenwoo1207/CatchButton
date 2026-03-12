namespace CatchButton1
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
            RunningButton = new Button();
            SuspendLayout();
            // 
            // RunningButton
            // 
            RunningButton.BackColor = SystemColors.GradientInactiveCaption;
            RunningButton.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            RunningButton.ForeColor = Color.Coral;
            RunningButton.Location = new Point(288, 172);
            RunningButton.Name = "RunningButton";
            RunningButton.Size = new Size(201, 84);
            RunningButton.TabIndex = 0;
            RunningButton.Text = "나를 잡아봐";
            RunningButton.UseVisualStyleBackColor = false;
            RunningButton.Click += button1_Click;
            RunningButton.MouseEnter += RunningButton1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RunningButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button RunningButton;
    }
}
