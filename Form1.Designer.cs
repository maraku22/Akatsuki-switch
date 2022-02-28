namespace AkatsukiServer
{
    partial class SwitchMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchMain));
            this.ChangeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeButton.Location = new System.Drawing.Point(12, 114);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(375, 23);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Server Change";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FileBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory";
            // 
            // FileBox
            // 
            this.FileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.FileBox.Enabled = false;
            this.FileBox.ForeColor = System.Drawing.Color.White;
            this.FileBox.Location = new System.Drawing.Point(6, 32);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(363, 20);
            this.FileBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application :";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.ForeColor = System.Drawing.Color.Maroon;
            this.StatusText.Location = new System.Drawing.Point(73, 99);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(57, 13);
            this.StatusText.TabIndex = 2;
            this.StatusText.Text = "Not Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Akatsuki Switching";
            // 
            // Exitlabel
            // 
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.Exitlabel.Location = new System.Drawing.Point(373, 9);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(14, 13);
            this.Exitlabel.TabIndex = 4;
            this.Exitlabel.Text = "X";
            this.Exitlabel.Click += new System.EventHandler(this.Exitlabel_Click);
            // 
            // SwitchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(399, 146);
            this.Controls.Add(this.Exitlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChangeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SwitchMain";
            this.Text = "Akatsuki Switching";
            this.Load += new System.EventHandler(this.SwitchMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Exitlabel;
    }
}

