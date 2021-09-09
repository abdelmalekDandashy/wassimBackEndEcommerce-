using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using BLC;
namespace BLC
{
public partial class BLC
{

#region Enum_API_Method
public enum Enum_API_Method
{
Get_Product_By_OWNER_ID,
Get_Product_By_Where,
Edit_Product,
Delete_Product,
Get_Category_By_OWNER_ID,
Get_Category_By_Where,
Edit_Category,
Delete_Category,
Get_Product_By_Where_Adv,
Get_User_account_By_USER_ID_Adv,
Edit_Address,
Delete_Address,
Authenticate,
Get_Order_details_By_INVOICE_ID,
Edit_User,
Get_Adress_By_USER_ID,
Edit_Adress
}
#endregion

#region Prepare_BLCInitializer
public BLCInitializer Prepare_BLCInitializer(string i_Ticket, Enum_API_Method i_Enum_API_Method)
{
#region Declaration And Initialization Section.
BLCInitializer oBLCInitializer = new BLCInitializer();
BLC oBLC_Default = new BLC();
string str_CUSTOM_BLC_INIT = string.Empty;
#endregion
#region Body Section.
if (this.OnPreEvent_BLC_Init != null)
{
oBLCInitializer = this.OnPreEvent_BLC_Init(i_Ticket, i_Enum_API_Method);
return oBLCInitializer;
}
else
{
oBLCInitializer.UserID = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
}
#endregion
#region Return Section.
return oBLCInitializer;
#endregion
}
#endregion

#region General Pre/Post events
public delegate void PreEvent_Handler_General(string i_MethodName);
public delegate void PostEvent_Handler_General(string i_MethodName);
public event PreEvent_Handler_General OnPreEvent_General;
public event PostEvent_Handler_General OnPostEvent_General;
#endregion
#region General Pre/Post BLC_Init
public delegate BLCInitializer PreEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public delegate BLCInitializer PostEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public event PreEvent_Handler_BLC_Init OnPreEvent_BLC_Init;
public event PostEvent_Handler_BLC_Init OnPostEvent_BLC_Init;
#endregion
public  delegate void PreEvent_Handler_Edit_Uploaded_file(Uploaded_file i_Uploaded_file,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Uploaded_file(Uploaded_file i_Uploaded_file,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Uploaded_file OnPreEvent_Edit_Uploaded_file;
public event PostEvent_Handler_Edit_Uploaded_file OnPostEvent_Edit_Uploaded_file;
public  delegate void PreEvent_Handler_Edit_User(User i_User,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_User(User i_User,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_User OnPreEvent_Edit_User;
public event PostEvent_Handler_Edit_User OnPostEvent_Edit_User;
public  delegate void PreEvent_Handler_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file);
public  delegate void  PostEvent_Handler_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file);
public event PreEvent_Handler_Delete_Uploaded_file OnPreEvent_Delete_Uploaded_file;
public event PostEvent_Handler_Delete_Uploaded_file OnPostEvent_Delete_Uploaded_file;
public  delegate void PreEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
public  delegate void  PostEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
public event PreEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
public event PostEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
public  delegate void PreEvent_Handler_Get_Category_By_Where(Params_Get_Category_By_Where i_Params_Get_Category_By_Where);
public  delegate void  PostEvent_Handler_Get_Category_By_Where(ref List<Category>  i_Result, Params_Get_Category_By_Where i_Params_Get_Category_By_Where);
public event PreEvent_Handler_Get_Category_By_Where OnPreEvent_Get_Category_By_Where;
public event PostEvent_Handler_Get_Category_By_Where OnPostEvent_Get_Category_By_Where;
public  delegate void PreEvent_Handler_Get_Product_By_Where(Params_Get_Product_By_Where i_Params_Get_Product_By_Where);
public  delegate void  PostEvent_Handler_Get_Product_By_Where(ref List<Product>  i_Result, Params_Get_Product_By_Where i_Params_Get_Product_By_Where);
public event PreEvent_Handler_Get_Product_By_Where OnPreEvent_Get_Product_By_Where;
public event PostEvent_Handler_Get_Product_By_Where OnPostEvent_Get_Product_By_Where;
public  delegate void PreEvent_Handler_Get_Product_By_Where_Adv(Params_Get_Product_By_Where i_Params_Get_Product_By_Where);
public  delegate void  PostEvent_Handler_Get_Product_By_Where_Adv(List<Product>  i_Result, Params_Get_Product_By_Where i_Params_Get_Product_By_Where);
public event PreEvent_Handler_Get_Product_By_Where_Adv OnPreEvent_Get_Product_By_Where_Adv;
public event PostEvent_Handler_Get_Product_By_Where_Adv OnPostEvent_Get_Product_By_Where_Adv;
#region Uploaded Files Events Handlers
#region Register_Uploaded_Events_Handlers
public void Register_Uploaded_Events_Handlers()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.OnPreEvent_Edit_Uploaded_file += BLC_OnPreEvent_Edit_Uploaded_file;
this.OnPreEvent_Delete_Uploaded_file += BLC_OnPreEvent_Delete_Uploaded_file;
this.OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD += BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
this.OnPostEvent_Get_Product_By_Where += BLC_OnPostEvent_Get_Product_By_Where_Uploaded_Files;
this.OnPostEvent_Get_Category_By_Where += BLC_OnPostEvent_Get_Category_By_Where_Uploaded_Files;
#endregion
}
#endregion
#region BLC_OnPostEvent_Get_Product_By_Where_Uploaded_Files
private void BLC_OnPostEvent_Get_Product_By_Where_Uploaded_Files(ref List<Product> i_Result, Params_Get_Product_By_Where i_Params_Get_Product_By_Where)
{
#region Declaration And Initialization Section.
Uploaded_file oUploaded_file = new Uploaded_file();
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
#endregion
if (i_Result != null)
{
foreach (var oRow_Product in i_Result)
{
#region Images
oRow_Product.My_Uploaded_files = Get_Uploaded_Files("[TBL_PRODUCT]", "PRODUCT_IMAGE", oRow_Product.PRODUCT_ID);
if (oRow_Product.My_Uploaded_files != null)
{
foreach (var oRow_Uploaded_file in oRow_Product.My_Uploaded_files)
{
oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
}
}
#endregion
}
}
}
#endregion
#region BLC_OnPostEvent_Get_Category_By_Where_Uploaded_Files
private void BLC_OnPostEvent_Get_Category_By_Where_Uploaded_Files(ref List<Category> i_Result, Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
#region Declaration And Initialization Section.
Uploaded_file oUploaded_file = new Uploaded_file();
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
#endregion
if (i_Result != null)
{
foreach (var oRow_Category in i_Result)
{
#region Images
oRow_Category.My_Uploaded_files = Get_Uploaded_Files("[TBL_CATEGORY]", "CATEGORY_IMAGE", oRow_Category.CATEGORY_ID);
if (oRow_Category.My_Uploaded_files != null)
{
foreach (var oRow_Uploaded_file in oRow_Category.My_Uploaded_files)
{
oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
}
}
#endregion
}
}
}
#endregion
#region Get_Uploaded_Files
public List<Uploaded_file> Get_Uploaded_Files(string i_REL_ENTITY,string i_REL_FIELD,long? i_REL_KEY)
{
#region Declaration And Initialization Section.
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY = i_REL_ENTITY;
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD = i_REL_FIELD;
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY = i_REL_KEY;
oList_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
#endregion
#region Return Section.
return oList_Uploaded_files;
#endregion
}
#endregion
#region BLC_OnPreEvent_Edit_Uploaded_file
void BLC_OnPreEvent_Edit_Uploaded_file(Uploaded_file i_Uploaded_file, BLC.Enum_EditMode i_Enum_EditMode)
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
i_Uploaded_file.STAMP = oTools.Get_Unique_String();
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Uploaded_file
void BLC_OnPreEvent_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
#region Declaration And Initialization Section.
string str_Full_Path = string.Empty;
Uploaded_file oUploaded_file = new Uploaded_file();
Params_Get_Uploaded_file_By_UPLOADED_FILE_ID oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID();
string str_Main_Folder = ConfigurationManager.AppSettings["UPLOAD_DOCUMENT_LOCATION"];
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID();
oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID.UPLOADED_FILE_ID = i_Params_Delete_Uploaded_file.UPLOADED_FILE_ID;
oUploaded_file = Get_Uploaded_file_By_UPLOADED_FILE_ID(oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID);
str_Full_Path = string.Format(@"{0}\{1}.{2}", str_Main_Folder, oUploaded_file.UPLOADED_FILE_ID.ToString(), oUploaded_file.EXTENSION);
File.Delete(str_Full_Path);
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
private void BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
#region Declaration And Initialization Section.
string str_Full_Path = string.Empty;
Uploaded_file oUploaded_file = new Uploaded_file();
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
string str_Main_Folder = ConfigurationManager.AppSettings["UPLOAD_DOCUMENT_LOCATION"];
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
oTools.CopyPropValues(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD, oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
oList_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
if ((oList_Uploaded_files != null) && (oList_Uploaded_files.Count > 0))
{
oUploaded_file = oList_Uploaded_files[oList_Uploaded_files.Count - 1];
str_Full_Path = string.Format(@"{0}\{1}.{2}", str_Main_Folder, oUploaded_file.UPLOADED_FILE_ID.ToString(), oUploaded_file.EXTENSION);
File.Delete(str_Full_Path);
}
#endregion
}
#endregion
#endregion
}
}
