namespace MultipleForms
{
    partial class PersonBasicDataForm
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
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(117, 157);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(201, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(287, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(201, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(287, 39);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(117, 217);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 32);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(201, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(287, 39);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(117, 274);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 32);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(201, 84);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(199, 32);
            label4.TabIndex = 6;
            label4.Text = "Basic Information";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(337, 336);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(151, 42);
            button3.TabIndex = 9;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // PersonBasicDataForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(622, 474);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "PersonBasicDataForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}