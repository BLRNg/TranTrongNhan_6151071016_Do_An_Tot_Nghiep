
namespace Parking_Slot
{
    partial class InOutLane
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cardNoBox = new System.Windows.Forms.TextBox();
            this.checkInImage = new System.Windows.Forms.PictureBox();
            this.checkOutImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.messaBox = new System.Windows.Forms.TextBox();
            this.licenseBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.laneBox = new System.Windows.Forms.TextBox();
            this.totalAmountBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 338);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cardNoBox
            // 
            this.cardNoBox.BackColor = System.Drawing.SystemColors.Window;
            this.cardNoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNoBox.Location = new System.Drawing.Point(713, 551);
            this.cardNoBox.Name = "cardNoBox";
            this.cardNoBox.ReadOnly = true;
            this.cardNoBox.Size = new System.Drawing.Size(266, 39);
            this.cardNoBox.TabIndex = 2;
            this.cardNoBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkInImage
            // 
            this.checkInImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkInImage.Location = new System.Drawing.Point(684, 12);
            this.checkInImage.Name = "checkInImage";
            this.checkInImage.Size = new System.Drawing.Size(222, 164);
            this.checkInImage.TabIndex = 3;
            this.checkInImage.TabStop = false;
            // 
            // checkOutImage
            // 
            this.checkOutImage.BackColor = System.Drawing.SystemColors.ControlText;
            this.checkOutImage.Location = new System.Drawing.Point(684, 182);
            this.checkOutImage.Name = "checkOutImage";
            this.checkOutImage.Size = new System.Drawing.Size(222, 168);
            this.checkOutImage.TabIndex = 4;
            this.checkOutImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông Báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biển Số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thời Gian ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Làn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá Tiền";
            // 
            // customerBox
            // 
            this.customerBox.BackColor = System.Drawing.SystemColors.Window;
            this.customerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBox.Location = new System.Drawing.Point(45, 368);
            this.customerBox.Name = "customerBox";
            this.customerBox.ReadOnly = true;
            this.customerBox.Size = new System.Drawing.Size(934, 39);
            this.customerBox.TabIndex = 10;
            // 
            // messaBox
            // 
            this.messaBox.BackColor = System.Drawing.SystemColors.Window;
            this.messaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messaBox.Location = new System.Drawing.Point(270, 413);
            this.messaBox.Name = "messaBox";
            this.messaBox.ReadOnly = true;
            this.messaBox.Size = new System.Drawing.Size(709, 39);
            this.messaBox.TabIndex = 11;
            // 
            // licenseBox
            // 
            this.licenseBox.BackColor = System.Drawing.SystemColors.Window;
            this.licenseBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licenseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseBox.Location = new System.Drawing.Point(270, 458);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.ReadOnly = true;
            this.licenseBox.Size = new System.Drawing.Size(276, 39);
            this.licenseBox.TabIndex = 12;
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.SystemColors.Window;
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(270, 503);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(709, 39);
            this.timeBox.TabIndex = 13;
            // 
            // laneBox
            // 
            this.laneBox.BackColor = System.Drawing.SystemColors.Window;
            this.laneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laneBox.Location = new System.Drawing.Point(270, 548);
            this.laneBox.Name = "laneBox";
            this.laneBox.ReadOnly = true;
            this.laneBox.Size = new System.Drawing.Size(265, 39);
            this.laneBox.TabIndex = 14;
            // 
            // totalAmountBox
            // 
            this.totalAmountBox.BackColor = System.Drawing.SystemColors.Window;
            this.totalAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountBox.Location = new System.Drawing.Point(713, 458);
            this.totalAmountBox.Name = "totalAmountBox";
            this.totalAmountBox.ReadOnly = true;
            this.totalAmountBox.Size = new System.Drawing.Size(266, 39);
            this.totalAmountBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã Thẻ";
            // 
            // InOutLane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 687);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalAmountBox);
            this.Controls.Add(this.laneBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.messaBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkOutImage);
            this.Controls.Add(this.checkInImage);
            this.Controls.Add(this.cardNoBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InOutLane";
            this.Text = "InOutLane";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InOutLane_FormClosed);
            this.Load += new System.EventHandler(this.InOutLane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cardNoBox;
        private System.Windows.Forms.PictureBox checkInImage;
        private System.Windows.Forms.PictureBox checkOutImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.TextBox messaBox;
        private System.Windows.Forms.TextBox licenseBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox laneBox;
        private System.Windows.Forms.TextBox totalAmountBox;
        private System.Windows.Forms.Label label6;
    }
}