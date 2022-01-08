
namespace RGR_Algo
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
            this.GraphBox = new System.Windows.Forms.PictureBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.lengthTB = new System.Windows.Forms.TextBox();
            this.first_vTB = new System.Windows.Forms.TextBox();
            this.destTB = new System.Windows.Forms.TextBox();
            this.searchB = new System.Windows.Forms.Button();
            this.first_cityL = new System.Windows.Forms.Label();
            this.destL = new System.Windows.Forms.Label();
            this.resultL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphBox
            // 
            this.GraphBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.GraphBox.Location = new System.Drawing.Point(48, 29);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(925, 706);
            this.GraphBox.TabIndex = 0;
            this.GraphBox.TabStop = false;
            this.GraphBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphBox_Paint);
            this.GraphBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphBox_MouseDown);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(1092, 223);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(200, 39);
            this.priceTB.TabIndex = 2;
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(2)))), ((int)(((byte)(177)))));
            this.length.Location = new System.Drawing.Point(1092, 42);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(88, 32);
            this.length.TabIndex = 3;
            this.length.Text = "Length";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(2)))), ((int)(((byte)(177)))));
            this.Price.Location = new System.Drawing.Point(1092, 165);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(65, 32);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(2)))), ((int)(((byte)(177)))));
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.Location = new System.Drawing.Point(1346, 151);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(150, 46);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.Enter_Click);
            // 
            // lengthTB
            // 
            this.lengthTB.Location = new System.Drawing.Point(1092, 100);
            this.lengthTB.Name = "lengthTB";
            this.lengthTB.Size = new System.Drawing.Size(200, 39);
            this.lengthTB.TabIndex = 6;
            // 
            // first_vTB
            // 
            this.first_vTB.Location = new System.Drawing.Point(1092, 449);
            this.first_vTB.Name = "first_vTB";
            this.first_vTB.Size = new System.Drawing.Size(200, 39);
            this.first_vTB.TabIndex = 7;
            // 
            // destTB
            // 
            this.destTB.Location = new System.Drawing.Point(1092, 605);
            this.destTB.Name = "destTB";
            this.destTB.Size = new System.Drawing.Size(200, 39);
            this.destTB.TabIndex = 8;
            // 
            // searchB
            // 
            this.searchB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(2)))), ((int)(((byte)(177)))));
            this.searchB.ForeColor = System.Drawing.Color.White;
            this.searchB.Location = new System.Drawing.Point(1346, 519);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(150, 46);
            this.searchB.TabIndex = 9;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = false;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // first_cityL
            // 
            this.first_cityL.AutoSize = true;
            this.first_cityL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(2)))), ((int)(((byte)(177)))));
            this.first_cityL.Location = new System.Drawing.Point(1092, 392);
            this.first_cityL.Name = "first_cityL";
            this.first_cityL.Size = new System.Drawing.Size(102, 32);
            this.first_cityL.TabIndex = 10;
            this.first_cityL.Text = "First city";
            // 
            // destL
            // 
            this.destL.AutoSize = true;
            this.destL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(2)))), ((int)(((byte)(177)))));
            this.destL.Location = new System.Drawing.Point(1092, 533);
            this.destL.Name = "destL";
            this.destL.Size = new System.Drawing.Size(136, 32);
            this.destL.TabIndex = 11;
            this.destL.Text = "Destination";
            // 
            // resultL
            // 
            this.resultL.AutoSize = true;
            this.resultL.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultL.Location = new System.Drawing.Point(1092, 715);
            this.resultL.Name = "resultL";
            this.resultL.Size = new System.Drawing.Size(88, 37);
            this.resultL.TabIndex = 12;
            this.resultL.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 857);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 1161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultL);
            this.Controls.Add(this.destL);
            this.Controls.Add(this.first_cityL);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.destTB);
            this.Controls.Add(this.first_vTB);
            this.Controls.Add(this.lengthTB);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.length);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.GraphBox);
            this.Name = "Form1";
            this.Text = "RGR Algorithms and Data Structure";
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphBox;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox lengthTB;
        private System.Windows.Forms.TextBox first_vTB;
        private System.Windows.Forms.TextBox destTB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label first_cityL;
        private System.Windows.Forms.Label destL;
        private System.Windows.Forms.Label resultL;
        private System.Windows.Forms.Label label1;
    }
}

