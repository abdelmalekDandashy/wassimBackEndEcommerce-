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
            

            Params_Fetoura oParams_Fetoura = new Params_Fetoura();
            Fetoura_Products oFetoura_Products = new Fetoura_Products();
            oFetoura_Products.PRODUCT_ID = 8;
            oFetoura_Products.QUANTITY = 5;


            List<Fetoura_Products> oList = new List<Fetoura_Products>();


            oList.Add(oFetoura_Products);
            oList.Add(oFetoura_Products);
            oParams_Fetoura.OWNER_ID = 1;
            oParams_Fetoura.USER_ACCOUNT_ID = 2;
            oParams_Fetoura.USER_ID = 1;
            oParams_Fetoura.PRODUCTS =oList;

            var result = oBLC.Fetoura(oParams_Fetoura);
            Console.WriteLine(result);
            Console.WriteLine(result);




        }
    }
}
