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
            //User oUser = new User();
            //oTools.SetPropertiesDefaultValue(oUser);
            //oUser.USER_ID = -1;
            //oUser.OWNER_ID = 1;
            //oUser.IS_ACTIVE = true;
            //oUser.USERNAME = "wassim";
            //oUser.PASSWORD = "hussein";
            //oBLC.Edit_User(oUser);
            //var jsonString = JsonConvert.SerializeObject(oUser);




            //Console.WriteLine(jsonString);
            //Console.WriteLine("user added");
            //Console.WriteLine("user added");

            //Params_Get_Product_By_OWNER_ID oParams_Get_Product_By_OWNER_ID = new Params_Get_Product_By_OWNER_ID();
            //oParams_Get_Product_By_OWNER_ID.OWNER_ID = 1;
            //var result = oBLC.Get_Product_By_OWNER_ID_Adv(oParams_Get_Product_By_OWNER_ID);
            //var jsonString = JsonConvert.SerializeObject(result);
            //Console.WriteLine(jsonString);
            //Console.WriteLine(jsonString);


            //for (int i = 0; i < result.Count; i++)
            //{
            //    Params_Get_Product_size_By_PRODUCT_ID oParams_Get_Product_size_By_PRODUCT_ID = new Params_Get_Product_size_By_PRODUCT_ID();
            //    oParams_Get_Product_size_By_PRODUCT_ID.PRODUCT_ID=result[i].PRODUCT_ID;
            //    var myresult = oBLC.Get_Product_size_By_PRODUCT_ID_Adv(oParams_Get_Product_size_By_PRODUCT_ID);
            //    Console.WriteLine("Value of i: {0}", result[i].PRODUCT_ID);
            //    Console.WriteLine("Value of i: {0}", result[i].PRODUCT_ID);


            //}

            Params_Get_Product_By_Where oParams_Get_Product_By_Where = new Params_Get_Product_By_Where();
            oParams_Get_Product_By_Where.OWNER_ID = 1;
            var myresult = oBLC.Get_Product_By_Where_Adv(oParams_Get_Product_By_Where);
            Console.WriteLine();



            //Params_Get_Product_size_By_PRODUCT_ID oParams_Get_Product_size_By_PRODUCT_ID = new Params_Get_Product_size_By_PRODUCT_ID();
            //oParams_Get_Product_size_By_PRODUCT_ID.PRODUCT_ID = 8;
            //var myresult = oBLC.Get_Product_size_By_PRODUCT_ID_Adv(oParams_Get_Product_size_By_PRODUCT_ID);
        }
    }
}
