using BLC;
using System;
using System.Collections.Generic;
using System.Configuration;
using Newtonsoft.Json;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {   

            #region Declaration And Initialization Section.
            string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
            BLC.BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
            oBLCInitializer.ConnectionString = _ConnectionString;
            oBLCInitializer.OwnerID = 1;
            oBLCInitializer.UserID = 1;
            oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
            BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);
            string str_Option = string.Empty;
            string str_BH_ID = string.Empty;
            string str_AC_ID = string.Empty;
            string str_Bucket_Name = string.Empty;
            string str_Main_Folder_Path = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            #endregion

            Params_Feetoura oParams_Feetoura = new Params_Feetoura();
            Feetoura_Products oFeetoura_Products = new Feetoura_Products();
            oFeetoura_Products.PRODUCT_ID = 8;
            oFeetoura_Products.QUANTITY = 5;


            List<Feetoura_Products> oList = new List<Feetoura_Products>();


            oList.Add(oFeetoura_Products);
            oList.Add(oFeetoura_Products);
            oParams_Feetoura.OWNER_ID = 1;
            oParams_Feetoura.USER_ACCOUNT_ID = 2;
            oParams_Feetoura.USER_ID = 1;
            oParams_Feetoura.PRODUCTS = oList;




            var json = JsonConvert.SerializeObject(oParams_Feetoura);
            Console.WriteLine(json);
            Console.WriteLine(json);
            var result = oBLC.Feetoura(oParams_Feetoura);
            Console.WriteLine(result);
            Console.WriteLine(result);




        }
    }
}
