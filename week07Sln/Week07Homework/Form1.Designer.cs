namespace Week07Homework
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
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbxInputProductStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxInputProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInputProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchProductSalePrice = new System.Windows.Forms.Label();
            this.lblSearchProductTotalPrice = new System.Windows.Forms.Label();
            this.lblSearchProductRegDate = new System.Windows.Forms.Label();
            this.lblSearchProductStock = new System.Windows.Forms.Label();
            this.lblSearchProductPrice = new System.Windows.Forms.Label();
            this.lblSearchProductCode = new System.Windows.Forms.Label();
            this.lblSearchProductName = new System.Windows.Forms.Label();
            this.lbxSearchProduct = new System.Windows.Forms.ListBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxSearchProductCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSearchNameCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxInput.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnInput);
            this.gbxInput.Controls.Add(this.tbxInputProductStock);
            this.gbxInput.Controls.Add(this.label3);
            this.gbxInput.Controls.Add(this.tbxInputProductPrice);
            this.gbxInput.Controls.Add(this.label2);
            this.gbxInput.Controls.Add(this.tbxInputProductName);
            this.gbxInput.Controls.Add(this.label1);
            this.gbxInput.Font = new System.Drawing.Font("굴림", 10F);
            this.gbxInput.Location = new System.Drawing.Point(39, 39);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(421, 364);
            this.gbxInput.TabIndex = 0;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "상품등록";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(179, 209);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(209, 38);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "등록";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbxInputProductStock
            // 
            this.tbxInputProductStock.Location = new System.Drawing.Point(179, 137);
            this.tbxInputProductStock.Name = "tbxInputProductStock";
            this.tbxInputProductStock.Size = new System.Drawing.Size(209, 30);
            this.tbxInputProductStock.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "재고";
            // 
            // tbxInputProductPrice
            // 
            this.tbxInputProductPrice.Location = new System.Drawing.Point(179, 90);
            this.tbxInputProductPrice.Name = "tbxInputProductPrice";
            this.tbxInputProductPrice.Size = new System.Drawing.Size(209, 30);
            this.tbxInputProductPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "가격";
            // 
            // tbxInputProductName
            // 
            this.tbxInputProductName.Location = new System.Drawing.Point(179, 43);
            this.tbxInputProductName.Name = "tbxInputProductName";
            this.tbxInputProductName.Size = new System.Drawing.Size(209, 30);
            this.tbxInputProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSearch.Controls.Add(this.lblSearchProductSalePrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductTotalPrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductRegDate);
            this.gbxSearch.Controls.Add(this.lblSearchProductStock);
            this.gbxSearch.Controls.Add(this.lblSearchProductPrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductCode);
            this.gbxSearch.Controls.Add(this.lblSearchProductName);
            this.gbxSearch.Controls.Add(this.lbxSearchProduct);
            this.gbxSearch.Controls.Add(this.btnCal);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.label12);
            this.gbxSearch.Controls.Add(this.tbxSearchProductCount);
            this.gbxSearch.Controls.Add(this.label11);
            this.gbxSearch.Controls.Add(this.label10);
            this.gbxSearch.Controls.Add(this.label9);
            this.gbxSearch.Controls.Add(this.label4);
            this.gbxSearch.Controls.Add(this.label7);
            this.gbxSearch.Controls.Add(this.label8);
            this.gbxSearch.Controls.Add(this.label5);
            this.gbxSearch.Controls.Add(this.tbxSearchNameCode);
            this.gbxSearch.Controls.Add(this.label6);
            this.gbxSearch.Font = new System.Drawing.Font("굴림", 10F);
            this.gbxSearch.Location = new System.Drawing.Point(524, 39);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(792, 585);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "상품조회";
            // 
            // lblSearchProductSalePrice
            // 
            this.lblSearchProductSalePrice.BackColor = System.Drawing.Color.White;
            this.lblSearchProductSalePrice.Location = new System.Drawing.Point(532, 245);
            this.lblSearchProductSalePrice.Name = "lblSearchProductSalePrice";
            this.lblSearchProductSalePrice.Size = new System.Drawing.Size(238, 40);
            this.lblSearchProductSalePrice.TabIndex = 4;
            // 
            // lblSearchProductTotalPrice
            // 
            this.lblSearchProductTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblSearchProductTotalPrice.Location = new System.Drawing.Point(532, 486);
            this.lblSearchProductTotalPrice.Name = "lblSearchProductTotalPrice";
            this.lblSearchProductTotalPrice.Size = new System.Drawing.Size(238, 40);
            this.lblSearchProductTotalPrice.TabIndex = 4;
            // 
            // lblSearchProductRegDate
            // 
            this.lblSearchProductRegDate.BackColor = System.Drawing.Color.White;
            this.lblSearchProductRegDate.Location = new System.Drawing.Point(532, 348);
            this.lblSearchProductRegDate.Name = "lblSearchProductRegDate";
            this.lblSearchProductRegDate.Size = new System.Drawing.Size(238, 40);
            this.lblSearchProductRegDate.TabIndex = 4;
            // 
            // lblSearchProductStock
            // 
            this.lblSearchProductStock.BackColor = System.Drawing.Color.White;
            this.lblSearchProductStock.Location = new System.Drawing.Point(532, 297);
            this.lblSearchProductStock.Name = "lblSearchProductStock";
            this.lblSearchProductStock.Size = new System.Drawing.Size(238, 40);
            this.lblSearchProductStock.TabIndex = 4;
            // 
            // lblSearchProductPrice
            // 
            this.lblSearchProductPrice.BackColor = System.Drawing.Color.White;
            this.lblSearchProductPrice.Location = new System.Drawing.Point(532, 195);
            this.lblSearchProductPrice.Name = "lblSearchProductPrice";
            this.lblSearchProductPrice.Size = new System.Drawing.Size(238, 40);
            this.lblSearchProductPrice.TabIndex = 4;
            // 
            // lblSearchProductCode
            // 
            this.lblSearchProductCode.BackColor = System.Drawing.Color.White;
            this.lblSearchProductCode.Location = new System.Drawing.Point(532, 140);
            this.lblSearchProductCode.Name = "lblSearchProductCode";
            this.lblSearchProductCode.Size = new System.Drawing.Size(238, 40);
            this.lblSearchProductCode.TabIndex = 4;
            // 
            // lblSearchProductName
            // 
            this.lblSearchProductName.BackColor = System.Drawing.Color.White;
            this.lblSearchProductName.Location = new System.Drawing.Point(532, 83);
            this.lblSearchProductName.Name = "lblSearchProductName";
            this.lblSearchProductName.Size = new System.Drawing.Size(238, 40);
            this.lblSearchProductName.TabIndex = 4;
            // 
            // lbxSearchProduct
            // 
            this.lbxSearchProduct.FormattingEnabled = true;
            this.lbxSearchProduct.ItemHeight = 20;
            this.lbxSearchProduct.Location = new System.Drawing.Point(19, 186);
            this.lbxSearchProduct.Name = "lbxSearchProduct";
            this.lbxSearchProduct.Size = new System.Drawing.Size(302, 164);
            this.lbxSearchProduct.TabIndex = 7;
            this.lbxSearchProduct.SelectedIndexChanged += new System.EventHandler(this.lbxSearchProduct_SelectedIndexChanged);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(683, 424);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(87, 41);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(296, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "총가격";
            // 
            // tbxSearchProductCount
            // 
            this.tbxSearchProductCount.Location = new System.Drawing.Point(532, 431);
            this.tbxSearchProductCount.Name = "tbxSearchProductCount";
            this.tbxSearchProductCount.Size = new System.Drawing.Size(136, 30);
            this.tbxSearchProductCount.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 431);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "수량";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "등록일자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "재고";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "가격";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "이름";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "할인가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "코드";
            // 
            // tbxSearchNameCode
            // 
            this.tbxSearchNameCode.BackColor = System.Drawing.SystemColors.Window;
            this.tbxSearchNameCode.Location = new System.Drawing.Point(19, 80);
            this.tbxSearchNameCode.Name = "tbxSearchNameCode";
            this.tbxSearchNameCode.Size = new System.Drawing.Size(296, 30);
            this.tbxSearchNameCode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(15, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "이름 && 코드";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 655);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxInput);
            this.Name = "Form1";
            this.Text = "7주차 숙제";
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tbxInputProductStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxInputProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInputProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSearchNameCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxSearchProduct;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox tbxSearchProductCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSearchProductSalePrice;
        private System.Windows.Forms.Label lblSearchProductStock;
        private System.Windows.Forms.Label lblSearchProductPrice;
        private System.Windows.Forms.Label lblSearchProductCode;
        private System.Windows.Forms.Label lblSearchProductName;
        private System.Windows.Forms.Label lblSearchProductTotalPrice;
        private System.Windows.Forms.Label lblSearchProductRegDate;
    }
}

