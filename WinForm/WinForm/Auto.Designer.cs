namespace WinForm
{
    partial class GUI
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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_enchantment = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_screen = new System.Windows.Forms.Button();
            this.Btn_gift = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(12, 12);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(160, 23);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_enchantment
            // 
            this.Btn_enchantment.Location = new System.Drawing.Point(203, 12);
            this.Btn_enchantment.Name = "Btn_enchantment";
            this.Btn_enchantment.Size = new System.Drawing.Size(160, 23);
            this.Btn_enchantment.TabIndex = 1;
            this.Btn_enchantment.Text = "Đánh enchantment";
            this.Btn_enchantment.UseVisualStyleBackColor = true;
            this.Btn_enchantment.Click += new System.EventHandler(this.Btn_enchantment_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(12, 106);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(351, 23);
            this.Btn_Exit.TabIndex = 20;
            this.Btn_Exit.Text = "End";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_screen
            // 
            this.Btn_screen.Location = new System.Drawing.Point(12, 41);
            this.Btn_screen.Name = "Btn_screen";
            this.Btn_screen.Size = new System.Drawing.Size(160, 23);
            this.Btn_screen.TabIndex = 2;
            this.Btn_screen.Text = "Chụp ảnh màn hình";
            this.Btn_screen.UseVisualStyleBackColor = true;
            this.Btn_screen.Click += new System.EventHandler(this.Btn_screen_Click);
            // 
            // Btn_gift
            // 
            this.Btn_gift.Location = new System.Drawing.Point(203, 41);
            this.Btn_gift.Name = "Btn_gift";
            this.Btn_gift.Size = new System.Drawing.Size(160, 23);
            this.Btn_gift.TabIndex = 3;
            this.Btn_gift.Text = "Tặng quà cho bạn bè";
            this.Btn_gift.UseVisualStyleBackColor = true;
            this.Btn_gift.Click += new System.EventHandler(this.Btn_gift_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(12, 70);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(160, 23);
            this.btn_test.TabIndex = 21;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.Btn_test_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 135);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(351, 101);
            this.flowLayoutPanel.TabIndex = 22;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 249);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.Btn_gift);
            this.Controls.Add(this.Btn_screen);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_enchantment);
            this.Controls.Add(this.Btn_Start);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto DML";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_enchantment;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_screen;
        private System.Windows.Forms.Button Btn_gift;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}

