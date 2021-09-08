using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Members
#region Used For Delete Operations
private Address _Address;
private Adress _Adress;
private Category _Category;
private Color _Color;
private Contact _Contact;
private Customer _Customer;
private Invoice _Invoice;
private Invoice_status _Invoice_status;
private Loc_l1 _Loc_l1;
private Loc_l2 _Loc_l2;
private Loc_l3 _Loc_l3;
private Loc_l4 _Loc_l4;
private Order_details _Order_details;
private Owner _Owner;
private Person _Person;
private Product _Product;
private Size _Size;
private Uploaded_file _Uploaded_file;
private User _User;
private User_account _User_account;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Address_Execution;
private bool _Stop_Delete_Address_Execution;
private bool _Stop_Edit_Adress_Execution;
private bool _Stop_Delete_Adress_Execution;
private bool _Stop_Edit_Category_Execution;
private bool _Stop_Delete_Category_Execution;
private bool _Stop_Edit_Color_Execution;
private bool _Stop_Delete_Color_Execution;
private bool _Stop_Edit_Contact_Execution;
private bool _Stop_Delete_Contact_Execution;
private bool _Stop_Edit_Customer_Execution;
private bool _Stop_Delete_Customer_Execution;
private bool _Stop_Edit_Invoice_Execution;
private bool _Stop_Delete_Invoice_Execution;
private bool _Stop_Edit_Invoice_status_Execution;
private bool _Stop_Delete_Invoice_status_Execution;
private bool _Stop_Edit_Loc_l1_Execution;
private bool _Stop_Delete_Loc_l1_Execution;
private bool _Stop_Edit_Loc_l2_Execution;
private bool _Stop_Delete_Loc_l2_Execution;
private bool _Stop_Edit_Loc_l3_Execution;
private bool _Stop_Delete_Loc_l3_Execution;
private bool _Stop_Edit_Loc_l4_Execution;
private bool _Stop_Delete_Loc_l4_Execution;
private bool _Stop_Edit_Order_details_Execution;
private bool _Stop_Delete_Order_details_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Person_Execution;
private bool _Stop_Delete_Person_Execution;
private bool _Stop_Edit_Product_Execution;
private bool _Stop_Delete_Product_Execution;
private bool _Stop_Edit_Size_Execution;
private bool _Stop_Delete_Size_Execution;
private bool _Stop_Edit_Uploaded_file_Execution;
private bool _Stop_Delete_Uploaded_file_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
private bool _Stop_Edit_User_account_Execution;
private bool _Stop_Delete_User_account_Execution;
#endregion
#endregion
public Address Get_Address_By_ADDRESS_ID(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID");}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID");}
return oAddress;
}
public Adress Get_Adress_By_ADRESS_ID(Params_Get_Adress_By_ADRESS_ID i_Params_Get_Adress_By_ADRESS_ID)
{
Adress oAdress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_ADRESS_ID");}
#region Body Section.
DALC.Adress oDBEntry = _AppContext.Get_Adress_By_ADRESS_ID(i_Params_Get_Adress_By_ADRESS_ID.ADRESS_ID);
oAdress = new Adress();
oTools.CopyPropValues(oDBEntry, oAdress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_ADRESS_ID");}
return oAdress;
}
public Category Get_Category_By_CATEGORY_ID(Params_Get_Category_By_CATEGORY_ID i_Params_Get_Category_By_CATEGORY_ID)
{
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID");}
#region Body Section.
DALC.Category oDBEntry = _AppContext.Get_Category_By_CATEGORY_ID(i_Params_Get_Category_By_CATEGORY_ID.CATEGORY_ID);
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID");}
return oCategory;
}
public Color Get_Color_By_COLOR_ID(Params_Get_Color_By_COLOR_ID i_Params_Get_Color_By_COLOR_ID)
{
Color oColor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_COLOR_ID");}
#region Body Section.
DALC.Color oDBEntry = _AppContext.Get_Color_By_COLOR_ID(i_Params_Get_Color_By_COLOR_ID.COLOR_ID);
oColor = new Color();
oTools.CopyPropValues(oDBEntry, oColor);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_COLOR_ID");}
return oColor;
}
public Contact Get_Contact_By_CONTACT_ID(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID");}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID");}
return oContact;
}
public Customer Get_Customer_By_CUSTOMER_ID(Params_Get_Customer_By_CUSTOMER_ID i_Params_Get_Customer_By_CUSTOMER_ID)
{
Customer oCustomer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_CUSTOMER_ID");}
#region Body Section.
DALC.Customer oDBEntry = _AppContext.Get_Customer_By_CUSTOMER_ID(i_Params_Get_Customer_By_CUSTOMER_ID.CUSTOMER_ID);
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_CUSTOMER_ID");}
return oCustomer;
}
public Invoice Get_Invoice_By_INVOICE_ID(Params_Get_Invoice_By_INVOICE_ID i_Params_Get_Invoice_By_INVOICE_ID)
{
Invoice oInvoice = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_ID");}
#region Body Section.
DALC.Invoice oDBEntry = _AppContext.Get_Invoice_By_INVOICE_ID(i_Params_Get_Invoice_By_INVOICE_ID.INVOICE_ID);
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_ID");}
return oInvoice;
}
public Invoice_status Get_Invoice_status_By_INVOICE_STATUS_ID(Params_Get_Invoice_status_By_INVOICE_STATUS_ID i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID)
{
Invoice_status oInvoice_status = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID");}
#region Body Section.
DALC.Invoice_status oDBEntry = _AppContext.Get_Invoice_status_By_INVOICE_STATUS_ID(i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID);
oInvoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry, oInvoice_status);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID");}
return oInvoice_status;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
return oLoc_l4;
}
public Order_details Get_Order_details_By_ORDER_DETAILS_ID(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID)
{
Order_details oOrder_details = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_ORDER_DETAILS_ID");}
#region Body Section.
DALC.Order_details oDBEntry = _AppContext.Get_Order_details_By_ORDER_DETAILS_ID(i_Params_Get_Order_details_By_ORDER_DETAILS_ID.ORDER_DETAILS_ID);
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_ORDER_DETAILS_ID");}
return oOrder_details;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Person Get_Person_By_PERSON_ID(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID");}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID");}
return oPerson;
}
public Product Get_Product_By_PRODUCT_ID(Params_Get_Product_By_PRODUCT_ID i_Params_Get_Product_By_PRODUCT_ID)
{
Product oProduct = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_PRODUCT_ID");}
#region Body Section.
DALC.Product oDBEntry = _AppContext.Get_Product_By_PRODUCT_ID(i_Params_Get_Product_By_PRODUCT_ID.PRODUCT_ID);
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_PRODUCT_ID");}
return oProduct;
}
public Size Get_Size_By_SIZE_ID(Params_Get_Size_By_SIZE_ID i_Params_Get_Size_By_SIZE_ID)
{
Size oSize = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_SIZE_ID");}
#region Body Section.
DALC.Size oDBEntry = _AppContext.Get_Size_By_SIZE_ID(i_Params_Get_Size_By_SIZE_ID.SIZE_ID);
oSize = new Size();
oTools.CopyPropValues(oDBEntry, oSize);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_SIZE_ID");}
return oSize;
}
public Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID)
{
Uploaded_file oUploaded_file = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
#region Body Section.
DALC.Uploaded_file oDBEntry = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID.UPLOADED_FILE_ID);
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
return oUploaded_file;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public User_account Get_User_account_By_USER_ACCOUNT_ID(Params_Get_User_account_By_USER_ACCOUNT_ID i_Params_Get_User_account_By_USER_ACCOUNT_ID)
{
User_account oUser_account = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ACCOUNT_ID");}
#region Body Section.
DALC.User_account oDBEntry = _AppContext.Get_User_account_By_USER_ACCOUNT_ID(i_Params_Get_User_account_By_USER_ACCOUNT_ID.USER_ACCOUNT_ID);
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ACCOUNT_ID");}
return oUser_account;
}
public List<Address> Get_Address_By_ADDRESS_ID_List(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List");}
return oList;
}
public List<Adress> Get_Adress_By_ADRESS_ID_List(Params_Get_Adress_By_ADRESS_ID_List i_Params_Get_Adress_By_ADRESS_ID_List)
{
Adress oAdress = null;
List<Adress> oList = new List<Adress>();
Params_Get_Adress_By_ADRESS_ID_List_SP oParams_Get_Adress_By_ADRESS_ID_List_SP = new Params_Get_Adress_By_ADRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_ADRESS_ID_List");}
#region Body Section.
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_ADRESS_ID_List(i_Params_Get_Adress_By_ADRESS_ID_List.ADRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdress = new Adress();
oTools.CopyPropValues(oDBEntry, oAdress);
oList.Add(oAdress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_ADRESS_ID_List");}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List(Params_Get_Category_By_CATEGORY_ID_List i_Params_Get_Category_By_CATEGORY_ID_List)
{
Category oCategory = null;
List<Category> oList = new List<Category>();
Params_Get_Category_By_CATEGORY_ID_List_SP oParams_Get_Category_By_CATEGORY_ID_List_SP = new Params_Get_Category_By_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_CATEGORY_ID_List(i_Params_Get_Category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_List");}
return oList;
}
public List<Color> Get_Color_By_COLOR_ID_List(Params_Get_Color_By_COLOR_ID_List i_Params_Get_Color_By_COLOR_ID_List)
{
Color oColor = null;
List<Color> oList = new List<Color>();
Params_Get_Color_By_COLOR_ID_List_SP oParams_Get_Color_By_COLOR_ID_List_SP = new Params_Get_Color_By_COLOR_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_COLOR_ID_List");}
#region Body Section.
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_COLOR_ID_List(i_Params_Get_Color_By_COLOR_ID_List.COLOR_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oColor = new Color();
oTools.CopyPropValues(oDBEntry, oColor);
oList.Add(oColor);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_COLOR_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List");}
return oList;
}
public List<Customer> Get_Customer_By_CUSTOMER_ID_List(Params_Get_Customer_By_CUSTOMER_ID_List i_Params_Get_Customer_By_CUSTOMER_ID_List)
{
Customer oCustomer = null;
List<Customer> oList = new List<Customer>();
Params_Get_Customer_By_CUSTOMER_ID_List_SP oParams_Get_Customer_By_CUSTOMER_ID_List_SP = new Params_Get_Customer_By_CUSTOMER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_CUSTOMER_ID_List");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_CUSTOMER_ID_List(i_Params_Get_Customer_By_CUSTOMER_ID_List.CUSTOMER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_CUSTOMER_ID_List");}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_ID_List(Params_Get_Invoice_By_INVOICE_ID_List i_Params_Get_Invoice_By_INVOICE_ID_List)
{
Invoice oInvoice = null;
List<Invoice> oList = new List<Invoice>();
Params_Get_Invoice_By_INVOICE_ID_List_SP oParams_Get_Invoice_By_INVOICE_ID_List_SP = new Params_Get_Invoice_By_INVOICE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_ID_List");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_INVOICE_ID_List(i_Params_Get_Invoice_By_INVOICE_ID_List.INVOICE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_ID_List");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_INVOICE_STATUS_ID_List(Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List)
{
Invoice_status oInvoice_status = null;
List<Invoice_status> oList = new List<Invoice_status>();
Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List_SP oParams_Get_Invoice_status_By_INVOICE_STATUS_ID_List_SP = new Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID_List");}
#region Body Section.
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_INVOICE_STATUS_ID_List(i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List.INVOICE_STATUS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry, oInvoice_status);
oList.Add(oInvoice_status);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID_List");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
return oList;
}
public List<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_List(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List)
{
Order_details oOrder_details = null;
List<Order_details> oList = new List<Order_details>();
Params_Get_Order_details_By_ORDER_DETAILS_ID_List_SP oParams_Get_Order_details_By_ORDER_DETAILS_ID_List_SP = new Params_Get_Order_details_By_ORDER_DETAILS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_ORDER_DETAILS_ID_List");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_ORDER_DETAILS_ID_List(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List.ORDER_DETAILS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_ORDER_DETAILS_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List");}
return oList;
}
public List<Product> Get_Product_By_PRODUCT_ID_List(Params_Get_Product_By_PRODUCT_ID_List i_Params_Get_Product_By_PRODUCT_ID_List)
{
Product oProduct = null;
List<Product> oList = new List<Product>();
Params_Get_Product_By_PRODUCT_ID_List_SP oParams_Get_Product_By_PRODUCT_ID_List_SP = new Params_Get_Product_By_PRODUCT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_PRODUCT_ID_List");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_PRODUCT_ID_List(i_Params_Get_Product_By_PRODUCT_ID_List.PRODUCT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_PRODUCT_ID_List");}
return oList;
}
public List<Size> Get_Size_By_SIZE_ID_List(Params_Get_Size_By_SIZE_ID_List i_Params_Get_Size_By_SIZE_ID_List)
{
Size oSize = null;
List<Size> oList = new List<Size>();
Params_Get_Size_By_SIZE_ID_List_SP oParams_Get_Size_By_SIZE_ID_List_SP = new Params_Get_Size_By_SIZE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_SIZE_ID_List");}
#region Body Section.
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_SIZE_ID_List(i_Params_Get_Size_By_SIZE_ID_List.SIZE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSize = new Size();
oTools.CopyPropValues(oDBEntry, oSize);
oList.Add(oSize);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_SIZE_ID_List");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List)
{
Uploaded_file oUploaded_file = null;
List<Uploaded_file> oList = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID_List(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List.UPLOADED_FILE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<User_account> Get_User_account_By_USER_ACCOUNT_ID_List(Params_Get_User_account_By_USER_ACCOUNT_ID_List i_Params_Get_User_account_By_USER_ACCOUNT_ID_List)
{
User_account oUser_account = null;
List<User_account> oList = new List<User_account>();
Params_Get_User_account_By_USER_ACCOUNT_ID_List_SP oParams_Get_User_account_By_USER_ACCOUNT_ID_List_SP = new Params_Get_User_account_By_USER_ACCOUNT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ACCOUNT_ID_List");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_USER_ACCOUNT_ID_List(i_Params_Get_User_account_By_USER_ACCOUNT_ID_List.USER_ACCOUNT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ACCOUNT_ID_List");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID");}
return oList;
}
public List<Adress> Get_Adress_By_OWNER_ID(Params_Get_Adress_By_OWNER_ID i_Params_Get_Adress_By_OWNER_ID)
{
List<Adress> oList = new List<Adress>();
Adress oAdress = new Adress();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_OWNER_ID");}
#region Body Section.
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_OWNER_ID(i_Params_Get_Adress_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdress = new Adress();
oTools.CopyPropValues(oDBEntry, oAdress);
oList.Add(oAdress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_OWNER_ID");}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_OWNER_ID");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_OWNER_ID(i_Params_Get_Category_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_OWNER_ID");}
return oList;
}
public List<Color> Get_Color_By_OWNER_ID(Params_Get_Color_By_OWNER_ID i_Params_Get_Color_By_OWNER_ID)
{
List<Color> oList = new List<Color>();
Color oColor = new Color();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_OWNER_ID");}
#region Body Section.
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_OWNER_ID(i_Params_Get_Color_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oColor = new Color();
oTools.CopyPropValues(oDBEntry, oColor);
oList.Add(oColor);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_OWNER_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID");}
return oList;
}
public List<Customer> Get_Customer_By_OWNER_ID(Params_Get_Customer_By_OWNER_ID i_Params_Get_Customer_By_OWNER_ID)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_OWNER_ID");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_OWNER_ID(i_Params_Get_Customer_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_OWNER_ID");}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID(Params_Get_Customer_By_ADRESS_ID i_Params_Get_Customer_By_ADRESS_ID)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_ADRESS_ID");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_ADRESS_ID(i_Params_Get_Customer_By_ADRESS_ID.ADRESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_ADRESS_ID");}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID(Params_Get_Customer_By_USER_ID i_Params_Get_Customer_By_USER_ID)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_USER_ID");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_USER_ID(i_Params_Get_Customer_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_USER_ID");}
return oList;
}
public List<Invoice> Get_Invoice_By_OWNER_ID(Params_Get_Invoice_By_OWNER_ID i_Params_Get_Invoice_By_OWNER_ID)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_OWNER_ID");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_OWNER_ID(i_Params_Get_Invoice_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_OWNER_ID");}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_STATUS_ID(Params_Get_Invoice_By_INVOICE_STATUS_ID i_Params_Get_Invoice_By_INVOICE_STATUS_ID)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_STATUS_ID");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_INVOICE_STATUS_ID(i_Params_Get_Invoice_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_STATUS_ID");}
return oList;
}
public List<Invoice> Get_Invoice_By_USER_ACCOUNT_ID(Params_Get_Invoice_By_USER_ACCOUNT_ID i_Params_Get_Invoice_By_USER_ACCOUNT_ID)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_USER_ACCOUNT_ID");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_USER_ACCOUNT_ID(i_Params_Get_Invoice_By_USER_ACCOUNT_ID.USER_ACCOUNT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_USER_ACCOUNT_ID");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_OWNER_ID(Params_Get_Invoice_status_By_OWNER_ID i_Params_Get_Invoice_status_By_OWNER_ID)
{
List<Invoice_status> oList = new List<Invoice_status>();
Invoice_status oInvoice_status = new Invoice_status();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_OWNER_ID");}
#region Body Section.
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_OWNER_ID(i_Params_Get_Invoice_status_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry, oInvoice_status);
oList.Add(oInvoice_status);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_OWNER_ID");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE(i_Params_Get_Loc_l1_By_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID");}
return oList;
}
public List<Order_details> Get_Order_details_By_OWNER_ID(Params_Get_Order_details_By_OWNER_ID i_Params_Get_Order_details_By_OWNER_ID)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_OWNER_ID");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_OWNER_ID(i_Params_Get_Order_details_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_OWNER_ID");}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID(Params_Get_Order_details_By_PRODUCT_ID i_Params_Get_Order_details_By_PRODUCT_ID)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_PRODUCT_ID");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_PRODUCT_ID(i_Params_Get_Order_details_By_PRODUCT_ID.PRODUCT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_PRODUCT_ID");}
return oList;
}
public List<Order_details> Get_Order_details_By_INVOICE_ID(Params_Get_Order_details_By_INVOICE_ID i_Params_Get_Order_details_By_INVOICE_ID)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_INVOICE_ID");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_INVOICE_ID(i_Params_Get_Order_details_By_INVOICE_ID.INVOICE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_INVOICE_ID");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID");}
return oList;
}
public List<Product> Get_Product_By_OWNER_ID(Params_Get_Product_By_OWNER_ID i_Params_Get_Product_By_OWNER_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_OWNER_ID");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_OWNER_ID(i_Params_Get_Product_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_OWNER_ID");}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID(Params_Get_Product_By_CATEGORY_ID i_Params_Get_Product_By_CATEGORY_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_CATEGORY_ID");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_CATEGORY_ID(i_Params_Get_Product_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_CATEGORY_ID");}
return oList;
}
public List<Product> Get_Product_By_IS_BEST_SELLING(Params_Get_Product_By_IS_BEST_SELLING i_Params_Get_Product_By_IS_BEST_SELLING)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_IS_BEST_SELLING");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_IS_BEST_SELLING(i_Params_Get_Product_By_IS_BEST_SELLING.IS_BEST_SELLING);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_IS_BEST_SELLING");}
return oList;
}
public List<Product> Get_Product_By_IS_RECOMMENDED(Params_Get_Product_By_IS_RECOMMENDED i_Params_Get_Product_By_IS_RECOMMENDED)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_IS_RECOMMENDED");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_IS_RECOMMENDED(i_Params_Get_Product_By_IS_RECOMMENDED.IS_RECOMMENDED);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_IS_RECOMMENDED");}
return oList;
}
public List<Product> Get_Product_By_COLOR_ID(Params_Get_Product_By_COLOR_ID i_Params_Get_Product_By_COLOR_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_COLOR_ID");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_COLOR_ID(i_Params_Get_Product_By_COLOR_ID.COLOR_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_COLOR_ID");}
return oList;
}
public List<Product> Get_Product_By_SIZE_ID(Params_Get_Product_By_SIZE_ID i_Params_Get_Product_By_SIZE_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_SIZE_ID");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_SIZE_ID(i_Params_Get_Product_By_SIZE_ID.SIZE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_SIZE_ID");}
return oList;
}
public List<Size> Get_Size_By_OWNER_ID(Params_Get_Size_By_OWNER_ID i_Params_Get_Size_By_OWNER_ID)
{
List<Size> oList = new List<Size>();
Size oSize = new Size();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_OWNER_ID");}
#region Body Section.
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_OWNER_ID(i_Params_Get_Size_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSize = new Size();
oTools.CopyPropValues(oDBEntry, oSize);
oList.Add(oSize);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID(Params_Get_Uploaded_file_By_OWNER_ID i_Params_Get_Uploaded_file_By_OWNER_ID)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_OWNER_ID");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_OWNER_ID(i_Params_Get_Uploaded_file_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY(Params_Get_Uploaded_file_By_REL_ENTITY i_Params_Get_Uploaded_file_By_REL_ENTITY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY(i_Params_Get_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<User_account> Get_User_account_By_OWNER_ID(Params_Get_User_account_By_OWNER_ID i_Params_Get_User_account_By_OWNER_ID)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_OWNER_ID");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_OWNER_ID(i_Params_Get_User_account_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_OWNER_ID");}
return oList;
}
public List<User_account> Get_User_account_By_USER_ID(Params_Get_User_account_By_USER_ID i_Params_Get_User_account_By_USER_ID)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ID");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_USER_ID(i_Params_Get_User_account_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ID");}
return oList;
}
public List<User_account> Get_User_account_By_ADRESS_ID(Params_Get_User_account_By_ADRESS_ID i_Params_Get_User_account_By_ADRESS_ID)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_ADRESS_ID");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_ADRESS_ID(i_Params_Get_User_account_By_ADRESS_ID.ADRESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_ADRESS_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List");}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID_List(Params_Get_Customer_By_ADRESS_ID_List i_Params_Get_Customer_By_ADRESS_ID_List)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_ADRESS_ID_List");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_ADRESS_ID_List(i_Params_Get_Customer_By_ADRESS_ID_List.ADRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_ADRESS_ID_List");}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID_List(Params_Get_Customer_By_USER_ID_List i_Params_Get_Customer_By_USER_ID_List)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_USER_ID_List");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_USER_ID_List(i_Params_Get_Customer_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_USER_ID_List");}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_STATUS_ID_List(Params_Get_Invoice_By_INVOICE_STATUS_ID_List i_Params_Get_Invoice_By_INVOICE_STATUS_ID_List)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_STATUS_ID_List");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_INVOICE_STATUS_ID_List(i_Params_Get_Invoice_By_INVOICE_STATUS_ID_List.INVOICE_STATUS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_STATUS_ID_List");}
return oList;
}
public List<Invoice> Get_Invoice_By_USER_ACCOUNT_ID_List(Params_Get_Invoice_By_USER_ACCOUNT_ID_List i_Params_Get_Invoice_By_USER_ACCOUNT_ID_List)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_USER_ACCOUNT_ID_List");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_USER_ACCOUNT_ID_List(i_Params_Get_Invoice_By_USER_ACCOUNT_ID_List.USER_ACCOUNT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_USER_ACCOUNT_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID_List(Params_Get_Order_details_By_PRODUCT_ID_List i_Params_Get_Order_details_By_PRODUCT_ID_List)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_PRODUCT_ID_List");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_PRODUCT_ID_List(i_Params_Get_Order_details_By_PRODUCT_ID_List.PRODUCT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_PRODUCT_ID_List");}
return oList;
}
public List<Order_details> Get_Order_details_By_INVOICE_ID_List(Params_Get_Order_details_By_INVOICE_ID_List i_Params_Get_Order_details_By_INVOICE_ID_List)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_INVOICE_ID_List");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_INVOICE_ID_List(i_Params_Get_Order_details_By_INVOICE_ID_List.INVOICE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_INVOICE_ID_List");}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID_List(Params_Get_Product_By_CATEGORY_ID_List i_Params_Get_Product_By_CATEGORY_ID_List)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_CATEGORY_ID_List(i_Params_Get_Product_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_CATEGORY_ID_List");}
return oList;
}
public List<Product> Get_Product_By_COLOR_ID_List(Params_Get_Product_By_COLOR_ID_List i_Params_Get_Product_By_COLOR_ID_List)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_COLOR_ID_List");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_COLOR_ID_List(i_Params_Get_Product_By_COLOR_ID_List.COLOR_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_COLOR_ID_List");}
return oList;
}
public List<Product> Get_Product_By_SIZE_ID_List(Params_Get_Product_By_SIZE_ID_List i_Params_Get_Product_By_SIZE_ID_List)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_SIZE_ID_List");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_SIZE_ID_List(i_Params_Get_Product_By_SIZE_ID_List.SIZE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_SIZE_ID_List");}
return oList;
}
public List<User_account> Get_User_account_By_USER_ID_List(Params_Get_User_account_By_USER_ID_List i_Params_Get_User_account_By_USER_ID_List)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ID_List");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_USER_ID_List(i_Params_Get_User_account_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ID_List");}
return oList;
}
public List<User_account> Get_User_account_By_ADRESS_ID_List(Params_Get_User_account_By_ADRESS_ID_List i_Params_Get_User_account_By_ADRESS_ID_List)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_ADRESS_ID_List");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_ADRESS_ID_List(i_Params_Get_User_account_By_ADRESS_ID_List.ADRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_ADRESS_ID_List");}
return oList;
}
public List<Address> Get_Address_By_Criteria(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria");}
return oList;
}
public List<Address> Get_Address_By_Where(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where");}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_V2");}
return oList;
}
public List<Adress> Get_Adress_By_Criteria(Params_Get_Adress_By_Criteria i_Params_Get_Adress_By_Criteria)
{
List<Adress> oList = new List<Adress>();
Adress oAdress = new Adress();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Adress_By_Criteria.OWNER_ID == null) || (i_Params_Get_Adress_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Adress_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Adress_By_Criteria.START_ROW == null) { i_Params_Get_Adress_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Adress_By_Criteria.END_ROW == null) || (i_Params_Get_Adress_By_Criteria.END_ROW == 0)) { i_Params_Get_Adress_By_Criteria.END_ROW = 1000000; }
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_Criteria(i_Params_Get_Adress_By_Criteria.STREET_NAME_ONE,i_Params_Get_Adress_By_Criteria.STREET_NAME_TWO,i_Params_Get_Adress_By_Criteria.STATE,i_Params_Get_Adress_By_Criteria.POST_CODE,i_Params_Get_Adress_By_Criteria.OWNER_ID,i_Params_Get_Adress_By_Criteria.START_ROW,i_Params_Get_Adress_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdress = new Adress();
oTools.CopyPropValues(oDBEntry, oAdress);
oList.Add(oAdress);
}
}
i_Params_Get_Adress_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_Criteria");}
return oList;
}
public List<Adress> Get_Adress_By_Where(Params_Get_Adress_By_Where i_Params_Get_Adress_By_Where)
{
List<Adress> oList = new List<Adress>();
Adress oAdress = new Adress();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_Where");}
#region Body Section.
if ((i_Params_Get_Adress_By_Where.OWNER_ID == null) || (i_Params_Get_Adress_By_Where.OWNER_ID == 0)) { i_Params_Get_Adress_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Adress_By_Where.START_ROW == null) { i_Params_Get_Adress_By_Where.START_ROW = 0; }
if ((i_Params_Get_Adress_By_Where.END_ROW == null) || (i_Params_Get_Adress_By_Where.END_ROW == 0)) { i_Params_Get_Adress_By_Where.END_ROW = 1000000; }
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_Where(i_Params_Get_Adress_By_Where.STREET_NAME_ONE,i_Params_Get_Adress_By_Where.STREET_NAME_TWO,i_Params_Get_Adress_By_Where.STATE,i_Params_Get_Adress_By_Where.POST_CODE,i_Params_Get_Adress_By_Where.OWNER_ID,i_Params_Get_Adress_By_Where.START_ROW,i_Params_Get_Adress_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdress = new Adress();
oTools.CopyPropValues(oDBEntry, oAdress);
oList.Add(oAdress);
}
}
i_Params_Get_Adress_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_Where");}
return oList;
}
public List<Category> Get_Category_By_Criteria(Params_Get_Category_By_Criteria i_Params_Get_Category_By_Criteria)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Criteria.START_ROW == null) { i_Params_Get_Category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_By_Criteria.END_ROW == null) || (i_Params_Get_Category_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_By_Criteria.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Criteria(i_Params_Get_Category_By_Criteria.NAME,i_Params_Get_Category_By_Criteria.OWNER_ID,i_Params_Get_Category_By_Criteria.START_ROW,i_Params_Get_Category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
i_Params_Get_Category_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Criteria");}
return oList;
}
public List<Category> Get_Category_By_Where(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Where");}
#region PreEvent_Get_Category_By_Where
if (OnPreEvent_Get_Category_By_Where != null)
{
OnPreEvent_Get_Category_By_Where(i_Params_Get_Category_By_Where);
}
#endregion
#region Body Section.
if ((i_Params_Get_Category_By_Where.OWNER_ID == null) || (i_Params_Get_Category_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Where.START_ROW == null) { i_Params_Get_Category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_By_Where.END_ROW == null) || (i_Params_Get_Category_By_Where.END_ROW == 0)) { i_Params_Get_Category_By_Where.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Where(i_Params_Get_Category_By_Where.NAME,i_Params_Get_Category_By_Where.OWNER_ID,i_Params_Get_Category_By_Where.START_ROW,i_Params_Get_Category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
i_Params_Get_Category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
#region PostEvent_Get_Category_By_Where
if (OnPostEvent_Get_Category_By_Where != null)
{
OnPostEvent_Get_Category_By_Where(ref oList,i_Params_Get_Category_By_Where);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Where");}
return oList;
}
public List<Color> Get_Color_By_Criteria(Params_Get_Color_By_Criteria i_Params_Get_Color_By_Criteria)
{
List<Color> oList = new List<Color>();
Color oColor = new Color();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Color_By_Criteria.OWNER_ID == null) || (i_Params_Get_Color_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Color_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Color_By_Criteria.START_ROW == null) { i_Params_Get_Color_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Color_By_Criteria.END_ROW == null) || (i_Params_Get_Color_By_Criteria.END_ROW == 0)) { i_Params_Get_Color_By_Criteria.END_ROW = 1000000; }
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_Criteria(i_Params_Get_Color_By_Criteria.NAME,i_Params_Get_Color_By_Criteria.OWNER_ID,i_Params_Get_Color_By_Criteria.START_ROW,i_Params_Get_Color_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oColor = new Color();
oTools.CopyPropValues(oDBEntry, oColor);
oList.Add(oColor);
}
}
i_Params_Get_Color_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_Criteria");}
return oList;
}
public List<Color> Get_Color_By_Where(Params_Get_Color_By_Where i_Params_Get_Color_By_Where)
{
List<Color> oList = new List<Color>();
Color oColor = new Color();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_Where");}
#region Body Section.
if ((i_Params_Get_Color_By_Where.OWNER_ID == null) || (i_Params_Get_Color_By_Where.OWNER_ID == 0)) { i_Params_Get_Color_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Color_By_Where.START_ROW == null) { i_Params_Get_Color_By_Where.START_ROW = 0; }
if ((i_Params_Get_Color_By_Where.END_ROW == null) || (i_Params_Get_Color_By_Where.END_ROW == 0)) { i_Params_Get_Color_By_Where.END_ROW = 1000000; }
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_Where(i_Params_Get_Color_By_Where.NAME,i_Params_Get_Color_By_Where.OWNER_ID,i_Params_Get_Color_By_Where.START_ROW,i_Params_Get_Color_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oColor = new Color();
oTools.CopyPropValues(oDBEntry, oColor);
oList.Add(oColor);
}
}
i_Params_Get_Color_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_Where");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria");}
return oList;
}
public List<Contact> Get_Contact_By_Where(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where");}
return oList;
}
public List<Customer> Get_Customer_By_Criteria(Params_Get_Customer_By_Criteria i_Params_Get_Customer_By_Criteria)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Customer_By_Criteria.OWNER_ID == null) || (i_Params_Get_Customer_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Customer_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Customer_By_Criteria.START_ROW == null) { i_Params_Get_Customer_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Customer_By_Criteria.END_ROW == null) || (i_Params_Get_Customer_By_Criteria.END_ROW == 0)) { i_Params_Get_Customer_By_Criteria.END_ROW = 1000000; }
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Criteria(i_Params_Get_Customer_By_Criteria.FIRST_NAME,i_Params_Get_Customer_By_Criteria.LAST_NAME,i_Params_Get_Customer_By_Criteria.PHONE,i_Params_Get_Customer_By_Criteria.OWNER_ID,i_Params_Get_Customer_By_Criteria.START_ROW,i_Params_Get_Customer_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Criteria");}
return oList;
}
public List<Customer> Get_Customer_By_Where(Params_Get_Customer_By_Where i_Params_Get_Customer_By_Where)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Where");}
#region Body Section.
if ((i_Params_Get_Customer_By_Where.OWNER_ID == null) || (i_Params_Get_Customer_By_Where.OWNER_ID == 0)) { i_Params_Get_Customer_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Customer_By_Where.START_ROW == null) { i_Params_Get_Customer_By_Where.START_ROW = 0; }
if ((i_Params_Get_Customer_By_Where.END_ROW == null) || (i_Params_Get_Customer_By_Where.END_ROW == 0)) { i_Params_Get_Customer_By_Where.END_ROW = 1000000; }
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Where(i_Params_Get_Customer_By_Where.FIRST_NAME,i_Params_Get_Customer_By_Where.LAST_NAME,i_Params_Get_Customer_By_Where.PHONE,i_Params_Get_Customer_By_Where.OWNER_ID,i_Params_Get_Customer_By_Where.START_ROW,i_Params_Get_Customer_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Where");}
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria(Params_Get_Invoice_By_Criteria i_Params_Get_Invoice_By_Criteria)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Invoice_By_Criteria.OWNER_ID == null) || (i_Params_Get_Invoice_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Invoice_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_By_Criteria.START_ROW == null) { i_Params_Get_Invoice_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Invoice_By_Criteria.END_ROW == null) || (i_Params_Get_Invoice_By_Criteria.END_ROW == 0)) { i_Params_Get_Invoice_By_Criteria.END_ROW = 1000000; }
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Criteria(i_Params_Get_Invoice_By_Criteria.DESCRIPTION,i_Params_Get_Invoice_By_Criteria.OWNER_ID,i_Params_Get_Invoice_By_Criteria.START_ROW,i_Params_Get_Invoice_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Criteria");}
return oList;
}
public List<Invoice> Get_Invoice_By_Where(Params_Get_Invoice_By_Where i_Params_Get_Invoice_By_Where)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Where");}
#region Body Section.
if ((i_Params_Get_Invoice_By_Where.OWNER_ID == null) || (i_Params_Get_Invoice_By_Where.OWNER_ID == 0)) { i_Params_Get_Invoice_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_By_Where.START_ROW == null) { i_Params_Get_Invoice_By_Where.START_ROW = 0; }
if ((i_Params_Get_Invoice_By_Where.END_ROW == null) || (i_Params_Get_Invoice_By_Where.END_ROW == 0)) { i_Params_Get_Invoice_By_Where.END_ROW = 1000000; }
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Where(i_Params_Get_Invoice_By_Where.DESCRIPTION,i_Params_Get_Invoice_By_Where.OWNER_ID,i_Params_Get_Invoice_By_Where.START_ROW,i_Params_Get_Invoice_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Where");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_Criteria(Params_Get_Invoice_status_By_Criteria i_Params_Get_Invoice_status_By_Criteria)
{
List<Invoice_status> oList = new List<Invoice_status>();
Invoice_status oInvoice_status = new Invoice_status();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Invoice_status_By_Criteria.OWNER_ID == null) || (i_Params_Get_Invoice_status_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Invoice_status_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_status_By_Criteria.START_ROW == null) { i_Params_Get_Invoice_status_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Invoice_status_By_Criteria.END_ROW == null) || (i_Params_Get_Invoice_status_By_Criteria.END_ROW == 0)) { i_Params_Get_Invoice_status_By_Criteria.END_ROW = 1000000; }
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_Criteria(i_Params_Get_Invoice_status_By_Criteria.INVOICE_STATUS,i_Params_Get_Invoice_status_By_Criteria.OWNER_ID,i_Params_Get_Invoice_status_By_Criteria.START_ROW,i_Params_Get_Invoice_status_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry, oInvoice_status);
oList.Add(oInvoice_status);
}
}
i_Params_Get_Invoice_status_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_Criteria");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_Where(Params_Get_Invoice_status_By_Where i_Params_Get_Invoice_status_By_Where)
{
List<Invoice_status> oList = new List<Invoice_status>();
Invoice_status oInvoice_status = new Invoice_status();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_Where");}
#region Body Section.
if ((i_Params_Get_Invoice_status_By_Where.OWNER_ID == null) || (i_Params_Get_Invoice_status_By_Where.OWNER_ID == 0)) { i_Params_Get_Invoice_status_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_status_By_Where.START_ROW == null) { i_Params_Get_Invoice_status_By_Where.START_ROW = 0; }
if ((i_Params_Get_Invoice_status_By_Where.END_ROW == null) || (i_Params_Get_Invoice_status_By_Where.END_ROW == 0)) { i_Params_Get_Invoice_status_By_Where.END_ROW = 1000000; }
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_Where(i_Params_Get_Invoice_status_By_Where.INVOICE_STATUS,i_Params_Get_Invoice_status_By_Where.OWNER_ID,i_Params_Get_Invoice_status_By_Where.START_ROW,i_Params_Get_Invoice_status_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry, oInvoice_status);
oList.Add(oInvoice_status);
}
}
i_Params_Get_Invoice_status_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_Where");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where");}
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria(Params_Get_Order_details_By_Criteria i_Params_Get_Order_details_By_Criteria)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Order_details_By_Criteria.OWNER_ID == null) || (i_Params_Get_Order_details_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Order_details_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Order_details_By_Criteria.START_ROW == null) { i_Params_Get_Order_details_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Order_details_By_Criteria.END_ROW == null) || (i_Params_Get_Order_details_By_Criteria.END_ROW == 0)) { i_Params_Get_Order_details_By_Criteria.END_ROW = 1000000; }
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Criteria(i_Params_Get_Order_details_By_Criteria.DESCRIPTION,i_Params_Get_Order_details_By_Criteria.OWNER_ID,i_Params_Get_Order_details_By_Criteria.START_ROW,i_Params_Get_Order_details_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Criteria");}
return oList;
}
public List<Order_details> Get_Order_details_By_Where(Params_Get_Order_details_By_Where i_Params_Get_Order_details_By_Where)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Where");}
#region Body Section.
if ((i_Params_Get_Order_details_By_Where.OWNER_ID == null) || (i_Params_Get_Order_details_By_Where.OWNER_ID == 0)) { i_Params_Get_Order_details_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Order_details_By_Where.START_ROW == null) { i_Params_Get_Order_details_By_Where.START_ROW = 0; }
if ((i_Params_Get_Order_details_By_Where.END_ROW == null) || (i_Params_Get_Order_details_By_Where.END_ROW == 0)) { i_Params_Get_Order_details_By_Where.END_ROW = 1000000; }
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Where(i_Params_Get_Order_details_By_Where.DESCRIPTION,i_Params_Get_Order_details_By_Where.OWNER_ID,i_Params_Get_Order_details_By_Where.START_ROW,i_Params_Get_Order_details_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Person> Get_Person_By_Criteria(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria");}
return oList;
}
public List<Person> Get_Person_By_Where(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where");}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where");}
return oList;
}
public List<Person> Get_Person_By_Criteria_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_V2");}
return oList;
}
public List<Product> Get_Product_By_Criteria(Params_Get_Product_By_Criteria i_Params_Get_Product_By_Criteria)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Product_By_Criteria.OWNER_ID == null) || (i_Params_Get_Product_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Product_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Product_By_Criteria.START_ROW == null) { i_Params_Get_Product_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Product_By_Criteria.END_ROW == null) || (i_Params_Get_Product_By_Criteria.END_ROW == 0)) { i_Params_Get_Product_By_Criteria.END_ROW = 1000000; }
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Criteria(i_Params_Get_Product_By_Criteria.NAME,i_Params_Get_Product_By_Criteria.DESCRIPTION,i_Params_Get_Product_By_Criteria.OWNER_ID,i_Params_Get_Product_By_Criteria.START_ROW,i_Params_Get_Product_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Criteria");}
return oList;
}
public List<Product> Get_Product_By_Where(Params_Get_Product_By_Where i_Params_Get_Product_By_Where)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Where");}
#region PreEvent_Get_Product_By_Where
if (OnPreEvent_Get_Product_By_Where != null)
{
OnPreEvent_Get_Product_By_Where(i_Params_Get_Product_By_Where);
}
#endregion
#region Body Section.
if ((i_Params_Get_Product_By_Where.OWNER_ID == null) || (i_Params_Get_Product_By_Where.OWNER_ID == 0)) { i_Params_Get_Product_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Product_By_Where.START_ROW == null) { i_Params_Get_Product_By_Where.START_ROW = 0; }
if ((i_Params_Get_Product_By_Where.END_ROW == null) || (i_Params_Get_Product_By_Where.END_ROW == 0)) { i_Params_Get_Product_By_Where.END_ROW = 1000000; }
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Where(i_Params_Get_Product_By_Where.NAME,i_Params_Get_Product_By_Where.DESCRIPTION,i_Params_Get_Product_By_Where.OWNER_ID,i_Params_Get_Product_By_Where.START_ROW,i_Params_Get_Product_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
#region PostEvent_Get_Product_By_Where
if (OnPostEvent_Get_Product_By_Where != null)
{
OnPostEvent_Get_Product_By_Where(ref oList,i_Params_Get_Product_By_Where);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Where");}
return oList;
}
public List<Size> Get_Size_By_Criteria(Params_Get_Size_By_Criteria i_Params_Get_Size_By_Criteria)
{
List<Size> oList = new List<Size>();
Size oSize = new Size();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Size_By_Criteria.OWNER_ID == null) || (i_Params_Get_Size_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Size_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Size_By_Criteria.START_ROW == null) { i_Params_Get_Size_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Size_By_Criteria.END_ROW == null) || (i_Params_Get_Size_By_Criteria.END_ROW == 0)) { i_Params_Get_Size_By_Criteria.END_ROW = 1000000; }
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_Criteria(i_Params_Get_Size_By_Criteria.DESCRIPTION,i_Params_Get_Size_By_Criteria.OWNER_ID,i_Params_Get_Size_By_Criteria.START_ROW,i_Params_Get_Size_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSize = new Size();
oTools.CopyPropValues(oDBEntry, oSize);
oList.Add(oSize);
}
}
i_Params_Get_Size_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_Criteria");}
return oList;
}
public List<Size> Get_Size_By_Where(Params_Get_Size_By_Where i_Params_Get_Size_By_Where)
{
List<Size> oList = new List<Size>();
Size oSize = new Size();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_Where");}
#region Body Section.
if ((i_Params_Get_Size_By_Where.OWNER_ID == null) || (i_Params_Get_Size_By_Where.OWNER_ID == 0)) { i_Params_Get_Size_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Size_By_Where.START_ROW == null) { i_Params_Get_Size_By_Where.START_ROW = 0; }
if ((i_Params_Get_Size_By_Where.END_ROW == null) || (i_Params_Get_Size_By_Where.END_ROW == 0)) { i_Params_Get_Size_By_Where.END_ROW = 1000000; }
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_Where(i_Params_Get_Size_By_Where.DESCRIPTION,i_Params_Get_Size_By_Where.OWNER_ID,i_Params_Get_Size_By_Where.START_ROW,i_Params_Get_Size_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSize = new Size();
oTools.CopyPropValues(oDBEntry, oSize);
oList.Add(oSize);
}
}
i_Params_Get_Size_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_Where");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Criteria(Params_Get_Uploaded_file_By_Criteria i_Params_Get_Uploaded_file_By_Criteria)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Criteria.START_ROW == null) { i_Params_Get_Uploaded_file_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Criteria.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Criteria.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Criteria.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Criteria(i_Params_Get_Uploaded_file_By_Criteria.REL_ENTITY,i_Params_Get_Uploaded_file_By_Criteria.REL_FIELD,i_Params_Get_Uploaded_file_By_Criteria.EXTENSION,i_Params_Get_Uploaded_file_By_Criteria.STAMP,i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID,i_Params_Get_Uploaded_file_By_Criteria.START_ROW,i_Params_Get_Uploaded_file_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Criteria");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Where(Params_Get_Uploaded_file_By_Where i_Params_Get_Uploaded_file_By_Where)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Where");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Where.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Where.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Where.START_ROW == null) { i_Params_Get_Uploaded_file_By_Where.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Where.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Where.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Where.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Where(i_Params_Get_Uploaded_file_By_Where.REL_ENTITY,i_Params_Get_Uploaded_file_By_Where.REL_FIELD,i_Params_Get_Uploaded_file_By_Where.EXTENSION,i_Params_Get_Uploaded_file_By_Where.STAMP,i_Params_Get_Uploaded_file_By_Where.OWNER_ID,i_Params_Get_Uploaded_file_By_Where.START_ROW,i_Params_Get_Uploaded_file_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.EMAIL,i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.PHONE,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.EMAIL,i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.PHONE,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public List<User_account> Get_User_account_By_Criteria(Params_Get_User_account_By_Criteria i_Params_Get_User_account_By_Criteria)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_account_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_account_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_account_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_account_By_Criteria.START_ROW == null) { i_Params_Get_User_account_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_account_By_Criteria.END_ROW == null) || (i_Params_Get_User_account_By_Criteria.END_ROW == 0)) { i_Params_Get_User_account_By_Criteria.END_ROW = 1000000; }
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Criteria(i_Params_Get_User_account_By_Criteria.DESCRIPTION,i_Params_Get_User_account_By_Criteria.OWNER_ID,i_Params_Get_User_account_By_Criteria.START_ROW,i_Params_Get_User_account_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Criteria");}
return oList;
}
public List<User_account> Get_User_account_By_Where(Params_Get_User_account_By_Where i_Params_Get_User_account_By_Where)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Where");}
#region Body Section.
if ((i_Params_Get_User_account_By_Where.OWNER_ID == null) || (i_Params_Get_User_account_By_Where.OWNER_ID == 0)) { i_Params_Get_User_account_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_account_By_Where.START_ROW == null) { i_Params_Get_User_account_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_account_By_Where.END_ROW == null) || (i_Params_Get_User_account_By_Where.END_ROW == 0)) { i_Params_Get_User_account_By_Where.END_ROW = 1000000; }
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Where(i_Params_Get_User_account_By_Where.DESCRIPTION,i_Params_Get_User_account_By_Where.OWNER_ID,i_Params_Get_User_account_By_Where.START_ROW,i_Params_Get_User_account_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Address_By_Criteria_InList.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP.STREET = i_Params_Get_Address_By_Criteria_InList.STREET;
oParams_Get_Address_By_Criteria_InList_SP.BUILDING = i_Params_Get_Address_By_Criteria_InList.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP.FLOOR = i_Params_Get_Address_By_Criteria_InList.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP.POBOX = i_Params_Get_Address_By_Criteria_InList.POBOX;
if ( i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP.START_ROW = i_Params_Get_Address_By_Criteria_InList.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP.END_ROW = i_Params_Get_Address_By_Criteria_InList.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList");}
return oList;
}
public List<Address> Get_Address_By_Where_InList(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList.START_ROW == null) { i_Params_Get_Address_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList.END_ROW == null) || (i_Params_Get_Address_By_Where_InList.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP.OWNER_ID = i_Params_Get_Address_By_Where_InList.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP.STREET = i_Params_Get_Address_By_Where_InList.STREET;
oParams_Get_Address_By_Where_InList_SP.BUILDING = i_Params_Get_Address_By_Where_InList.BUILDING;
oParams_Get_Address_By_Where_InList_SP.FLOOR = i_Params_Get_Address_By_Where_InList.FLOOR;
oParams_Get_Address_By_Where_InList_SP.POBOX = i_Params_Get_Address_By_Where_InList.POBOX;
if ( i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP.START_ROW = i_Params_Get_Address_By_Where_InList.START_ROW;
oParams_Get_Address_By_Where_InList_SP.END_ROW = i_Params_Get_Address_By_Where_InList.END_ROW;
oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP_V2.STREET = i_Params_Get_Address_By_Criteria_InList_V2.STREET;
oParams_Get_Address_By_Criteria_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Criteria_InList_V2.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Criteria_InList_V2.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP_V2.POBOX = i_Params_Get_Address_By_Criteria_InList_V2.POBOX;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Criteria_InList_V2.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Criteria_InList_V2.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Where_InList_V2.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP_V2.STREET = i_Params_Get_Address_By_Where_InList_V2.STREET;
oParams_Get_Address_By_Where_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Where_InList_V2.BUILDING;
oParams_Get_Address_By_Where_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Where_InList_V2.FLOOR;
oParams_Get_Address_By_Where_InList_SP_V2.POBOX = i_Params_Get_Address_By_Where_InList_V2.POBOX;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Where_InList_V2.START_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Where_InList_V2.END_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_V2");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria_InList.START_ROW == null) { i_Params_Get_Contact_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Contact_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Criteria_InList.OWNER_ID;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT = i_Params_Get_Contact_By_Criteria_InList.CONTACT;
oParams_Get_Contact_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Criteria_InList_SP.START_ROW = i_Params_Get_Contact_By_Criteria_InList.START_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.END_ROW = i_Params_Get_Contact_By_Criteria_InList.END_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where_InList.START_ROW == null) { i_Params_Get_Contact_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where_InList.END_ROW == null) || (i_Params_Get_Contact_By_Where_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Where_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Where_InList.OWNER_ID;
oParams_Get_Contact_By_Where_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Where_InList_SP.CONTACT = i_Params_Get_Contact_By_Where_InList.CONTACT;
oParams_Get_Contact_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Where_InList_SP.START_ROW = i_Params_Get_Contact_By_Where_InList.START_ROW;
oParams_Get_Contact_By_Where_InList_SP.END_ROW = i_Params_Get_Contact_By_Where_InList.END_ROW;
oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList");}
return oList;
}
public List<Customer> Get_Customer_By_Criteria_InList(Params_Get_Customer_By_Criteria_InList i_Params_Get_Customer_By_Criteria_InList)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Customer_By_Criteria_InList_SP oParams_Get_Customer_By_Criteria_InList_SP = new Params_Get_Customer_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Customer_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Customer_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Customer_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Customer_By_Criteria_InList.START_ROW == null) { i_Params_Get_Customer_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Customer_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Customer_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Customer_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Customer_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Customer_By_Criteria_InList.OWNER_ID;
oParams_Get_Customer_By_Criteria_InList_SP.FIRST_NAME = i_Params_Get_Customer_By_Criteria_InList.FIRST_NAME;
oParams_Get_Customer_By_Criteria_InList_SP.LAST_NAME = i_Params_Get_Customer_By_Criteria_InList.LAST_NAME;
oParams_Get_Customer_By_Criteria_InList_SP.PHONE = i_Params_Get_Customer_By_Criteria_InList.PHONE;
if ( i_Params_Get_Customer_By_Criteria_InList.USER_ID_LIST == null)
{
i_Params_Get_Customer_By_Criteria_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_Customer_By_Criteria_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Customer_By_Criteria_InList.USER_ID_LIST);
if ( i_Params_Get_Customer_By_Criteria_InList.ADRESS_ID_LIST == null)
{
i_Params_Get_Customer_By_Criteria_InList.ADRESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Customer_By_Criteria_InList_SP.ADRESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Customer_By_Criteria_InList.ADRESS_ID_LIST);
oParams_Get_Customer_By_Criteria_InList_SP.START_ROW = i_Params_Get_Customer_By_Criteria_InList.START_ROW;
oParams_Get_Customer_By_Criteria_InList_SP.END_ROW = i_Params_Get_Customer_By_Criteria_InList.END_ROW;
oParams_Get_Customer_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Customer_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Criteria_InList(i_Params_Get_Customer_By_Criteria_InList.FIRST_NAME,i_Params_Get_Customer_By_Criteria_InList.LAST_NAME,i_Params_Get_Customer_By_Criteria_InList.PHONE,i_Params_Get_Customer_By_Criteria_InList.USER_ID_LIST,i_Params_Get_Customer_By_Criteria_InList.ADRESS_ID_LIST,i_Params_Get_Customer_By_Criteria_InList.OWNER_ID,i_Params_Get_Customer_By_Criteria_InList.START_ROW,i_Params_Get_Customer_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Customer_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Customer_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Criteria_InList");}
return oList;
}
public List<Customer> Get_Customer_By_Where_InList(Params_Get_Customer_By_Where_InList i_Params_Get_Customer_By_Where_InList)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Customer_By_Where_InList_SP oParams_Get_Customer_By_Where_InList_SP = new Params_Get_Customer_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Customer_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Customer_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Customer_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Customer_By_Where_InList.START_ROW == null) { i_Params_Get_Customer_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Customer_By_Where_InList.END_ROW == null) || (i_Params_Get_Customer_By_Where_InList.END_ROW == 0)) { i_Params_Get_Customer_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Customer_By_Where_InList_SP.OWNER_ID = i_Params_Get_Customer_By_Where_InList.OWNER_ID;
oParams_Get_Customer_By_Where_InList_SP.FIRST_NAME = i_Params_Get_Customer_By_Where_InList.FIRST_NAME;
oParams_Get_Customer_By_Where_InList_SP.LAST_NAME = i_Params_Get_Customer_By_Where_InList.LAST_NAME;
oParams_Get_Customer_By_Where_InList_SP.PHONE = i_Params_Get_Customer_By_Where_InList.PHONE;
if ( i_Params_Get_Customer_By_Where_InList.USER_ID_LIST == null)
{
i_Params_Get_Customer_By_Where_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_Customer_By_Where_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Customer_By_Where_InList.USER_ID_LIST);
if ( i_Params_Get_Customer_By_Where_InList.ADRESS_ID_LIST == null)
{
i_Params_Get_Customer_By_Where_InList.ADRESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Customer_By_Where_InList_SP.ADRESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Customer_By_Where_InList.ADRESS_ID_LIST);
oParams_Get_Customer_By_Where_InList_SP.START_ROW = i_Params_Get_Customer_By_Where_InList.START_ROW;
oParams_Get_Customer_By_Where_InList_SP.END_ROW = i_Params_Get_Customer_By_Where_InList.END_ROW;
oParams_Get_Customer_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Customer_By_Where_InList.TOTAL_COUNT;
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Where_InList(i_Params_Get_Customer_By_Where_InList.FIRST_NAME,i_Params_Get_Customer_By_Where_InList.LAST_NAME,i_Params_Get_Customer_By_Where_InList.PHONE,i_Params_Get_Customer_By_Where_InList.USER_ID_LIST,i_Params_Get_Customer_By_Where_InList.ADRESS_ID_LIST,i_Params_Get_Customer_By_Where_InList.OWNER_ID,i_Params_Get_Customer_By_Where_InList.START_ROW,i_Params_Get_Customer_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Where_InList.TOTAL_COUNT = oParams_Get_Customer_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Customer_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Where_InList");}
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria_InList(Params_Get_Invoice_By_Criteria_InList i_Params_Get_Invoice_By_Criteria_InList)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Invoice_By_Criteria_InList_SP oParams_Get_Invoice_By_Criteria_InList_SP = new Params_Get_Invoice_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Invoice_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Invoice_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Invoice_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_By_Criteria_InList.START_ROW == null) { i_Params_Get_Invoice_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Invoice_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Invoice_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Invoice_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Invoice_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Invoice_By_Criteria_InList.OWNER_ID;
oParams_Get_Invoice_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Invoice_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Invoice_By_Criteria_InList.USER_ACCOUNT_ID_LIST == null)
{
i_Params_Get_Invoice_By_Criteria_InList.USER_ACCOUNT_ID_LIST = new List<long?>();
}
oParams_Get_Invoice_By_Criteria_InList_SP.USER_ACCOUNT_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Invoice_By_Criteria_InList.USER_ACCOUNT_ID_LIST);
if ( i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST == null)
{
i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Invoice_By_Criteria_InList_SP.INVOICE_STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST);
oParams_Get_Invoice_By_Criteria_InList_SP.START_ROW = i_Params_Get_Invoice_By_Criteria_InList.START_ROW;
oParams_Get_Invoice_By_Criteria_InList_SP.END_ROW = i_Params_Get_Invoice_By_Criteria_InList.END_ROW;
oParams_Get_Invoice_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Invoice_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Criteria_InList(i_Params_Get_Invoice_By_Criteria_InList.DESCRIPTION,i_Params_Get_Invoice_By_Criteria_InList.USER_ACCOUNT_ID_LIST,i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST,i_Params_Get_Invoice_By_Criteria_InList.OWNER_ID,i_Params_Get_Invoice_By_Criteria_InList.START_ROW,i_Params_Get_Invoice_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Invoice_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Invoice_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Criteria_InList");}
return oList;
}
public List<Invoice> Get_Invoice_By_Where_InList(Params_Get_Invoice_By_Where_InList i_Params_Get_Invoice_By_Where_InList)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Invoice_By_Where_InList_SP oParams_Get_Invoice_By_Where_InList_SP = new Params_Get_Invoice_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Invoice_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Invoice_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Invoice_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_By_Where_InList.START_ROW == null) { i_Params_Get_Invoice_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Invoice_By_Where_InList.END_ROW == null) || (i_Params_Get_Invoice_By_Where_InList.END_ROW == 0)) { i_Params_Get_Invoice_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Invoice_By_Where_InList_SP.OWNER_ID = i_Params_Get_Invoice_By_Where_InList.OWNER_ID;
oParams_Get_Invoice_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Invoice_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Invoice_By_Where_InList.USER_ACCOUNT_ID_LIST == null)
{
i_Params_Get_Invoice_By_Where_InList.USER_ACCOUNT_ID_LIST = new List<long?>();
}
oParams_Get_Invoice_By_Where_InList_SP.USER_ACCOUNT_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Invoice_By_Where_InList.USER_ACCOUNT_ID_LIST);
if ( i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST == null)
{
i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Invoice_By_Where_InList_SP.INVOICE_STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST);
oParams_Get_Invoice_By_Where_InList_SP.START_ROW = i_Params_Get_Invoice_By_Where_InList.START_ROW;
oParams_Get_Invoice_By_Where_InList_SP.END_ROW = i_Params_Get_Invoice_By_Where_InList.END_ROW;
oParams_Get_Invoice_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Invoice_By_Where_InList.TOTAL_COUNT;
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Where_InList(i_Params_Get_Invoice_By_Where_InList.DESCRIPTION,i_Params_Get_Invoice_By_Where_InList.USER_ACCOUNT_ID_LIST,i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST,i_Params_Get_Invoice_By_Where_InList.OWNER_ID,i_Params_Get_Invoice_By_Where_InList.START_ROW,i_Params_Get_Invoice_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Where_InList.TOTAL_COUNT = oParams_Get_Invoice_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Invoice_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Where_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l2_By_Criteria_InList.CODE;
oParams_Get_Loc_l2_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Where_InList_SP.CODE = i_Params_Get_Loc_l2_By_Where_InList.CODE;
oParams_Get_Loc_l2_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Where_InList.START_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Where_InList.END_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l3_By_Criteria_InList.CODE;
oParams_Get_Loc_l3_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Where_InList_SP.CODE = i_Params_Get_Loc_l3_By_Where_InList.CODE;
oParams_Get_Loc_l3_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Where_InList.START_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Where_InList.END_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l4_By_Criteria_InList.CODE;
oParams_Get_Loc_l4_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Where_InList_SP.CODE = i_Params_Get_Loc_l4_By_Where_InList.CODE;
oParams_Get_Loc_l4_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Where_InList.START_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Where_InList.END_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList");}
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria_InList(Params_Get_Order_details_By_Criteria_InList i_Params_Get_Order_details_By_Criteria_InList)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Order_details_By_Criteria_InList_SP oParams_Get_Order_details_By_Criteria_InList_SP = new Params_Get_Order_details_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Order_details_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Order_details_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Order_details_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Order_details_By_Criteria_InList.START_ROW == null) { i_Params_Get_Order_details_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Order_details_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Order_details_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Order_details_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Order_details_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Order_details_By_Criteria_InList.OWNER_ID;
oParams_Get_Order_details_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Order_details_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Order_details_By_Criteria_InList.PRODUCT_ID_LIST == null)
{
i_Params_Get_Order_details_By_Criteria_InList.PRODUCT_ID_LIST = new List<Int32?>();
}
oParams_Get_Order_details_By_Criteria_InList_SP.PRODUCT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Order_details_By_Criteria_InList.PRODUCT_ID_LIST);
if ( i_Params_Get_Order_details_By_Criteria_InList.INVOICE_ID_LIST == null)
{
i_Params_Get_Order_details_By_Criteria_InList.INVOICE_ID_LIST = new List<Int32?>();
}
oParams_Get_Order_details_By_Criteria_InList_SP.INVOICE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Order_details_By_Criteria_InList.INVOICE_ID_LIST);
oParams_Get_Order_details_By_Criteria_InList_SP.START_ROW = i_Params_Get_Order_details_By_Criteria_InList.START_ROW;
oParams_Get_Order_details_By_Criteria_InList_SP.END_ROW = i_Params_Get_Order_details_By_Criteria_InList.END_ROW;
oParams_Get_Order_details_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Order_details_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Criteria_InList(i_Params_Get_Order_details_By_Criteria_InList.DESCRIPTION,i_Params_Get_Order_details_By_Criteria_InList.PRODUCT_ID_LIST,i_Params_Get_Order_details_By_Criteria_InList.INVOICE_ID_LIST,i_Params_Get_Order_details_By_Criteria_InList.OWNER_ID,i_Params_Get_Order_details_By_Criteria_InList.START_ROW,i_Params_Get_Order_details_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Order_details_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Order_details_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Criteria_InList");}
return oList;
}
public List<Order_details> Get_Order_details_By_Where_InList(Params_Get_Order_details_By_Where_InList i_Params_Get_Order_details_By_Where_InList)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Order_details_By_Where_InList_SP oParams_Get_Order_details_By_Where_InList_SP = new Params_Get_Order_details_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Order_details_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Order_details_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Order_details_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Order_details_By_Where_InList.START_ROW == null) { i_Params_Get_Order_details_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Order_details_By_Where_InList.END_ROW == null) || (i_Params_Get_Order_details_By_Where_InList.END_ROW == 0)) { i_Params_Get_Order_details_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Order_details_By_Where_InList_SP.OWNER_ID = i_Params_Get_Order_details_By_Where_InList.OWNER_ID;
oParams_Get_Order_details_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Order_details_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Order_details_By_Where_InList.PRODUCT_ID_LIST == null)
{
i_Params_Get_Order_details_By_Where_InList.PRODUCT_ID_LIST = new List<Int32?>();
}
oParams_Get_Order_details_By_Where_InList_SP.PRODUCT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Order_details_By_Where_InList.PRODUCT_ID_LIST);
if ( i_Params_Get_Order_details_By_Where_InList.INVOICE_ID_LIST == null)
{
i_Params_Get_Order_details_By_Where_InList.INVOICE_ID_LIST = new List<Int32?>();
}
oParams_Get_Order_details_By_Where_InList_SP.INVOICE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Order_details_By_Where_InList.INVOICE_ID_LIST);
oParams_Get_Order_details_By_Where_InList_SP.START_ROW = i_Params_Get_Order_details_By_Where_InList.START_ROW;
oParams_Get_Order_details_By_Where_InList_SP.END_ROW = i_Params_Get_Order_details_By_Where_InList.END_ROW;
oParams_Get_Order_details_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Order_details_By_Where_InList.TOTAL_COUNT;
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Where_InList(i_Params_Get_Order_details_By_Where_InList.DESCRIPTION,i_Params_Get_Order_details_By_Where_InList.PRODUCT_ID_LIST,i_Params_Get_Order_details_By_Where_InList.INVOICE_ID_LIST,i_Params_Get_Order_details_By_Where_InList.OWNER_ID,i_Params_Get_Order_details_By_Where_InList.START_ROW,i_Params_Get_Order_details_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Where_InList.TOTAL_COUNT = oParams_Get_Order_details_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Order_details_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Where_InList");}
return oList;
}
public List<Product> Get_Product_By_Criteria_InList(Params_Get_Product_By_Criteria_InList i_Params_Get_Product_By_Criteria_InList)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Product_By_Criteria_InList_SP oParams_Get_Product_By_Criteria_InList_SP = new Params_Get_Product_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Product_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Product_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Product_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Product_By_Criteria_InList.START_ROW == null) { i_Params_Get_Product_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Product_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Product_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Product_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Product_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Product_By_Criteria_InList.OWNER_ID;
oParams_Get_Product_By_Criteria_InList_SP.NAME = i_Params_Get_Product_By_Criteria_InList.NAME;
oParams_Get_Product_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Product_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Product_By_Criteria_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Product_By_Criteria_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Product_By_Criteria_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Product_By_Criteria_InList.CATEGORY_ID_LIST);
if ( i_Params_Get_Product_By_Criteria_InList.COLOR_ID_LIST == null)
{
i_Params_Get_Product_By_Criteria_InList.COLOR_ID_LIST = new List<Int32?>();
}
oParams_Get_Product_By_Criteria_InList_SP.COLOR_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Product_By_Criteria_InList.COLOR_ID_LIST);
if ( i_Params_Get_Product_By_Criteria_InList.SIZE_ID_LIST == null)
{
i_Params_Get_Product_By_Criteria_InList.SIZE_ID_LIST = new List<Int32?>();
}
oParams_Get_Product_By_Criteria_InList_SP.SIZE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Product_By_Criteria_InList.SIZE_ID_LIST);
oParams_Get_Product_By_Criteria_InList_SP.START_ROW = i_Params_Get_Product_By_Criteria_InList.START_ROW;
oParams_Get_Product_By_Criteria_InList_SP.END_ROW = i_Params_Get_Product_By_Criteria_InList.END_ROW;
oParams_Get_Product_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Product_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Criteria_InList(i_Params_Get_Product_By_Criteria_InList.NAME,i_Params_Get_Product_By_Criteria_InList.DESCRIPTION,i_Params_Get_Product_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Product_By_Criteria_InList.COLOR_ID_LIST,i_Params_Get_Product_By_Criteria_InList.SIZE_ID_LIST,i_Params_Get_Product_By_Criteria_InList.OWNER_ID,i_Params_Get_Product_By_Criteria_InList.START_ROW,i_Params_Get_Product_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Product_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Product_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Criteria_InList");}
return oList;
}
public List<Product> Get_Product_By_Where_InList(Params_Get_Product_By_Where_InList i_Params_Get_Product_By_Where_InList)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Product_By_Where_InList_SP oParams_Get_Product_By_Where_InList_SP = new Params_Get_Product_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Product_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Product_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Product_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Product_By_Where_InList.START_ROW == null) { i_Params_Get_Product_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Product_By_Where_InList.END_ROW == null) || (i_Params_Get_Product_By_Where_InList.END_ROW == 0)) { i_Params_Get_Product_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Product_By_Where_InList_SP.OWNER_ID = i_Params_Get_Product_By_Where_InList.OWNER_ID;
oParams_Get_Product_By_Where_InList_SP.NAME = i_Params_Get_Product_By_Where_InList.NAME;
oParams_Get_Product_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Product_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Product_By_Where_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Product_By_Where_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Product_By_Where_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Product_By_Where_InList.CATEGORY_ID_LIST);
if ( i_Params_Get_Product_By_Where_InList.COLOR_ID_LIST == null)
{
i_Params_Get_Product_By_Where_InList.COLOR_ID_LIST = new List<Int32?>();
}
oParams_Get_Product_By_Where_InList_SP.COLOR_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Product_By_Where_InList.COLOR_ID_LIST);
if ( i_Params_Get_Product_By_Where_InList.SIZE_ID_LIST == null)
{
i_Params_Get_Product_By_Where_InList.SIZE_ID_LIST = new List<Int32?>();
}
oParams_Get_Product_By_Where_InList_SP.SIZE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Product_By_Where_InList.SIZE_ID_LIST);
oParams_Get_Product_By_Where_InList_SP.START_ROW = i_Params_Get_Product_By_Where_InList.START_ROW;
oParams_Get_Product_By_Where_InList_SP.END_ROW = i_Params_Get_Product_By_Where_InList.END_ROW;
oParams_Get_Product_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Product_By_Where_InList.TOTAL_COUNT;
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Where_InList(i_Params_Get_Product_By_Where_InList.NAME,i_Params_Get_Product_By_Where_InList.DESCRIPTION,i_Params_Get_Product_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Product_By_Where_InList.COLOR_ID_LIST,i_Params_Get_Product_By_Where_InList.SIZE_ID_LIST,i_Params_Get_Product_By_Where_InList.OWNER_ID,i_Params_Get_Product_By_Where_InList.START_ROW,i_Params_Get_Product_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Where_InList.TOTAL_COUNT = oParams_Get_Product_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Product_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Where_InList");}
return oList;
}
public List<User_account> Get_User_account_By_Criteria_InList(Params_Get_User_account_By_Criteria_InList i_Params_Get_User_account_By_Criteria_InList)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
long? tmp_TOTAL_COUNT = 0;
Params_Get_User_account_By_Criteria_InList_SP oParams_Get_User_account_By_Criteria_InList_SP = new Params_Get_User_account_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_User_account_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_User_account_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_User_account_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_account_By_Criteria_InList.START_ROW == null) { i_Params_Get_User_account_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_User_account_By_Criteria_InList.END_ROW == null) || (i_Params_Get_User_account_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_User_account_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_User_account_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_User_account_By_Criteria_InList.OWNER_ID;
oParams_Get_User_account_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_User_account_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_User_account_By_Criteria_InList.ADRESS_ID_LIST == null)
{
i_Params_Get_User_account_By_Criteria_InList.ADRESS_ID_LIST = new List<Int32?>();
}
oParams_Get_User_account_By_Criteria_InList_SP.ADRESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_User_account_By_Criteria_InList.ADRESS_ID_LIST);
if ( i_Params_Get_User_account_By_Criteria_InList.USER_ID_LIST == null)
{
i_Params_Get_User_account_By_Criteria_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_User_account_By_Criteria_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_User_account_By_Criteria_InList.USER_ID_LIST);
oParams_Get_User_account_By_Criteria_InList_SP.START_ROW = i_Params_Get_User_account_By_Criteria_InList.START_ROW;
oParams_Get_User_account_By_Criteria_InList_SP.END_ROW = i_Params_Get_User_account_By_Criteria_InList.END_ROW;
oParams_Get_User_account_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_User_account_By_Criteria_InList.TOTAL_COUNT;
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Criteria_InList(i_Params_Get_User_account_By_Criteria_InList.DESCRIPTION,i_Params_Get_User_account_By_Criteria_InList.ADRESS_ID_LIST,i_Params_Get_User_account_By_Criteria_InList.USER_ID_LIST,i_Params_Get_User_account_By_Criteria_InList.OWNER_ID,i_Params_Get_User_account_By_Criteria_InList.START_ROW,i_Params_Get_User_account_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Criteria_InList.TOTAL_COUNT = oParams_Get_User_account_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_User_account_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Criteria_InList");}
return oList;
}
public List<User_account> Get_User_account_By_Where_InList(Params_Get_User_account_By_Where_InList i_Params_Get_User_account_By_Where_InList)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
long? tmp_TOTAL_COUNT = 0;
Params_Get_User_account_By_Where_InList_SP oParams_Get_User_account_By_Where_InList_SP = new Params_Get_User_account_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_User_account_By_Where_InList.OWNER_ID == null) || (i_Params_Get_User_account_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_User_account_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_account_By_Where_InList.START_ROW == null) { i_Params_Get_User_account_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_User_account_By_Where_InList.END_ROW == null) || (i_Params_Get_User_account_By_Where_InList.END_ROW == 0)) { i_Params_Get_User_account_By_Where_InList.END_ROW = 1000000; }
oParams_Get_User_account_By_Where_InList_SP.OWNER_ID = i_Params_Get_User_account_By_Where_InList.OWNER_ID;
oParams_Get_User_account_By_Where_InList_SP.DESCRIPTION = i_Params_Get_User_account_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_User_account_By_Where_InList.ADRESS_ID_LIST == null)
{
i_Params_Get_User_account_By_Where_InList.ADRESS_ID_LIST = new List<Int32?>();
}
oParams_Get_User_account_By_Where_InList_SP.ADRESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_User_account_By_Where_InList.ADRESS_ID_LIST);
if ( i_Params_Get_User_account_By_Where_InList.USER_ID_LIST == null)
{
i_Params_Get_User_account_By_Where_InList.USER_ID_LIST = new List<long?>();
}
oParams_Get_User_account_By_Where_InList_SP.USER_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_User_account_By_Where_InList.USER_ID_LIST);
oParams_Get_User_account_By_Where_InList_SP.START_ROW = i_Params_Get_User_account_By_Where_InList.START_ROW;
oParams_Get_User_account_By_Where_InList_SP.END_ROW = i_Params_Get_User_account_By_Where_InList.END_ROW;
oParams_Get_User_account_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_User_account_By_Where_InList.TOTAL_COUNT;
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Where_InList(i_Params_Get_User_account_By_Where_InList.DESCRIPTION,i_Params_Get_User_account_By_Where_InList.ADRESS_ID_LIST,i_Params_Get_User_account_By_Where_InList.USER_ID_LIST,i_Params_Get_User_account_By_Where_InList.OWNER_ID,i_Params_Get_User_account_By_Where_InList.START_ROW,i_Params_Get_User_account_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Where_InList.TOTAL_COUNT = oParams_Get_User_account_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_User_account_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Where_InList");}
return oList;
}
public void Delete_Address(Params_Delete_Address i_Params_Delete_Address)
{
Params_Get_Address_By_ADDRESS_ID oParams_Get_Address_By_ADDRESS_ID = new Params_Get_Address_By_ADDRESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address");}
#region Body Section.
try
{
oParams_Get_Address_By_ADDRESS_ID.ADDRESS_ID = i_Params_Delete_Address.ADDRESS_ID;
_Address = Get_Address_By_ADDRESS_ID_Adv(oParams_Get_Address_By_ADDRESS_ID);
if (_Address != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address(i_Params_Delete_Address.ADDRESS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address");}
}
public void Delete_Adress(Params_Delete_Adress i_Params_Delete_Adress)
{
Params_Get_Adress_By_ADRESS_ID oParams_Get_Adress_By_ADRESS_ID = new Params_Get_Adress_By_ADRESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Adress");}
#region Body Section.
try
{
oParams_Get_Adress_By_ADRESS_ID.ADRESS_ID = i_Params_Delete_Adress.ADRESS_ID;
_Adress = Get_Adress_By_ADRESS_ID_Adv(oParams_Get_Adress_By_ADRESS_ID);
if (_Adress != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Adress_Execution)
{
_Stop_Delete_Adress_Execution = false;
return;
}
_AppContext.Delete_Adress(i_Params_Delete_Adress.ADRESS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Adress");}
}
public void Delete_Category(Params_Delete_Category i_Params_Delete_Category)
{
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category");}
#region Body Section.
try
{
oParams_Get_Category_By_CATEGORY_ID.CATEGORY_ID = i_Params_Delete_Category.CATEGORY_ID;
_Category = Get_Category_By_CATEGORY_ID_Adv(oParams_Get_Category_By_CATEGORY_ID);
if (_Category != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_Execution)
{
_Stop_Delete_Category_Execution = false;
return;
}
_AppContext.Delete_Category(i_Params_Delete_Category.CATEGORY_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category");}
}
public void Delete_Color(Params_Delete_Color i_Params_Delete_Color)
{
Params_Get_Color_By_COLOR_ID oParams_Get_Color_By_COLOR_ID = new Params_Get_Color_By_COLOR_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Color");}
#region Body Section.
try
{
oParams_Get_Color_By_COLOR_ID.COLOR_ID = i_Params_Delete_Color.COLOR_ID;
_Color = Get_Color_By_COLOR_ID_Adv(oParams_Get_Color_By_COLOR_ID);
if (_Color != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Color_Execution)
{
_Stop_Delete_Color_Execution = false;
return;
}
_AppContext.Delete_Color(i_Params_Delete_Color.COLOR_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Color");}
}
public void Delete_Contact(Params_Delete_Contact i_Params_Delete_Contact)
{
Params_Get_Contact_By_CONTACT_ID oParams_Get_Contact_By_CONTACT_ID = new Params_Get_Contact_By_CONTACT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact");}
#region Body Section.
try
{
oParams_Get_Contact_By_CONTACT_ID.CONTACT_ID = i_Params_Delete_Contact.CONTACT_ID;
_Contact = Get_Contact_By_CONTACT_ID_Adv(oParams_Get_Contact_By_CONTACT_ID);
if (_Contact != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact(i_Params_Delete_Contact.CONTACT_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact");}
}
public void Delete_Customer(Params_Delete_Customer i_Params_Delete_Customer)
{
Params_Get_Customer_By_CUSTOMER_ID oParams_Get_Customer_By_CUSTOMER_ID = new Params_Get_Customer_By_CUSTOMER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Customer");}
#region Body Section.
try
{
oParams_Get_Customer_By_CUSTOMER_ID.CUSTOMER_ID = i_Params_Delete_Customer.CUSTOMER_ID;
_Customer = Get_Customer_By_CUSTOMER_ID_Adv(oParams_Get_Customer_By_CUSTOMER_ID);
if (_Customer != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Customer_Execution)
{
_Stop_Delete_Customer_Execution = false;
return;
}
_AppContext.Delete_Customer(i_Params_Delete_Customer.CUSTOMER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Customer");}
}
public void Delete_Invoice(Params_Delete_Invoice i_Params_Delete_Invoice)
{
Params_Get_Invoice_By_INVOICE_ID oParams_Get_Invoice_By_INVOICE_ID = new Params_Get_Invoice_By_INVOICE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Invoice");}
#region Body Section.
try
{
oParams_Get_Invoice_By_INVOICE_ID.INVOICE_ID = i_Params_Delete_Invoice.INVOICE_ID;
_Invoice = Get_Invoice_By_INVOICE_ID_Adv(oParams_Get_Invoice_By_INVOICE_ID);
if (_Invoice != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Invoice_Execution)
{
_Stop_Delete_Invoice_Execution = false;
return;
}
_AppContext.Delete_Invoice(i_Params_Delete_Invoice.INVOICE_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Invoice");}
}
public void Delete_Invoice_status(Params_Delete_Invoice_status i_Params_Delete_Invoice_status)
{
Params_Get_Invoice_status_By_INVOICE_STATUS_ID oParams_Get_Invoice_status_By_INVOICE_STATUS_ID = new Params_Get_Invoice_status_By_INVOICE_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Invoice_status");}
#region Body Section.
try
{
oParams_Get_Invoice_status_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID = i_Params_Delete_Invoice_status.INVOICE_STATUS_ID;
_Invoice_status = Get_Invoice_status_By_INVOICE_STATUS_ID_Adv(oParams_Get_Invoice_status_By_INVOICE_STATUS_ID);
if (_Invoice_status != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Invoice_status_Execution)
{
_Stop_Delete_Invoice_status_Execution = false;
return;
}
_AppContext.Delete_Invoice_status(i_Params_Delete_Invoice_status.INVOICE_STATUS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Invoice_status");}
}
public void Delete_Loc_l1(Params_Delete_Loc_l1 i_Params_Delete_Loc_l1)
{
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1");}
#region Body Section.
try
{
oParams_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID = i_Params_Delete_Loc_l1.LOC_L1_ID;
_Loc_l1 = Get_Loc_l1_By_LOC_L1_ID_Adv(oParams_Get_Loc_l1_By_LOC_L1_ID);
if (_Loc_l1 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1(i_Params_Delete_Loc_l1.LOC_L1_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1");}
}
public void Delete_Loc_l2(Params_Delete_Loc_l2 i_Params_Delete_Loc_l2)
{
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2");}
#region Body Section.
try
{
oParams_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID = i_Params_Delete_Loc_l2.LOC_L2_ID;
_Loc_l2 = Get_Loc_l2_By_LOC_L2_ID_Adv(oParams_Get_Loc_l2_By_LOC_L2_ID);
if (_Loc_l2 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2(i_Params_Delete_Loc_l2.LOC_L2_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2");}
}
public void Delete_Loc_l3(Params_Delete_Loc_l3 i_Params_Delete_Loc_l3)
{
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3");}
#region Body Section.
try
{
oParams_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID = i_Params_Delete_Loc_l3.LOC_L3_ID;
_Loc_l3 = Get_Loc_l3_By_LOC_L3_ID_Adv(oParams_Get_Loc_l3_By_LOC_L3_ID);
if (_Loc_l3 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3(i_Params_Delete_Loc_l3.LOC_L3_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3");}
}
public void Delete_Loc_l4(Params_Delete_Loc_l4 i_Params_Delete_Loc_l4)
{
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4");}
#region Body Section.
try
{
oParams_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID = i_Params_Delete_Loc_l4.LOC_L4_ID;
_Loc_l4 = Get_Loc_l4_By_LOC_L4_ID_Adv(oParams_Get_Loc_l4_By_LOC_L4_ID);
if (_Loc_l4 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4(i_Params_Delete_Loc_l4.LOC_L4_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4");}
}
public void Delete_Order_details(Params_Delete_Order_details i_Params_Delete_Order_details)
{
Params_Get_Order_details_By_ORDER_DETAILS_ID oParams_Get_Order_details_By_ORDER_DETAILS_ID = new Params_Get_Order_details_By_ORDER_DETAILS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Order_details");}
#region Body Section.
try
{
oParams_Get_Order_details_By_ORDER_DETAILS_ID.ORDER_DETAILS_ID = i_Params_Delete_Order_details.ORDER_DETAILS_ID;
_Order_details = Get_Order_details_By_ORDER_DETAILS_ID_Adv(oParams_Get_Order_details_By_ORDER_DETAILS_ID);
if (_Order_details != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Order_details_Execution)
{
_Stop_Delete_Order_details_Execution = false;
return;
}
_AppContext.Delete_Order_details(i_Params_Delete_Order_details.ORDER_DETAILS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Order_details");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Person(Params_Delete_Person i_Params_Delete_Person)
{
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person");}
#region Body Section.
try
{
oParams_Get_Person_By_PERSON_ID.PERSON_ID = i_Params_Delete_Person.PERSON_ID;
_Person = Get_Person_By_PERSON_ID_Adv(oParams_Get_Person_By_PERSON_ID);
if (_Person != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person(i_Params_Delete_Person.PERSON_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person");}
}
public void Delete_Product(Params_Delete_Product i_Params_Delete_Product)
{
Params_Get_Product_By_PRODUCT_ID oParams_Get_Product_By_PRODUCT_ID = new Params_Get_Product_By_PRODUCT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product");}
#region Body Section.
try
{
oParams_Get_Product_By_PRODUCT_ID.PRODUCT_ID = i_Params_Delete_Product.PRODUCT_ID;
_Product = Get_Product_By_PRODUCT_ID_Adv(oParams_Get_Product_By_PRODUCT_ID);
if (_Product != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Product_Execution)
{
_Stop_Delete_Product_Execution = false;
return;
}
_AppContext.Delete_Product(i_Params_Delete_Product.PRODUCT_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product");}
}
public void Delete_Size(Params_Delete_Size i_Params_Delete_Size)
{
Params_Get_Size_By_SIZE_ID oParams_Get_Size_By_SIZE_ID = new Params_Get_Size_By_SIZE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Size");}
#region Body Section.
try
{
oParams_Get_Size_By_SIZE_ID.SIZE_ID = i_Params_Delete_Size.SIZE_ID;
_Size = Get_Size_By_SIZE_ID_Adv(oParams_Get_Size_By_SIZE_ID);
if (_Size != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Size_Execution)
{
_Stop_Delete_Size_Execution = false;
return;
}
_AppContext.Delete_Size(i_Params_Delete_Size.SIZE_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Size");}
}
public void Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file
if (OnPreEvent_Delete_Uploaded_file != null)
{
OnPreEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file(i_Params_Delete_Uploaded_file.UPLOADED_FILE_ID);
#region PostEvent_Delete_Uploaded_file
if (OnPostEvent_Delete_Uploaded_file != null)
{
OnPostEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
#region Body Section.
try
{
oParams_Get_User_By_USER_ID.USER_ID = i_Params_Delete_User.USER_ID;
_User = Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
if (_User != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_User_account(Params_Delete_User_account i_Params_Delete_User_account)
{
Params_Get_User_account_By_USER_ACCOUNT_ID oParams_Get_User_account_By_USER_ACCOUNT_ID = new Params_Get_User_account_By_USER_ACCOUNT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_account");}
#region Body Section.
try
{
oParams_Get_User_account_By_USER_ACCOUNT_ID.USER_ACCOUNT_ID = i_Params_Delete_User_account.USER_ACCOUNT_ID;
_User_account = Get_User_account_By_USER_ACCOUNT_ID_Adv(oParams_Get_User_account_By_USER_ACCOUNT_ID);
if (_User_account != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_account_Execution)
{
_Stop_Delete_User_account_Execution = false;
return;
}
_AppContext.Delete_User_account(i_Params_Delete_User_account.USER_ACCOUNT_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_account");}
}
public void Delete_Address_By_PERSON_ID(Params_Delete_Address_By_PERSON_ID i_Params_Delete_Address_By_PERSON_ID)
{
Params_Get_Address_By_PERSON_ID oParams_Get_Address_By_PERSON_ID = new Params_Get_Address_By_PERSON_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID(i_Params_Delete_Address_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID");}
}
public void Delete_Address_By_LOC_L1_ID(Params_Delete_Address_By_LOC_L1_ID i_Params_Delete_Address_By_LOC_L1_ID)
{
Params_Get_Address_By_LOC_L1_ID oParams_Get_Address_By_LOC_L1_ID = new Params_Get_Address_By_LOC_L1_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L1_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L1_ID(i_Params_Delete_Address_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L1_ID");}
}
public void Delete_Address_By_LOC_L2_ID(Params_Delete_Address_By_LOC_L2_ID i_Params_Delete_Address_By_LOC_L2_ID)
{
Params_Get_Address_By_LOC_L2_ID oParams_Get_Address_By_LOC_L2_ID = new Params_Get_Address_By_LOC_L2_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L2_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L2_ID(i_Params_Delete_Address_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L2_ID");}
}
public void Delete_Address_By_LOC_L3_ID(Params_Delete_Address_By_LOC_L3_ID i_Params_Delete_Address_By_LOC_L3_ID)
{
Params_Get_Address_By_LOC_L3_ID oParams_Get_Address_By_LOC_L3_ID = new Params_Get_Address_By_LOC_L3_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L3_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L3_ID(i_Params_Delete_Address_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L3_ID");}
}
public void Delete_Address_By_OWNER_ID(Params_Delete_Address_By_OWNER_ID i_Params_Delete_Address_By_OWNER_ID)
{
Params_Get_Address_By_OWNER_ID oParams_Get_Address_By_OWNER_ID = new Params_Get_Address_By_OWNER_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_OWNER_ID(i_Params_Delete_Address_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_OWNER_ID");}
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE oParams_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE = new Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
}
public void Delete_Address_By_LOC_L4_ID(Params_Delete_Address_By_LOC_L4_ID i_Params_Delete_Address_By_LOC_L4_ID)
{
Params_Get_Address_By_LOC_L4_ID oParams_Get_Address_By_LOC_L4_ID = new Params_Get_Address_By_LOC_L4_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L4_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L4_ID(i_Params_Delete_Address_By_LOC_L4_ID.LOC_L4_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L4_ID");}
}
public void Delete_Adress_By_OWNER_ID(Params_Delete_Adress_By_OWNER_ID i_Params_Delete_Adress_By_OWNER_ID)
{
Params_Get_Adress_By_OWNER_ID oParams_Get_Adress_By_OWNER_ID = new Params_Get_Adress_By_OWNER_ID();
List<Adress> _List_Adress = new List<Adress>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Adress_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Adress_Execution)
{
_Stop_Delete_Adress_Execution = false;
return;
}
_AppContext.Delete_Adress_By_OWNER_ID(i_Params_Delete_Adress_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Adress_By_OWNER_ID");}
}
public void Delete_Category_By_OWNER_ID(Params_Delete_Category_By_OWNER_ID i_Params_Delete_Category_By_OWNER_ID)
{
Params_Get_Category_By_OWNER_ID oParams_Get_Category_By_OWNER_ID = new Params_Get_Category_By_OWNER_ID();
List<Category> _List_Category = new List<Category>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_Execution)
{
_Stop_Delete_Category_Execution = false;
return;
}
_AppContext.Delete_Category_By_OWNER_ID(i_Params_Delete_Category_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_By_OWNER_ID");}
}
public void Delete_Color_By_OWNER_ID(Params_Delete_Color_By_OWNER_ID i_Params_Delete_Color_By_OWNER_ID)
{
Params_Get_Color_By_OWNER_ID oParams_Get_Color_By_OWNER_ID = new Params_Get_Color_By_OWNER_ID();
List<Color> _List_Color = new List<Color>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Color_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Color_Execution)
{
_Stop_Delete_Color_Execution = false;
return;
}
_AppContext.Delete_Color_By_OWNER_ID(i_Params_Delete_Color_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Color_By_OWNER_ID");}
}
public void Delete_Contact_By_PERSON_ID(Params_Delete_Contact_By_PERSON_ID i_Params_Delete_Contact_By_PERSON_ID)
{
Params_Get_Contact_By_PERSON_ID oParams_Get_Contact_By_PERSON_ID = new Params_Get_Contact_By_PERSON_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID(i_Params_Delete_Contact_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID");}
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT oParams_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT = new Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
}
public void Delete_Contact_By_OWNER_ID(Params_Delete_Contact_By_OWNER_ID i_Params_Delete_Contact_By_OWNER_ID)
{
Params_Get_Contact_By_OWNER_ID oParams_Get_Contact_By_OWNER_ID = new Params_Get_Contact_By_OWNER_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_OWNER_ID(i_Params_Delete_Contact_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_OWNER_ID");}
}
public void Delete_Customer_By_OWNER_ID(Params_Delete_Customer_By_OWNER_ID i_Params_Delete_Customer_By_OWNER_ID)
{
Params_Get_Customer_By_OWNER_ID oParams_Get_Customer_By_OWNER_ID = new Params_Get_Customer_By_OWNER_ID();
List<Customer> _List_Customer = new List<Customer>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Customer_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Customer_Execution)
{
_Stop_Delete_Customer_Execution = false;
return;
}
_AppContext.Delete_Customer_By_OWNER_ID(i_Params_Delete_Customer_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Customer_By_OWNER_ID");}
}
public void Delete_Customer_By_ADRESS_ID(Params_Delete_Customer_By_ADRESS_ID i_Params_Delete_Customer_By_ADRESS_ID)
{
Params_Get_Customer_By_ADRESS_ID oParams_Get_Customer_By_ADRESS_ID = new Params_Get_Customer_By_ADRESS_ID();
List<Customer> _List_Customer = new List<Customer>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Customer_By_ADRESS_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Customer_Execution)
{
_Stop_Delete_Customer_Execution = false;
return;
}
_AppContext.Delete_Customer_By_ADRESS_ID(i_Params_Delete_Customer_By_ADRESS_ID.ADRESS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Customer_By_ADRESS_ID");}
}
public void Delete_Customer_By_USER_ID(Params_Delete_Customer_By_USER_ID i_Params_Delete_Customer_By_USER_ID)
{
Params_Get_Customer_By_USER_ID oParams_Get_Customer_By_USER_ID = new Params_Get_Customer_By_USER_ID();
List<Customer> _List_Customer = new List<Customer>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Customer_By_USER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Customer_Execution)
{
_Stop_Delete_Customer_Execution = false;
return;
}
_AppContext.Delete_Customer_By_USER_ID(i_Params_Delete_Customer_By_USER_ID.USER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Customer_By_USER_ID");}
}
public void Delete_Invoice_By_OWNER_ID(Params_Delete_Invoice_By_OWNER_ID i_Params_Delete_Invoice_By_OWNER_ID)
{
Params_Get_Invoice_By_OWNER_ID oParams_Get_Invoice_By_OWNER_ID = new Params_Get_Invoice_By_OWNER_ID();
List<Invoice> _List_Invoice = new List<Invoice>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Invoice_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Invoice_Execution)
{
_Stop_Delete_Invoice_Execution = false;
return;
}
_AppContext.Delete_Invoice_By_OWNER_ID(i_Params_Delete_Invoice_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Invoice_By_OWNER_ID");}
}
public void Delete_Invoice_By_INVOICE_STATUS_ID(Params_Delete_Invoice_By_INVOICE_STATUS_ID i_Params_Delete_Invoice_By_INVOICE_STATUS_ID)
{
Params_Get_Invoice_By_INVOICE_STATUS_ID oParams_Get_Invoice_By_INVOICE_STATUS_ID = new Params_Get_Invoice_By_INVOICE_STATUS_ID();
List<Invoice> _List_Invoice = new List<Invoice>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Invoice_By_INVOICE_STATUS_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Invoice_Execution)
{
_Stop_Delete_Invoice_Execution = false;
return;
}
_AppContext.Delete_Invoice_By_INVOICE_STATUS_ID(i_Params_Delete_Invoice_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Invoice_By_INVOICE_STATUS_ID");}
}
public void Delete_Invoice_By_USER_ACCOUNT_ID(Params_Delete_Invoice_By_USER_ACCOUNT_ID i_Params_Delete_Invoice_By_USER_ACCOUNT_ID)
{
Params_Get_Invoice_By_USER_ACCOUNT_ID oParams_Get_Invoice_By_USER_ACCOUNT_ID = new Params_Get_Invoice_By_USER_ACCOUNT_ID();
List<Invoice> _List_Invoice = new List<Invoice>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Invoice_By_USER_ACCOUNT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Invoice_Execution)
{
_Stop_Delete_Invoice_Execution = false;
return;
}
_AppContext.Delete_Invoice_By_USER_ACCOUNT_ID(i_Params_Delete_Invoice_By_USER_ACCOUNT_ID.USER_ACCOUNT_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Invoice_By_USER_ACCOUNT_ID");}
}
public void Delete_Invoice_status_By_OWNER_ID(Params_Delete_Invoice_status_By_OWNER_ID i_Params_Delete_Invoice_status_By_OWNER_ID)
{
Params_Get_Invoice_status_By_OWNER_ID oParams_Get_Invoice_status_By_OWNER_ID = new Params_Get_Invoice_status_By_OWNER_ID();
List<Invoice_status> _List_Invoice_status = new List<Invoice_status>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Invoice_status_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Invoice_status_Execution)
{
_Stop_Delete_Invoice_status_Execution = false;
return;
}
_AppContext.Delete_Invoice_status_By_OWNER_ID(i_Params_Delete_Invoice_status_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Invoice_status_By_OWNER_ID");}
}
public void Delete_Loc_l1_By_CODE(Params_Delete_Loc_l1_By_CODE i_Params_Delete_Loc_l1_By_CODE)
{
Params_Get_Loc_l1_By_CODE oParams_Get_Loc_l1_By_CODE = new Params_Get_Loc_l1_By_CODE();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_CODE(i_Params_Delete_Loc_l1_By_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_CODE");}
}
public void Delete_Loc_l1_By_OWNER_ID(Params_Delete_Loc_l1_By_OWNER_ID i_Params_Delete_Loc_l1_By_OWNER_ID)
{
Params_Get_Loc_l1_By_OWNER_ID oParams_Get_Loc_l1_By_OWNER_ID = new Params_Get_Loc_l1_By_OWNER_ID();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_OWNER_ID(i_Params_Delete_Loc_l1_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_OWNER_ID");}
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE(Params_Delete_Loc_l2_By_LOC_L1_ID_CODE i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE)
{
Params_Get_Loc_l2_By_LOC_L1_ID_CODE oParams_Get_Loc_l2_By_LOC_L1_ID_CODE = new Params_Get_Loc_l2_By_LOC_L1_ID_CODE();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
}
public void Delete_Loc_l2_By_LOC_L1_ID(Params_Delete_Loc_l2_By_LOC_L1_ID i_Params_Delete_Loc_l2_By_LOC_L1_ID)
{
Params_Get_Loc_l2_By_LOC_L1_ID oParams_Get_Loc_l2_By_LOC_L1_ID = new Params_Get_Loc_l2_By_LOC_L1_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID(i_Params_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
}
public void Delete_Loc_l2_By_OWNER_ID(Params_Delete_Loc_l2_By_OWNER_ID i_Params_Delete_Loc_l2_By_OWNER_ID)
{
Params_Get_Loc_l2_By_OWNER_ID oParams_Get_Loc_l2_By_OWNER_ID = new Params_Get_Loc_l2_By_OWNER_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_OWNER_ID(i_Params_Delete_Loc_l2_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_OWNER_ID");}
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE(Params_Delete_Loc_l3_By_LOC_L2_ID_CODE i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE)
{
Params_Get_Loc_l3_By_LOC_L2_ID_CODE oParams_Get_Loc_l3_By_LOC_L2_ID_CODE = new Params_Get_Loc_l3_By_LOC_L2_ID_CODE();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
}
public void Delete_Loc_l3_By_LOC_L2_ID(Params_Delete_Loc_l3_By_LOC_L2_ID i_Params_Delete_Loc_l3_By_LOC_L2_ID)
{
Params_Get_Loc_l3_By_LOC_L2_ID oParams_Get_Loc_l3_By_LOC_L2_ID = new Params_Get_Loc_l3_By_LOC_L2_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID(i_Params_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
}
public void Delete_Loc_l3_By_OWNER_ID(Params_Delete_Loc_l3_By_OWNER_ID i_Params_Delete_Loc_l3_By_OWNER_ID)
{
Params_Get_Loc_l3_By_OWNER_ID oParams_Get_Loc_l3_By_OWNER_ID = new Params_Get_Loc_l3_By_OWNER_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_OWNER_ID(i_Params_Delete_Loc_l3_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_OWNER_ID");}
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE(Params_Delete_Loc_l4_By_LOC_L3_ID_CODE i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE)
{
Params_Get_Loc_l4_By_LOC_L3_ID_CODE oParams_Get_Loc_l4_By_LOC_L3_ID_CODE = new Params_Get_Loc_l4_By_LOC_L3_ID_CODE();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
}
public void Delete_Loc_l4_By_LOC_L3_ID(Params_Delete_Loc_l4_By_LOC_L3_ID i_Params_Delete_Loc_l4_By_LOC_L3_ID)
{
Params_Get_Loc_l4_By_LOC_L3_ID oParams_Get_Loc_l4_By_LOC_L3_ID = new Params_Get_Loc_l4_By_LOC_L3_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID(i_Params_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
}
public void Delete_Loc_l4_By_OWNER_ID(Params_Delete_Loc_l4_By_OWNER_ID i_Params_Delete_Loc_l4_By_OWNER_ID)
{
Params_Get_Loc_l4_By_OWNER_ID oParams_Get_Loc_l4_By_OWNER_ID = new Params_Get_Loc_l4_By_OWNER_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_OWNER_ID(i_Params_Delete_Loc_l4_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_OWNER_ID");}
}
public void Delete_Order_details_By_OWNER_ID(Params_Delete_Order_details_By_OWNER_ID i_Params_Delete_Order_details_By_OWNER_ID)
{
Params_Get_Order_details_By_OWNER_ID oParams_Get_Order_details_By_OWNER_ID = new Params_Get_Order_details_By_OWNER_ID();
List<Order_details> _List_Order_details = new List<Order_details>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Order_details_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Order_details_Execution)
{
_Stop_Delete_Order_details_Execution = false;
return;
}
_AppContext.Delete_Order_details_By_OWNER_ID(i_Params_Delete_Order_details_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Order_details_By_OWNER_ID");}
}
public void Delete_Order_details_By_PRODUCT_ID(Params_Delete_Order_details_By_PRODUCT_ID i_Params_Delete_Order_details_By_PRODUCT_ID)
{
Params_Get_Order_details_By_PRODUCT_ID oParams_Get_Order_details_By_PRODUCT_ID = new Params_Get_Order_details_By_PRODUCT_ID();
List<Order_details> _List_Order_details = new List<Order_details>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Order_details_By_PRODUCT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Order_details_Execution)
{
_Stop_Delete_Order_details_Execution = false;
return;
}
_AppContext.Delete_Order_details_By_PRODUCT_ID(i_Params_Delete_Order_details_By_PRODUCT_ID.PRODUCT_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Order_details_By_PRODUCT_ID");}
}
public void Delete_Order_details_By_INVOICE_ID(Params_Delete_Order_details_By_INVOICE_ID i_Params_Delete_Order_details_By_INVOICE_ID)
{
Params_Get_Order_details_By_INVOICE_ID oParams_Get_Order_details_By_INVOICE_ID = new Params_Get_Order_details_By_INVOICE_ID();
List<Order_details> _List_Order_details = new List<Order_details>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Order_details_By_INVOICE_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Order_details_Execution)
{
_Stop_Delete_Order_details_Execution = false;
return;
}
_AppContext.Delete_Order_details_By_INVOICE_ID(i_Params_Delete_Order_details_By_INVOICE_ID.INVOICE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Order_details_By_INVOICE_ID");}
}
public void Delete_Person_By_OWNER_ID(Params_Delete_Person_By_OWNER_ID i_Params_Delete_Person_By_OWNER_ID)
{
Params_Get_Person_By_OWNER_ID oParams_Get_Person_By_OWNER_ID = new Params_Get_Person_By_OWNER_ID();
List<Person> _List_Person = new List<Person>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person_By_OWNER_ID(i_Params_Delete_Person_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_By_OWNER_ID");}
}
public void Delete_Product_By_OWNER_ID(Params_Delete_Product_By_OWNER_ID i_Params_Delete_Product_By_OWNER_ID)
{
Params_Get_Product_By_OWNER_ID oParams_Get_Product_By_OWNER_ID = new Params_Get_Product_By_OWNER_ID();
List<Product> _List_Product = new List<Product>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Product_Execution)
{
_Stop_Delete_Product_Execution = false;
return;
}
_AppContext.Delete_Product_By_OWNER_ID(i_Params_Delete_Product_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product_By_OWNER_ID");}
}
public void Delete_Product_By_CATEGORY_ID(Params_Delete_Product_By_CATEGORY_ID i_Params_Delete_Product_By_CATEGORY_ID)
{
Params_Get_Product_By_CATEGORY_ID oParams_Get_Product_By_CATEGORY_ID = new Params_Get_Product_By_CATEGORY_ID();
List<Product> _List_Product = new List<Product>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product_By_CATEGORY_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Product_Execution)
{
_Stop_Delete_Product_Execution = false;
return;
}
_AppContext.Delete_Product_By_CATEGORY_ID(i_Params_Delete_Product_By_CATEGORY_ID.CATEGORY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product_By_CATEGORY_ID");}
}
public void Delete_Product_By_IS_BEST_SELLING(Params_Delete_Product_By_IS_BEST_SELLING i_Params_Delete_Product_By_IS_BEST_SELLING)
{
Params_Get_Product_By_IS_BEST_SELLING oParams_Get_Product_By_IS_BEST_SELLING = new Params_Get_Product_By_IS_BEST_SELLING();
List<Product> _List_Product = new List<Product>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product_By_IS_BEST_SELLING");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Product_Execution)
{
_Stop_Delete_Product_Execution = false;
return;
}
_AppContext.Delete_Product_By_IS_BEST_SELLING(i_Params_Delete_Product_By_IS_BEST_SELLING.IS_BEST_SELLING);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product_By_IS_BEST_SELLING");}
}
public void Delete_Product_By_IS_RECOMMENDED(Params_Delete_Product_By_IS_RECOMMENDED i_Params_Delete_Product_By_IS_RECOMMENDED)
{
Params_Get_Product_By_IS_RECOMMENDED oParams_Get_Product_By_IS_RECOMMENDED = new Params_Get_Product_By_IS_RECOMMENDED();
List<Product> _List_Product = new List<Product>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product_By_IS_RECOMMENDED");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Product_Execution)
{
_Stop_Delete_Product_Execution = false;
return;
}
_AppContext.Delete_Product_By_IS_RECOMMENDED(i_Params_Delete_Product_By_IS_RECOMMENDED.IS_RECOMMENDED);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product_By_IS_RECOMMENDED");}
}
public void Delete_Product_By_COLOR_ID(Params_Delete_Product_By_COLOR_ID i_Params_Delete_Product_By_COLOR_ID)
{
Params_Get_Product_By_COLOR_ID oParams_Get_Product_By_COLOR_ID = new Params_Get_Product_By_COLOR_ID();
List<Product> _List_Product = new List<Product>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product_By_COLOR_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Product_Execution)
{
_Stop_Delete_Product_Execution = false;
return;
}
_AppContext.Delete_Product_By_COLOR_ID(i_Params_Delete_Product_By_COLOR_ID.COLOR_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product_By_COLOR_ID");}
}
public void Delete_Product_By_SIZE_ID(Params_Delete_Product_By_SIZE_ID i_Params_Delete_Product_By_SIZE_ID)
{
Params_Get_Product_By_SIZE_ID oParams_Get_Product_By_SIZE_ID = new Params_Get_Product_By_SIZE_ID();
List<Product> _List_Product = new List<Product>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product_By_SIZE_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Product_Execution)
{
_Stop_Delete_Product_Execution = false;
return;
}
_AppContext.Delete_Product_By_SIZE_ID(i_Params_Delete_Product_By_SIZE_ID.SIZE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product_By_SIZE_ID");}
}
public void Delete_Size_By_OWNER_ID(Params_Delete_Size_By_OWNER_ID i_Params_Delete_Size_By_OWNER_ID)
{
Params_Get_Size_By_OWNER_ID oParams_Get_Size_By_OWNER_ID = new Params_Get_Size_By_OWNER_ID();
List<Size> _List_Size = new List<Size>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Size_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Size_Execution)
{
_Stop_Delete_Size_Execution = false;
return;
}
_AppContext.Delete_Size_By_OWNER_ID(i_Params_Delete_Size_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Size_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_OWNER_ID(Params_Delete_Uploaded_file_By_OWNER_ID i_Params_Delete_Uploaded_file_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_OWNER_ID(i_Params_Delete_Uploaded_file_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_REL_ENTITY(Params_Delete_Uploaded_file_By_REL_ENTITY i_Params_Delete_Uploaded_file_By_REL_ENTITY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY(i_Params_Delete_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
#region PostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
Params_Get_User_By_USERNAME oParams_Get_User_By_USERNAME = new Params_Get_User_By_USERNAME();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Delete_User_account_By_OWNER_ID(Params_Delete_User_account_By_OWNER_ID i_Params_Delete_User_account_By_OWNER_ID)
{
Params_Get_User_account_By_OWNER_ID oParams_Get_User_account_By_OWNER_ID = new Params_Get_User_account_By_OWNER_ID();
List<User_account> _List_User_account = new List<User_account>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_account_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_account_Execution)
{
_Stop_Delete_User_account_Execution = false;
return;
}
_AppContext.Delete_User_account_By_OWNER_ID(i_Params_Delete_User_account_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_account_By_OWNER_ID");}
}
public void Delete_User_account_By_USER_ID(Params_Delete_User_account_By_USER_ID i_Params_Delete_User_account_By_USER_ID)
{
Params_Get_User_account_By_USER_ID oParams_Get_User_account_By_USER_ID = new Params_Get_User_account_By_USER_ID();
List<User_account> _List_User_account = new List<User_account>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_account_By_USER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_account_Execution)
{
_Stop_Delete_User_account_Execution = false;
return;
}
_AppContext.Delete_User_account_By_USER_ID(i_Params_Delete_User_account_By_USER_ID.USER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_account_By_USER_ID");}
}
public void Delete_User_account_By_ADRESS_ID(Params_Delete_User_account_By_ADRESS_ID i_Params_Delete_User_account_By_ADRESS_ID)
{
Params_Get_User_account_By_ADRESS_ID oParams_Get_User_account_By_ADRESS_ID = new Params_Get_User_account_By_ADRESS_ID();
List<User_account> _List_User_account = new List<User_account>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_account_By_ADRESS_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_account_Execution)
{
_Stop_Delete_User_account_Execution = false;
return;
}
_AppContext.Delete_User_account_By_ADRESS_ID(i_Params_Delete_User_account_By_ADRESS_ID.ADRESS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_account_By_ADRESS_ID");}
}
public void Edit_Address(Address i_Address) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Address.ADDRESS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address");}
#region Body Section.
if ((i_Address.ADDRESS_ID == null) || (i_Address.ADDRESS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Address"); }
i_Address.ENTRY_USER_ID = this.UserID;
i_Address.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Address.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Address_Execution)
{
_Stop_Edit_Address_Execution = false;
return;
}
i_Address.ADDRESS_ID = _AppContext.Edit_Address
(
i_Address.ADDRESS_ID
,i_Address.PERSON_ID
,i_Address.ADDRESS_TYPE_CODE
,i_Address.LOC_L1_ID
,i_Address.LOC_L2_ID
,i_Address.LOC_L3_ID
,i_Address.LOC_L4_ID
,i_Address.STREET
,i_Address.BUILDING
,i_Address.FLOOR
,i_Address.POBOX
,i_Address.VALID_DATE_START
,i_Address.VALID_DATE_END
,i_Address.NOTES
,i_Address.ENTRY_DATE
,i_Address.ENTRY_USER_ID
,i_Address.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address");}
}
public void Edit_Adress(Adress i_Adress) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Adress.ADRESS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Adress");}
#region Body Section.
if ((i_Adress.ADRESS_ID == null) || (i_Adress.ADRESS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Adress"); }
i_Adress.ENTRY_USER_ID = this.UserID;
i_Adress.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Adress.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Adress_Execution)
{
_Stop_Edit_Adress_Execution = false;
return;
}
i_Adress.ADRESS_ID = _AppContext.Edit_Adress
(
i_Adress.ADRESS_ID
,i_Adress.STREET_NAME_ONE
,i_Adress.STREET_NAME_TWO
,i_Adress.STATE
,i_Adress.POST_CODE
,i_Adress.ENTRY_USER_ID
,i_Adress.ENTRY_DATE
,i_Adress.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Adress");}
}
public void Edit_Category(Category i_Category) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Category.CATEGORY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category");}
#region Body Section.
if ((i_Category.CATEGORY_ID == null) || (i_Category.CATEGORY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Category"); }
i_Category.ENTRY_USER_ID = this.UserID;
i_Category.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Category.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Category_Execution)
{
_Stop_Edit_Category_Execution = false;
return;
}
i_Category.CATEGORY_ID = _AppContext.Edit_Category
(
i_Category.CATEGORY_ID
,i_Category.NAME
,i_Category.ENTRY_USER_ID
,i_Category.ENTRY_DATE
,i_Category.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category");}
}
public void Edit_Color(Color i_Color) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Color.COLOR_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Color");}
#region Body Section.
if ((i_Color.COLOR_ID == null) || (i_Color.COLOR_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Color"); }
i_Color.ENTRY_USER_ID = this.UserID;
i_Color.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Color.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Color_Execution)
{
_Stop_Edit_Color_Execution = false;
return;
}
i_Color.COLOR_ID = _AppContext.Edit_Color
(
i_Color.COLOR_ID
,i_Color.NAME
,i_Color.ENTRY_USER_ID
,i_Color.ENTRY_DATE
,i_Color.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Color");}
}
public void Edit_Contact(Contact i_Contact) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Contact.CONTACT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact");}
#region Body Section.
if ((i_Contact.CONTACT_ID == null) || (i_Contact.CONTACT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Contact"); }
i_Contact.ENTRY_USER_ID = this.UserID;
i_Contact.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Contact.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Contact_Execution)
{
_Stop_Edit_Contact_Execution = false;
return;
}
i_Contact.CONTACT_ID = _AppContext.Edit_Contact
(
i_Contact.CONTACT_ID
,i_Contact.PERSON_ID
,i_Contact.CONTACT_TYPE_CODE
,i_Contact.CONTACT
,i_Contact.DESCRIPTION
,i_Contact.ENTRY_USER_ID
,i_Contact.ENTRY_DATE
,i_Contact.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact");}
}
public void Edit_Customer(Customer i_Customer) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Customer.CUSTOMER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Customer");}
#region Body Section.
if ((i_Customer.CUSTOMER_ID == null) || (i_Customer.CUSTOMER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Customer"); }
i_Customer.ENTRY_USER_ID = this.UserID;
i_Customer.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Customer.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Customer_Execution)
{
_Stop_Edit_Customer_Execution = false;
return;
}
i_Customer.CUSTOMER_ID = _AppContext.Edit_Customer
(
i_Customer.CUSTOMER_ID
,i_Customer.USER_ID
,i_Customer.FIRST_NAME
,i_Customer.LAST_NAME
,i_Customer.ADRESS_ID
,i_Customer.PHONE
,i_Customer.ENTRY_USER_ID
,i_Customer.ENTRY_DATE
,i_Customer.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Customer");}
}
public void Edit_Invoice(Invoice i_Invoice) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Invoice.INVOICE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice");}
#region Body Section.
if ((i_Invoice.INVOICE_ID == null) || (i_Invoice.INVOICE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Invoice"); }
i_Invoice.ENTRY_USER_ID = this.UserID;
i_Invoice.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Invoice.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Invoice_Execution)
{
_Stop_Edit_Invoice_Execution = false;
return;
}
i_Invoice.INVOICE_ID = _AppContext.Edit_Invoice
(
i_Invoice.INVOICE_ID
,i_Invoice.USER_ACCOUNT_ID
,i_Invoice.INVOICE_STATUS_ID
,i_Invoice.ENTRY_USER_ID
,i_Invoice.ENTRY_DATE
,i_Invoice.OWNER_ID
,i_Invoice.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice");}
}
public void Edit_Invoice_status(Invoice_status i_Invoice_status) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Invoice_status.INVOICE_STATUS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice_status");}
#region Body Section.
if ((i_Invoice_status.INVOICE_STATUS_ID == null) || (i_Invoice_status.INVOICE_STATUS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Invoice_status"); }
i_Invoice_status.ENTRY_USER_ID = this.UserID;
i_Invoice_status.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Invoice_status.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Invoice_status_Execution)
{
_Stop_Edit_Invoice_status_Execution = false;
return;
}
i_Invoice_status.INVOICE_STATUS_ID = _AppContext.Edit_Invoice_status
(
i_Invoice_status.INVOICE_STATUS_ID
,i_Invoice_status.INVOICE_STATUS
,i_Invoice_status.ENTRY_USER_ID
,i_Invoice_status.ENTRY_DATE
,i_Invoice_status.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice_status");}
}
public void Edit_Loc_l1(Loc_l1 i_Loc_l1) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l1.LOC_L1_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1");}
#region Body Section.
if ((i_Loc_l1.LOC_L1_ID == null) || (i_Loc_l1.LOC_L1_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l1"); }
i_Loc_l1.ENTRY_USER_ID = this.UserID;
i_Loc_l1.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l1.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l1_Execution)
{
_Stop_Edit_Loc_l1_Execution = false;
return;
}
i_Loc_l1.LOC_L1_ID = _AppContext.Edit_Loc_l1
(
i_Loc_l1.LOC_L1_ID
,i_Loc_l1.CODE
,i_Loc_l1.DESCRIPTION
,i_Loc_l1.NOTES
,i_Loc_l1.ENTRY_DATE
,i_Loc_l1.ENTRY_USER_ID
,i_Loc_l1.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1");}
}
public void Edit_Loc_l2(Loc_l2 i_Loc_l2) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l2.LOC_L2_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2");}
#region Body Section.
if ((i_Loc_l2.LOC_L2_ID == null) || (i_Loc_l2.LOC_L2_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l2"); }
i_Loc_l2.ENTRY_USER_ID = this.UserID;
i_Loc_l2.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l2.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l2_Execution)
{
_Stop_Edit_Loc_l2_Execution = false;
return;
}
i_Loc_l2.LOC_L2_ID = _AppContext.Edit_Loc_l2
(
i_Loc_l2.LOC_L2_ID
,i_Loc_l2.CODE
,i_Loc_l2.DESCRIPTION
,i_Loc_l2.LOC_L1_ID
,i_Loc_l2.NOTES
,i_Loc_l2.ENTRY_DATE
,i_Loc_l2.ENTRY_USER_ID
,i_Loc_l2.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2");}
}
public void Edit_Loc_l3(Loc_l3 i_Loc_l3) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l3.LOC_L3_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3");}
#region Body Section.
if ((i_Loc_l3.LOC_L3_ID == null) || (i_Loc_l3.LOC_L3_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l3"); }
i_Loc_l3.ENTRY_USER_ID = this.UserID;
i_Loc_l3.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l3.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l3_Execution)
{
_Stop_Edit_Loc_l3_Execution = false;
return;
}
i_Loc_l3.LOC_L3_ID = _AppContext.Edit_Loc_l3
(
i_Loc_l3.LOC_L3_ID
,i_Loc_l3.CODE
,i_Loc_l3.DESCRIPTION
,i_Loc_l3.LOC_L2_ID
,i_Loc_l3.NOTES
,i_Loc_l3.ENTRY_DATE
,i_Loc_l3.ENTRY_USER_ID
,i_Loc_l3.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3");}
}
public void Edit_Loc_l4(Loc_l4 i_Loc_l4) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l4.LOC_L4_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4");}
#region Body Section.
if ((i_Loc_l4.LOC_L4_ID == null) || (i_Loc_l4.LOC_L4_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l4"); }
i_Loc_l4.ENTRY_USER_ID = this.UserID;
i_Loc_l4.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l4.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l4_Execution)
{
_Stop_Edit_Loc_l4_Execution = false;
return;
}
i_Loc_l4.LOC_L4_ID = _AppContext.Edit_Loc_l4
(
i_Loc_l4.LOC_L4_ID
,i_Loc_l4.CODE
,i_Loc_l4.DESCRIPTION
,i_Loc_l4.LOC_L3_ID
,i_Loc_l4.NOTES
,i_Loc_l4.ENTRY_DATE
,i_Loc_l4.ENTRY_USER_ID
,i_Loc_l4.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4");}
}
public void Edit_Order_details(Order_details i_Order_details) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Order_details.ORDER_DETAILS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Order_details");}
#region Body Section.
if ((i_Order_details.ORDER_DETAILS_ID == null) || (i_Order_details.ORDER_DETAILS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Order_details"); }
i_Order_details.ENTRY_USER_ID = this.UserID;
i_Order_details.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Order_details.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Order_details_Execution)
{
_Stop_Edit_Order_details_Execution = false;
return;
}
i_Order_details.ORDER_DETAILS_ID = _AppContext.Edit_Order_details
(
i_Order_details.ORDER_DETAILS_ID
,i_Order_details.PRODUCT_ID
,i_Order_details.PRICE
,i_Order_details.QUANTITY
,i_Order_details.INVOICE_ID
,i_Order_details.ENTRY_USER_ID
,i_Order_details.ENTRY_DATE
,i_Order_details.OWNER_ID
,i_Order_details.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Order_details");}
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Person(Person i_Person) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Person.PERSON_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person");}
#region Body Section.
if ((i_Person.PERSON_ID == null) || (i_Person.PERSON_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Person"); }
i_Person.ENTRY_USER_ID = this.UserID;
i_Person.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Person.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Person_Execution)
{
_Stop_Edit_Person_Execution = false;
return;
}
i_Person.PERSON_ID = _AppContext.Edit_Person
(
i_Person.PERSON_ID
,i_Person.FIRST_NAME
,i_Person.LAST_NAME
,i_Person.FATHER_NAME
,i_Person.MOTHER_NAME
,i_Person.TITLE_CODE
,i_Person.GENDER_CODE
,i_Person.RELIGION_CODE
,i_Person.BIRTH_DATE
,i_Person.IS_BLOCKED
,i_Person.DESCRIPTION
,i_Person.OWNER_ID
,i_Person.ENTRY_USER_ID
,i_Person.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person");}
}
public void Edit_Product(Product i_Product) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Product.PRODUCT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Product");}
#region Body Section.
if ((i_Product.PRODUCT_ID == null) || (i_Product.PRODUCT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Product"); }
i_Product.ENTRY_USER_ID = this.UserID;
i_Product.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Product.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Product_Execution)
{
_Stop_Edit_Product_Execution = false;
return;
}
i_Product.PRODUCT_ID = _AppContext.Edit_Product
(
i_Product.PRODUCT_ID
,i_Product.NAME
,i_Product.DESCRIPTION
,i_Product.CATEGORY_ID
,i_Product.STOCK
,i_Product.FULL_PRICE
,i_Product.COLOR_ID
,i_Product.SIZE_ID
,i_Product.DISCOUNT_PRICE
,i_Product.IS_BEST_SELLING
,i_Product.IS_RECOMMENDED
,i_Product.ENTRY_USER_ID
,i_Product.ENTRY_DATE
,i_Product.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Product");}
}
public void Edit_Size(Size i_Size) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Size.SIZE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Size");}
#region Body Section.
if ((i_Size.SIZE_ID == null) || (i_Size.SIZE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Size"); }
i_Size.ENTRY_USER_ID = this.UserID;
i_Size.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Size.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Size_Execution)
{
_Stop_Edit_Size_Execution = false;
return;
}
i_Size.SIZE_ID = _AppContext.Edit_Size
(
i_Size.SIZE_ID
,i_Size.DESCRIPTION
,i_Size.ENTRY_USER_ID
,i_Size.ENTRY_DATE
,i_Size.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Size");}
}
public void Edit_Uploaded_file(Uploaded_file i_Uploaded_file) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Uploaded_file.UPLOADED_FILE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file");}
#region Body Section.
if ((i_Uploaded_file.UPLOADED_FILE_ID == null) || (i_Uploaded_file.UPLOADED_FILE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Uploaded_file"); }
i_Uploaded_file.ENTRY_USER_ID = this.UserID;
i_Uploaded_file.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Uploaded_file.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Uploaded_file
if (OnPreEvent_Edit_Uploaded_file != null)
{
OnPreEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Uploaded_file_Execution)
{
_Stop_Edit_Uploaded_file_Execution = false;
return;
}
i_Uploaded_file.UPLOADED_FILE_ID = _AppContext.Edit_Uploaded_file
(
i_Uploaded_file.UPLOADED_FILE_ID
,i_Uploaded_file.REL_ENTITY
,i_Uploaded_file.REL_KEY
,i_Uploaded_file.REL_FIELD
,i_Uploaded_file.SIZE
,i_Uploaded_file.EXTENSION
,i_Uploaded_file.STAMP
,i_Uploaded_file.ENTRY_USER_ID
,i_Uploaded_file.ENTRY_DATE
,i_Uploaded_file.OWNER_ID
);
#region PostEvent_Edit_Uploaded_file
if (OnPostEvent_Edit_Uploaded_file != null)
{
OnPostEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.EMAIL
,i_User.USERNAME
,i_User.PASSWORD
,i_User.PHONE
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_User_account(User_account i_User_account) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User_account.USER_ACCOUNT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_account");}
#region Body Section.
if ((i_User_account.USER_ACCOUNT_ID == null) || (i_User_account.USER_ACCOUNT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User_account"); }
i_User_account.ENTRY_USER_ID = this.UserID;
i_User_account.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User_account.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_account_Execution)
{
_Stop_Edit_User_account_Execution = false;
return;
}
i_User_account.USER_ACCOUNT_ID = _AppContext.Edit_User_account
(
i_User_account.USER_ACCOUNT_ID
,i_User_account.ADRESS_ID
,i_User_account.USER_ID
,i_User_account.ENTRY_USER_ID
,i_User_account.ENTRY_DATE
,i_User_account.OWNER_ID
,i_User_account.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_account");}
}
public void Edit_Address_List(List<Address> i_List_Address)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Address != null)
{
foreach (var oRow in i_List_Address)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Address_List(Params_Edit_Address_List i_Params_Edit_Address_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Address_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Delete)
{
Delete_Address(new Params_Delete_Address() { ADDRESS_ID = oRow.ADDRESS_ID });
}
}
if (i_Params_Edit_Address_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Edit)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Adress_List(List<Adress> i_List_Adress)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Adress_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Adress != null)
{
foreach (var oRow in i_List_Adress)
{
Edit_Adress(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Adress_List");}
}
public void Edit_Adress_List(Params_Edit_Adress_List i_Params_Edit_Adress_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Adress_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Adress_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Adress_List.My_List_To_Delete)
{
Delete_Adress(new Params_Delete_Adress() { ADRESS_ID = oRow.ADRESS_ID });
}
}
if (i_Params_Edit_Adress_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Adress_List.My_List_To_Edit)
{
Edit_Adress(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Adress_List");}
}
public void Edit_Category_List(List<Category> i_List_Category)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Category != null)
{
foreach (var oRow in i_List_Category)
{
Edit_Category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_List");}
}
public void Edit_Category_List(Params_Edit_Category_List i_Params_Edit_Category_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Category_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Category_List.My_List_To_Delete)
{
Delete_Category(new Params_Delete_Category() { CATEGORY_ID = oRow.CATEGORY_ID });
}
}
if (i_Params_Edit_Category_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Category_List.My_List_To_Edit)
{
Edit_Category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_List");}
}
public void Edit_Color_List(List<Color> i_List_Color)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Color_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Color != null)
{
foreach (var oRow in i_List_Color)
{
Edit_Color(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Color_List");}
}
public void Edit_Color_List(Params_Edit_Color_List i_Params_Edit_Color_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Color_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Color_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Color_List.My_List_To_Delete)
{
Delete_Color(new Params_Delete_Color() { COLOR_ID = oRow.COLOR_ID });
}
}
if (i_Params_Edit_Color_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Color_List.My_List_To_Edit)
{
Edit_Color(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Color_List");}
}
public void Edit_Contact_List(List<Contact> i_List_Contact)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Contact != null)
{
foreach (var oRow in i_List_Contact)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Contact_List(Params_Edit_Contact_List i_Params_Edit_Contact_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Contact_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Delete)
{
Delete_Contact(new Params_Delete_Contact() { CONTACT_ID = oRow.CONTACT_ID });
}
}
if (i_Params_Edit_Contact_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Edit)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Customer_List(List<Customer> i_List_Customer)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Customer_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Customer != null)
{
foreach (var oRow in i_List_Customer)
{
Edit_Customer(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Customer_List");}
}
public void Edit_Customer_List(Params_Edit_Customer_List i_Params_Edit_Customer_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Customer_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Customer_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Customer_List.My_List_To_Delete)
{
Delete_Customer(new Params_Delete_Customer() { CUSTOMER_ID = oRow.CUSTOMER_ID });
}
}
if (i_Params_Edit_Customer_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Customer_List.My_List_To_Edit)
{
Edit_Customer(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Customer_List");}
}
public void Edit_Invoice_List(List<Invoice> i_List_Invoice)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Invoice != null)
{
foreach (var oRow in i_List_Invoice)
{
Edit_Invoice(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice_List");}
}
public void Edit_Invoice_List(Params_Edit_Invoice_List i_Params_Edit_Invoice_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Invoice_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Invoice_List.My_List_To_Delete)
{
Delete_Invoice(new Params_Delete_Invoice() { INVOICE_ID = oRow.INVOICE_ID });
}
}
if (i_Params_Edit_Invoice_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Invoice_List.My_List_To_Edit)
{
Edit_Invoice(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice_List");}
}
public void Edit_Invoice_status_List(List<Invoice_status> i_List_Invoice_status)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice_status_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Invoice_status != null)
{
foreach (var oRow in i_List_Invoice_status)
{
Edit_Invoice_status(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice_status_List");}
}
public void Edit_Invoice_status_List(Params_Edit_Invoice_status_List i_Params_Edit_Invoice_status_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice_status_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Invoice_status_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Invoice_status_List.My_List_To_Delete)
{
Delete_Invoice_status(new Params_Delete_Invoice_status() { INVOICE_STATUS_ID = oRow.INVOICE_STATUS_ID });
}
}
if (i_Params_Edit_Invoice_status_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Invoice_status_List.My_List_To_Edit)
{
Edit_Invoice_status(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice_status_List");}
}
public void Edit_Loc_l1_List(List<Loc_l1> i_List_Loc_l1)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l1 != null)
{
foreach (var oRow in i_List_Loc_l1)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l1_List(Params_Edit_Loc_l1_List i_Params_Edit_Loc_l1_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l1_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Delete)
{
Delete_Loc_l1(new Params_Delete_Loc_l1() { LOC_L1_ID = oRow.LOC_L1_ID });
}
}
if (i_Params_Edit_Loc_l1_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Edit)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l2_List(List<Loc_l2> i_List_Loc_l2)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l2 != null)
{
foreach (var oRow in i_List_Loc_l2)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l2_List(Params_Edit_Loc_l2_List i_Params_Edit_Loc_l2_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l2_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Delete)
{
Delete_Loc_l2(new Params_Delete_Loc_l2() { LOC_L2_ID = oRow.LOC_L2_ID });
}
}
if (i_Params_Edit_Loc_l2_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Edit)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l3_List(List<Loc_l3> i_List_Loc_l3)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l3 != null)
{
foreach (var oRow in i_List_Loc_l3)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l3_List(Params_Edit_Loc_l3_List i_Params_Edit_Loc_l3_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l3_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Delete)
{
Delete_Loc_l3(new Params_Delete_Loc_l3() { LOC_L3_ID = oRow.LOC_L3_ID });
}
}
if (i_Params_Edit_Loc_l3_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Edit)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l4_List(List<Loc_l4> i_List_Loc_l4)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l4 != null)
{
foreach (var oRow in i_List_Loc_l4)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Loc_l4_List(Params_Edit_Loc_l4_List i_Params_Edit_Loc_l4_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l4_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Delete)
{
Delete_Loc_l4(new Params_Delete_Loc_l4() { LOC_L4_ID = oRow.LOC_L4_ID });
}
}
if (i_Params_Edit_Loc_l4_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Edit)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Order_details_List(List<Order_details> i_List_Order_details)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Order_details_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Order_details != null)
{
foreach (var oRow in i_List_Order_details)
{
Edit_Order_details(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Order_details_List");}
}
public void Edit_Order_details_List(Params_Edit_Order_details_List i_Params_Edit_Order_details_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Order_details_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Order_details_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Order_details_List.My_List_To_Delete)
{
Delete_Order_details(new Params_Delete_Order_details() { ORDER_DETAILS_ID = oRow.ORDER_DETAILS_ID });
}
}
if (i_Params_Edit_Order_details_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Order_details_List.My_List_To_Edit)
{
Edit_Order_details(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Order_details_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Person_List(List<Person> i_List_Person)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Person != null)
{
foreach (var oRow in i_List_Person)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Person_List(Params_Edit_Person_List i_Params_Edit_Person_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Person_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Delete)
{
Delete_Person(new Params_Delete_Person() { PERSON_ID = oRow.PERSON_ID });
}
}
if (i_Params_Edit_Person_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Edit)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Product_List(List<Product> i_List_Product)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Product_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Product != null)
{
foreach (var oRow in i_List_Product)
{
Edit_Product(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Product_List");}
}
public void Edit_Product_List(Params_Edit_Product_List i_Params_Edit_Product_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Product_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Product_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Product_List.My_List_To_Delete)
{
Delete_Product(new Params_Delete_Product() { PRODUCT_ID = oRow.PRODUCT_ID });
}
}
if (i_Params_Edit_Product_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Product_List.My_List_To_Edit)
{
Edit_Product(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Product_List");}
}
public void Edit_Size_List(List<Size> i_List_Size)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Size_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Size != null)
{
foreach (var oRow in i_List_Size)
{
Edit_Size(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Size_List");}
}
public void Edit_Size_List(Params_Edit_Size_List i_Params_Edit_Size_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Size_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Size_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Size_List.My_List_To_Delete)
{
Delete_Size(new Params_Delete_Size() { SIZE_ID = oRow.SIZE_ID });
}
}
if (i_Params_Edit_Size_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Size_List.My_List_To_Edit)
{
Edit_Size(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Size_List");}
}
public void Edit_Uploaded_file_List(List<Uploaded_file> i_List_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Uploaded_file != null)
{
foreach (var oRow in i_List_Uploaded_file)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_Uploaded_file_List(Params_Edit_Uploaded_file_List i_Params_Edit_Uploaded_file_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Uploaded_file_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Delete)
{
Delete_Uploaded_file(new Params_Delete_Uploaded_file() { UPLOADED_FILE_ID = oRow.UPLOADED_FILE_ID });
}
}
if (i_Params_Edit_Uploaded_file_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Edit)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_account_List(List<User_account> i_List_User_account)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_account_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User_account != null)
{
foreach (var oRow in i_List_User_account)
{
Edit_User_account(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_account_List");}
}
public void Edit_User_account_List(Params_Edit_User_account_List i_Params_Edit_User_account_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_account_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_account_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_account_List.My_List_To_Delete)
{
Delete_User_account(new Params_Delete_User_account() { USER_ACCOUNT_ID = oRow.USER_ACCOUNT_ID });
}
}
if (i_Params_Edit_User_account_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_account_List.My_List_To_Edit)
{
Edit_User_account(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_account_List");}
}
}
}
