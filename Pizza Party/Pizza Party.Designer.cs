namespace Pizza_Party
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
            this.chkpizza8inch = new System.Windows.Forms.CheckBox();
            this.chkpizza12Inch = new System.Windows.Forms.CheckBox();
            this.chkpizza14Inch = new System.Windows.Forms.CheckBox();
            this.chkpizza16Inch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chksausage = new System.Windows.Forms.CheckBox();
            this.chkpepper = new System.Windows.Forms.CheckBox();
            this.chkgarlic = new System.Windows.Forms.CheckBox();
            this.chkbecan = new System.Windows.Forms.CheckBox();
            this.chkcoke2Liter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chksprite2Liter = new System.Windows.Forms.CheckBox();
            this.chkchocolateChip = new System.Windows.Forms.CheckBox();
            this.chkcheeseBread = new System.Windows.Forms.CheckBox();
            this.chkbaffoloWings = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.orderLists = new System.Windows.Forms.Label();
            this.btnReceiptClear = new System.Windows.Forms.Button();
            this.picImageDisplay = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkpizza8inch
            // 
            this.chkpizza8inch.AutoSize = true;
            this.chkpizza8inch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpizza8inch.Location = new System.Drawing.Point(2, 5);
            this.chkpizza8inch.Name = "chkpizza8inch";
            this.chkpizza8inch.Size = new System.Drawing.Size(199, 28);
            this.chkpizza8inch.TabIndex = 0;
            this.chkpizza8inch.Text = "8 Inches Pizza $8.00";
            this.chkpizza8inch.UseVisualStyleBackColor = true;
            this.chkpizza8inch.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkpizza12Inch
            // 
            this.chkpizza12Inch.AutoSize = true;
            this.chkpizza12Inch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpizza12Inch.Location = new System.Drawing.Point(3, 33);
            this.chkpizza12Inch.Name = "chkpizza12Inch";
            this.chkpizza12Inch.Size = new System.Drawing.Size(219, 28);
            this.chkpizza12Inch.TabIndex = 1;
            this.chkpizza12Inch.Text = "12 Inches Pizza $12.00";
            this.chkpizza12Inch.UseVisualStyleBackColor = true;
            this.chkpizza12Inch.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkpizza14Inch
            // 
            this.chkpizza14Inch.AutoSize = true;
            this.chkpizza14Inch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpizza14Inch.Location = new System.Drawing.Point(3, 67);
            this.chkpizza14Inch.Name = "chkpizza14Inch";
            this.chkpizza14Inch.Size = new System.Drawing.Size(219, 28);
            this.chkpizza14Inch.TabIndex = 2;
            this.chkpizza14Inch.Text = "14 Inches Pizza $12.50";
            this.chkpizza14Inch.UseVisualStyleBackColor = true;
            this.chkpizza14Inch.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkpizza16Inch
            // 
            this.chkpizza16Inch.AutoSize = true;
            this.chkpizza16Inch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpizza16Inch.Location = new System.Drawing.Point(3, 105);
            this.chkpizza16Inch.Name = "chkpizza16Inch";
            this.chkpizza16Inch.Size = new System.Drawing.Size(219, 28);
            this.chkpizza16Inch.TabIndex = 3;
            this.chkpizza16Inch.Text = "16 inches Pizza $13.50";
            this.chkpizza16Inch.UseVisualStyleBackColor = true;
            this.chkpizza16Inch.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sizes of Pizza Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toppings Available";
            // 
            // chksausage
            // 
            this.chksausage.AutoSize = true;
            this.chksausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksausage.Location = new System.Drawing.Point(8, 5);
            this.chksausage.Name = "chksausage";
            this.chksausage.Size = new System.Drawing.Size(136, 24);
            this.chksausage.TabIndex = 6;
            this.chksausage.Text = "Sausage $2.00";
            this.chksausage.UseVisualStyleBackColor = true;
            this.chksausage.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkpepper
            // 
            this.chkpepper.AutoSize = true;
            this.chkpepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpepper.Location = new System.Drawing.Point(8, 33);
            this.chkpepper.Name = "chkpepper";
            this.chkpepper.Size = new System.Drawing.Size(131, 24);
            this.chkpepper.TabIndex = 7;
            this.chkpepper.Text = "Peppers $1.00";
            this.chkpepper.UseVisualStyleBackColor = true;
            this.chkpepper.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkgarlic
            // 
            this.chkgarlic.AutoSize = true;
            this.chkgarlic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgarlic.Location = new System.Drawing.Point(8, 64);
            this.chkgarlic.Name = "chkgarlic";
            this.chkgarlic.Size = new System.Drawing.Size(113, 24);
            this.chkgarlic.TabIndex = 8;
            this.chkgarlic.Text = "Garlic $2.50";
            this.chkgarlic.UseVisualStyleBackColor = true;
            this.chkgarlic.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkbecan
            // 
            this.chkbecan.AutoSize = true;
            this.chkbecan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbecan.Location = new System.Drawing.Point(8, 95);
            this.chkbecan.Name = "chkbecan";
            this.chkbecan.Size = new System.Drawing.Size(118, 24);
            this.chkbecan.TabIndex = 9;
            this.chkbecan.Text = "Becan $2.75";
            this.chkbecan.UseVisualStyleBackColor = true;
            this.chkbecan.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkcoke2Liter
            // 
            this.chkcoke2Liter.AutoSize = true;
            this.chkcoke2Liter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcoke2Liter.Location = new System.Drawing.Point(6, 19);
            this.chkcoke2Liter.Name = "chkcoke2Liter";
            this.chkcoke2Liter.Size = new System.Drawing.Size(157, 24);
            this.chkcoke2Liter.TabIndex = 10;
            this.chkcoke2Liter.Text = "2 Liter Coke $1.50";
            this.chkcoke2Liter.UseVisualStyleBackColor = true;
            this.chkcoke2Liter.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Extras Available";
            // 
            // chksprite2Liter
            // 
            this.chksprite2Liter.AutoSize = true;
            this.chksprite2Liter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksprite2Liter.Location = new System.Drawing.Point(6, 43);
            this.chksprite2Liter.Name = "chksprite2Liter";
            this.chksprite2Liter.Size = new System.Drawing.Size(162, 24);
            this.chksprite2Liter.TabIndex = 12;
            this.chksprite2Liter.Text = "2 Liter Sprite $1.50";
            this.chksprite2Liter.UseVisualStyleBackColor = true;
            this.chksprite2Liter.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkchocolateChip
            // 
            this.chkchocolateChip.AutoSize = true;
            this.chkchocolateChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkchocolateChip.Location = new System.Drawing.Point(6, 73);
            this.chkchocolateChip.Name = "chkchocolateChip";
            this.chkchocolateChip.Size = new System.Drawing.Size(233, 24);
            this.chkchocolateChip.TabIndex = 14;
            this.chkchocolateChip.Text = "Chocolate Chip Cookie $5.00";
            this.chkchocolateChip.UseVisualStyleBackColor = true;
            this.chkchocolateChip.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkcheeseBread
            // 
            this.chkcheeseBread.AutoSize = true;
            this.chkcheeseBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcheeseBread.Location = new System.Drawing.Point(7, 103);
            this.chkcheeseBread.Name = "chkcheeseBread";
            this.chkcheeseBread.Size = new System.Drawing.Size(174, 24);
            this.chkcheeseBread.TabIndex = 15;
            this.chkcheeseBread.Text = "Cheese Bread $7.00";
            this.chkcheeseBread.UseVisualStyleBackColor = true;
            this.chkcheeseBread.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // chkbaffoloWings
            // 
            this.chkbaffoloWings.AutoSize = true;
            this.chkbaffoloWings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbaffoloWings.Location = new System.Drawing.Point(6, 133);
            this.chkbaffoloWings.Name = "chkbaffoloWings";
            this.chkbaffoloWings.Size = new System.Drawing.Size(227, 24);
            this.chkbaffoloWings.TabIndex = 16;
            this.chkbaffoloWings.Text = "12 Pcs Bafalo Wings $12.75";
            this.chkbaffoloWings.UseVisualStyleBackColor = true;
            this.chkbaffoloWings.CheckedChanged += new System.EventHandler(this.pizza8inch_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkpizza16Inch);
            this.groupBox1.Controls.Add(this.chkpizza14Inch);
            this.groupBox1.Controls.Add(this.chkpizza12Inch);
            this.groupBox1.Controls.Add(this.chkpizza8inch);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 143);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbaffoloWings);
            this.groupBox2.Controls.Add(this.chkcheeseBread);
            this.groupBox2.Controls.Add(this.chkchocolateChip);
            this.groupBox2.Controls.Add(this.chksprite2Liter);
            this.groupBox2.Controls.Add(this.chkcoke2Liter);
            this.groupBox2.Location = new System.Drawing.Point(477, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 169);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkbecan);
            this.groupBox3.Controls.Add(this.chkgarlic);
            this.groupBox3.Controls.Add(this.chkpepper);
            this.groupBox3.Controls.Add(this.chksausage);
            this.groupBox3.Location = new System.Drawing.Point(260, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 137);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(15, 524);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(158, 36);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Place Order";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // orderLists
            // 
            this.orderLists.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLists.Location = new System.Drawing.Point(398, 205);
            this.orderLists.Name = "orderLists";
            this.orderLists.Size = new System.Drawing.Size(312, 317);
            this.orderLists.TabIndex = 21;
            // 
            // btnReceiptClear
            // 
            this.btnReceiptClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiptClear.Location = new System.Drawing.Point(179, 525);
            this.btnReceiptClear.Name = "btnReceiptClear";
            this.btnReceiptClear.Size = new System.Drawing.Size(163, 36);
            this.btnReceiptClear.TabIndex = 22;
            this.btnReceiptClear.Text = "Cancel Order";
            this.btnReceiptClear.UseVisualStyleBackColor = true;
            this.btnReceiptClear.Click += new System.EventHandler(this.btnReceiptClear_Click);
            // 
            // picImageDisplay
            // 
            this.picImageDisplay.Image = global::Pizza_Party.Properties.Resources.pizza1;
            this.picImageDisplay.Location = new System.Drawing.Point(15, 196);
            this.picImageDisplay.Name = "picImageDisplay";
            this.picImageDisplay.Size = new System.Drawing.Size(314, 146);
            this.picImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageDisplay.TabIndex = 23;
            this.picImageDisplay.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Party.Properties.Resources.Chicken_Wings1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(357, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 36);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(736, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picImageDisplay);
            this.Controls.Add(this.btnReceiptClear);
            this.Controls.Add(this.orderLists);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Pizza Party Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkpizza8inch;
        private System.Windows.Forms.CheckBox chkpizza12Inch;
        private System.Windows.Forms.CheckBox chkpizza14Inch;
        private System.Windows.Forms.CheckBox chkpizza16Inch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chksausage;
        private System.Windows.Forms.CheckBox chkpepper;
        private System.Windows.Forms.CheckBox chkgarlic;
        private System.Windows.Forms.CheckBox chkbecan;
        private System.Windows.Forms.CheckBox chkcoke2Liter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chksprite2Liter;
        private System.Windows.Forms.CheckBox chkchocolateChip;
        private System.Windows.Forms.CheckBox chkcheeseBread;
        private System.Windows.Forms.CheckBox chkbaffoloWings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label orderLists;
        private System.Windows.Forms.Button btnReceiptClear;
        private System.Windows.Forms.PictureBox picImageDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

