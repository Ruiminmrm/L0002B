namespace WinFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fornamnsvar = new System.Windows.Forms.Label();
            this.efternamnsvar = new System.Windows.Forms.Label();
            this.personnummersvar = new System.Windows.Forms.Label();
            this.konsvar = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 400);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Avbryt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 312);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 235);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 163);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 27);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Förnamn";
            // 
            // fornamnsvar
            // 
            this.fornamnsvar.AutoSize = true;
            this.fornamnsvar.Location = new System.Drawing.Point(30, 452);
            this.fornamnsvar.Name = "fornamnsvar";
            this.fornamnsvar.Size = new System.Drawing.Size(0, 20);
            this.fornamnsvar.TabIndex = 8;
            this.fornamnsvar.Click += new System.EventHandler(this.fornamnsvar_Click);
            // 
            // efternamnsvar
            // 
            this.efternamnsvar.AutoSize = true;
            this.efternamnsvar.Location = new System.Drawing.Point(30, 492);
            this.efternamnsvar.Name = "efternamnsvar";
            this.efternamnsvar.Size = new System.Drawing.Size(0, 20);
            this.efternamnsvar.TabIndex = 9;
            this.efternamnsvar.Click += new System.EventHandler(this.efternamnsvar_Click);
            // 
            // personnummersvar
            // 
            this.personnummersvar.AutoSize = true;
            this.personnummersvar.Location = new System.Drawing.Point(30, 533);
            this.personnummersvar.Name = "personnummersvar";
            this.personnummersvar.Size = new System.Drawing.Size(0, 20);
            this.personnummersvar.TabIndex = 10;
            this.personnummersvar.Click += new System.EventHandler(this.personnummersvar_Click);
            // 
            // konsvar
            // 
            this.konsvar.AutoSize = true;
            this.konsvar.Location = new System.Drawing.Point(30, 575);
            this.konsvar.Name = "konsvar";
            this.konsvar.Size = new System.Drawing.Size(0, 20);
            this.konsvar.TabIndex = 11;
            this.konsvar.Click += new System.EventHandler(this.konsvar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(129, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(239, 67);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Welcome!";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "ÅÅMMDDXXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.konsvar);
            this.Controls.Add(this.personnummersvar);
            this.Controls.Add(this.efternamnsvar);
            this.Controls.Add(this.fornamnsvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label fornamnsvar;
        private Label efternamnsvar;
        private Label personnummersvar;
        private Label konsvar;
        private Label labelTitle;
        private Label label4;
    }
}