using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SicParvisMagna.Controllers;
using System.Windows.Documents;

namespace SicParvisMagna.Library
{
    class Utility
    {
        public  static string  loadProductVariants(Guid ProductVariantId)
        {
            DataTable dtt = new DataTable();
            DataRow dr = dtt.NewRow();
         
            string variant = "";
            ProductVariantDetailDAL obj = new ProductVariantDetailDAL();
            VariantTypeDAL objVTD = new VariantTypeDAL();
            DataTable dt = obj.productVariantsDetails_LoadByProductVariantId(ProductVariantId);
            for (int xx = 0; xx < dt.Rows.Count; xx++)
            {
                variant += dt.Rows[xx]["Variant"].ToString() + "  | ";
                 
            }
             
            return variant;
 

           
        }

        public static DataTable convertStringToDataTable(string data)
        {
            DataTable dataTable = new DataTable();
            bool columnsAdded = false;
            foreach (string row in data.Split('$'))
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (string cell in row.Split('|'))
                {
                    string[] keyValue = cell.Split('~');
                    if (!columnsAdded)
                    {
                        DataColumn dataColumn = new DataColumn(keyValue[0]);
                        dataTable.Columns.Add(dataColumn);
                    }
                    dataRow[keyValue[0]] = keyValue[1];
                }
                columnsAdded = true;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
        public static int User_ID { get; set; }



        public static List<comboboxListItem> GetListByDataTable(DataTable dt)
        {

            List<comboboxListItem> reult = (from rw in dt.AsEnumerable()
                         select new comboboxListItem()
                         {
                             id = Guid.Parse(rw["Pro_id"].ToString()),
                             Title = Convert.ToString(rw["Name"])
                         }).ToList();


            
            
            return reult.ConvertAll<comboboxListItem>(o => (comboboxListItem)o);
        }

        public static List<comboboxListItem> GetVariantByDataTable(DataTable dt)
        {

            List<comboboxListItem> reult  = (from rw in dt.AsEnumerable()
                                            select new comboboxListItem()
                                            {
                                                Product_Variant_Id = Guid.Parse(rw["Product_Variant_Id"].ToString()),
                                                Variants = Convert.ToString(rw["Variants"])
                                            }).ToList();




            return reult.ConvertAll<comboboxListItem>(o => (comboboxListItem)o);
        }
        public static List<comboboxListItem> GetVariantListByDataTable(DataTable dt)
        {

            List<comboboxListItem> reult = (from rw in dt.AsEnumerable()
                                            select new comboboxListItem()
                                            {
                                                Variant_Type_Id = Guid.Parse(rw["Variant_Type_Id"].ToString()),
                                                Title = Convert.ToString(rw["Title"])
                                            }).ToList();




            return reult.ConvertAll<comboboxListItem>(o => (comboboxListItem)o);
        }
    }



    public class comboboxListItem
    {
        public Guid id { get; set; }
        public Guid Variant_Type_Id { get; set; }
        public Guid Variant_id { get; set;  }
        public string Title { get; set; }
        public string Variants { get; set; }
        public Guid Product_Variant_Id { get; set; }


        //public comboboxListItem(Guid ID, string Value)
        //{
        //    this.id = ID;
        //    this.value = Value;
        //}


        //public Guid Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public string Value
        //{
        //    get { return value; }
        //    set { value = value; }
        //}


    }

}
