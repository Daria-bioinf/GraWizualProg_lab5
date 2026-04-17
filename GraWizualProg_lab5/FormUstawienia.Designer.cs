namespace GraWizualProg_lab5
{
    partial class FormUstawienia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butnZapisz = new System.Windows.Forms.Button();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericCzas = new System.Windows.Forms.NumericUpDown();
            this.numericKrokodyle = new System.Windows.Forms.NumericUpDown();
            this.numericDydelfy = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericSzops = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKrokodyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDydelfy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSzops)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "plansza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dydelfy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Krokodyle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Czas";
            // 
            // butnZapisz
            // 
            this.butnZapisz.Location = new System.Drawing.Point(98, 341);
            this.butnZapisz.Name = "butnZapisz";
            this.butnZapisz.Size = new System.Drawing.Size(240, 45);
            this.butnZapisz.TabIndex = 6;
            this.butnZapisz.Text = "Zapisz";
            this.butnZapisz.UseVisualStyleBackColor = true;
            this.butnZapisz.Click += new System.EventHandler(this.butnZapisz_Click);
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(98, 95);
            this.numericX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericX.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(97, 22);
            this.numericX.TabIndex = 7;
            this.numericX.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericY
            // 
            this.numericY.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericY.Location = new System.Drawing.Point(98, 183);
            this.numericY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(97, 22);
            this.numericY.TabIndex = 8;
            // 
            // numericCzas
            // 
            this.numericCzas.Location = new System.Drawing.Point(98, 259);
            this.numericCzas.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericCzas.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCzas.Name = "numericCzas";
            this.numericCzas.Size = new System.Drawing.Size(97, 22);
            this.numericCzas.TabIndex = 9;
            this.numericCzas.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericKrokodyle
            // 
            this.numericKrokodyle.Location = new System.Drawing.Point(270, 181);
            this.numericKrokodyle.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKrokodyle.Name = "numericKrokodyle";
            this.numericKrokodyle.Size = new System.Drawing.Size(97, 22);
            this.numericKrokodyle.TabIndex = 10;
            // 
            // numericDydelfy
            // 
            this.numericDydelfy.Location = new System.Drawing.Point(270, 95);
            this.numericDydelfy.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericDydelfy.Name = "numericDydelfy";
            this.numericDydelfy.Size = new System.Drawing.Size(97, 22);
            this.numericDydelfy.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Szopy";
            // 
            // numericSzops
            // 
            this.numericSzops.Location = new System.Drawing.Point(270, 263);
            this.numericSzops.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericSzops.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericSzops.Name = "numericSzops";
            this.numericSzops.Size = new System.Drawing.Size(97, 22);
            this.numericSzops.TabIndex = 13;
            this.numericSzops.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // FormUstawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 424);
            this.Controls.Add(this.numericSzops);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericDydelfy);
            this.Controls.Add(this.numericKrokodyle);
            this.Controls.Add(this.numericCzas);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.butnZapisz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUstawienia";
            this.Text = "FormUstawienia";
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKrokodyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDydelfy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSzops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butnZapisz;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericCzas;
        private System.Windows.Forms.NumericUpDown numericKrokodyle;
        private System.Windows.Forms.NumericUpDown numericDydelfy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericSzops;
    }
}