namespace ggame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panel1;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBoxTurnIndicator = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnIndicator).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 760);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(740, 179);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBoxTurnIndicator
            // 
            pictureBoxTurnIndicator.Image = (Image)resources.GetObject("pictureBoxTurnIndicator.Image");
            pictureBoxTurnIndicator.Location = new Point(730, 26);
            pictureBoxTurnIndicator.Name = "pictureBoxTurnIndicator";
            pictureBoxTurnIndicator.Size = new Size(150, 150);
            pictureBoxTurnIndicator.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTurnIndicator.TabIndex = 2;
            pictureBoxTurnIndicator.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 700);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxTurnIndicator);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Reversi";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurnIndicator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBoxTurnIndicator;

    }
}