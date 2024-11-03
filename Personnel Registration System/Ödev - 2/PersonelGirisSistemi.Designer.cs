namespace Ödev___2
{
    partial class PersonelGirisSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGirisSistemi));
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // checkBox2
            // 
            resources.ApplyResources(checkBox2, "checkBox2");
            checkBox2.BackColor = Color.FromArgb(109, 124, 81);
            checkBox2.Name = "checkBox2";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(109, 124, 81);
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.ForeColor = Color.White;
            textBox2.Name = "textBox2";
            textBox2.Tag = "";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.White;
            label3.Name = "label3";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(172, 181, 150);
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(172, 181, 150);
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(109, 124, 81);
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.ForeColor = Color.White;
            textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.White;
            label2.Name = "label2";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(172, 181, 150);
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(109, 124, 81);
            label1.Name = "label1";
            label1.Click += label23_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // PersonelGirisSistemi
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 227, 215);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonelGirisSistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Button button3;
        private Button button2;
        private CheckBox checkBox2;
        private TextBox textBox2;
        private Label label3;
    }
}