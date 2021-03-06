using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLC;
[Route("api/[controller]")]
[ApiController]
public partial class DataController : ControllerBase
{
#region Members
#endregion
#region Extract_Ticket
private string Extract_Ticket()
{
#region Declaration And Initialization Section.
string str_Ticket = string.Empty;
#endregion
if(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null)
{
str_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
#region Return Section.
return str_Ticket;
#endregion
}
#endregion
#region IsValidWebTicket
private bool IsValidWebTicket(string i_Input)
{
#region Declaration And Initialization Section.
bool Is_Valid = false;
BLCInitializer oBLCInitializer = new BLCInitializer();
#endregion
#region Body Section.
BLC.BLC oBLC_Default = new BLC.BLC();
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
Is_Valid = oBLC.IsValidTicket(i_Input);
}
#endregion
#region Return Section.
return Is_Valid;
#endregion
}
#endregion
#region Authenticate
[HttpPost]
[Route("Authenticate")]
public Result_Authenticate Authenticate(Params_Authenticate i_Params_Authenticate)
{
#region Declaration And Initialization Section.
User oReturnValue = new User();
string i_Ticket = string.Empty;
Result_Authenticate oResult_Authenticate = new Result_Authenticate();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Authenticate(i_Params_Authenticate);
oResult_Authenticate.My_Result = oReturnValue;
oResult_Authenticate.My_Params_Authenticate = i_Params_Authenticate;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Authenticate.ExceptionMsg = string.Format("Authenticate : {0}", ex.Message);
}
else
{
oResult_Authenticate.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Authenticate;
#endregion
}
#endregion
#region Delete_Category
[HttpPost]
[Route("Delete_Category")]
public Result_Delete_Category Delete_Category(Params_Delete_Category i_Params_Delete_Category)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Category oResult_Delete_Category = new Result_Delete_Category();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Category);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Category(i_Params_Delete_Category);
oResult_Delete_Category.My_Params_Delete_Category = i_Params_Delete_Category;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Category.ExceptionMsg = string.Format("Delete_Category : {0}", ex.Message);
}
else
{
oResult_Delete_Category.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Category;
#endregion
}
#endregion
#region Delete_Product
[HttpPost]
[Route("Delete_Product")]
public Result_Delete_Product Delete_Product(Params_Delete_Product i_Params_Delete_Product)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Product oResult_Delete_Product = new Result_Delete_Product();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Product);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Product(i_Params_Delete_Product);
oResult_Delete_Product.My_Params_Delete_Product = i_Params_Delete_Product;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Product.ExceptionMsg = string.Format("Delete_Product : {0}", ex.Message);
}
else
{
oResult_Delete_Product.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Product;
#endregion
}
#endregion
#region Delete_Uploaded_file
[HttpPost]
[Route("Delete_Uploaded_file")]
public Result_Delete_Uploaded_file Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Uploaded_file oResult_Delete_Uploaded_file = new Result_Delete_Uploaded_file();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
oResult_Delete_Uploaded_file.My_Params_Delete_Uploaded_file = i_Params_Delete_Uploaded_file;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Uploaded_file.ExceptionMsg = string.Format("Delete_Uploaded_file : {0}", ex.Message);
}
else
{
oResult_Delete_Uploaded_file.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Uploaded_file;
#endregion
}
#endregion
#region Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
[HttpPost]
[Route("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD")]
public Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.My_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.ExceptionMsg = string.Format("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD : {0}", ex.Message);
}
else
{
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
#endregion
}
#endregion
#region Delete_User
[HttpPost]
[Route("Delete_User")]
public Result_Delete_User Delete_User(Params_Delete_User i_Params_Delete_User)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_User oResult_Delete_User = new Result_Delete_User();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_User);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_User(i_Params_Delete_User);
oResult_Delete_User.My_Params_Delete_User = i_Params_Delete_User;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_User.ExceptionMsg = string.Format("Delete_User : {0}", ex.Message);
}
else
{
oResult_Delete_User.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_User;
#endregion
}
#endregion
#region Delete_User_account
[HttpPost]
[Route("Delete_User_account")]
public Result_Delete_User_account Delete_User_account(Params_Delete_User_account i_Params_Delete_User_account)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_User_account oResult_Delete_User_account = new Result_Delete_User_account();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_User_account);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_User_account(i_Params_Delete_User_account);
oResult_Delete_User_account.My_Params_Delete_User_account = i_Params_Delete_User_account;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_User_account.ExceptionMsg = string.Format("Delete_User_account : {0}", ex.Message);
}
else
{
oResult_Delete_User_account.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_User_account;
#endregion
}
#endregion
#region Edit_Category
[HttpPost]
[Route("Edit_Category")]
public Result_Edit_Category Edit_Category(Category i_Category)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Category oResult_Edit_Category = new Result_Edit_Category();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Category);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Category(i_Category);
oResult_Edit_Category.My_Category = i_Category;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Category.ExceptionMsg = string.Format("Edit_Category : {0}", ex.Message);
}
else
{
oResult_Edit_Category.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Category;
#endregion
}
#endregion
#region Edit_Product
[HttpPost]
[Route("Edit_Product")]
public Result_Edit_Product Edit_Product(Product i_Product)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Product oResult_Edit_Product = new Result_Edit_Product();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Product);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Product(i_Product);
oResult_Edit_Product.My_Product = i_Product;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Product.ExceptionMsg = string.Format("Edit_Product : {0}", ex.Message);
}
else
{
oResult_Edit_Product.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Product;
#endregion
}
#endregion
#region Edit_Uploaded_file
[HttpPost]
[Route("Edit_Uploaded_file")]
public Result_Edit_Uploaded_file Edit_Uploaded_file(Uploaded_file i_Uploaded_file)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Uploaded_file oResult_Edit_Uploaded_file = new Result_Edit_Uploaded_file();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Uploaded_file(i_Uploaded_file);
oResult_Edit_Uploaded_file.My_Uploaded_file = i_Uploaded_file;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Uploaded_file.ExceptionMsg = string.Format("Edit_Uploaded_file : {0}", ex.Message);
}
else
{
oResult_Edit_Uploaded_file.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Uploaded_file;
#endregion
}
#endregion
#region Edit_User
[HttpPost]
[Route("Edit_User")]
public Result_Edit_User Edit_User(User i_User)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_User oResult_Edit_User = new Result_Edit_User();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_User);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_User(i_User);
oResult_Edit_User.My_User = i_User;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_User.ExceptionMsg = string.Format("Edit_User : {0}", ex.Message);
}
else
{
oResult_Edit_User.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_User;
#endregion
}
#endregion
#region Edit_User_account
[HttpPost]
[Route("Edit_User_account")]
public Result_Edit_User_account Edit_User_account(User_account i_User_account)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_User_account oResult_Edit_User_account = new Result_Edit_User_account();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_User_account);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_User_account(i_User_account);
oResult_Edit_User_account.My_User_account = i_User_account;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_User_account.ExceptionMsg = string.Format("Edit_User_account : {0}", ex.Message);
}
else
{
oResult_Edit_User_account.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_User_account;
#endregion
}
#endregion
#region EditSetup
[HttpPost]
[Route("EditSetup")]
public Result_EditSetup EditSetup(SetupEntry i_SetupEntry)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_EditSetup oResult_EditSetup = new Result_EditSetup();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.EditSetup);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.EditSetup(i_SetupEntry);
oResult_EditSetup.My_SetupEntry = i_SetupEntry;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_EditSetup.ExceptionMsg = string.Format("EditSetup : {0}", ex.Message);
}
else
{
oResult_EditSetup.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_EditSetup;
#endregion
}
#endregion
#region Get_Category_By_OWNER_ID
[HttpPost]
[Route("Get_Category_By_OWNER_ID")]
public Result_Get_Category_By_OWNER_ID Get_Category_By_OWNER_ID(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Category>  oReturnValue = new List<Category> ();
string i_Ticket = string.Empty;
Result_Get_Category_By_OWNER_ID oResult_Get_Category_By_OWNER_ID = new Result_Get_Category_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Category_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Category_By_OWNER_ID(i_Params_Get_Category_By_OWNER_ID);
oResult_Get_Category_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Category_By_OWNER_ID.My_Params_Get_Category_By_OWNER_ID = i_Params_Get_Category_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Category_By_OWNER_ID.ExceptionMsg = string.Format("Get_Category_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Category_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Category_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Category_By_Where
[HttpPost]
[Route("Get_Category_By_Where")]
public Result_Get_Category_By_Where Get_Category_By_Where(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
#region Declaration And Initialization Section.
List<Category>  oReturnValue = new List<Category> ();
string i_Ticket = string.Empty;
Result_Get_Category_By_Where oResult_Get_Category_By_Where = new Result_Get_Category_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Category_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Category_By_Where(i_Params_Get_Category_By_Where);
oResult_Get_Category_By_Where.My_Result = oReturnValue;
oResult_Get_Category_By_Where.My_Params_Get_Category_By_Where = i_Params_Get_Category_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Category_By_Where.ExceptionMsg = string.Format("Get_Category_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Category_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Category_By_Where;
#endregion
}
#endregion
#region Get_Product_By_OWNER_ID
[HttpPost]
[Route("Get_Product_By_OWNER_ID")]
public Result_Get_Product_By_OWNER_ID Get_Product_By_OWNER_ID(Params_Get_Product_By_OWNER_ID i_Params_Get_Product_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Product>  oReturnValue = new List<Product> ();
string i_Ticket = string.Empty;
Result_Get_Product_By_OWNER_ID oResult_Get_Product_By_OWNER_ID = new Result_Get_Product_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Product_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Product_By_OWNER_ID(i_Params_Get_Product_By_OWNER_ID);
oResult_Get_Product_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Product_By_OWNER_ID.My_Params_Get_Product_By_OWNER_ID = i_Params_Get_Product_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Product_By_OWNER_ID.ExceptionMsg = string.Format("Get_Product_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Product_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Product_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Product_By_Where
[HttpPost]
[Route("Get_Product_By_Where")]
public Result_Get_Product_By_Where Get_Product_By_Where(Params_Get_Product_By_Where i_Params_Get_Product_By_Where)
{
#region Declaration And Initialization Section.
List<Product>  oReturnValue = new List<Product> ();
string i_Ticket = string.Empty;
Result_Get_Product_By_Where oResult_Get_Product_By_Where = new Result_Get_Product_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Product_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Product_By_Where(i_Params_Get_Product_By_Where);
oResult_Get_Product_By_Where.My_Result = oReturnValue;
oResult_Get_Product_By_Where.My_Params_Get_Product_By_Where = i_Params_Get_Product_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Product_By_Where.ExceptionMsg = string.Format("Get_Product_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Product_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Product_By_Where;
#endregion
}
#endregion
#region Get_SetupEntries_Per_Table
[HttpPost]
[Route("Get_SetupEntries_Per_Table")]
public Result_Get_SetupEntries_Per_Table Get_SetupEntries_Per_Table(Params_Get_SetupEntries_Per_Table i_Params_Get_SetupEntries_Per_Table)
{
#region Declaration And Initialization Section.
List<User_Type>  oReturnValue = new List<User_Type> ();
string i_Ticket = string.Empty;
Result_Get_SetupEntries_Per_Table oResult_Get_SetupEntries_Per_Table = new Result_Get_SetupEntries_Per_Table();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_SetupEntries_Per_Table);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_SetupEntries_Per_Table(i_Params_Get_SetupEntries_Per_Table);
oResult_Get_SetupEntries_Per_Table.My_Result = oReturnValue;
oResult_Get_SetupEntries_Per_Table.My_Params_Get_SetupEntries_Per_Table = i_Params_Get_SetupEntries_Per_Table;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_SetupEntries_Per_Table.ExceptionMsg = string.Format("Get_SetupEntries_Per_Table : {0}", ex.Message);
}
else
{
oResult_Get_SetupEntries_Per_Table.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_SetupEntries_Per_Table;
#endregion
}
#endregion
#region Get_User_account_By_OWNER_ID
[HttpPost]
[Route("Get_User_account_By_OWNER_ID")]
public Result_Get_User_account_By_OWNER_ID Get_User_account_By_OWNER_ID(Params_Get_User_account_By_OWNER_ID i_Params_Get_User_account_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<User_account>  oReturnValue = new List<User_account> ();
string i_Ticket = string.Empty;
Result_Get_User_account_By_OWNER_ID oResult_Get_User_account_By_OWNER_ID = new Result_Get_User_account_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_account_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_account_By_OWNER_ID(i_Params_Get_User_account_By_OWNER_ID);
oResult_Get_User_account_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_User_account_By_OWNER_ID.My_Params_Get_User_account_By_OWNER_ID = i_Params_Get_User_account_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_account_By_OWNER_ID.ExceptionMsg = string.Format("Get_User_account_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_User_account_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_account_By_OWNER_ID;
#endregion
}
#endregion
#region Get_User_account_By_Where
[HttpPost]
[Route("Get_User_account_By_Where")]
public Result_Get_User_account_By_Where Get_User_account_By_Where(Params_Get_User_account_By_Where i_Params_Get_User_account_By_Where)
{
#region Declaration And Initialization Section.
List<User_account>  oReturnValue = new List<User_account> ();
string i_Ticket = string.Empty;
Result_Get_User_account_By_Where oResult_Get_User_account_By_Where = new Result_Get_User_account_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_account_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_account_By_Where(i_Params_Get_User_account_By_Where);
oResult_Get_User_account_By_Where.My_Result = oReturnValue;
oResult_Get_User_account_By_Where.My_Params_Get_User_account_By_Where = i_Params_Get_User_account_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_account_By_Where.ExceptionMsg = string.Format("Get_User_account_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_User_account_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_account_By_Where;
#endregion
}
#endregion
#region Get_User_By_OWNER_ID
[HttpPost]
[Route("Get_User_By_OWNER_ID")]
public Result_Get_User_By_OWNER_ID Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_OWNER_ID oResult_Get_User_By_OWNER_ID = new Result_Get_User_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID);
oResult_Get_User_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_User_By_OWNER_ID.My_Params_Get_User_By_OWNER_ID = i_Params_Get_User_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = string.Format("Get_User_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_OWNER_ID;
#endregion
}
#endregion
#region Get_User_By_Where
[HttpPost]
[Route("Get_User_By_Where")]
public Result_Get_User_By_Where Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_Where oResult_Get_User_By_Where = new Result_Get_User_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_Where(i_Params_Get_User_By_Where);
oResult_Get_User_By_Where.My_Result = oReturnValue;
oResult_Get_User_By_Where.My_Params_Get_User_By_Where = i_Params_Get_User_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_Where.ExceptionMsg = string.Format("Get_User_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_User_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion  
#region Return Section
return oResult_Get_User_By_Where;
#endregion
}
#endregion
}

#region Action_Result
public partial class Action_Result
{
#region Properties.
public string ExceptionMsg { get; set; }
#endregion
#region Constructor
public Action_Result()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.ExceptionMsg = string.Empty;
#endregion
}
#endregion
}
#endregion
#region Result_Authenticate
public partial class Result_Authenticate : Action_Result
{
#region Properties.
public User My_Result { get; set; }
public Params_Authenticate My_Params_Authenticate { get; set; }
#endregion
}
#endregion
#region Result_Delete_Category
public partial class Result_Delete_Category : Action_Result
{
#region Properties.
public Params_Delete_Category My_Params_Delete_Category { get; set; }
#endregion
}
#endregion
#region Result_Delete_Product
public partial class Result_Delete_Product : Action_Result
{
#region Properties.
public Params_Delete_Product My_Params_Delete_Product { get; set; }
#endregion
}
#endregion
#region Result_Delete_Uploaded_file
public partial class Result_Delete_Uploaded_file : Action_Result
{
#region Properties.
public Params_Delete_Uploaded_file My_Params_Delete_Uploaded_file { get; set; }
#endregion
}
#endregion
#region Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
public partial class Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD : Action_Result
{
#region Properties.
public Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD My_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD { get; set; }
#endregion
}
#endregion
#region Result_Delete_User
public partial class Result_Delete_User : Action_Result
{
#region Properties.
public Params_Delete_User My_Params_Delete_User { get; set; }
#endregion
}
#endregion
#region Result_Delete_User_account
public partial class Result_Delete_User_account : Action_Result
{
#region Properties.
public Params_Delete_User_account My_Params_Delete_User_account { get; set; }
#endregion
}
#endregion
#region Result_Edit_Category
public partial class Result_Edit_Category : Action_Result
{
#region Properties.
public Category My_Category { get; set; }
#endregion
}
#endregion
#region Result_Edit_Product
public partial class Result_Edit_Product : Action_Result
{
#region Properties.
public Product My_Product { get; set; }
#endregion
}
#endregion
#region Result_Edit_Uploaded_file
public partial class Result_Edit_Uploaded_file : Action_Result
{
#region Properties.
public Uploaded_file My_Uploaded_file { get; set; }
#endregion
}
#endregion
#region Result_Edit_User
public partial class Result_Edit_User : Action_Result
{
#region Properties.
public User My_User { get; set; }
#endregion
}
#endregion
#region Result_Edit_User_account
public partial class Result_Edit_User_account : Action_Result
{
#region Properties.
public User_account My_User_account { get; set; }
#endregion
}
#endregion
#region Result_EditSetup
public partial class Result_EditSetup : Action_Result
{
#region Properties.
public SetupEntry My_SetupEntry { get; set; }
#endregion
}
#endregion
#region Result_Get_Category_By_OWNER_ID
public partial class Result_Get_Category_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Category>  My_Result { get; set; }
public Params_Get_Category_By_OWNER_ID My_Params_Get_Category_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Category_By_Where
public partial class Result_Get_Category_By_Where : Action_Result
{
#region Properties.
public List<Category>  My_Result { get; set; }
public Params_Get_Category_By_Where My_Params_Get_Category_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Product_By_OWNER_ID
public partial class Result_Get_Product_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Product>  My_Result { get; set; }
public Params_Get_Product_By_OWNER_ID My_Params_Get_Product_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Product_By_Where
public partial class Result_Get_Product_By_Where : Action_Result
{
#region Properties.
public List<Product>  My_Result { get; set; }
public Params_Get_Product_By_Where My_Params_Get_Product_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_SetupEntries_Per_Table
public partial class Result_Get_SetupEntries_Per_Table : Action_Result
{
#region Properties.
public List<User_Type>  My_Result { get; set; }
public Params_Get_SetupEntries_Per_Table My_Params_Get_SetupEntries_Per_Table { get; set; }
#endregion
}
#endregion
#region Result_Get_User_account_By_OWNER_ID
public partial class Result_Get_User_account_By_OWNER_ID : Action_Result
{
#region Properties.
public List<User_account>  My_Result { get; set; }
public Params_Get_User_account_By_OWNER_ID My_Params_Get_User_account_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_User_account_By_Where
public partial class Result_Get_User_account_By_Where : Action_Result
{
#region Properties.
public List<User_account>  My_Result { get; set; }
public Params_Get_User_account_By_Where My_Params_Get_User_account_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_OWNER_ID
public partial class Result_Get_User_By_OWNER_ID : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_OWNER_ID My_Params_Get_User_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_Where
public partial class Result_Get_User_By_Where : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_Where My_Params_Get_User_By_Where { get; set; }
#endregion
}
#endregion
