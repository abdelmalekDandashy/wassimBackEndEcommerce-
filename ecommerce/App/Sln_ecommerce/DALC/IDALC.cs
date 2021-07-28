using System;
using System.Collections.Generic;
namespace DALC
{
#region Repositories
public partial class Address
{
public long? ADDRESS_ID {get;set;}
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public long? LOC_L1_ID {get;set;}
public long? LOC_L2_ID {get;set;}
public long? LOC_L3_ID {get;set;}
public long? LOC_L4_ID {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
}
public partial class Adress
{
public Int32? ADRESS_ID {get;set;}
public string STREET_NAME_ONE {get;set;}
public string STREET_NAME_TWO {get;set;}
public string STATE {get;set;}
public string POST_CODE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Category
{
public Int32? CATEGORY_ID {get;set;}
public string NAME {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Color
{
public Int32? COLOR_ID {get;set;}
public string NAME {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Contact
{
public Int32? CONTACT_ID {get;set;}
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
}
public partial class Customer
{
public Int32? CUSTOMER_ID {get;set;}
public long? USER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public Int32? ADRESS_ID {get;set;}
public string PHONE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public User My_User {get;set;}
public Adress My_Adress {get;set;}
}
public partial class Invoice
{
public Int32? INVOICE_ID {get;set;}
public Int32? CUSTOMER_ID {get;set;}
public Int32? AMMOUNT {get;set;}
public Int32? ADRESS_ID {get;set;}
public Int32? ORDER_STATUS {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public Customer My_Customer {get;set;}
public Adress My_Adress {get;set;}
}
public partial class Loc_l1
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l2
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L1_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
}
public partial class Loc_l3
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L2_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
}
public partial class Loc_l4
{
public long? LOC_L4_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L3_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
}
public partial class Order_details
{
public Int32? ORDER_DETAILS_ID {get;set;}
public Int32? INVOICE_ID {get;set;}
public Int32? PRODUCT_ID {get;set;}
public decimal PRICE {get;set;}
public Int32? QUANTITY {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public Invoice My_Invoice {get;set;}
public Product My_Product {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Person
{
public long? PERSON_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public bool? IS_BLOCKED {get;set;}
public string DESCRIPTION {get;set;}
public Int32? OWNER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Product
{
public Int32? PRODUCT_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public Int32? CATEGORY_ID {get;set;}
public Int32? STOCK {get;set;}
public decimal FULL_PRICE {get;set;}
public decimal? DISCOUNT_PRICE {get;set;}
public bool? IS_BEST_SELLING {get;set;}
public bool? IS_RECOMMENDED {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Category My_Category {get;set;}
}
public partial class Product_color
{
public long? PRODUCT_COLOR_ID {get;set;}
public Int32? PRODUCT_ID {get;set;}
public Int32? COLOR_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public Product My_Product {get;set;}
public Color My_Color {get;set;}
}
public partial class Product_size
{
public long? PRODUCT_SIZE_ID {get;set;}
public Int32? PRODUCT_ID {get;set;}
public Int32? SIZE_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public Product My_Product {get;set;}
public Size My_Size {get;set;}
}
public partial class Size
{
public Int32? SIZE_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Uploaded_file
{
public long? UPLOADED_FILE_ID {get;set;}
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
public Int32? SIZE {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string EMAIL {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class User_account
{
public long? USER_ACCOUNT_ID {get;set;}
public long? USER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public User My_User {get;set;}
}
#endregion 
public partial interface IDALC
{
Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID);
Adress Get_Adress_By_ADRESS_ID ( Int32? ADRESS_ID);
Category Get_Category_By_CATEGORY_ID ( Int32? CATEGORY_ID);
Color Get_Color_By_COLOR_ID ( Int32? COLOR_ID);
Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID);
Customer Get_Customer_By_CUSTOMER_ID ( Int32? CUSTOMER_ID);
Invoice Get_Invoice_By_INVOICE_ID ( Int32? INVOICE_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID);
Order_details Get_Order_details_By_ORDER_DETAILS_ID ( Int32? ORDER_DETAILS_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Person Get_Person_By_PERSON_ID ( long? PERSON_ID);
Product Get_Product_By_PRODUCT_ID ( Int32? PRODUCT_ID);
Product_color Get_Product_color_By_PRODUCT_COLOR_ID ( long? PRODUCT_COLOR_ID);
Product_size Get_Product_size_By_PRODUCT_SIZE_ID ( long? PRODUCT_SIZE_ID);
Size Get_Size_By_SIZE_ID ( Int32? SIZE_ID);
Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID ( long? UPLOADED_FILE_ID);
User Get_User_By_USER_ID ( long? USER_ID);
User_account Get_User_account_By_USER_ACCOUNT_ID ( long? USER_ACCOUNT_ID);
Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID);
Adress Get_Adress_By_ADRESS_ID_Adv ( Int32? ADRESS_ID);
Category Get_Category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
Color Get_Color_By_COLOR_ID_Adv ( Int32? COLOR_ID);
Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID);
Customer Get_Customer_By_CUSTOMER_ID_Adv ( Int32? CUSTOMER_ID);
Invoice Get_Invoice_By_INVOICE_ID_Adv ( Int32? INVOICE_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
Order_details Get_Order_details_By_ORDER_DETAILS_ID_Adv ( Int32? ORDER_DETAILS_ID);
Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID);
Product Get_Product_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID);
Product_color Get_Product_color_By_PRODUCT_COLOR_ID_Adv ( long? PRODUCT_COLOR_ID);
Product_size Get_Product_size_By_PRODUCT_SIZE_ID_Adv ( long? PRODUCT_SIZE_ID);
Size Get_Size_By_SIZE_ID_Adv ( Int32? SIZE_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
User_account Get_User_account_By_USER_ACCOUNT_ID_Adv ( long? USER_ACCOUNT_ID);
List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST);
List<Adress> Get_Adress_By_ADRESS_ID_List ( List<Int32?> ADRESS_ID_LIST);
List<Category> Get_Category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Color> Get_Color_By_COLOR_ID_List ( List<Int32?> COLOR_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST);
List<Customer> Get_Customer_By_CUSTOMER_ID_List ( List<Int32?> CUSTOMER_ID_LIST);
List<Invoice> Get_Invoice_By_INVOICE_ID_List ( List<Int32?> INVOICE_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_List ( List<Int32?> ORDER_DETAILS_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Product> Get_Product_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST);
List<Product_color> Get_Product_color_By_PRODUCT_COLOR_ID_List ( List<long?> PRODUCT_COLOR_ID_LIST);
List<Product_size> Get_Product_size_By_PRODUCT_SIZE_ID_List ( List<long?> PRODUCT_SIZE_ID_LIST);
List<Size> Get_Size_By_SIZE_ID_List ( List<Int32?> SIZE_ID_LIST);
List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List ( List<long?> UPLOADED_FILE_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<User_account> Get_User_account_By_USER_ACCOUNT_ID_List ( List<long?> USER_ACCOUNT_ID_LIST);
List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST);
List<Adress> Get_Adress_By_ADRESS_ID_List_Adv ( List<Int32?> ADRESS_ID_LIST);
List<Category> Get_Category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Color> Get_Color_By_COLOR_ID_List_Adv ( List<Int32?> COLOR_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST);
List<Customer> Get_Customer_By_CUSTOMER_ID_List_Adv ( List<Int32?> CUSTOMER_ID_LIST);
List<Invoice> Get_Invoice_By_INVOICE_ID_List_Adv ( List<Int32?> INVOICE_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_List_Adv ( List<Int32?> ORDER_DETAILS_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Product> Get_Product_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST);
List<Product_color> Get_Product_color_By_PRODUCT_COLOR_ID_List_Adv ( List<long?> PRODUCT_COLOR_ID_LIST);
List<Product_size> Get_Product_size_By_PRODUCT_SIZE_ID_List_Adv ( List<long?> PRODUCT_SIZE_ID_LIST);
List<Size> Get_Size_By_SIZE_ID_List_Adv ( List<Int32?> SIZE_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<User_account> Get_User_account_By_USER_ACCOUNT_ID_List_Adv ( List<long?> USER_ACCOUNT_ID_LIST);
List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
List<Adress> Get_Adress_By_OWNER_ID ( Int32? OWNER_ID);
List<Category> Get_Category_By_OWNER_ID ( Int32? OWNER_ID);
List<Color> Get_Color_By_OWNER_ID ( Int32? OWNER_ID);
List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID);
List<Customer> Get_Customer_By_OWNER_ID ( Int32? OWNER_ID);
List<Customer> Get_Customer_By_ADRESS_ID ( Int32? ADRESS_ID);
List<Customer> Get_Customer_By_USER_ID ( long? USER_ID);
List<Invoice> Get_Invoice_By_OWNER_ID ( Int32? OWNER_ID);
List<Invoice> Get_Invoice_By_CUSTOMER_ID ( Int32? CUSTOMER_ID);
List<Invoice> Get_Invoice_By_ADRESS_ID ( Int32? ADRESS_ID);
List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
List<Order_details> Get_Order_details_By_OWNER_ID ( Int32? OWNER_ID);
List<Order_details> Get_Order_details_By_INVOICE_ID ( Int32? INVOICE_ID);
List<Order_details> Get_Order_details_By_PRODUCT_ID ( Int32? PRODUCT_ID);
List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID);
List<Product> Get_Product_By_OWNER_ID ( Int32? OWNER_ID);
List<Product> Get_Product_By_CATEGORY_ID ( Int32? CATEGORY_ID);
List<Product> Get_Product_By_IS_BEST_SELLING ( bool? IS_BEST_SELLING);
List<Product> Get_Product_By_IS_RECOMMENDED ( bool? IS_RECOMMENDED);
List<Product_color> Get_Product_color_By_OWNER_ID ( Int32? OWNER_ID);
List<Product_color> Get_Product_color_By_PRODUCT_ID ( Int32? PRODUCT_ID);
List<Product_color> Get_Product_color_By_COLOR_ID ( Int32? COLOR_ID);
List<Product_size> Get_Product_size_By_OWNER_ID ( Int32? OWNER_ID);
List<Product_size> Get_Product_size_By_PRODUCT_ID ( Int32? PRODUCT_ID);
List<Product_size> Get_Product_size_By_SIZE_ID ( Int32? SIZE_ID);
List<Size> Get_Size_By_OWNER_ID ( Int32? OWNER_ID);
List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<User_account> Get_User_account_By_OWNER_ID ( Int32? OWNER_ID);
List<User_account> Get_User_account_By_USER_ID ( long? USER_ID);
List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
List<Adress> Get_Adress_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Category> Get_Category_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Color> Get_Color_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Customer> Get_Customer_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Customer> Get_Customer_By_ADRESS_ID_Adv ( Int32? ADRESS_ID);
List<Customer> Get_Customer_By_USER_ID_Adv ( long? USER_ID);
List<Invoice> Get_Invoice_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Invoice> Get_Invoice_By_CUSTOMER_ID_Adv ( Int32? CUSTOMER_ID);
List<Invoice> Get_Invoice_By_ADRESS_ID_Adv ( Int32? ADRESS_ID);
List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Order_details> Get_Order_details_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Order_details> Get_Order_details_By_INVOICE_ID_Adv ( Int32? INVOICE_ID);
List<Order_details> Get_Order_details_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID);
List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Product> Get_Product_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Product> Get_Product_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
List<Product> Get_Product_By_IS_BEST_SELLING_Adv ( bool? IS_BEST_SELLING);
List<Product> Get_Product_By_IS_RECOMMENDED_Adv ( bool? IS_RECOMMENDED);
List<Product_color> Get_Product_color_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Product_color> Get_Product_color_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID);
List<Product_color> Get_Product_color_By_COLOR_ID_Adv ( Int32? COLOR_ID);
List<Product_size> Get_Product_size_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Product_size> Get_Product_size_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID);
List<Product_size> Get_Product_size_By_SIZE_ID_Adv ( Int32? SIZE_ID);
List<Size> Get_Size_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<User_account> Get_User_account_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User_account> Get_User_account_By_USER_ID_Adv ( long? USER_ID);
List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Customer> Get_Customer_By_ADRESS_ID_List ( List<Int32?> ADRESS_ID_LIST);
List<Customer> Get_Customer_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Invoice> Get_Invoice_By_CUSTOMER_ID_List ( List<Int32?> CUSTOMER_ID_LIST);
List<Invoice> Get_Invoice_By_ADRESS_ID_List ( List<Int32?> ADRESS_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Order_details> Get_Order_details_By_INVOICE_ID_List ( List<Int32?> INVOICE_ID_LIST);
List<Order_details> Get_Order_details_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST);
List<Product> Get_Product_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Product_color> Get_Product_color_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST);
List<Product_color> Get_Product_color_By_COLOR_ID_List ( List<Int32?> COLOR_ID_LIST);
List<Product_size> Get_Product_size_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST);
List<Product_size> Get_Product_size_By_SIZE_ID_List ( List<Int32?> SIZE_ID_LIST);
List<User_account> Get_User_account_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Customer> Get_Customer_By_ADRESS_ID_List_Adv ( List<Int32?> ADRESS_ID_LIST);
List<Customer> Get_Customer_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Invoice> Get_Invoice_By_CUSTOMER_ID_List_Adv ( List<Int32?> CUSTOMER_ID_LIST);
List<Invoice> Get_Invoice_By_ADRESS_ID_List_Adv ( List<Int32?> ADRESS_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Order_details> Get_Order_details_By_INVOICE_ID_List_Adv ( List<Int32?> INVOICE_ID_LIST);
List<Order_details> Get_Order_details_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST);
List<Product> Get_Product_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Product_color> Get_Product_color_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST);
List<Product_color> Get_Product_color_By_COLOR_ID_List_Adv ( List<Int32?> COLOR_ID_LIST);
List<Product_size> Get_Product_size_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST);
List<Product_size> Get_Product_size_By_SIZE_ID_List_Adv ( List<Int32?> SIZE_ID_LIST);
List<User_account> Get_User_account_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Adress> Get_Adress_By_Criteria ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Adress> Get_Adress_By_Where ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Color> Get_Color_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Color> Get_Color_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Criteria ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Where ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Size> Get_Size_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Size> Get_Size_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Criteria ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Where ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Adress> Get_Adress_By_Criteria_Adv ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Adress> Get_Adress_By_Where_Adv ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Color> Get_Color_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Color> Get_Color_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Size> Get_Size_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Size> Get_Size_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Criteria_InList ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Where_InList ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Criteria_InList ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Where_InList ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Criteria_InList ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Where_InList ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Criteria_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Where_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Criteria_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Where_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Criteria_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Where_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Criteria_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Where_InList ( string DESCRIPTION, List<long?> USER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Criteria_InList_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Customer> Get_Customer_By_Where_InList_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Invoice> Get_Invoice_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Order_details> Get_Order_details_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Criteria_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product> Get_Product_By_Where_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_color> Get_Product_color_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Product_size> Get_Product_size_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Criteria_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User_account> Get_User_account_By_Where_InList_Adv ( string DESCRIPTION, List<long?> USER_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Address ( long? ADDRESS_ID);
void Delete_Adress ( Int32? ADRESS_ID);
void Delete_Category ( Int32? CATEGORY_ID);
void Delete_Color ( Int32? COLOR_ID);
void Delete_Contact ( Int32? CONTACT_ID);
void Delete_Customer ( Int32? CUSTOMER_ID);
void Delete_Invoice ( Int32? INVOICE_ID);
void Delete_Loc_l1 ( long? LOC_L1_ID);
void Delete_Loc_l2 ( long? LOC_L2_ID);
void Delete_Loc_l3 ( long? LOC_L3_ID);
void Delete_Loc_l4 ( long? LOC_L4_ID);
void Delete_Order_details ( Int32? ORDER_DETAILS_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Person ( long? PERSON_ID);
void Delete_Product ( Int32? PRODUCT_ID);
void Delete_Product_color ( long? PRODUCT_COLOR_ID);
void Delete_Product_size ( long? PRODUCT_SIZE_ID);
void Delete_Size ( Int32? SIZE_ID);
void Delete_Uploaded_file ( long? UPLOADED_FILE_ID);
void Delete_User ( long? USER_ID);
void Delete_User_account ( long? USER_ACCOUNT_ID);
void Delete_Address_By_PERSON_ID ( long? PERSON_ID);
void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
void Delete_Adress_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Category_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Color_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Contact_By_PERSON_ID ( long? PERSON_ID);
void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Customer_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Customer_By_ADRESS_ID ( Int32? ADRESS_ID);
void Delete_Customer_By_USER_ID ( long? USER_ID);
void Delete_Invoice_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Invoice_By_CUSTOMER_ID ( Int32? CUSTOMER_ID);
void Delete_Invoice_By_ADRESS_ID ( Int32? ADRESS_ID);
void Delete_Loc_l1_By_CODE ( string CODE);
void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Order_details_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Order_details_By_INVOICE_ID ( Int32? INVOICE_ID);
void Delete_Order_details_By_PRODUCT_ID ( Int32? PRODUCT_ID);
void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Product_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Product_By_CATEGORY_ID ( Int32? CATEGORY_ID);
void Delete_Product_By_IS_BEST_SELLING ( bool? IS_BEST_SELLING);
void Delete_Product_By_IS_RECOMMENDED ( bool? IS_RECOMMENDED);
void Delete_Product_color_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Product_color_By_PRODUCT_ID ( Int32? PRODUCT_ID);
void Delete_Product_color_By_COLOR_ID ( Int32? COLOR_ID);
void Delete_Product_size_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Product_size_By_PRODUCT_ID ( Int32? PRODUCT_ID);
void Delete_Product_size_By_SIZE_ID ( Int32? SIZE_ID);
void Delete_Size_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
void Delete_User_account_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_account_By_USER_ID ( long? USER_ID);
long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Adress ( Int32? ADRESS_ID, string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Category ( Int32? CATEGORY_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Color ( Int32? COLOR_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Customer ( Int32? CUSTOMER_ID, long? USER_ID, string FIRST_NAME, string LAST_NAME, Int32? ADRESS_ID, string PHONE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Invoice ( Int32? INVOICE_ID, Int32? CUSTOMER_ID, Int32? AMMOUNT, Int32? ADRESS_ID, Int32? ORDER_STATUS, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Order_details ( Int32? ORDER_DETAILS_ID, Int32? INVOICE_ID, Int32? PRODUCT_ID, decimal PRICE, Int32? QUANTITY, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE);
Int32? Edit_Product ( Int32? PRODUCT_ID, string NAME, string DESCRIPTION, Int32? CATEGORY_ID, Int32? STOCK, decimal FULL_PRICE, decimal? DISCOUNT_PRICE, bool? IS_BEST_SELLING, bool? IS_RECOMMENDED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Product_color ( long? PRODUCT_COLOR_ID, Int32? PRODUCT_ID, Int32? COLOR_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
long? Edit_Product_size ( long? PRODUCT_SIZE_ID, Int32? PRODUCT_ID, Int32? SIZE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Size ( Int32? SIZE_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Uploaded_file ( long? UPLOADED_FILE_ID, string REL_ENTITY, long? REL_KEY, string REL_FIELD, Int32? SIZE, string EXTENSION, string STAMP, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE);
long? Edit_User_account ( long? USER_ACCOUNT_ID, long? USER_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_ADRESS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_ATTRIBUTE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CATEGORY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_COLOR ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CUSTOMER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_INVOICE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_ORDER_DETAILS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PRODUCT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PRODUCT_COLOR ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PRODUCT_SIZE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SIZE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_UPLOADED_FILE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER_ACCOUNT ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
}
}
