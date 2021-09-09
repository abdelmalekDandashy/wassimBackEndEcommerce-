using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Transactions;
using Newtonsoft.Json;

namespace BLC
{
    #region Enumeration
    public enum Enum_EntityNameFormat
    {
        FML,
        FLM,
        MFL,
        MLF,
        LFM,
        LMF
    }
    #endregion
    public partial class BLC
    {
        #region Members
        #endregion        
        #region Setup
        #region EditSetup
        #region EditSetup
        public void EditSetup(SetupEntry i_SetupEntry)
        {
            #region Declaration And Initialization Section.
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "EditSetup";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                oMethodInfo.Invoke(this, new object[] { i_SetupEntry });
                return;
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("EditSetup");
            }
            #endregion
            #region Body Section.
            i_SetupEntry.ENTRY_USER_ID = this.UserID;
            i_SetupEntry.OWNER_ID = this.OwnerID;
            i_SetupEntry.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
            oTools.InvokeMethod(_AppContext, "UP_EDIT_SETUP", i_SetupEntry);
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("EditSetup");
            }
            #endregion
        }
        #endregion
        #endregion
        #endregion
        #region Ticket
        #region ResolveTicket
        public Dictionary<string, string> ResolveTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            Dictionary<string, string> oList = new Dictionary<string, string>();
            string str_Ticket_PlainText = string.Empty;
            Crypto.Crypto oCrypto = new Crypto.Crypto();
            string[] oMainTempList = null;
            string[] oSubTempList = null;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("ResolveTicket");
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                //str_Ticket_PlainText = oCrypto.Decrypt(i_Input, _KeySet);
                str_Ticket_PlainText = i_Input;

                if (!string.IsNullOrEmpty(str_Ticket_PlainText))
                {
                    oMainTempList = str_Ticket_PlainText.Split(new string[] { "[~!@]" }, StringSplitOptions.RemoveEmptyEntries);

                    var oQuery = from oItem in oMainTempList
                                 select oItem;

                    foreach (var oRow in oQuery)
                    {
                        oSubTempList = oRow.Split(new string[] { ":" }, StringSplitOptions.None);
                        oList.Add(oSubTempList[0], oSubTempList[1]);
                    }
                }
            }
            else
            {
                oList.Add("USER_ID", "1");
                oList.Add("OWNER_ID", "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("ResolveTicket");
            }
            #endregion
            #region Return Section.
            return oList;
            #endregion
        }
        #endregion
        #region IsValidTicket
        public bool IsValidTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool Is_ValidTicket = false;
            long? i_MinutesElapsedSinceMidnight = 0;
            string str_CurrentDate = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            Dictionary<string, string> oTicketParts = new Dictionary<string, string>();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "IsValidTicket";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                return Convert.ToBoolean(oMethodInfo.Invoke(this, new object[] { i_Input }));
                // Intentially Left Empty.
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("IsValidTicket");
            }
            #endregion
            #region Body Section.
            try
            {
                oTicketParts = ResolveTicket(i_Input);
                str_CurrentDate = oTools.GetDateString(DateTime.Today);

                if (oTicketParts["START_DATE"] == str_CurrentDate) // Session Started In Different Day.
                {
                    i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;

                    if (i_MinutesElapsedSinceMidnight <= Convert.ToInt32(oTicketParts["START_MINUTE"]) + Convert.ToInt32(oTicketParts["SESSION_PERIOD"]))
                    {
                        Is_ValidTicket = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Is_ValidTicket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("IsValidTicket");
            }
            #endregion
            #region Return Section.
            return Is_ValidTicket;
            #endregion
        }
        #endregion
        #endregion

        #region authenticate
        public User Authenticate(Params_Authenticate i_Params_Authenticate)
            {
                #region declaration
            
                User oUser = new User();
            #endregion

            List<dynamic> oList = _AppContext.UP_GET_USER_BY_CREDENTIALS
                (
                i_Params_Authenticate.OWNER_ID,
                i_Params_Authenticate.EMAIL,
                i_Params_Authenticate.PASSWORD
                );


            if ((oList != null) && (oList.Count > 0)) {

                //Console.WriteLine(JsonConvert.SerializeObject(oList));

                oUser.USER_ID = oList[0].USER_ID;
                oUser.OWNER_ID = oList[0].OWNER_ID;
                oUser.EMAIL = oList[0].EMAIL;
                oUser.USERNAME = oList[0].USERNAME;
                oUser.PHONE = oList[0].PHONE;
                oUser.FIRST_NAME = oList[0].FIRST_NAME;
                oUser.LAST_NAME = oList[0].LAST_NAME;

                var MinutesEplapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                var TicketText = string.Format
                    (
                    "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                    oUser.USER_ID,
                    oUser.OWNER_ID,
                    oTools.GetDateString(DateTime.Today),
                    MinutesEplapsedSinceMidnight.ToString(),
                    60
                    );


                List<Adress> oListAdress = new List<Adress>(0);
                Params_Get_Adress_By_USER_ID oParams_Get_Adress_By_USER_ID = new Params_Get_Adress_By_USER_ID();
                oParams_Get_Adress_By_USER_ID.USER_ID = oList[0].USER_ID;
                var result = this.Get_Adress_By_USER_ID(oParams_Get_Adress_By_USER_ID);
                if ((result != null) && (result.Count > 0))
                {
                    oListAdress = result;
                }
                




                oUser.myTicket = TicketText;
                oUser.myAdress = oListAdress;

            }
            else
            {
                //Console.WriteLine(JsonConvert.SerializeObject(oList));
                //Console.WriteLine("password or email 8alat");

                throw new BLCException("email or password are invalid");
            }

            return oUser;
                
            }
        #endregion


        #region Feetoura
        public Faatoura Feetoura(Params_Feetoura i_Params_Feetoura)
        {
            #region method code
            Faatoura oInvoice = new Faatoura();
            List<dynamic> outOfStockProducts = new List<dynamic>();
            List<int?> oListProduct= new List<int?> ();
            List<int?> oListOrder_details_IDs= new List<int?> ();
            List<Order_details> oListProductsToBuy= new List<Order_details> ();

            
            decimal Total_Price = 0;

            if (i_Params_Feetoura != null && i_Params_Feetoura.PRODUCTS != null && i_Params_Feetoura.PRODUCTS.Count > 0)
            {


                using (TransactionScope oScope = new TransactionScope())
                {
                    // makes invoice:
                    Invoice eInvoice = new Invoice();

                    eInvoice.INVOICE_ID = -1;
                    eInvoice.INVOICE_STATUS_ID = 6;
                    eInvoice.USER_ACCOUNT_ID = i_Params_Feetoura.USER_ACCOUNT_ID;
                    eInvoice.ENTRY_USER_ID = 1;
                    this.Edit_Invoice(eInvoice);
                    Console.WriteLine("invoice was made");


                    foreach (var product in i_Params_Feetoura.PRODUCTS)
                    {
                        oListProduct.Add(product.PRODUCT_ID);

                        Params_Get_Product_By_PRODUCT_ID oParams_Get_Product_By_PRODUCT_ID = new Params_Get_Product_By_PRODUCT_ID();


                        oParams_Get_Product_By_PRODUCT_ID.PRODUCT_ID = product.PRODUCT_ID;

                        var oResult = this.Get_Product_By_PRODUCT_ID(oParams_Get_Product_By_PRODUCT_ID);
                        if (oResult != null)
                        {
                            if (oResult.STOCK < product.QUANTITY)
                            {
                                outOfStockProducts.Add(product.PRODUCT_ID);

                            };

                            if (oResult.STOCK >= product.QUANTITY)
                            {




                                Total_Price = Total_Price + (
                                  Convert.ToDecimal(oResult.DISCOUNT_PRICE) * Convert.ToDecimal(product.QUANTITY)
                                    );


                               


                                // add invoice_id to each order_details entry:

                                Order_details oOrder_details = new Order_details();
                                oOrder_details.ORDER_DETAILS_ID = -1;
                                oOrder_details.PRODUCT_ID = product.PRODUCT_ID;
                                oOrder_details.QUANTITY = product.QUANTITY;
                                oOrder_details.OWNER_ID = i_Params_Feetoura.OWNER_ID;
                                oOrder_details.INVOICE_ID = eInvoice.INVOICE_ID;
                                decimal discountPrice = oResult.DISCOUNT_PRICE ?? 0;
                                oOrder_details.PRICE = discountPrice;

                                Console.WriteLine(oOrder_details);
                                Console.WriteLine(oOrder_details);
                                

                                this.Edit_Order_details(oOrder_details);
                                oListProductsToBuy.Add(oOrder_details);



                                Console.WriteLine(oOrder_details);
                                Console.WriteLine("product was added to products details table");


                                oResult.STOCK = oResult.STOCK - product.QUANTITY;

                                List<Product> oListProductToEdit = new List<Product>();
                                oListProductToEdit.Add(oResult);
                                Params_Edit_Product_List oParams_Edit_Product_List = new Params_Edit_Product_List();
                                oParams_Edit_Product_List.My_List_To_Edit = oListProductToEdit;

                                this.Edit_Product_List(oParams_Edit_Product_List);




                            }
                               else if (oResult.STOCK < product.QUANTITY)
                                {
                                    oScope.Dispose();
                                var o = JsonConvert.SerializeObject(outOfStockProducts);
                                throw new BLCException("transactions was canceled due lack in stock for some products with ID/s: "+ o);

                                }

                            














                        }
                    }
                    oScope.Complete();
                }
                
                // here close transactionscope


     
           
                    oInvoice.outOfStockProducts = outOfStockProducts;
                    oInvoice.total = Total_Price;
                    oInvoice.productsToBuy = oListProductsToBuy;
                    return oInvoice;
              
            }

        #endregion 
            return oInvoice;
        }

        #endregion
    }
    #region Business Entities
    #region Setup
    #region SetupEntry
    public class SetupEntry
    {
        #region Properties
        public Int32? OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public string CODE_NAME { get; set; }
        public bool? ISSYSTEM { get; set; }
        public bool? ISDELETEABLE { get; set; }
        public bool? ISUPDATEABLE { get; set; }
        public bool? ISVISIBLE { get; set; }
        public bool? ISDELETED { get; set; }
        public Int32? DISPLAY_ORDER { get; set; }
        public string CODE_VALUE_EN { get; set; }
        public string CODE_VALUE_FR { get; set; }
        public string CODE_VALUE_AR { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string NOTES { get; set; }

        public string INVARIANT_VALUE { get; set; }
        #endregion
    }
    #endregion    
    #endregion
    #region Uploaded_file
    public partial class Uploaded_file
    {
        public string My_URL { get; set; }
    }
    #endregion
    #region Product
    public partial class Product
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
        public string My_Image_Url { get; set; }
        //public List<Product_color> My_Color { get; set; }
        //public List<Product_size> My_Size { get; set; }

    }
    #endregion

    #region User
    public partial class User
    {
    public string myTicket { get; set; }
    public List<Adress> myAdress { get; set; }

    }
    #endregion
    #region Product
    public partial class Category
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
        //public string My_Image_Url { get; set; }
    }
    #endregion
    #region Feetoura
    public partial class Faatoura
    {
        public List<dynamic> outOfStockProducts { get; set; }
        public List<Order_details> productsToBuy { get; set; }
        public decimal total { get; set; }
    }
    #endregion
    #region Params_Authenticate
    public partial class Params_Authenticate
    {
        public int OWNER_ID { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
    }
    #endregion
    #region Params_Feetoura
    public partial class Params_Feetoura
    {
        public int OWNER_ID { get; set; }
        public int USER_ID { get; set; }
        public List<Feetoura_Products> PRODUCTS { get; set; }
        public int USER_ACCOUNT_ID { get; set; }
    }
    #endregion
    #region Feetoura_Products
    public partial class Feetoura_Products
    {
        public int PRODUCT_ID { get; set; }
        public int QUANTITY { get; set; }
  
    }
    #endregion


    #endregion
}


