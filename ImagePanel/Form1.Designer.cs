﻿namespace ImagePanel
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_LoadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_CreateTestImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 361);
            this.panel1.TabIndex = 0;
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Location = new System.Drawing.Point(214, 6);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(163, 35);
            this.button_LoadImage.TabIndex = 1;
            this.button_LoadImage.Text = "LoadImage";
            this.button_LoadImage.UseVisualStyleBackColor = true;
            this.button_LoadImage.Click += new System.EventHandler(this.button_LoadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mouse wheel :  vertical scroll";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mouse wheel + right Button : horizontal scroll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drag Center Button :  move picture";
            // 
            // button_CreateTestImage
            // 
            this.button_CreateTestImage.Location = new System.Drawing.Point(661, 12);
            this.button_CreateTestImage.Name = "button_CreateTestImage";
            this.button_CreateTestImage.Size = new System.Drawing.Size(163, 35);
            this.button_CreateTestImage.TabIndex = 1;
            this.button_CreateTestImage.Text = "CreateTestImage";
            this.button_CreateTestImage.UseVisualStyleBackColor = true;
            this.button_CreateTestImage.Click += new System.EventHandler(this.button_CreateTestImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alt + MouseLeftButton : move click point to center";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ctrl + MouseRightButton : remove point from List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ctrl + MouseLeftButton Drag : move point in List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ctrl + MouseLeftButton : add point to List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CreateTestImage);
            this.Controls.Add(this.button_LoadImage);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "PictureBoxScrollSample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_LoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_CreateTestImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

