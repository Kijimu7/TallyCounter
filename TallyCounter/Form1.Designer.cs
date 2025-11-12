namespace TallyCounter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            labelCount = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "262039.png");
            imageList1.Images.SetKeyName(1, "iconmonstr-plus-circle-thin.png");
            // 
            // labelCount
            // 
            labelCount.AccessibleName = "";
            labelCount.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point);
            labelCount.Location = new Point(182, 51);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(265, 201);
            labelCount.TabIndex = 4;
            labelCount.Text = "10";
            labelCount.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.CausesValidation = false;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(69, 296);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(120, 120);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_enter;
            button1.MouseLeave += button1_leave;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(212, 296);
            button2.Margin = new Padding(0, 3, 3, 3);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(121, 120);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_enter;
            button2.MouseLeave += button2_leave;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatAppearance.MouseOverBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(356, 296);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(120, 120);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseEnter += button3_enter;
            button3.MouseLeave += button3_leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(567, 516);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelCount);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tally Count";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Label labelCount;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}