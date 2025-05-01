namespace Week04Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgTest11 = new System.Windows.Forms.TabPage();
            this.tpgTest2 = new System.Windows.Forms.TabPage();
            this.tpgTest3 = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgTest11);
            this.tabMain.Controls.Add(this.tpgTest2);
            this.tabMain.Controls.Add(this.tpgTest3);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(964, 616);
            this.tabMain.TabIndex = 0;
            // 
            // tpgTest11
            // 
            this.tpgTest11.Location = new System.Drawing.Point(4, 28);
            this.tpgTest11.Name = "tpgTest11";
            this.tpgTest11.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTest11.Size = new System.Drawing.Size(767, 393);
            this.tpgTest11.TabIndex = 0;
            this.tpgTest11.Text = "test1";
            this.tpgTest11.UseVisualStyleBackColor = true;
            // 
            // tpgTest2
            // 
            this.tpgTest2.Location = new System.Drawing.Point(4, 28);
            this.tpgTest2.Name = "tpgTest2";
            this.tpgTest2.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTest2.Size = new System.Drawing.Size(767, 393);
            this.tpgTest2.TabIndex = 1;
            this.tpgTest2.Text = "test2";
            this.tpgTest2.UseVisualStyleBackColor = true;
            // 
            // tpgTest3
            // 
            this.tpgTest3.Location = new System.Drawing.Point(4, 28);
            this.tpgTest3.Name = "tpgTest3";
            this.tpgTest3.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTest3.Size = new System.Drawing.Size(956, 584);
            this.tpgTest3.TabIndex = 2;
            this.tpgTest3.Text = "test3";
            this.tpgTest3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 641);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgTest11;
        private System.Windows.Forms.TabPage tpgTest2;
        private System.Windows.Forms.TabPage tpgTest3;
    }
}

