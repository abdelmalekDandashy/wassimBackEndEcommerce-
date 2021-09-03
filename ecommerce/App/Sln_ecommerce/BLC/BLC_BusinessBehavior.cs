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
#region Reset_Customer_By_Adress
public void Reset_Customer_By_Adress(Adress i_Adress, List<Customer> i_Customer_List)
{
#region Declaration And Initialization Section.
Params_Delete_Customer_By_ADRESS_ID oParams_Delete_Customer_By_ADRESS_ID = new Params_Delete_Customer_By_ADRESS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Customer_By_Adress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Customer
//---------------------------------
oParams_Delete_Customer_By_ADRESS_ID.ADRESS_ID = i_Adress.ADRESS_ID;
Delete_Customer_By_ADRESS_ID(oParams_Delete_Customer_By_ADRESS_ID);
//---------------------------------
// Edit Customer
//---------------------------------
Edit_Adress_WithCustomer(i_Adress, i_Customer_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Customer_By_Adress");}
}
#endregion
#region Reset_Customer_By_Adress
public void Reset_Customer_By_Adress(Adress i_Adress, List<Customer> i_Customer_List_To_Delete,List<Customer> i_Customer_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Customer oParams_Delete_Customer = new Params_Delete_Customer();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Customer_By_Adress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Customer_List_To_Delete != null)
{
foreach (var oRow in i_Customer_List_To_Delete)
{
oParams_Delete_Customer.CUSTOMER_ID = oRow.CUSTOMER_ID;
Delete_Customer(oParams_Delete_Customer);
}
}
//---------------------------------
// Edit Customer
//---------------------------------
Edit_Adress_WithCustomer(i_Adress, i_Customer_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Customer_By_Adress");}
}
#endregion
#region Edit_Adress_With_Customer(Adress i_Adress,List<Customer> i_CustomerList)
public void Edit_Adress_WithCustomer(Adress i_Adress,List<Customer> i_List_Customer)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Adress_WithCustomer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Adress(i_Adress);
if (i_List_Customer != null)
{
foreach(Customer oCustomer in i_List_Customer)
{
oCustomer.ADRESS_ID = i_Adress.ADRESS_ID;
Edit_Customer(oCustomer);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Adress_WithCustomer");}
}
#endregion
#region Reset_User_account_By_Adress
public void Reset_User_account_By_Adress(Adress i_Adress, List<User_account> i_User_account_List)
{
#region Declaration And Initialization Section.
Params_Delete_User_account_By_ADRESS_ID oParams_Delete_User_account_By_ADRESS_ID = new Params_Delete_User_account_By_ADRESS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_User_account_By_Adress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing User_account
//---------------------------------
oParams_Delete_User_account_By_ADRESS_ID.ADRESS_ID = i_Adress.ADRESS_ID;
Delete_User_account_By_ADRESS_ID(oParams_Delete_User_account_By_ADRESS_ID);
//---------------------------------
// Edit User_account
//---------------------------------
Edit_Adress_WithUser_account(i_Adress, i_User_account_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_User_account_By_Adress");}
}
#endregion
#region Reset_User_account_By_Adress
public void Reset_User_account_By_Adress(Adress i_Adress, List<User_account> i_User_account_List_To_Delete,List<User_account> i_User_account_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_User_account oParams_Delete_User_account = new Params_Delete_User_account();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_User_account_By_Adress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_User_account_List_To_Delete != null)
{
foreach (var oRow in i_User_account_List_To_Delete)
{
oParams_Delete_User_account.USER_ACCOUNT_ID = oRow.USER_ACCOUNT_ID;
Delete_User_account(oParams_Delete_User_account);
}
}
//---------------------------------
// Edit User_account
//---------------------------------
Edit_Adress_WithUser_account(i_Adress, i_User_account_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_User_account_By_Adress");}
}
#endregion
#region Edit_Adress_With_User_account(Adress i_Adress,List<User_account> i_User_accountList)
public void Edit_Adress_WithUser_account(Adress i_Adress,List<User_account> i_List_User_account)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Adress_WithUser_account");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Adress(i_Adress);
if (i_List_User_account != null)
{
foreach(User_account oUser_account in i_List_User_account)
{
oUser_account.ADRESS_ID = i_Adress.ADRESS_ID;
Edit_User_account(oUser_account);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Adress_WithUser_account");}
}
#endregion
#region Edit_Adress_WithRelatedData(Adress i_Adress,List<Customer> i_List_Customer,List<User_account> i_List_User_account)
public void Edit_Adress_WithRelatedData(Adress i_Adress,List<Customer> i_List_Customer,List<User_account> i_List_User_account)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Adress_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Adress(i_Adress);
if (i_List_Customer != null)
{
foreach(Customer oCustomer in i_List_Customer)
{
oCustomer.ADRESS_ID = i_Adress.ADRESS_ID;
Edit_Customer(oCustomer);
}
}
if (i_List_User_account != null)
{
foreach(User_account oUser_account in i_List_User_account)
{
oUser_account.ADRESS_ID = i_Adress.ADRESS_ID;
Edit_User_account(oUser_account);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Adress_WithRelatedData");}
}
#endregion
#region Delete_Adress_With_Children(Adress i_Adress)
public void Delete_Adress_With_Children(Adress i_Adress)
{
 #region Declaration And Initialization Section.
Params_Delete_Adress oParams_Delete_Adress = new Params_Delete_Adress();
Params_Delete_Customer_By_ADRESS_ID oParams_Delete_Customer_By_ADRESS_ID = new Params_Delete_Customer_By_ADRESS_ID();
Params_Delete_User_account_By_ADRESS_ID oParams_Delete_User_account_By_ADRESS_ID = new Params_Delete_User_account_By_ADRESS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Adress_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Customer_By_ADRESS_ID.ADRESS_ID = i_Adress.ADRESS_ID;
Delete_Customer_By_ADRESS_ID(oParams_Delete_Customer_By_ADRESS_ID);
oParams_Delete_User_account_By_ADRESS_ID.ADRESS_ID = i_Adress.ADRESS_ID;
Delete_User_account_By_ADRESS_ID(oParams_Delete_User_account_By_ADRESS_ID);
//-------------------------

//-------------------------
oParams_Delete_Adress.ADRESS_ID = i_Adress.ADRESS_ID;
Delete_Adress(oParams_Delete_Adress);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Adress_With_Children");}
}
#endregion
#region Reset_Product_By_Category
public void Reset_Product_By_Category(Category i_Category, List<Product> i_Product_List)
{
#region Declaration And Initialization Section.
Params_Delete_Product_By_CATEGORY_ID oParams_Delete_Product_By_CATEGORY_ID = new Params_Delete_Product_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Product_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Product
//---------------------------------
oParams_Delete_Product_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Product_By_CATEGORY_ID(oParams_Delete_Product_By_CATEGORY_ID);
//---------------------------------
// Edit Product
//---------------------------------
Edit_Category_WithProduct(i_Category, i_Product_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Product_By_Category");}
}
#endregion
#region Reset_Product_By_Category
public void Reset_Product_By_Category(Category i_Category, List<Product> i_Product_List_To_Delete,List<Product> i_Product_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Product oParams_Delete_Product = new Params_Delete_Product();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Product_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Product_List_To_Delete != null)
{
foreach (var oRow in i_Product_List_To_Delete)
{
oParams_Delete_Product.PRODUCT_ID = oRow.PRODUCT_ID;
Delete_Product(oParams_Delete_Product);
}
}
//---------------------------------
// Edit Product
//---------------------------------
Edit_Category_WithProduct(i_Category, i_Product_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Product_By_Category");}
}
#endregion
#region Edit_Category_With_Product(Category i_Category,List<Product> i_ProductList)
public void Edit_Category_WithProduct(Category i_Category,List<Product> i_List_Product)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithProduct");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Product != null)
{
foreach(Product oProduct in i_List_Product)
{
oProduct.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Product(oProduct);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithProduct");}
}
#endregion
#region Edit_Category_WithRelatedData(Category i_Category,List<Product> i_List_Product)
public void Edit_Category_WithRelatedData(Category i_Category,List<Product> i_List_Product)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Product != null)
{
foreach(Product oProduct in i_List_Product)
{
oProduct.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Product(oProduct);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithRelatedData");}
}
#endregion
#region Delete_Category_With_Children(Category i_Category)
public void Delete_Category_With_Children(Category i_Category)
{
 #region Declaration And Initialization Section.
Params_Delete_Category oParams_Delete_Category = new Params_Delete_Category();
Params_Delete_Product_By_CATEGORY_ID oParams_Delete_Product_By_CATEGORY_ID = new Params_Delete_Product_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Product_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Product_By_CATEGORY_ID(oParams_Delete_Product_By_CATEGORY_ID);
//-------------------------

//-------------------------
oParams_Delete_Category.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Category(oParams_Delete_Category);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_With_Children");}
}
#endregion
#region Reset_Product_By_Color
public void Reset_Product_By_Color(Color i_Color, List<Product> i_Product_List)
{
#region Declaration And Initialization Section.
Params_Delete_Product_By_COLOR_ID oParams_Delete_Product_By_COLOR_ID = new Params_Delete_Product_By_COLOR_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Product_By_Color");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Product
//---------------------------------
oParams_Delete_Product_By_COLOR_ID.COLOR_ID = i_Color.COLOR_ID;
Delete_Product_By_COLOR_ID(oParams_Delete_Product_By_COLOR_ID);
//---------------------------------
// Edit Product
//---------------------------------
Edit_Color_WithProduct(i_Color, i_Product_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Product_By_Color");}
}
#endregion
#region Reset_Product_By_Color
public void Reset_Product_By_Color(Color i_Color, List<Product> i_Product_List_To_Delete,List<Product> i_Product_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Product oParams_Delete_Product = new Params_Delete_Product();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Product_By_Color");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Product_List_To_Delete != null)
{
foreach (var oRow in i_Product_List_To_Delete)
{
oParams_Delete_Product.PRODUCT_ID = oRow.PRODUCT_ID;
Delete_Product(oParams_Delete_Product);
}
}
//---------------------------------
// Edit Product
//---------------------------------
Edit_Color_WithProduct(i_Color, i_Product_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Product_By_Color");}
}
#endregion
#region Edit_Color_With_Product(Color i_Color,List<Product> i_ProductList)
public void Edit_Color_WithProduct(Color i_Color,List<Product> i_List_Product)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Color_WithProduct");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Color(i_Color);
if (i_List_Product != null)
{
foreach(Product oProduct in i_List_Product)
{
oProduct.COLOR_ID = i_Color.COLOR_ID;
Edit_Product(oProduct);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Color_WithProduct");}
}
#endregion
#region Edit_Color_WithRelatedData(Color i_Color,List<Product> i_List_Product)
public void Edit_Color_WithRelatedData(Color i_Color,List<Product> i_List_Product)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Color_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Color(i_Color);
if (i_List_Product != null)
{
foreach(Product oProduct in i_List_Product)
{
oProduct.COLOR_ID = i_Color.COLOR_ID;
Edit_Product(oProduct);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Color_WithRelatedData");}
}
#endregion
#region Delete_Color_With_Children(Color i_Color)
public void Delete_Color_With_Children(Color i_Color)
{
 #region Declaration And Initialization Section.
Params_Delete_Color oParams_Delete_Color = new Params_Delete_Color();
Params_Delete_Product_By_COLOR_ID oParams_Delete_Product_By_COLOR_ID = new Params_Delete_Product_By_COLOR_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Color_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Product_By_COLOR_ID.COLOR_ID = i_Color.COLOR_ID;
Delete_Product_By_COLOR_ID(oParams_Delete_Product_By_COLOR_ID);
//-------------------------

//-------------------------
oParams_Delete_Color.COLOR_ID = i_Color.COLOR_ID;
Delete_Color(oParams_Delete_Color);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Color_With_Children");}
}
#endregion
#region Reset_Invoice_By_Customer
public void Reset_Invoice_By_Customer(Customer i_Customer, List<Invoice> i_Invoice_List)
{
#region Declaration And Initialization Section.
Params_Delete_Invoice_By_CUSTOMER_ID oParams_Delete_Invoice_By_CUSTOMER_ID = new Params_Delete_Invoice_By_CUSTOMER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Invoice_By_Customer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Invoice
//---------------------------------
oParams_Delete_Invoice_By_CUSTOMER_ID.CUSTOMER_ID = i_Customer.CUSTOMER_ID;
Delete_Invoice_By_CUSTOMER_ID(oParams_Delete_Invoice_By_CUSTOMER_ID);
//---------------------------------
// Edit Invoice
//---------------------------------
Edit_Customer_WithInvoice(i_Customer, i_Invoice_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Invoice_By_Customer");}
}
#endregion
#region Reset_Invoice_By_Customer
public void Reset_Invoice_By_Customer(Customer i_Customer, List<Invoice> i_Invoice_List_To_Delete,List<Invoice> i_Invoice_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Invoice oParams_Delete_Invoice = new Params_Delete_Invoice();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Invoice_By_Customer");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Invoice_List_To_Delete != null)
{
foreach (var oRow in i_Invoice_List_To_Delete)
{
oParams_Delete_Invoice.INVOICE_ID = oRow.INVOICE_ID;
Delete_Invoice(oParams_Delete_Invoice);
}
}
//---------------------------------
// Edit Invoice
//---------------------------------
Edit_Customer_WithInvoice(i_Customer, i_Invoice_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Invoice_By_Customer");}
}
#endregion
#region Edit_Customer_With_Invoice(Customer i_Customer,List<Invoice> i_InvoiceList)
public void Edit_Customer_WithInvoice(Customer i_Customer,List<Invoice> i_List_Invoice)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Customer_WithInvoice");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Customer(i_Customer);
if (i_List_Invoice != null)
{
foreach(Invoice oInvoice in i_List_Invoice)
{
oInvoice.CUSTOMER_ID = i_Customer.CUSTOMER_ID;
Edit_Invoice(oInvoice);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Customer_WithInvoice");}
}
#endregion
#region Edit_Customer_WithRelatedData(Customer i_Customer,List<Invoice> i_List_Invoice)
public void Edit_Customer_WithRelatedData(Customer i_Customer,List<Invoice> i_List_Invoice)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Customer_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Customer(i_Customer);
if (i_List_Invoice != null)
{
foreach(Invoice oInvoice in i_List_Invoice)
{
oInvoice.CUSTOMER_ID = i_Customer.CUSTOMER_ID;
Edit_Invoice(oInvoice);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Customer_WithRelatedData");}
}
#endregion
#region Delete_Customer_With_Children(Customer i_Customer)
public void Delete_Customer_With_Children(Customer i_Customer)
{
 #region Declaration And Initialization Section.
Params_Delete_Customer oParams_Delete_Customer = new Params_Delete_Customer();
Params_Delete_Invoice_By_CUSTOMER_ID oParams_Delete_Invoice_By_CUSTOMER_ID = new Params_Delete_Invoice_By_CUSTOMER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Customer_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Invoice_By_CUSTOMER_ID.CUSTOMER_ID = i_Customer.CUSTOMER_ID;
Delete_Invoice_By_CUSTOMER_ID(oParams_Delete_Invoice_By_CUSTOMER_ID);
//-------------------------

//-------------------------
oParams_Delete_Customer.CUSTOMER_ID = i_Customer.CUSTOMER_ID;
Delete_Customer(oParams_Delete_Customer);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Customer_With_Children");}
}
#endregion
#region Reset_Invoice_By_Invoice_status
public void Reset_Invoice_By_Invoice_status(Invoice_status i_Invoice_status, List<Invoice> i_Invoice_List)
{
#region Declaration And Initialization Section.
Params_Delete_Invoice_By_INVOICE_STATUS_ID oParams_Delete_Invoice_By_INVOICE_STATUS_ID = new Params_Delete_Invoice_By_INVOICE_STATUS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Invoice_By_Invoice_status");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Invoice
//---------------------------------
oParams_Delete_Invoice_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID = i_Invoice_status.INVOICE_STATUS_ID;
Delete_Invoice_By_INVOICE_STATUS_ID(oParams_Delete_Invoice_By_INVOICE_STATUS_ID);
//---------------------------------
// Edit Invoice
//---------------------------------
Edit_Invoice_status_WithInvoice(i_Invoice_status, i_Invoice_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Invoice_By_Invoice_status");}
}
#endregion
#region Reset_Invoice_By_Invoice_status
public void Reset_Invoice_By_Invoice_status(Invoice_status i_Invoice_status, List<Invoice> i_Invoice_List_To_Delete,List<Invoice> i_Invoice_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Invoice oParams_Delete_Invoice = new Params_Delete_Invoice();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Invoice_By_Invoice_status");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Invoice_List_To_Delete != null)
{
foreach (var oRow in i_Invoice_List_To_Delete)
{
oParams_Delete_Invoice.INVOICE_ID = oRow.INVOICE_ID;
Delete_Invoice(oParams_Delete_Invoice);
}
}
//---------------------------------
// Edit Invoice
//---------------------------------
Edit_Invoice_status_WithInvoice(i_Invoice_status, i_Invoice_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Invoice_By_Invoice_status");}
}
#endregion
#region Edit_Invoice_status_With_Invoice(Invoice_status i_Invoice_status,List<Invoice> i_InvoiceList)
public void Edit_Invoice_status_WithInvoice(Invoice_status i_Invoice_status,List<Invoice> i_List_Invoice)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice_status_WithInvoice");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Invoice_status(i_Invoice_status);
if (i_List_Invoice != null)
{
foreach(Invoice oInvoice in i_List_Invoice)
{
oInvoice.INVOICE_STATUS_ID = i_Invoice_status.INVOICE_STATUS_ID;
Edit_Invoice(oInvoice);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice_status_WithInvoice");}
}
#endregion
#region Edit_Invoice_status_WithRelatedData(Invoice_status i_Invoice_status,List<Invoice> i_List_Invoice)
public void Edit_Invoice_status_WithRelatedData(Invoice_status i_Invoice_status,List<Invoice> i_List_Invoice)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Invoice_status_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Invoice_status(i_Invoice_status);
if (i_List_Invoice != null)
{
foreach(Invoice oInvoice in i_List_Invoice)
{
oInvoice.INVOICE_STATUS_ID = i_Invoice_status.INVOICE_STATUS_ID;
Edit_Invoice(oInvoice);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Invoice_status_WithRelatedData");}
}
#endregion
#region Delete_Invoice_status_With_Children(Invoice_status i_Invoice_status)
public void Delete_Invoice_status_With_Children(Invoice_status i_Invoice_status)
{
 #region Declaration And Initialization Section.
Params_Delete_Invoice_status oParams_Delete_Invoice_status = new Params_Delete_Invoice_status();
Params_Delete_Invoice_By_INVOICE_STATUS_ID oParams_Delete_Invoice_By_INVOICE_STATUS_ID = new Params_Delete_Invoice_By_INVOICE_STATUS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Invoice_status_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Invoice_By_INVOICE_STATUS_ID.INVOICE_STATUS_ID = i_Invoice_status.INVOICE_STATUS_ID;
Delete_Invoice_By_INVOICE_STATUS_ID(oParams_Delete_Invoice_By_INVOICE_STATUS_ID);
//-------------------------

//-------------------------
oParams_Delete_Invoice_status.INVOICE_STATUS_ID = i_Invoice_status.INVOICE_STATUS_ID;
Delete_Invoice_status(oParams_Delete_Invoice_status);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Invoice_status_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Address(Loc_l1 i_Loc_l1,List<Address> i_AddressList)
public void Edit_Loc_l1_WithAddress(Loc_l1 i_Loc_l1,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithAddress");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l2
//---------------------------------
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List_To_Delete,List<Loc_l2> i_Loc_l2_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l2_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l2_List_To_Delete)
{
oParams_Delete_Loc_l2.LOC_L2_ID = oRow.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
}
}
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Loc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_Loc_l2List)
public void Edit_Loc_l1_WithLoc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithLoc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithLoc_l2");}
}
#endregion
#region Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
public void Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithRelatedData");}
}
#endregion
#region Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
public void Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l1 oParams_Delete_Loc_l1 = new Params_Delete_Loc_l1();
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l1.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l1(oParams_Delete_Loc_l1);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Address(Loc_l2 i_Loc_l2,List<Address> i_AddressList)
public void Edit_Loc_l2_WithAddress(Loc_l2 i_Loc_l2,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithAddress");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l3
//---------------------------------
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List_To_Delete,List<Loc_l3> i_Loc_l3_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l3_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l3_List_To_Delete)
{
oParams_Delete_Loc_l3.LOC_L3_ID = oRow.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
}
}
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Loc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_Loc_l3List)
public void Edit_Loc_l2_WithLoc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithLoc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithLoc_l3");}
}
#endregion
#region Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
public void Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithRelatedData");}
}
#endregion
#region Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
public void Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l2.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Address(Loc_l3 i_Loc_l3,List<Address> i_AddressList)
public void Edit_Loc_l3_WithAddress(Loc_l3 i_Loc_l3,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithAddress");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l4
//---------------------------------
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List_To_Delete,List<Loc_l4> i_Loc_l4_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l4_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l4_List_To_Delete)
{
oParams_Delete_Loc_l4.LOC_L4_ID = oRow.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
}
}
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Loc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_Loc_l4List)
public void Edit_Loc_l3_WithLoc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithLoc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithLoc_l4");}
}
#endregion
#region Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
public void Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithRelatedData");}
}
#endregion
#region Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
public void Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l3.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Edit_Loc_l4_With_Address(Loc_l4 i_Loc_l4,List<Address> i_AddressList)
public void Edit_Loc_l4_WithAddress(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithAddress");}
}
#endregion
#region Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
public void Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithRelatedData");}
}
#endregion
#region Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
public void Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l4.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_With_Children");}
}
#endregion
#region Reset_Invoice_By_Order_details
public void Reset_Invoice_By_Order_details(Order_details i_Order_details, List<Invoice> i_Invoice_List)
{
#region Declaration And Initialization Section.
Params_Delete_Invoice_By_ORDER_DETAILS_ID oParams_Delete_Invoice_By_ORDER_DETAILS_ID = new Params_Delete_Invoice_By_ORDER_DETAILS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Invoice_By_Order_details");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Invoice
//---------------------------------
oParams_Delete_Invoice_By_ORDER_DETAILS_ID.ORDER_DETAILS_ID = i_Order_details.ORDER_DETAILS_ID;
Delete_Invoice_By_ORDER_DETAILS_ID(oParams_Delete_Invoice_By_ORDER_DETAILS_ID);
//---------------------------------
// Edit Invoice
//---------------------------------
Edit_Order_details_WithInvoice(i_Order_details, i_Invoice_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Invoice_By_Order_details");}
}
#endregion
#region Reset_Invoice_By_Order_details
public void Reset_Invoice_By_Order_details(Order_details i_Order_details, List<Invoice> i_Invoice_List_To_Delete,List<Invoice> i_Invoice_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Invoice oParams_Delete_Invoice = new Params_Delete_Invoice();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Invoice_By_Order_details");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Invoice_List_To_Delete != null)
{
foreach (var oRow in i_Invoice_List_To_Delete)
{
oParams_Delete_Invoice.INVOICE_ID = oRow.INVOICE_ID;
Delete_Invoice(oParams_Delete_Invoice);
}
}
//---------------------------------
// Edit Invoice
//---------------------------------
Edit_Order_details_WithInvoice(i_Order_details, i_Invoice_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Invoice_By_Order_details");}
}
#endregion
#region Edit_Order_details_With_Invoice(Order_details i_Order_details,List<Invoice> i_InvoiceList)
public void Edit_Order_details_WithInvoice(Order_details i_Order_details,List<Invoice> i_List_Invoice)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Order_details_WithInvoice");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Order_details(i_Order_details);
if (i_List_Invoice != null)
{
foreach(Invoice oInvoice in i_List_Invoice)
{
oInvoice.ORDER_DETAILS_ID = i_Order_details.ORDER_DETAILS_ID;
Edit_Invoice(oInvoice);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Order_details_WithInvoice");}
}
#endregion
#region Edit_Order_details_WithRelatedData(Order_details i_Order_details,List<Invoice> i_List_Invoice)
public void Edit_Order_details_WithRelatedData(Order_details i_Order_details,List<Invoice> i_List_Invoice)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Order_details_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Order_details(i_Order_details);
if (i_List_Invoice != null)
{
foreach(Invoice oInvoice in i_List_Invoice)
{
oInvoice.ORDER_DETAILS_ID = i_Order_details.ORDER_DETAILS_ID;
Edit_Invoice(oInvoice);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Order_details_WithRelatedData");}
}
#endregion
#region Delete_Order_details_With_Children(Order_details i_Order_details)
public void Delete_Order_details_With_Children(Order_details i_Order_details)
{
 #region Declaration And Initialization Section.
Params_Delete_Order_details oParams_Delete_Order_details = new Params_Delete_Order_details();
Params_Delete_Invoice_By_ORDER_DETAILS_ID oParams_Delete_Invoice_By_ORDER_DETAILS_ID = new Params_Delete_Invoice_By_ORDER_DETAILS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Order_details_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Invoice_By_ORDER_DETAILS_ID.ORDER_DETAILS_ID = i_Order_details.ORDER_DETAILS_ID;
Delete_Invoice_By_ORDER_DETAILS_ID(oParams_Delete_Invoice_By_ORDER_DETAILS_ID);
//-------------------------

//-------------------------
oParams_Delete_Order_details.ORDER_DETAILS_ID = i_Order_details.ORDER_DETAILS_ID;
Delete_Order_details(oParams_Delete_Order_details);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Order_details_With_Children");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Edit_Person_With_Address(Person i_Person,List<Address> i_AddressList)
public void Edit_Person_WithAddress(Person i_Person,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithAddress");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List)
{
#region Declaration And Initialization Section.
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Contact
//---------------------------------
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List_To_Delete,List<Contact> i_Contact_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Contact oParams_Delete_Contact = new Params_Delete_Contact();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Contact_List_To_Delete != null)
{
foreach (var oRow in i_Contact_List_To_Delete)
{
oParams_Delete_Contact.CONTACT_ID = oRow.CONTACT_ID;
Delete_Contact(oParams_Delete_Contact);
}
}
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Edit_Person_With_Contact(Person i_Person,List<Contact> i_ContactList)
public void Edit_Person_WithContact(Person i_Person,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithContact");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithContact");}
}
#endregion
#region Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
public void Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithRelatedData");}
}
#endregion
#region Delete_Person_With_Children(Person i_Person)
public void Delete_Person_With_Children(Person i_Person)
{
 #region Declaration And Initialization Section.
Params_Delete_Person oParams_Delete_Person = new Params_Delete_Person();
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//-------------------------

//-------------------------
oParams_Delete_Person.PERSON_ID = i_Person.PERSON_ID;
Delete_Person(oParams_Delete_Person);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_With_Children");}
}
#endregion
#region Reset_Order_details_By_Product
public void Reset_Order_details_By_Product(Product i_Product, List<Order_details> i_Order_details_List)
{
#region Declaration And Initialization Section.
Params_Delete_Order_details_By_PRODUCT_ID oParams_Delete_Order_details_By_PRODUCT_ID = new Params_Delete_Order_details_By_PRODUCT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Order_details_By_Product");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Order_details
//---------------------------------
oParams_Delete_Order_details_By_PRODUCT_ID.PRODUCT_ID = i_Product.PRODUCT_ID;
Delete_Order_details_By_PRODUCT_ID(oParams_Delete_Order_details_By_PRODUCT_ID);
//---------------------------------
// Edit Order_details
//---------------------------------
Edit_Product_WithOrder_details(i_Product, i_Order_details_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Order_details_By_Product");}
}
#endregion
#region Reset_Order_details_By_Product
public void Reset_Order_details_By_Product(Product i_Product, List<Order_details> i_Order_details_List_To_Delete,List<Order_details> i_Order_details_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Order_details oParams_Delete_Order_details = new Params_Delete_Order_details();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Order_details_By_Product");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Order_details_List_To_Delete != null)
{
foreach (var oRow in i_Order_details_List_To_Delete)
{
oParams_Delete_Order_details.ORDER_DETAILS_ID = oRow.ORDER_DETAILS_ID;
Delete_Order_details(oParams_Delete_Order_details);
}
}
//---------------------------------
// Edit Order_details
//---------------------------------
Edit_Product_WithOrder_details(i_Product, i_Order_details_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Order_details_By_Product");}
}
#endregion
#region Edit_Product_With_Order_details(Product i_Product,List<Order_details> i_Order_detailsList)
public void Edit_Product_WithOrder_details(Product i_Product,List<Order_details> i_List_Order_details)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Product_WithOrder_details");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Product(i_Product);
if (i_List_Order_details != null)
{
foreach(Order_details oOrder_details in i_List_Order_details)
{
oOrder_details.PRODUCT_ID = i_Product.PRODUCT_ID;
Edit_Order_details(oOrder_details);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Product_WithOrder_details");}
}
#endregion
#region Edit_Product_WithRelatedData(Product i_Product,List<Order_details> i_List_Order_details)
public void Edit_Product_WithRelatedData(Product i_Product,List<Order_details> i_List_Order_details)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Product_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Product(i_Product);
if (i_List_Order_details != null)
{
foreach(Order_details oOrder_details in i_List_Order_details)
{
oOrder_details.PRODUCT_ID = i_Product.PRODUCT_ID;
Edit_Order_details(oOrder_details);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Product_WithRelatedData");}
}
#endregion
#region Delete_Product_With_Children(Product i_Product)
public void Delete_Product_With_Children(Product i_Product)
{
 #region Declaration And Initialization Section.
Params_Delete_Product oParams_Delete_Product = new Params_Delete_Product();
Params_Delete_Order_details_By_PRODUCT_ID oParams_Delete_Order_details_By_PRODUCT_ID = new Params_Delete_Order_details_By_PRODUCT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Product_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Order_details_By_PRODUCT_ID.PRODUCT_ID = i_Product.PRODUCT_ID;
Delete_Order_details_By_PRODUCT_ID(oParams_Delete_Order_details_By_PRODUCT_ID);
//-------------------------

//-------------------------
oParams_Delete_Product.PRODUCT_ID = i_Product.PRODUCT_ID;
Delete_Product(oParams_Delete_Product);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Product_With_Children");}
}
#endregion
#region Reset_Product_By_Size
public void Reset_Product_By_Size(Size i_Size, List<Product> i_Product_List)
{
#region Declaration And Initialization Section.
Params_Delete_Product_By_SIZE_ID oParams_Delete_Product_By_SIZE_ID = new Params_Delete_Product_By_SIZE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Product_By_Size");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Product
//---------------------------------
oParams_Delete_Product_By_SIZE_ID.SIZE_ID = i_Size.SIZE_ID;
Delete_Product_By_SIZE_ID(oParams_Delete_Product_By_SIZE_ID);
//---------------------------------
// Edit Product
//---------------------------------
Edit_Size_WithProduct(i_Size, i_Product_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Product_By_Size");}
}
#endregion
#region Reset_Product_By_Size
public void Reset_Product_By_Size(Size i_Size, List<Product> i_Product_List_To_Delete,List<Product> i_Product_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Product oParams_Delete_Product = new Params_Delete_Product();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Product_By_Size");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Product_List_To_Delete != null)
{
foreach (var oRow in i_Product_List_To_Delete)
{
oParams_Delete_Product.PRODUCT_ID = oRow.PRODUCT_ID;
Delete_Product(oParams_Delete_Product);
}
}
//---------------------------------
// Edit Product
//---------------------------------
Edit_Size_WithProduct(i_Size, i_Product_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Product_By_Size");}
}
#endregion
#region Edit_Size_With_Product(Size i_Size,List<Product> i_ProductList)
public void Edit_Size_WithProduct(Size i_Size,List<Product> i_List_Product)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Size_WithProduct");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Size(i_Size);
if (i_List_Product != null)
{
foreach(Product oProduct in i_List_Product)
{
oProduct.SIZE_ID = i_Size.SIZE_ID;
Edit_Product(oProduct);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Size_WithProduct");}
}
#endregion
#region Edit_Size_WithRelatedData(Size i_Size,List<Product> i_List_Product)
public void Edit_Size_WithRelatedData(Size i_Size,List<Product> i_List_Product)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Size_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Size(i_Size);
if (i_List_Product != null)
{
foreach(Product oProduct in i_List_Product)
{
oProduct.SIZE_ID = i_Size.SIZE_ID;
Edit_Product(oProduct);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Size_WithRelatedData");}
}
#endregion
#region Delete_Size_With_Children(Size i_Size)
public void Delete_Size_With_Children(Size i_Size)
{
 #region Declaration And Initialization Section.
Params_Delete_Size oParams_Delete_Size = new Params_Delete_Size();
Params_Delete_Product_By_SIZE_ID oParams_Delete_Product_By_SIZE_ID = new Params_Delete_Product_By_SIZE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Size_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Product_By_SIZE_ID.SIZE_ID = i_Size.SIZE_ID;
Delete_Product_By_SIZE_ID(oParams_Delete_Product_By_SIZE_ID);
//-------------------------

//-------------------------
oParams_Delete_Size.SIZE_ID = i_Size.SIZE_ID;
Delete_Size(oParams_Delete_Size);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Size_With_Children");}
}
#endregion
}
}
