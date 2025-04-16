using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Homework
{
    public partial class Form1: Form
    {

        List<Product> products;
        List<string> Codes;
        Product selectedProduct;

        
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
            Codes = new List<string>();
            selectedProduct = null;
        }
  
        
        private bool inputValid(TextBox tb1)
        {
            if (string.IsNullOrEmpty(tb1.Text))
            {
                
                MessageBox.Show($"{tb1.Name}을(를) 입력하세요.");
                tb1.Focus();
                return false;
            }
            return true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (!inputValid(tbxInputProductName)) return;
            if (!inputValid(tbxInputProductPrice)) return;
            if (!inputValid(tbxInputProductStock)) return;

            string productName = tbxInputProductName.Text.Trim();
            int productPrice;
            int productStock;

            if (!int.TryParse(tbxInputProductPrice.Text.Trim(), out productPrice))
            {
                MessageBox.Show("상품가격은 숫자만입력");
                return;
            } 
            if (!int.TryParse(tbxInputProductStock.Text.Trim(), out productStock))
            {
                MessageBox.Show("상품재고는 숫자만입력");
                return;
            }
            DateTime productRegDate = DateTime.Now.AddDays(-new Random().Next(20, 100));
            string productCode;
            do
            {
                productCode = DateTime.Now.ToString("yyyyMMdd") + new Random().Next(1000).ToString("D3");
            }
            while (Codes.Contains(productCode));

            Product product = new Product(productCode, productName, productPrice, productStock, productRegDate);
            products.Add(product);
            MessageBox.Show("등록완료");
            tbxInputProductName.Text = "";
            tbxInputProductPrice.Text = "";
            tbxInputProductStock.Text = "";
        }

        private void ClearView()
        {
            
            lblSearchProductCode.Text = "";
            lblSearchProductName.Text = "";
            lblSearchProductPrice.Text = "";
            lblSearchProductRegDate.Text = "";
            lblSearchProductSalePrice.Text = "";
            lblSearchProductStock.Text = "";
            lblSearchProductTotalPrice.Text = "";
            tbxSearchProductCount.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxSearchProduct.Items.Clear();
            ClearView();
            if (!inputValid(tbxSearchNameCode)) return;

            bool productEmpty = true;
            string codeName = tbxSearchNameCode.Text;

            foreach (var prod in products)
            {
                if (prod.Code.Contains(codeName) || prod.Name.Contains(codeName))
                {
                    lbxSearchProduct.Items.Add(prod);
                    productEmpty = false;
                    continue;
                }
                
            }
            if (productEmpty)
            {
                MessageBox.Show("해당 상품은 존재하지 않습니다.");
                return;
            }
        }

        private void lbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearView();
            var product = lbxSearchProduct.SelectedItem as Product;
            selectedProduct = product;
            if (product == null)
            {
                return;
            }

            lblSearchProductName.Text = product.Name;
            lblSearchProductCode.Text = product.Code;
            lblSearchProductPrice.Text = product.Price.ToString();
            lblSearchProductSalePrice.Text = product.SalePrice().ToString();
            lblSearchProductStock.Text = product.Stock.ToString();
            lblSearchProductRegDate.Text = product.RegDate.ToString("yyyy-MM-dd");
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (!inputValid(tbxSearchProductCount)) return;
            int count;
            if (!int.TryParse(tbxSearchProductCount.Text, out count))
            {
                MessageBox.Show("수량은 숫자만 입력하세요.");
                return;
            }
            lblSearchProductTotalPrice.Text = selectedProduct.CalPrice(count).ToString();
        }
    }
}
