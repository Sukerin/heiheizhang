namespace HeiHeiZhang
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.text_shortNum = new System.Windows.Forms.TextBox();
            this.text_short_length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_push = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_long_length = new System.Windows.Forms.TextBox();
            this.label_about = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // text_shortNum
            // 
            this.text_shortNum.Location = new System.Drawing.Point(121, 107);
            this.text_shortNum.Name = "text_shortNum";
            this.text_shortNum.Size = new System.Drawing.Size(100, 21);
            this.text_shortNum.TabIndex = 1;
            // 
            // text_short_length
            // 
            this.text_short_length.Location = new System.Drawing.Point(121, 80);
            this.text_short_length.Name = "text_short_length";
            this.text_short_length.Size = new System.Drawing.Size(100, 21);
            this.text_short_length.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "短棒子长度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "数量";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(52, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 136);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "长度";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "数量";
            this.columnHeader2.Width = 80;
            // 
            // button_push
            // 
            this.button_push.Font = new System.Drawing.Font("宋体", 9F);
            this.button_push.Location = new System.Drawing.Point(52, 144);
            this.button_push.Name = "button_push";
            this.button_push.Size = new System.Drawing.Size(79, 37);
            this.button_push.TabIndex = 7;
            this.button_push.Text = "压入";
            this.button_push.UseVisualStyleBackColor = true;
            this.button_push.Click += new System.EventHandler(this.Button_push_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "总长度";
            // 
            // text_long_length
            // 
            this.text_long_length.Location = new System.Drawing.Point(121, 37);
            this.text_long_length.Name = "text_long_length";
            this.text_long_length.Size = new System.Drawing.Size(100, 21);
            this.text_long_length.TabIndex = 8;
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.Location = new System.Drawing.Point(230, 429);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(29, 12);
            this.label_about.TabIndex = 10;
            this.label_about.Text = "关于";
            this.toolTip1.SetToolTip(this.label_about, "copyright by sukerin");
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("宋体", 9F);
            this.button_clean.Location = new System.Drawing.Point(142, 144);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(79, 37);
            this.button_clean.TabIndex = 11;
            this.button_clean.Text = "清空";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.Button_clean_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.ReshowDelay = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.label_about);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_long_length);
            this.Controls.Add(this.button_push);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_short_length);
            this.Controls.Add(this.text_shortNum);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "嘿味";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_shortNum;
        private System.Windows.Forms.TextBox text_short_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_push;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_long_length;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

