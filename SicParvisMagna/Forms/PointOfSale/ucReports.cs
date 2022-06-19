using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace SicParvisMagna.Reports
{
	public partial class ucReports : UserControl
	{
        public static Panel formContainer;
        public static Label formHeading;

        public ucReports()
		{
			InitializeComponent();
		}

        private void btnStock_Click(object sender, EventArgs e)
        {

            FormReport f = new FormReport("StockList", "StockList");
            f.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("ProductList", "ProductList");
            f.Show();
        }

        private void btnPurchaseOrderList_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("PurchaseOrderList", "PurchaseOrderList");
            f.Show();
        }

        private void btnReturnPurchaseOrder_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("Return_PurchaseOrderList", "Return_PurchaseOrderList");
            f.Show();
        }

        private void btnSaleOrder_Click(object sender, EventArgs e)
        {

            FormReport f = new FormReport("SaleOrderList", "SaleOrderList");
            f.Show();
        }

        private void btnReturnSaleOrder_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("Return_SaleOrderList", "Return_SaleOrderList");
            f.Show();
        }

        private void btnSaleInvoice_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("SaleInvoice", "SaleInvoice");
            f.Show();
        }

        private void btnPurchaseOrderSummary_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("PurchaseOrderSummary", "PurchaseOrderSummary");
            f.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("PurchaseOrderDetails", "PurchaseOrderDetails");
            f.Show();
        }

        private void btnPurchasingTaxReport_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("PurchasingTaxReport", "PurchasingTaxReport");
            f.Show();
        }

        private void btnPurchaseOrderStatus_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("PurchaseOrderStatus", "PurchaseOrderStatus");
            f.Show();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            FormReport f = new FormReport("ProductCostReport", "ProductCostReport");
            f.Show();
        }

        private void btnVendorProductList_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("VendorProductList", "VendorProductList");
            f.Show();
        }

        private void btnVendorList_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("VendorList", "VendorList");
            f.Show();
        }

        private void btnSalesByProductSummary_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("SalesByProductSummary", "SalesByProductSummary");
            
            f.Show();
        }

        private void btnSalesByProductDetails_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("SalesByProductDetails", "SalesByProductDetails");

            f.Show();
        }

        private void btnHistoricalInventory_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("HistoricalInventory", "HistoricalInventory");

            f.Show();
        }
    }
}
