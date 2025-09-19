namespace excelEntegrasyonProjesi
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
            btnVTdenOku = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnVTdenOku
            // 
            btnVTdenOku.Location = new Point(219, 96);
            btnVTdenOku.Name = "btnVTdenOku";
            btnVTdenOku.Size = new Size(306, 40);
            btnVTdenOku.TabIndex = 0;
            btnVTdenOku.Text = "Veri Tabanından Oku ve Excele yaz";
            btnVTdenOku.UseVisualStyleBackColor = true;
            btnVTdenOku.Click += BtnVTdenOku_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(159, 167);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(405, 120);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnVTdenOku);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVTdenOku;
        private RichTextBox richTextBox1;
    }
}
