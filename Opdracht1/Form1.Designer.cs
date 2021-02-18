
namespace Opdracht1
{
    partial class Form1
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.txtDice1 = new System.Windows.Forms.TextBox();
            this.txtDice2 = new System.Windows.Forms.TextBox();
            this.txtDice3 = new System.Windows.Forms.TextBox();
            this.txtDice4 = new System.Windows.Forms.TextBox();
            this.txtDice5 = new System.Windows.Forms.TextBox();
            this.txtDice6 = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeviation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(96, 317);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(150, 35);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Dobbel";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // txtDice1
            // 
            this.txtDice1.Location = new System.Drawing.Point(96, 63);
            this.txtDice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDice1.Name = "txtDice1";
            this.txtDice1.Size = new System.Drawing.Size(148, 26);
            this.txtDice1.TabIndex = 1;
            // 
            // txtDice2
            // 
            this.txtDice2.Location = new System.Drawing.Point(96, 103);
            this.txtDice2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDice2.Name = "txtDice2";
            this.txtDice2.Size = new System.Drawing.Size(148, 26);
            this.txtDice2.TabIndex = 2;
            // 
            // txtDice3
            // 
            this.txtDice3.Location = new System.Drawing.Point(96, 143);
            this.txtDice3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDice3.Name = "txtDice3";
            this.txtDice3.Size = new System.Drawing.Size(148, 26);
            this.txtDice3.TabIndex = 3;
            // 
            // txtDice4
            // 
            this.txtDice4.Location = new System.Drawing.Point(96, 183);
            this.txtDice4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDice4.Name = "txtDice4";
            this.txtDice4.Size = new System.Drawing.Size(148, 26);
            this.txtDice4.TabIndex = 4;
            // 
            // txtDice5
            // 
            this.txtDice5.Location = new System.Drawing.Point(96, 223);
            this.txtDice5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDice5.Name = "txtDice5";
            this.txtDice5.Size = new System.Drawing.Size(148, 26);
            this.txtDice5.TabIndex = 5;
            // 
            // txtDice6
            // 
            this.txtDice6.Location = new System.Drawing.Point(96, 263);
            this.txtDice6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDice6.Name = "txtDice6";
            this.txtDice6.Size = new System.Drawing.Size(148, 26);
            this.txtDice6.TabIndex = 6;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(556, 63);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(148, 26);
            this.txtSum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Som";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gemiddelde";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(556, 103);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(148, 26);
            this.txtAverage.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Range";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(556, 143);
            this.txtRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(148, 26);
            this.txtRange.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Deviatie";
            // 
            // txtDeviation
            // 
            this.txtDeviation.Location = new System.Drawing.Point(556, 183);
            this.txtDeviation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeviation.Name = "txtDeviation";
            this.txtDeviation.Size = new System.Drawing.Size(148, 26);
            this.txtDeviation.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeviation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtDice6);
            this.Controls.Add(this.txtDice5);
            this.Controls.Add(this.txtDice4);
            this.Controls.Add(this.txtDice3);
            this.Controls.Add(this.txtDice2);
            this.Controls.Add(this.txtDice1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Hoofdstuk 8  - Opdracht 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.TextBox txtDice1;
        private System.Windows.Forms.TextBox txtDice2;
        private System.Windows.Forms.TextBox txtDice3;
        private System.Windows.Forms.TextBox txtDice4;
        private System.Windows.Forms.TextBox txtDice5;
        private System.Windows.Forms.TextBox txtDice6;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeviation;
    }
}

