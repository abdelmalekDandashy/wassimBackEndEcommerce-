using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
        
        #region authenticate
        public User Authenticate(Params_Authenticate i_Params_Authenticate)
        {
            #region declaration

            User oUser = new User();

            #endregion
            
            List<dynamic> oList = _AppContext.UP_GET_USER_BY_CREDENTIALS( i_Params_Authenticate.OWNER_ID, i_Params_Authenticate.USERNAME, i_Params_Authenticate.PASSWORD);
            if ((oList != null) && (oList.Count > 0))
            {
                if (i_Params_Authenticate.PASSWORD == oList[0].PASSWORD)
                {
                    oUser.USER_ID = oList[0].USER_ID;
                    oUser.OWNER_ID = oList[0].OWNER_ID;
                    oUser.USERNAME = oList[0].USERNAME;
                    oUser.EMAIL = oList[0].EMAIL;
                    //oUser.USER_TYPE_CODE = oList[0].USER_TYPE_CODE;
                    //oUser.IS_ACTIVE = oList[0].IS_ACTIVE;

                    


                    //oUser.My_User_type_code = oList[0].My_User_type_code;

                    //var MinutesEplapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                    //var TicketText = string.Format
                    //    (
                    //    "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                    //    oUser.USER_ID,
                    //    oUser.OWNER_ID,
                    //    oTools.GetDateString(DateTime.Today),
                    //    MinutesEplapsedSinceMidnight.ToString(),
                    //    60
                    //    );
                    //oUser.myTicket = TicketText;
                }
                else
                {
                    throw new BLCException("password is not correct");
                }

            }
            else
            {
                throw new BLCException("couldn't find enmail in our database");
            }

            return oUser;

        }


        #endregion auhtenticate
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
        public List<User_Type> Get_SetupEntries_Per_Table(Params_Get_SetupEntries_Per_Table i_Params_Get_SetupEntries_Per_Table)
        {
            List<User_Type> Olist_User_Type = new List<User_Type>();
            List<dynamic> oList = _AppContext.UP_GET_SETUP_ENTRIES(
                i_Params_Get_SetupEntries_Per_Table.OWNER_ID,
                i_Params_Get_SetupEntries_Per_Table.TBL_NAME,
                i_Params_Get_SetupEntries_Per_Table.ISVISIBLE,
                i_Params_Get_SetupEntries_Per_Table.ISDELETED
                );

            if ((oList != null) && (oList.Count > 0))
            {
                foreach (var x in oList)
                {
                    User_Type oUser_Type = new User_Type();
                    oTools.CopyPropValues(x, oUser_Type);
                    Olist_User_Type.Add(oUser_Type);
                }
                //oTools.CopyPropValues(oList, Olist_User_Type);


            }
                return Olist_User_Type;


           
        }
            
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
    public partial class Params_Get_SetupEntries_Per_Table
    {
   
        public int OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public bool ISVISIBLE { get; set; }
        public bool ISDELETED { get; set; }
        
    }
    public partial class User_Type
    {
   
        public int OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public string CODE_NAME { get; set; }
        public bool ISSYSTEM { get; set; }
        public bool ISDELETEABLE { get; set; }
        public bool ISUPDATEABLE { get; set; }
        public int DISPLAY_ORDER { get; set; }
        public bool ISVISIBLE { get; set; }
        public bool ISDELETED { get; set; }

        public string CODE_VALUE_EN { get; set; }
        public string CODE_VALUE_FR { get; set; }
        public string CODE_VALUE_AR { get; set; }
        public string NOTES { get; set; }
        public string ENTRY_DATE { get; set; }
        public string ENTRY_USER_ID { get; set; }






    }
    #endregion
    #region Product
    public partial class Product
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
        public string My_Image_Url { get; set; }
    }
    #endregion
    #region params authenticate
    public class Params_Authenticate
    {
        #region Properties

        public int OWNER_ID{ get; set; }
        public string USERNAME { get; set; }
        public string EMAIL { get; set; }

        public string PASSWORD { get; set; }

        #endregion
    }
    #endregion
    #region Product
    public partial class Category
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
        //public string My_Image_Url { get; set; }
    }
    #endregion
    public partial class User
    {
        public string myTicket { get; set; }
        public string My_Image_Url { get; set; }
        public List<Uploaded_file> My_Uploaded_files { get; set; }

    }
    
    public partial class User_account
    {

        public List<Uploaded_file> My_Uploaded_files { get; set; }
        public string My_Image_Url { get; set; }

    }
    #endregion
}


