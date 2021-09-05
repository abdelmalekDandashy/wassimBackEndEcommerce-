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
public Address Get_Address_By_ADDRESS_ID_Adv(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID_Adv(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
return oAddress;
}
public Adress Get_Adress_By_ADRESS_ID_Adv(Params_Get_Adress_By_ADRESS_ID i_Params_Get_Adress_By_ADRESS_ID)
{
Adress oAdress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_ADRESS_ID_Adv");}
#region Body Section.
DALC.Adress oDBEntry = _AppContext.Get_Adress_By_ADRESS_ID_Adv(i_Params_Get_Adress_By_ADRESS_ID.ADRESS_ID);
oAdress = new Adress();
oTools.CopyPropValues(oDBEntry, oAdress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_ADRESS_ID_Adv");}
return oAdress;
}
public Category Get_Category_By_CATEGORY_ID_Adv(Params_Get_Category_By_CATEGORY_ID i_Params_Get_Category_By_CATEGORY_ID)
{
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_Adv");}
#region Body Section.
DALC.Category oDBEntry = _AppContext.Get_Category_By_CATEGORY_ID_Adv(i_Params_Get_Category_By_CATEGORY_ID.CATEGORY_ID);
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_Adv");}
return oCategory;
}
public Color Get_Color_By_COLOR_ID_Adv(Params_Get_Color_By_COLOR_ID i_Params_Get_Color_By_COLOR_ID)
{
Color oColor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_COLOR_ID_Adv");}
#region Body Section.
DALC.Color oDBEntry = _AppContext.Get_Color_By_COLOR_ID_Adv(i_Params_Get_Color_By_COLOR_ID.COLOR_ID);
oColor = new Color();
oTools.CopyPropValues(oDBEntry, oColor);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_COLOR_ID_Adv");}
return oColor;
}
public Contact Get_Contact_By_CONTACT_ID_Adv(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID_Adv(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
return oContact;
}
public Customer Get_Customer_By_CUSTOMER_ID_Adv(Params_Get_Customer_By_CUSTOMER_ID i_Params_Get_Customer_By_CUSTOMER_ID)
{
Customer oCustomer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_CUSTOMER_ID_Adv");}
#region Body Section.
DALC.Customer oDBEntry = _AppContext.Get_Customer_By_CUSTOMER_ID_Adv(i_Params_Get_Customer_By_CUSTOMER_ID.CUSTOMER_ID);
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_CUSTOMER_ID_Adv");}
return oCustomer;
}
public Invoice Get_Invoice_By_INVOICE_ID_Adv(Params_Get_Invoice_By_INVOICE_ID i_Params_Get_Invoice_By_INVOICE_ID)
{
Invoice oInvoice = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_ID_Adv");}
#region Body Section.
DALC.Invoice oDBEntry = _AppContext.Get_Invoice_By_INVOICE_ID_Adv(i_Params_Get_Invoice_By_INVOICE_ID.INVOICE_ID);
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_ID_Adv");}
return oInvoice;
}
public Invoice_status Get_Invoice_status_By_INVOICE_STATUS_ID_Adv(Params_Get_Invoice_status_By_INVOICE_STATUS_ID i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID)
{
Invoice_status oInvoice_status = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID_Adv");}
#region Body Section.
DALC.Invoice_status oDBEntry = _AppContext.Get_Invoice_status_By_INVOICE_STATUS_ID_Adv(i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID);
oInvoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry, oInvoice_status);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID_Adv");}
return oInvoice_status;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
return oLoc_l4;
}
public Order_details Get_Order_details_By_ORDER_DETAILS_ID_Adv(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID)
{
Order_details oOrder_details = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_ORDER_DETAILS_ID_Adv");}
#region Body Section.
DALC.Order_details oDBEntry = _AppContext.Get_Order_details_By_ORDER_DETAILS_ID_Adv(i_Params_Get_Order_details_By_ORDER_DETAILS_ID.ORDER_DETAILS_ID);
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_ORDER_DETAILS_ID_Adv");}
return oOrder_details;
}
public Person Get_Person_By_PERSON_ID_Adv(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_Adv");}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID_Adv(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_Adv");}
return oPerson;
}
public Product Get_Product_By_PRODUCT_ID_Adv(Params_Get_Product_By_PRODUCT_ID i_Params_Get_Product_By_PRODUCT_ID)
{
Product oProduct = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_PRODUCT_ID_Adv");}
#region Body Section.
DALC.Product oDBEntry = _AppContext.Get_Product_By_PRODUCT_ID_Adv(i_Params_Get_Product_By_PRODUCT_ID.PRODUCT_ID);
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_PRODUCT_ID_Adv");}
return oProduct;
}
public Size Get_Size_By_SIZE_ID_Adv(Params_Get_Size_By_SIZE_ID i_Params_Get_Size_By_SIZE_ID)
{
Size oSize = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_SIZE_ID_Adv");}
#region Body Section.
DALC.Size oDBEntry = _AppContext.Get_Size_By_SIZE_ID_Adv(i_Params_Get_Size_By_SIZE_ID.SIZE_ID);
oSize = new Size();
oTools.CopyPropValues(oDBEntry, oSize);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_SIZE_ID_Adv");}
return oSize;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public User_account Get_User_account_By_USER_ACCOUNT_ID_Adv(Params_Get_User_account_By_USER_ACCOUNT_ID i_Params_Get_User_account_By_USER_ACCOUNT_ID)
{
User_account oUser_account = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ACCOUNT_ID_Adv");}
#region Body Section.
DALC.User_account oDBEntry = _AppContext.Get_User_account_By_USER_ACCOUNT_ID_Adv(i_Params_Get_User_account_By_USER_ACCOUNT_ID.USER_ACCOUNT_ID);
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ACCOUNT_ID_Adv");}
return oUser_account;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List_Adv(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
return oList;
}
public List<Adress> Get_Adress_By_ADRESS_ID_List_Adv(Params_Get_Adress_By_ADRESS_ID_List i_Params_Get_Adress_By_ADRESS_ID_List)
{
Adress oAdress = null;
List<Adress> oList = new List<Adress>();
Params_Get_Adress_By_ADRESS_ID_List_SP oParams_Get_Adress_By_ADRESS_ID_List_SP = new Params_Get_Adress_By_ADRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_ADRESS_ID_List_Adv");}
#region Body Section.
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_ADRESS_ID_List_Adv(i_Params_Get_Adress_By_ADRESS_ID_List.ADRESS_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_ADRESS_ID_List_Adv");}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List_Adv(Params_Get_Category_By_CATEGORY_ID_List i_Params_Get_Category_By_CATEGORY_ID_List)
{
Category oCategory = null;
List<Category> oList = new List<Category>();
Params_Get_Category_By_CATEGORY_ID_List_SP oParams_Get_Category_By_CATEGORY_ID_List_SP = new Params_Get_Category_By_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_CATEGORY_ID_List_Adv(i_Params_Get_Category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Color> Get_Color_By_COLOR_ID_List_Adv(Params_Get_Color_By_COLOR_ID_List i_Params_Get_Color_By_COLOR_ID_List)
{
Color oColor = null;
List<Color> oList = new List<Color>();
Params_Get_Color_By_COLOR_ID_List_SP oParams_Get_Color_By_COLOR_ID_List_SP = new Params_Get_Color_By_COLOR_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_COLOR_ID_List_Adv");}
#region Body Section.
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_COLOR_ID_List_Adv(i_Params_Get_Color_By_COLOR_ID_List.COLOR_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_COLOR_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List_Adv(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_CUSTOMER_ID_List_Adv(Params_Get_Customer_By_CUSTOMER_ID_List i_Params_Get_Customer_By_CUSTOMER_ID_List)
{
Customer oCustomer = null;
List<Customer> oList = new List<Customer>();
Params_Get_Customer_By_CUSTOMER_ID_List_SP oParams_Get_Customer_By_CUSTOMER_ID_List_SP = new Params_Get_Customer_By_CUSTOMER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_CUSTOMER_ID_List_Adv");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_CUSTOMER_ID_List_Adv(i_Params_Get_Customer_By_CUSTOMER_ID_List.CUSTOMER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_CUSTOMER_ID_List_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_ID_List_Adv(Params_Get_Invoice_By_INVOICE_ID_List i_Params_Get_Invoice_By_INVOICE_ID_List)
{
Invoice oInvoice = null;
List<Invoice> oList = new List<Invoice>();
Params_Get_Invoice_By_INVOICE_ID_List_SP oParams_Get_Invoice_By_INVOICE_ID_List_SP = new Params_Get_Invoice_By_INVOICE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_ID_List_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_INVOICE_ID_List_Adv(i_Params_Get_Invoice_By_INVOICE_ID_List.INVOICE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_ID_List_Adv");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_INVOICE_STATUS_ID_List_Adv(Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List)
{
Invoice_status oInvoice_status = null;
List<Invoice_status> oList = new List<Invoice_status>();
Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List_SP oParams_Get_Invoice_status_By_INVOICE_STATUS_ID_List_SP = new Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID_List_Adv");}
#region Body Section.
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_INVOICE_STATUS_ID_List_Adv(i_Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List.INVOICE_STATUS_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_INVOICE_STATUS_ID_List_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_List_Adv(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List)
{
Order_details oOrder_details = null;
List<Order_details> oList = new List<Order_details>();
Params_Get_Order_details_By_ORDER_DETAILS_ID_List_SP oParams_Get_Order_details_By_ORDER_DETAILS_ID_List_SP = new Params_Get_Order_details_By_ORDER_DETAILS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_ORDER_DETAILS_ID_List_Adv");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_ORDER_DETAILS_ID_List_Adv(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List.ORDER_DETAILS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_ORDER_DETAILS_ID_List_Adv");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List_Adv(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Product> Get_Product_By_PRODUCT_ID_List_Adv(Params_Get_Product_By_PRODUCT_ID_List i_Params_Get_Product_By_PRODUCT_ID_List)
{
Product oProduct = null;
List<Product> oList = new List<Product>();
Params_Get_Product_By_PRODUCT_ID_List_SP oParams_Get_Product_By_PRODUCT_ID_List_SP = new Params_Get_Product_By_PRODUCT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_PRODUCT_ID_List_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_PRODUCT_ID_List_Adv(i_Params_Get_Product_By_PRODUCT_ID_List.PRODUCT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_PRODUCT_ID_List_Adv");}
return oList;
}
public List<Size> Get_Size_By_SIZE_ID_List_Adv(Params_Get_Size_By_SIZE_ID_List i_Params_Get_Size_By_SIZE_ID_List)
{
Size oSize = null;
List<Size> oList = new List<Size>();
Params_Get_Size_By_SIZE_ID_List_SP oParams_Get_Size_By_SIZE_ID_List_SP = new Params_Get_Size_By_SIZE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_SIZE_ID_List_Adv");}
#region Body Section.
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_SIZE_ID_List_Adv(i_Params_Get_Size_By_SIZE_ID_List.SIZE_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_SIZE_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_USER_ACCOUNT_ID_List_Adv(Params_Get_User_account_By_USER_ACCOUNT_ID_List i_Params_Get_User_account_By_USER_ACCOUNT_ID_List)
{
User_account oUser_account = null;
List<User_account> oList = new List<User_account>();
Params_Get_User_account_By_USER_ACCOUNT_ID_List_SP oParams_Get_User_account_By_USER_ACCOUNT_ID_List_SP = new Params_Get_User_account_By_USER_ACCOUNT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ACCOUNT_ID_List_Adv");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_USER_ACCOUNT_ID_List_Adv(i_Params_Get_User_account_By_USER_ACCOUNT_ID_List.USER_ACCOUNT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ACCOUNT_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_Adv(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_Adv(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_Adv(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_Adv(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID_Adv(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_Adv(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
return oList;
}
public List<Adress> Get_Adress_By_OWNER_ID_Adv(Params_Get_Adress_By_OWNER_ID i_Params_Get_Adress_By_OWNER_ID)
{
List<Adress> oList = new List<Adress>();
Adress oAdress = new Adress();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_OWNER_ID_Adv(i_Params_Get_Adress_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_OWNER_ID_Adv");}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID_Adv(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_OWNER_ID_Adv(i_Params_Get_Category_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_OWNER_ID_Adv");}
return oList;
}
public List<Color> Get_Color_By_OWNER_ID_Adv(Params_Get_Color_By_OWNER_ID i_Params_Get_Color_By_OWNER_ID)
{
List<Color> oList = new List<Color>();
Color oColor = new Color();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_OWNER_ID_Adv(i_Params_Get_Color_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_OWNER_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_Adv(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID_Adv(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_OWNER_ID_Adv(Params_Get_Customer_By_OWNER_ID i_Params_Get_Customer_By_OWNER_ID)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_OWNER_ID_Adv(i_Params_Get_Customer_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_OWNER_ID_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID_Adv(Params_Get_Customer_By_ADRESS_ID i_Params_Get_Customer_By_ADRESS_ID)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_ADRESS_ID_Adv");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_ADRESS_ID_Adv(i_Params_Get_Customer_By_ADRESS_ID.ADRESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_ADRESS_ID_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID_Adv(Params_Get_Customer_By_USER_ID i_Params_Get_Customer_By_USER_ID)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_USER_ID_Adv");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_USER_ID_Adv(i_Params_Get_Customer_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_USER_ID_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_OWNER_ID_Adv(Params_Get_Invoice_By_OWNER_ID i_Params_Get_Invoice_By_OWNER_ID)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_OWNER_ID_Adv(i_Params_Get_Invoice_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_OWNER_ID_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_ORDER_DETAILS_ID_Adv(Params_Get_Invoice_By_ORDER_DETAILS_ID i_Params_Get_Invoice_By_ORDER_DETAILS_ID)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_ORDER_DETAILS_ID_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_ORDER_DETAILS_ID_Adv(i_Params_Get_Invoice_By_ORDER_DETAILS_ID.ORDER_DETAILS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_ORDER_DETAILS_ID_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_STATUS_ID_Adv(Params_Get_Invoice_By_INVOICE_STATUS_ID i_Params_Get_Invoice_By_INVOICE_STATUS_ID)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_STATUS_ID_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_INVOICE_STATUS_ID_Adv(i_Params_Get_Invoice_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_STATUS_ID_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_USER_ACCOUNT_ID_Adv(Params_Get_Invoice_By_USER_ACCOUNT_ID i_Params_Get_Invoice_By_USER_ACCOUNT_ID)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_USER_ACCOUNT_ID_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_USER_ACCOUNT_ID_Adv(i_Params_Get_Invoice_By_USER_ACCOUNT_ID.USER_ACCOUNT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_USER_ACCOUNT_ID_Adv");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_OWNER_ID_Adv(Params_Get_Invoice_status_By_OWNER_ID i_Params_Get_Invoice_status_By_OWNER_ID)
{
List<Invoice_status> oList = new List<Invoice_status>();
Invoice_status oInvoice_status = new Invoice_status();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_OWNER_ID_Adv(i_Params_Get_Invoice_status_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE_Adv(i_Params_Get_Loc_l1_By_CODE.CODE);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID_Adv(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID_Adv(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID_Adv(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID_Adv(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_OWNER_ID_Adv(Params_Get_Order_details_By_OWNER_ID i_Params_Get_Order_details_By_OWNER_ID)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_OWNER_ID_Adv(i_Params_Get_Order_details_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_OWNER_ID_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID_Adv(Params_Get_Order_details_By_PRODUCT_ID i_Params_Get_Order_details_By_PRODUCT_ID)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_PRODUCT_ID_Adv");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_PRODUCT_ID_Adv(i_Params_Get_Order_details_By_PRODUCT_ID.PRODUCT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_PRODUCT_ID_Adv");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID_Adv(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID_Adv");}
return oList;
}
public List<Product> Get_Product_By_OWNER_ID_Adv(Params_Get_Product_By_OWNER_ID i_Params_Get_Product_By_OWNER_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_OWNER_ID_Adv(i_Params_Get_Product_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_OWNER_ID_Adv");}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID_Adv(Params_Get_Product_By_CATEGORY_ID i_Params_Get_Product_By_CATEGORY_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_CATEGORY_ID_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_CATEGORY_ID_Adv(i_Params_Get_Product_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_CATEGORY_ID_Adv");}
return oList;
}
public List<Product> Get_Product_By_IS_BEST_SELLING_Adv(Params_Get_Product_By_IS_BEST_SELLING i_Params_Get_Product_By_IS_BEST_SELLING)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_IS_BEST_SELLING_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_IS_BEST_SELLING_Adv(i_Params_Get_Product_By_IS_BEST_SELLING.IS_BEST_SELLING);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_IS_BEST_SELLING_Adv");}
return oList;
}
public List<Product> Get_Product_By_IS_RECOMMENDED_Adv(Params_Get_Product_By_IS_RECOMMENDED i_Params_Get_Product_By_IS_RECOMMENDED)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_IS_RECOMMENDED_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_IS_RECOMMENDED_Adv(i_Params_Get_Product_By_IS_RECOMMENDED.IS_RECOMMENDED);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_IS_RECOMMENDED_Adv");}
return oList;
}
public List<Product> Get_Product_By_COLOR_ID_Adv(Params_Get_Product_By_COLOR_ID i_Params_Get_Product_By_COLOR_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_COLOR_ID_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_COLOR_ID_Adv(i_Params_Get_Product_By_COLOR_ID.COLOR_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_COLOR_ID_Adv");}
return oList;
}
public List<Product> Get_Product_By_SIZE_ID_Adv(Params_Get_Product_By_SIZE_ID i_Params_Get_Product_By_SIZE_ID)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_SIZE_ID_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_SIZE_ID_Adv(i_Params_Get_Product_By_SIZE_ID.SIZE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_SIZE_ID_Adv");}
return oList;
}
public List<Size> Get_Size_By_OWNER_ID_Adv(Params_Get_Size_By_OWNER_ID i_Params_Get_Size_By_OWNER_ID)
{
List<Size> oList = new List<Size>();
Size oSize = new Size();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_OWNER_ID_Adv(i_Params_Get_Size_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME_Adv(i_Params_Get_User_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_OWNER_ID_Adv(Params_Get_User_account_By_OWNER_ID i_Params_Get_User_account_By_OWNER_ID)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_OWNER_ID_Adv(i_Params_Get_User_account_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_OWNER_ID_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_USER_ID_Adv(Params_Get_User_account_By_USER_ID i_Params_Get_User_account_By_USER_ID)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ID_Adv");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_USER_ID_Adv(i_Params_Get_User_account_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ID_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_ADRESS_ID_Adv(Params_Get_User_account_By_ADRESS_ID i_Params_Get_User_account_By_ADRESS_ID)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_ADRESS_ID_Adv");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_ADRESS_ID_Adv(i_Params_Get_User_account_By_ADRESS_ID.ADRESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_ADRESS_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List_Adv(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List_Adv(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List_Adv(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List_Adv(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List_Adv(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List_Adv(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID_List_Adv(Params_Get_Customer_By_ADRESS_ID_List i_Params_Get_Customer_By_ADRESS_ID_List)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_ADRESS_ID_List_Adv");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_ADRESS_ID_List_Adv(i_Params_Get_Customer_By_ADRESS_ID_List.ADRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_ADRESS_ID_List_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID_List_Adv(Params_Get_Customer_By_USER_ID_List i_Params_Get_Customer_By_USER_ID_List)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_USER_ID_List_Adv(i_Params_Get_Customer_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_USER_ID_List_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_ORDER_DETAILS_ID_List_Adv(Params_Get_Invoice_By_ORDER_DETAILS_ID_List i_Params_Get_Invoice_By_ORDER_DETAILS_ID_List)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_ORDER_DETAILS_ID_List_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_ORDER_DETAILS_ID_List_Adv(i_Params_Get_Invoice_By_ORDER_DETAILS_ID_List.ORDER_DETAILS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_ORDER_DETAILS_ID_List_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_STATUS_ID_List_Adv(Params_Get_Invoice_By_INVOICE_STATUS_ID_List i_Params_Get_Invoice_By_INVOICE_STATUS_ID_List)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_INVOICE_STATUS_ID_List_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_INVOICE_STATUS_ID_List_Adv(i_Params_Get_Invoice_By_INVOICE_STATUS_ID_List.INVOICE_STATUS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_INVOICE_STATUS_ID_List_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_USER_ACCOUNT_ID_List_Adv(Params_Get_Invoice_By_USER_ACCOUNT_ID_List i_Params_Get_Invoice_By_USER_ACCOUNT_ID_List)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_USER_ACCOUNT_ID_List_Adv");}
#region Body Section.
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_USER_ACCOUNT_ID_List_Adv(i_Params_Get_Invoice_By_USER_ACCOUNT_ID_List.USER_ACCOUNT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_USER_ACCOUNT_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID_List_Adv(Params_Get_Order_details_By_PRODUCT_ID_List i_Params_Get_Order_details_By_PRODUCT_ID_List)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_PRODUCT_ID_List_Adv");}
#region Body Section.
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_PRODUCT_ID_List_Adv(i_Params_Get_Order_details_By_PRODUCT_ID_List.PRODUCT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_PRODUCT_ID_List_Adv");}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID_List_Adv(Params_Get_Product_By_CATEGORY_ID_List i_Params_Get_Product_By_CATEGORY_ID_List)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_CATEGORY_ID_List_Adv(i_Params_Get_Product_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Product> Get_Product_By_COLOR_ID_List_Adv(Params_Get_Product_By_COLOR_ID_List i_Params_Get_Product_By_COLOR_ID_List)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_COLOR_ID_List_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_COLOR_ID_List_Adv(i_Params_Get_Product_By_COLOR_ID_List.COLOR_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_COLOR_ID_List_Adv");}
return oList;
}
public List<Product> Get_Product_By_SIZE_ID_List_Adv(Params_Get_Product_By_SIZE_ID_List i_Params_Get_Product_By_SIZE_ID_List)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_SIZE_ID_List_Adv");}
#region Body Section.
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_SIZE_ID_List_Adv(i_Params_Get_Product_By_SIZE_ID_List.SIZE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_SIZE_ID_List_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_USER_ID_List_Adv(Params_Get_User_account_By_USER_ID_List i_Params_Get_User_account_By_USER_ID_List)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_USER_ID_List_Adv(i_Params_Get_User_account_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_USER_ID_List_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_ADRESS_ID_List_Adv(Params_Get_User_account_By_ADRESS_ID_List i_Params_Get_User_account_By_ADRESS_ID_List)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_ADRESS_ID_List_Adv");}
#region Body Section.
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_ADRESS_ID_List_Adv(i_Params_Get_User_account_By_ADRESS_ID_List.ADRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_ADRESS_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv_V2");}
return oList;
}
public List<Adress> Get_Adress_By_Criteria_Adv(Params_Get_Adress_By_Criteria i_Params_Get_Adress_By_Criteria)
{
List<Adress> oList = new List<Adress>();
long? tmp_TOTAL_COUNT = 0;
Adress oAdress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Adress_By_Criteria.OWNER_ID == null) || (i_Params_Get_Adress_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Adress_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Adress_By_Criteria.START_ROW == null) { i_Params_Get_Adress_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Adress_By_Criteria.END_ROW == null) || (i_Params_Get_Adress_By_Criteria.END_ROW == 0)) { i_Params_Get_Adress_By_Criteria.END_ROW = 1000000; }
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_Criteria_Adv(i_Params_Get_Adress_By_Criteria.STREET_NAME_ONE,i_Params_Get_Adress_By_Criteria.STREET_NAME_TWO,i_Params_Get_Adress_By_Criteria.STATE,i_Params_Get_Adress_By_Criteria.POST_CODE,i_Params_Get_Adress_By_Criteria.OWNER_ID,i_Params_Get_Adress_By_Criteria.START_ROW,i_Params_Get_Adress_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_Criteria_Adv");}
return oList;
}
public List<Adress> Get_Adress_By_Where_Adv(Params_Get_Adress_By_Where i_Params_Get_Adress_By_Where)
{
List<Adress> oList = new List<Adress>();
long? tmp_TOTAL_COUNT = 0;
Adress oAdress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Adress_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Adress_By_Where.OWNER_ID == null) || (i_Params_Get_Adress_By_Where.OWNER_ID == 0)) { i_Params_Get_Adress_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Adress_By_Where.START_ROW == null) { i_Params_Get_Adress_By_Where.START_ROW = 0; }
if ((i_Params_Get_Adress_By_Where.END_ROW == null) || (i_Params_Get_Adress_By_Where.END_ROW == 0)) { i_Params_Get_Adress_By_Where.END_ROW = 1000000; }
List<DALC.Adress> oList_DBEntries = _AppContext.Get_Adress_By_Where_Adv(i_Params_Get_Adress_By_Where.STREET_NAME_ONE,i_Params_Get_Adress_By_Where.STREET_NAME_TWO,i_Params_Get_Adress_By_Where.STATE,i_Params_Get_Adress_By_Where.POST_CODE,i_Params_Get_Adress_By_Where.OWNER_ID,i_Params_Get_Adress_By_Where.START_ROW,i_Params_Get_Adress_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Adress_By_Where_Adv");}
return oList;
}
public List<Category> Get_Category_By_Criteria_Adv(Params_Get_Category_By_Criteria i_Params_Get_Category_By_Criteria)
{
List<Category> oList = new List<Category>();
long? tmp_TOTAL_COUNT = 0;
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Criteria.START_ROW == null) { i_Params_Get_Category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_By_Criteria.END_ROW == null) || (i_Params_Get_Category_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_By_Criteria.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Criteria_Adv(i_Params_Get_Category_By_Criteria.NAME,i_Params_Get_Category_By_Criteria.OWNER_ID,i_Params_Get_Category_By_Criteria.START_ROW,i_Params_Get_Category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Criteria_Adv");}
return oList;
}
public List<Category> Get_Category_By_Where_Adv(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
List<Category> oList = new List<Category>();
long? tmp_TOTAL_COUNT = 0;
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Category_By_Where.OWNER_ID == null) || (i_Params_Get_Category_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Where.START_ROW == null) { i_Params_Get_Category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_By_Where.END_ROW == null) || (i_Params_Get_Category_By_Where.END_ROW == 0)) { i_Params_Get_Category_By_Where.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Where_Adv(i_Params_Get_Category_By_Where.NAME,i_Params_Get_Category_By_Where.OWNER_ID,i_Params_Get_Category_By_Where.START_ROW,i_Params_Get_Category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Where_Adv");}
return oList;
}
public List<Color> Get_Color_By_Criteria_Adv(Params_Get_Color_By_Criteria i_Params_Get_Color_By_Criteria)
{
List<Color> oList = new List<Color>();
long? tmp_TOTAL_COUNT = 0;
Color oColor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Color_By_Criteria.OWNER_ID == null) || (i_Params_Get_Color_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Color_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Color_By_Criteria.START_ROW == null) { i_Params_Get_Color_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Color_By_Criteria.END_ROW == null) || (i_Params_Get_Color_By_Criteria.END_ROW == 0)) { i_Params_Get_Color_By_Criteria.END_ROW = 1000000; }
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_Criteria_Adv(i_Params_Get_Color_By_Criteria.NAME,i_Params_Get_Color_By_Criteria.OWNER_ID,i_Params_Get_Color_By_Criteria.START_ROW,i_Params_Get_Color_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_Criteria_Adv");}
return oList;
}
public List<Color> Get_Color_By_Where_Adv(Params_Get_Color_By_Where i_Params_Get_Color_By_Where)
{
List<Color> oList = new List<Color>();
long? tmp_TOTAL_COUNT = 0;
Color oColor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Color_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Color_By_Where.OWNER_ID == null) || (i_Params_Get_Color_By_Where.OWNER_ID == 0)) { i_Params_Get_Color_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Color_By_Where.START_ROW == null) { i_Params_Get_Color_By_Where.START_ROW = 0; }
if ((i_Params_Get_Color_By_Where.END_ROW == null) || (i_Params_Get_Color_By_Where.END_ROW == 0)) { i_Params_Get_Color_By_Where.END_ROW = 1000000; }
List<DALC.Color> oList_DBEntries = _AppContext.Get_Color_By_Where_Adv(i_Params_Get_Color_By_Where.NAME,i_Params_Get_Color_By_Where.OWNER_ID,i_Params_Get_Color_By_Where.START_ROW,i_Params_Get_Color_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Color_By_Where_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_Adv(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_Adv(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_Criteria_Adv(Params_Get_Customer_By_Criteria i_Params_Get_Customer_By_Criteria)
{
List<Customer> oList = new List<Customer>();
long? tmp_TOTAL_COUNT = 0;
Customer oCustomer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Customer_By_Criteria.OWNER_ID == null) || (i_Params_Get_Customer_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Customer_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Customer_By_Criteria.START_ROW == null) { i_Params_Get_Customer_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Customer_By_Criteria.END_ROW == null) || (i_Params_Get_Customer_By_Criteria.END_ROW == 0)) { i_Params_Get_Customer_By_Criteria.END_ROW = 1000000; }
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Criteria_Adv(i_Params_Get_Customer_By_Criteria.FIRST_NAME,i_Params_Get_Customer_By_Criteria.LAST_NAME,i_Params_Get_Customer_By_Criteria.PHONE,i_Params_Get_Customer_By_Criteria.OWNER_ID,i_Params_Get_Customer_By_Criteria.START_ROW,i_Params_Get_Customer_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Criteria_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_Where_Adv(Params_Get_Customer_By_Where i_Params_Get_Customer_By_Where)
{
List<Customer> oList = new List<Customer>();
long? tmp_TOTAL_COUNT = 0;
Customer oCustomer = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Customer_By_Where.OWNER_ID == null) || (i_Params_Get_Customer_By_Where.OWNER_ID == 0)) { i_Params_Get_Customer_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Customer_By_Where.START_ROW == null) { i_Params_Get_Customer_By_Where.START_ROW = 0; }
if ((i_Params_Get_Customer_By_Where.END_ROW == null) || (i_Params_Get_Customer_By_Where.END_ROW == 0)) { i_Params_Get_Customer_By_Where.END_ROW = 1000000; }
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Where_Adv(i_Params_Get_Customer_By_Where.FIRST_NAME,i_Params_Get_Customer_By_Where.LAST_NAME,i_Params_Get_Customer_By_Where.PHONE,i_Params_Get_Customer_By_Where.OWNER_ID,i_Params_Get_Customer_By_Where.START_ROW,i_Params_Get_Customer_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Where_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria_Adv(Params_Get_Invoice_By_Criteria i_Params_Get_Invoice_By_Criteria)
{
List<Invoice> oList = new List<Invoice>();
long? tmp_TOTAL_COUNT = 0;
Invoice oInvoice = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Invoice_By_Criteria.OWNER_ID == null) || (i_Params_Get_Invoice_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Invoice_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_By_Criteria.START_ROW == null) { i_Params_Get_Invoice_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Invoice_By_Criteria.END_ROW == null) || (i_Params_Get_Invoice_By_Criteria.END_ROW == 0)) { i_Params_Get_Invoice_By_Criteria.END_ROW = 1000000; }
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Criteria_Adv(i_Params_Get_Invoice_By_Criteria.DESCRIPTION,i_Params_Get_Invoice_By_Criteria.OWNER_ID,i_Params_Get_Invoice_By_Criteria.START_ROW,i_Params_Get_Invoice_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Criteria_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_Where_Adv(Params_Get_Invoice_By_Where i_Params_Get_Invoice_By_Where)
{
List<Invoice> oList = new List<Invoice>();
long? tmp_TOTAL_COUNT = 0;
Invoice oInvoice = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Invoice_By_Where.OWNER_ID == null) || (i_Params_Get_Invoice_By_Where.OWNER_ID == 0)) { i_Params_Get_Invoice_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_By_Where.START_ROW == null) { i_Params_Get_Invoice_By_Where.START_ROW = 0; }
if ((i_Params_Get_Invoice_By_Where.END_ROW == null) || (i_Params_Get_Invoice_By_Where.END_ROW == 0)) { i_Params_Get_Invoice_By_Where.END_ROW = 1000000; }
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Where_Adv(i_Params_Get_Invoice_By_Where.DESCRIPTION,i_Params_Get_Invoice_By_Where.OWNER_ID,i_Params_Get_Invoice_By_Where.START_ROW,i_Params_Get_Invoice_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Where_Adv");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_Criteria_Adv(Params_Get_Invoice_status_By_Criteria i_Params_Get_Invoice_status_By_Criteria)
{
List<Invoice_status> oList = new List<Invoice_status>();
long? tmp_TOTAL_COUNT = 0;
Invoice_status oInvoice_status = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Invoice_status_By_Criteria.OWNER_ID == null) || (i_Params_Get_Invoice_status_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Invoice_status_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_status_By_Criteria.START_ROW == null) { i_Params_Get_Invoice_status_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Invoice_status_By_Criteria.END_ROW == null) || (i_Params_Get_Invoice_status_By_Criteria.END_ROW == 0)) { i_Params_Get_Invoice_status_By_Criteria.END_ROW = 1000000; }
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_Criteria_Adv(i_Params_Get_Invoice_status_By_Criteria.INVOICE_STATUS,i_Params_Get_Invoice_status_By_Criteria.OWNER_ID,i_Params_Get_Invoice_status_By_Criteria.START_ROW,i_Params_Get_Invoice_status_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_Criteria_Adv");}
return oList;
}
public List<Invoice_status> Get_Invoice_status_By_Where_Adv(Params_Get_Invoice_status_By_Where i_Params_Get_Invoice_status_By_Where)
{
List<Invoice_status> oList = new List<Invoice_status>();
long? tmp_TOTAL_COUNT = 0;
Invoice_status oInvoice_status = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_status_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Invoice_status_By_Where.OWNER_ID == null) || (i_Params_Get_Invoice_status_By_Where.OWNER_ID == 0)) { i_Params_Get_Invoice_status_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Invoice_status_By_Where.START_ROW == null) { i_Params_Get_Invoice_status_By_Where.START_ROW = 0; }
if ((i_Params_Get_Invoice_status_By_Where.END_ROW == null) || (i_Params_Get_Invoice_status_By_Where.END_ROW == 0)) { i_Params_Get_Invoice_status_By_Where.END_ROW = 1000000; }
List<DALC.Invoice_status> oList_DBEntries = _AppContext.Get_Invoice_status_By_Where_Adv(i_Params_Get_Invoice_status_By_Where.INVOICE_STATUS,i_Params_Get_Invoice_status_By_Where.OWNER_ID,i_Params_Get_Invoice_status_By_Where.START_ROW,i_Params_Get_Invoice_status_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_status_By_Where_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria_Adv(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where_Adv(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_Adv(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_Adv(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_Adv(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_Adv(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_Adv(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_Adv(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria_Adv(Params_Get_Order_details_By_Criteria i_Params_Get_Order_details_By_Criteria)
{
List<Order_details> oList = new List<Order_details>();
long? tmp_TOTAL_COUNT = 0;
Order_details oOrder_details = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Order_details_By_Criteria.OWNER_ID == null) || (i_Params_Get_Order_details_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Order_details_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Order_details_By_Criteria.START_ROW == null) { i_Params_Get_Order_details_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Order_details_By_Criteria.END_ROW == null) || (i_Params_Get_Order_details_By_Criteria.END_ROW == 0)) { i_Params_Get_Order_details_By_Criteria.END_ROW = 1000000; }
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Criteria_Adv(i_Params_Get_Order_details_By_Criteria.DESCRIPTION,i_Params_Get_Order_details_By_Criteria.OWNER_ID,i_Params_Get_Order_details_By_Criteria.START_ROW,i_Params_Get_Order_details_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Criteria_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_Where_Adv(Params_Get_Order_details_By_Where i_Params_Get_Order_details_By_Where)
{
List<Order_details> oList = new List<Order_details>();
long? tmp_TOTAL_COUNT = 0;
Order_details oOrder_details = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Order_details_By_Where.OWNER_ID == null) || (i_Params_Get_Order_details_By_Where.OWNER_ID == 0)) { i_Params_Get_Order_details_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Order_details_By_Where.START_ROW == null) { i_Params_Get_Order_details_By_Where.START_ROW = 0; }
if ((i_Params_Get_Order_details_By_Where.END_ROW == null) || (i_Params_Get_Order_details_By_Where.END_ROW == 0)) { i_Params_Get_Order_details_By_Where.END_ROW = 1000000; }
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Where_Adv(i_Params_Get_Order_details_By_Where.DESCRIPTION,i_Params_Get_Order_details_By_Where.OWNER_ID,i_Params_Get_Order_details_By_Where.START_ROW,i_Params_Get_Order_details_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Where_Adv");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv_V2");}
return oList;
}
public List<Product> Get_Product_By_Criteria_Adv(Params_Get_Product_By_Criteria i_Params_Get_Product_By_Criteria)
{
List<Product> oList = new List<Product>();
long? tmp_TOTAL_COUNT = 0;
Product oProduct = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Product_By_Criteria.OWNER_ID == null) || (i_Params_Get_Product_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Product_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Product_By_Criteria.START_ROW == null) { i_Params_Get_Product_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Product_By_Criteria.END_ROW == null) || (i_Params_Get_Product_By_Criteria.END_ROW == 0)) { i_Params_Get_Product_By_Criteria.END_ROW = 1000000; }
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Criteria_Adv(i_Params_Get_Product_By_Criteria.NAME,i_Params_Get_Product_By_Criteria.DESCRIPTION,i_Params_Get_Product_By_Criteria.OWNER_ID,i_Params_Get_Product_By_Criteria.START_ROW,i_Params_Get_Product_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Criteria_Adv");}
return oList;
}
public List<Product> Get_Product_By_Where_Adv(Params_Get_Product_By_Where i_Params_Get_Product_By_Where)
{
List<Product> oList = new List<Product>();
long? tmp_TOTAL_COUNT = 0;
Product oProduct = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Where_Adv");}
#region PreEvent_Get_Product_By_Where_Adv
if (OnPreEvent_Get_Product_By_Where_Adv != null)
{
OnPreEvent_Get_Product_By_Where_Adv(i_Params_Get_Product_By_Where);
}
#endregion
#region Body Section.
if ((i_Params_Get_Product_By_Where.OWNER_ID == null) || (i_Params_Get_Product_By_Where.OWNER_ID == 0)) { i_Params_Get_Product_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Product_By_Where.START_ROW == null) { i_Params_Get_Product_By_Where.START_ROW = 0; }
if ((i_Params_Get_Product_By_Where.END_ROW == null) || (i_Params_Get_Product_By_Where.END_ROW == 0)) { i_Params_Get_Product_By_Where.END_ROW = 1000000; }
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Where_Adv(i_Params_Get_Product_By_Where.NAME,i_Params_Get_Product_By_Where.DESCRIPTION,i_Params_Get_Product_By_Where.OWNER_ID,i_Params_Get_Product_By_Where.START_ROW,i_Params_Get_Product_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
#region PostEvent_Get_Product_By_Where_Adv
if (OnPostEvent_Get_Product_By_Where_Adv != null)
{
OnPostEvent_Get_Product_By_Where_Adv(oList,i_Params_Get_Product_By_Where);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Where_Adv");}
return oList;
}
public List<Size> Get_Size_By_Criteria_Adv(Params_Get_Size_By_Criteria i_Params_Get_Size_By_Criteria)
{
List<Size> oList = new List<Size>();
long? tmp_TOTAL_COUNT = 0;
Size oSize = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Size_By_Criteria.OWNER_ID == null) || (i_Params_Get_Size_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Size_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Size_By_Criteria.START_ROW == null) { i_Params_Get_Size_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Size_By_Criteria.END_ROW == null) || (i_Params_Get_Size_By_Criteria.END_ROW == 0)) { i_Params_Get_Size_By_Criteria.END_ROW = 1000000; }
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_Criteria_Adv(i_Params_Get_Size_By_Criteria.DESCRIPTION,i_Params_Get_Size_By_Criteria.OWNER_ID,i_Params_Get_Size_By_Criteria.START_ROW,i_Params_Get_Size_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_Criteria_Adv");}
return oList;
}
public List<Size> Get_Size_By_Where_Adv(Params_Get_Size_By_Where i_Params_Get_Size_By_Where)
{
List<Size> oList = new List<Size>();
long? tmp_TOTAL_COUNT = 0;
Size oSize = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Size_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Size_By_Where.OWNER_ID == null) || (i_Params_Get_Size_By_Where.OWNER_ID == 0)) { i_Params_Get_Size_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Size_By_Where.START_ROW == null) { i_Params_Get_Size_By_Where.START_ROW = 0; }
if ((i_Params_Get_Size_By_Where.END_ROW == null) || (i_Params_Get_Size_By_Where.END_ROW == 0)) { i_Params_Get_Size_By_Where.END_ROW = 1000000; }
List<DALC.Size> oList_DBEntries = _AppContext.Get_Size_By_Where_Adv(i_Params_Get_Size_By_Where.DESCRIPTION,i_Params_Get_Size_By_Where.OWNER_ID,i_Params_Get_Size_By_Where.START_ROW,i_Params_Get_Size_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Size_By_Where_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.EMAIL,i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.PHONE,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv");}
return oList;
}
public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.EMAIL,i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.PHONE,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_Criteria_Adv(Params_Get_User_account_By_Criteria i_Params_Get_User_account_By_Criteria)
{
List<User_account> oList = new List<User_account>();
long? tmp_TOTAL_COUNT = 0;
User_account oUser_account = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_User_account_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_account_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_account_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_account_By_Criteria.START_ROW == null) { i_Params_Get_User_account_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_account_By_Criteria.END_ROW == null) || (i_Params_Get_User_account_By_Criteria.END_ROW == 0)) { i_Params_Get_User_account_By_Criteria.END_ROW = 1000000; }
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Criteria_Adv(i_Params_Get_User_account_By_Criteria.DESCRIPTION,i_Params_Get_User_account_By_Criteria.OWNER_ID,i_Params_Get_User_account_By_Criteria.START_ROW,i_Params_Get_User_account_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Criteria_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_Where_Adv(Params_Get_User_account_By_Where i_Params_Get_User_account_By_Where)
{
List<User_account> oList = new List<User_account>();
long? tmp_TOTAL_COUNT = 0;
User_account oUser_account = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_User_account_By_Where.OWNER_ID == null) || (i_Params_Get_User_account_By_Where.OWNER_ID == 0)) { i_Params_Get_User_account_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_account_By_Where.START_ROW == null) { i_Params_Get_User_account_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_account_By_Where.END_ROW == null) || (i_Params_Get_User_account_By_Where.END_ROW == 0)) { i_Params_Get_User_account_By_Where.END_ROW = 1000000; }
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Where_Adv(i_Params_Get_User_account_By_Where.DESCRIPTION,i_Params_Get_User_account_By_Where.OWNER_ID,i_Params_Get_User_account_By_Where.START_ROW,i_Params_Get_User_account_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Where_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv_V2");}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv_V2");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList_Adv");}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList_Adv(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList_Adv");}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList_Adv(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_Criteria_InList_Adv(Params_Get_Customer_By_Criteria_InList i_Params_Get_Customer_By_Criteria_InList)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Customer_By_Criteria_InList_SP oParams_Get_Customer_By_Criteria_InList_SP = new Params_Get_Customer_By_Criteria_InList_SP();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
Params_Get_Adress_By_ADRESS_ID oParams_Get_Adress_By_ADRESS_ID = new Params_Get_Adress_By_ADRESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Criteria_InList_Adv");}
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
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Criteria_InList_Adv(i_Params_Get_Customer_By_Criteria_InList.FIRST_NAME,i_Params_Get_Customer_By_Criteria_InList.LAST_NAME,i_Params_Get_Customer_By_Criteria_InList.PHONE,i_Params_Get_Customer_By_Criteria_InList.USER_ID_LIST,i_Params_Get_Customer_By_Criteria_InList.ADRESS_ID_LIST,i_Params_Get_Customer_By_Criteria_InList.OWNER_ID,i_Params_Get_Customer_By_Criteria_InList.START_ROW,i_Params_Get_Customer_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Customer_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Customer_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Criteria_InList_Adv");}
return oList;
}
public List<Customer> Get_Customer_By_Where_InList_Adv(Params_Get_Customer_By_Where_InList i_Params_Get_Customer_By_Where_InList)
{
List<Customer> oList = new List<Customer>();
Customer oCustomer = new Customer();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Customer_By_Where_InList_SP oParams_Get_Customer_By_Where_InList_SP = new Params_Get_Customer_By_Where_InList_SP();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
Params_Get_Adress_By_ADRESS_ID oParams_Get_Adress_By_ADRESS_ID = new Params_Get_Adress_By_ADRESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Customer_By_Where_InList_Adv");}
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
List<DALC.Customer> oList_DBEntries = _AppContext.Get_Customer_By_Where_InList_Adv(i_Params_Get_Customer_By_Where_InList.FIRST_NAME,i_Params_Get_Customer_By_Where_InList.LAST_NAME,i_Params_Get_Customer_By_Where_InList.PHONE,i_Params_Get_Customer_By_Where_InList.USER_ID_LIST,i_Params_Get_Customer_By_Where_InList.ADRESS_ID_LIST,i_Params_Get_Customer_By_Where_InList.OWNER_ID,i_Params_Get_Customer_By_Where_InList.START_ROW,i_Params_Get_Customer_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCustomer = new Customer();
oTools.CopyPropValues(oDBEntry, oCustomer);
oCustomer.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oCustomer.My_User);
oCustomer.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oCustomer.My_Adress);
oList.Add(oCustomer);
}
}
i_Params_Get_Customer_By_Where_InList.TOTAL_COUNT = oParams_Get_Customer_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Customer_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Customer_By_Where_InList_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria_InList_Adv(Params_Get_Invoice_By_Criteria_InList i_Params_Get_Invoice_By_Criteria_InList)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Invoice_By_Criteria_InList_SP oParams_Get_Invoice_By_Criteria_InList_SP = new Params_Get_Invoice_By_Criteria_InList_SP();
Params_Get_User_account_By_USER_ACCOUNT_ID oParams_Get_User_account_By_USER_ACCOUNT_ID = new Params_Get_User_account_By_USER_ACCOUNT_ID();
Params_Get_Order_details_By_ORDER_DETAILS_ID oParams_Get_Order_details_By_ORDER_DETAILS_ID = new Params_Get_Order_details_By_ORDER_DETAILS_ID();
Params_Get_Invoice_status_By_INVOICE_STATUS_ID oParams_Get_Invoice_status_By_INVOICE_STATUS_ID = new Params_Get_Invoice_status_By_INVOICE_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Criteria_InList_Adv");}
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
if ( i_Params_Get_Invoice_By_Criteria_InList.ORDER_DETAILS_ID_LIST == null)
{
i_Params_Get_Invoice_By_Criteria_InList.ORDER_DETAILS_ID_LIST = new List<Int32?>();
}
oParams_Get_Invoice_By_Criteria_InList_SP.ORDER_DETAILS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Invoice_By_Criteria_InList.ORDER_DETAILS_ID_LIST);
if ( i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST == null)
{
i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Invoice_By_Criteria_InList_SP.INVOICE_STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST);
oParams_Get_Invoice_By_Criteria_InList_SP.START_ROW = i_Params_Get_Invoice_By_Criteria_InList.START_ROW;
oParams_Get_Invoice_By_Criteria_InList_SP.END_ROW = i_Params_Get_Invoice_By_Criteria_InList.END_ROW;
oParams_Get_Invoice_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Invoice_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Criteria_InList_Adv(i_Params_Get_Invoice_By_Criteria_InList.DESCRIPTION,i_Params_Get_Invoice_By_Criteria_InList.USER_ACCOUNT_ID_LIST,i_Params_Get_Invoice_By_Criteria_InList.ORDER_DETAILS_ID_LIST,i_Params_Get_Invoice_By_Criteria_InList.INVOICE_STATUS_ID_LIST,i_Params_Get_Invoice_By_Criteria_InList.OWNER_ID,i_Params_Get_Invoice_By_Criteria_InList.START_ROW,i_Params_Get_Invoice_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Invoice_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Invoice_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Criteria_InList_Adv");}
return oList;
}
public List<Invoice> Get_Invoice_By_Where_InList_Adv(Params_Get_Invoice_By_Where_InList i_Params_Get_Invoice_By_Where_InList)
{
List<Invoice> oList = new List<Invoice>();
Invoice oInvoice = new Invoice();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Invoice_By_Where_InList_SP oParams_Get_Invoice_By_Where_InList_SP = new Params_Get_Invoice_By_Where_InList_SP();
Params_Get_User_account_By_USER_ACCOUNT_ID oParams_Get_User_account_By_USER_ACCOUNT_ID = new Params_Get_User_account_By_USER_ACCOUNT_ID();
Params_Get_Order_details_By_ORDER_DETAILS_ID oParams_Get_Order_details_By_ORDER_DETAILS_ID = new Params_Get_Order_details_By_ORDER_DETAILS_ID();
Params_Get_Invoice_status_By_INVOICE_STATUS_ID oParams_Get_Invoice_status_By_INVOICE_STATUS_ID = new Params_Get_Invoice_status_By_INVOICE_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Invoice_By_Where_InList_Adv");}
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
if ( i_Params_Get_Invoice_By_Where_InList.ORDER_DETAILS_ID_LIST == null)
{
i_Params_Get_Invoice_By_Where_InList.ORDER_DETAILS_ID_LIST = new List<Int32?>();
}
oParams_Get_Invoice_By_Where_InList_SP.ORDER_DETAILS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Invoice_By_Where_InList.ORDER_DETAILS_ID_LIST);
if ( i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST == null)
{
i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Invoice_By_Where_InList_SP.INVOICE_STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST);
oParams_Get_Invoice_By_Where_InList_SP.START_ROW = i_Params_Get_Invoice_By_Where_InList.START_ROW;
oParams_Get_Invoice_By_Where_InList_SP.END_ROW = i_Params_Get_Invoice_By_Where_InList.END_ROW;
oParams_Get_Invoice_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Invoice_By_Where_InList.TOTAL_COUNT;
List<DALC.Invoice> oList_DBEntries = _AppContext.Get_Invoice_By_Where_InList_Adv(i_Params_Get_Invoice_By_Where_InList.DESCRIPTION,i_Params_Get_Invoice_By_Where_InList.USER_ACCOUNT_ID_LIST,i_Params_Get_Invoice_By_Where_InList.ORDER_DETAILS_ID_LIST,i_Params_Get_Invoice_By_Where_InList.INVOICE_STATUS_ID_LIST,i_Params_Get_Invoice_By_Where_InList.OWNER_ID,i_Params_Get_Invoice_By_Where_InList.START_ROW,i_Params_Get_Invoice_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oInvoice = new Invoice();
oTools.CopyPropValues(oDBEntry, oInvoice);
oInvoice.My_User_account = new User_account();
oTools.CopyPropValues(oDBEntry.My_User_account, oInvoice.My_User_account);
oInvoice.My_Order_details = new Order_details();
oTools.CopyPropValues(oDBEntry.My_Order_details, oInvoice.My_Order_details);
oInvoice.My_Invoice_status = new Invoice_status();
oTools.CopyPropValues(oDBEntry.My_Invoice_status, oInvoice.My_Invoice_status);
oList.Add(oInvoice);
}
}
i_Params_Get_Invoice_By_Where_InList.TOTAL_COUNT = oParams_Get_Invoice_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Invoice_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Invoice_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList_Adv(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList_Adv(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList_Adv(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList_Adv(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList_Adv(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList_Adv(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria_InList_Adv(Params_Get_Order_details_By_Criteria_InList i_Params_Get_Order_details_By_Criteria_InList)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Order_details_By_Criteria_InList_SP oParams_Get_Order_details_By_Criteria_InList_SP = new Params_Get_Order_details_By_Criteria_InList_SP();
Params_Get_Product_By_PRODUCT_ID oParams_Get_Product_By_PRODUCT_ID = new Params_Get_Product_By_PRODUCT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Criteria_InList_Adv");}
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
oParams_Get_Order_details_By_Criteria_InList_SP.START_ROW = i_Params_Get_Order_details_By_Criteria_InList.START_ROW;
oParams_Get_Order_details_By_Criteria_InList_SP.END_ROW = i_Params_Get_Order_details_By_Criteria_InList.END_ROW;
oParams_Get_Order_details_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Order_details_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Criteria_InList_Adv(i_Params_Get_Order_details_By_Criteria_InList.DESCRIPTION,i_Params_Get_Order_details_By_Criteria_InList.PRODUCT_ID_LIST,i_Params_Get_Order_details_By_Criteria_InList.OWNER_ID,i_Params_Get_Order_details_By_Criteria_InList.START_ROW,i_Params_Get_Order_details_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Order_details_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Order_details_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Criteria_InList_Adv");}
return oList;
}
public List<Order_details> Get_Order_details_By_Where_InList_Adv(Params_Get_Order_details_By_Where_InList i_Params_Get_Order_details_By_Where_InList)
{
List<Order_details> oList = new List<Order_details>();
Order_details oOrder_details = new Order_details();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Order_details_By_Where_InList_SP oParams_Get_Order_details_By_Where_InList_SP = new Params_Get_Order_details_By_Where_InList_SP();
Params_Get_Product_By_PRODUCT_ID oParams_Get_Product_By_PRODUCT_ID = new Params_Get_Product_By_PRODUCT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Order_details_By_Where_InList_Adv");}
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
oParams_Get_Order_details_By_Where_InList_SP.START_ROW = i_Params_Get_Order_details_By_Where_InList.START_ROW;
oParams_Get_Order_details_By_Where_InList_SP.END_ROW = i_Params_Get_Order_details_By_Where_InList.END_ROW;
oParams_Get_Order_details_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Order_details_By_Where_InList.TOTAL_COUNT;
List<DALC.Order_details> oList_DBEntries = _AppContext.Get_Order_details_By_Where_InList_Adv(i_Params_Get_Order_details_By_Where_InList.DESCRIPTION,i_Params_Get_Order_details_By_Where_InList.PRODUCT_ID_LIST,i_Params_Get_Order_details_By_Where_InList.OWNER_ID,i_Params_Get_Order_details_By_Where_InList.START_ROW,i_Params_Get_Order_details_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOrder_details = new Order_details();
oTools.CopyPropValues(oDBEntry, oOrder_details);
oOrder_details.My_Product = new Product();
oTools.CopyPropValues(oDBEntry.My_Product, oOrder_details.My_Product);
oList.Add(oOrder_details);
}
}
i_Params_Get_Order_details_By_Where_InList.TOTAL_COUNT = oParams_Get_Order_details_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Order_details_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Order_details_By_Where_InList_Adv");}
return oList;
}
public List<Product> Get_Product_By_Criteria_InList_Adv(Params_Get_Product_By_Criteria_InList i_Params_Get_Product_By_Criteria_InList)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Product_By_Criteria_InList_SP oParams_Get_Product_By_Criteria_InList_SP = new Params_Get_Product_By_Criteria_InList_SP();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
Params_Get_Color_By_COLOR_ID oParams_Get_Color_By_COLOR_ID = new Params_Get_Color_By_COLOR_ID();
Params_Get_Size_By_SIZE_ID oParams_Get_Size_By_SIZE_ID = new Params_Get_Size_By_SIZE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Criteria_InList_Adv");}
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
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Criteria_InList_Adv(i_Params_Get_Product_By_Criteria_InList.NAME,i_Params_Get_Product_By_Criteria_InList.DESCRIPTION,i_Params_Get_Product_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Product_By_Criteria_InList.COLOR_ID_LIST,i_Params_Get_Product_By_Criteria_InList.SIZE_ID_LIST,i_Params_Get_Product_By_Criteria_InList.OWNER_ID,i_Params_Get_Product_By_Criteria_InList.START_ROW,i_Params_Get_Product_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Product_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Product_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Criteria_InList_Adv");}
return oList;
}
public List<Product> Get_Product_By_Where_InList_Adv(Params_Get_Product_By_Where_InList i_Params_Get_Product_By_Where_InList)
{
List<Product> oList = new List<Product>();
Product oProduct = new Product();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Product_By_Where_InList_SP oParams_Get_Product_By_Where_InList_SP = new Params_Get_Product_By_Where_InList_SP();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
Params_Get_Color_By_COLOR_ID oParams_Get_Color_By_COLOR_ID = new Params_Get_Color_By_COLOR_ID();
Params_Get_Size_By_SIZE_ID oParams_Get_Size_By_SIZE_ID = new Params_Get_Size_By_SIZE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Product_By_Where_InList_Adv");}
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
List<DALC.Product> oList_DBEntries = _AppContext.Get_Product_By_Where_InList_Adv(i_Params_Get_Product_By_Where_InList.NAME,i_Params_Get_Product_By_Where_InList.DESCRIPTION,i_Params_Get_Product_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Product_By_Where_InList.COLOR_ID_LIST,i_Params_Get_Product_By_Where_InList.SIZE_ID_LIST,i_Params_Get_Product_By_Where_InList.OWNER_ID,i_Params_Get_Product_By_Where_InList.START_ROW,i_Params_Get_Product_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProduct = new Product();
oTools.CopyPropValues(oDBEntry, oProduct);
oProduct.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oProduct.My_Category);
oProduct.My_Color = new Color();
oTools.CopyPropValues(oDBEntry.My_Color, oProduct.My_Color);
oProduct.My_Size = new Size();
oTools.CopyPropValues(oDBEntry.My_Size, oProduct.My_Size);
oList.Add(oProduct);
}
}
i_Params_Get_Product_By_Where_InList.TOTAL_COUNT = oParams_Get_Product_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Product_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Product_By_Where_InList_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_Criteria_InList_Adv(Params_Get_User_account_By_Criteria_InList i_Params_Get_User_account_By_Criteria_InList)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_User_account_By_Criteria_InList_SP oParams_Get_User_account_By_Criteria_InList_SP = new Params_Get_User_account_By_Criteria_InList_SP();
Params_Get_Adress_By_ADRESS_ID oParams_Get_Adress_By_ADRESS_ID = new Params_Get_Adress_By_ADRESS_ID();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Criteria_InList_Adv");}
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
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Criteria_InList_Adv(i_Params_Get_User_account_By_Criteria_InList.DESCRIPTION,i_Params_Get_User_account_By_Criteria_InList.ADRESS_ID_LIST,i_Params_Get_User_account_By_Criteria_InList.USER_ID_LIST,i_Params_Get_User_account_By_Criteria_InList.OWNER_ID,i_Params_Get_User_account_By_Criteria_InList.START_ROW,i_Params_Get_User_account_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Criteria_InList.TOTAL_COUNT = oParams_Get_User_account_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_User_account_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Criteria_InList_Adv");}
return oList;
}
public List<User_account> Get_User_account_By_Where_InList_Adv(Params_Get_User_account_By_Where_InList i_Params_Get_User_account_By_Where_InList)
{
List<User_account> oList = new List<User_account>();
User_account oUser_account = new User_account();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_User_account_By_Where_InList_SP oParams_Get_User_account_By_Where_InList_SP = new Params_Get_User_account_By_Where_InList_SP();
Params_Get_Adress_By_ADRESS_ID oParams_Get_Adress_By_ADRESS_ID = new Params_Get_Adress_By_ADRESS_ID();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_account_By_Where_InList_Adv");}
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
List<DALC.User_account> oList_DBEntries = _AppContext.Get_User_account_By_Where_InList_Adv(i_Params_Get_User_account_By_Where_InList.DESCRIPTION,i_Params_Get_User_account_By_Where_InList.ADRESS_ID_LIST,i_Params_Get_User_account_By_Where_InList.USER_ID_LIST,i_Params_Get_User_account_By_Where_InList.OWNER_ID,i_Params_Get_User_account_By_Where_InList.START_ROW,i_Params_Get_User_account_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser_account = new User_account();
oTools.CopyPropValues(oDBEntry, oUser_account);
oUser_account.My_Adress = new Adress();
oTools.CopyPropValues(oDBEntry.My_Adress, oUser_account.My_Adress);
oUser_account.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oUser_account.My_User);
oList.Add(oUser_account);
}
}
i_Params_Get_User_account_By_Where_InList.TOTAL_COUNT = oParams_Get_User_account_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_User_account_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_account_By_Where_InList_Adv");}
return oList;
}
}
}
