namespace Shiw_number_array
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
            txt1 = new TextBox();
            add_butt = new Button();
            cacu_butt = new Button();
            out_lab = new Label();
            reset_butt = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(75, 77);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 0;
            // 
            // add_butt
            // 
            add_butt.Location = new Point(75, 155);
            add_butt.Name = "add_butt";
            add_butt.Size = new Size(75, 23);
            add_butt.TabIndex = 1;
            add_butt.Text = "Add";
            add_butt.UseVisualStyleBackColor = true;
            add_butt.Click += add_butt_Click;
            // 
            // cacu_butt
            // 
            cacu_butt.Location = new Point(235, 155);
            cacu_butt.Name = "cacu_butt";
            cacu_butt.Size = new Size(120, 23);
            cacu_butt.TabIndex = 2;
            cacu_butt.Text = "Caculate Avg ";
            cacu_butt.UseVisualStyleBackColor = true;
            cacu_butt.Click += cacu_butt_Click;
            // 
            // out_lab
            // 
            out_lab.AutoSize = true;
            out_lab.Location = new Point(297, 77);
            out_lab.Name = "out_lab";
            out_lab.Size = new Size(0, 15);
            out_lab.TabIndex = 3;
            out_lab.Click += label1_Click;
            // 
            // reset_butt
            // 
            reset_butt.Location = new Point(439, 155);
            reset_butt.Name = "reset_butt";
            reset_butt.Size = new Size(75, 23);
            reset_butt.TabIndex = 4;
            reset_butt.Text = "Reset";
            reset_butt.UseVisualStyleBackColor = true;
            reset_butt.Click += reset_butt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reset_butt);
            Controls.Add(out_lab);
            Controls.Add(cacu_butt);
            Controls.Add(add_butt);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private Button add_butt;
        private Button cacu_butt;
        private Label out_lab;
        private Button reset_butt;
    }
}
