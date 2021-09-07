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
#region Address
public partial class Address
{
#region Advanced Properties
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
#endregion
}
#endregion
#region Adress
public partial class Adress
{
#region Advanced Properties
#endregion
}
#endregion
#region Category
public partial class Category
{
#region Advanced Properties
#endregion
}
#endregion
#region Color
public partial class Color
{
#region Advanced Properties
#endregion
}
#endregion
#region Contact
public partial class Contact
{
#region Advanced Properties
public Person My_Person {get;set;}
#endregion
}
#endregion
#region Customer
public partial class Customer
{
#region Advanced Properties
public User My_User {get;set;}
public Adress My_Adress {get;set;}
#endregion
}
#endregion
#region Invoice
public partial class Invoice
{
#region Advanced Properties
public User_account My_User_account {get;set;}
public Invoice_status My_Invoice_status {get;set;}
#endregion
}
#endregion
#region Invoice_status
public partial class Invoice_status
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l1
public partial class Loc_l1
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l2
public partial class Loc_l2
{
#region Advanced Properties
public Loc_l1 My_Loc_l1 {get;set;}
#endregion
}
#endregion
#region Loc_l3
public partial class Loc_l3
{
#region Advanced Properties
public Loc_l2 My_Loc_l2 {get;set;}
#endregion
}
#endregion
#region Loc_l4
public partial class Loc_l4
{
#region Advanced Properties
public Loc_l3 My_Loc_l3 {get;set;}
#endregion
}
#endregion
#region Order_details
public partial class Order_details
{
#region Advanced Properties
public Product My_Product {get;set;}
public Invoice My_Invoice {get;set;}
#endregion
}
#endregion
#region Owner
public partial class Owner
{
#region Advanced Properties
#endregion
}
#endregion
#region Person
public partial class Person
{
#region Advanced Properties
#endregion
}
#endregion
#region Product
public partial class Product
{
#region Advanced Properties
public Category My_Category {get;set;}
public Color My_Color {get;set;}
public Size My_Size {get;set;}
#endregion
}
#endregion
#region Size
public partial class Size
{
#region Advanced Properties
#endregion
}
#endregion
#region Uploaded_file
public partial class Uploaded_file
{
#region Advanced Properties
#endregion
}
#endregion
#region User
public partial class User
{
#region Advanced Properties
#endregion
}
#endregion
#region User_account
public partial class User_account
{
#region Advanced Properties
public Adress My_Adress {get;set;}
public User My_User {get;set;}
#endregion
}
#endregion
}
