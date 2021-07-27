using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Adress Get_Adress_By_ADRESS_ID ( Int32? ADRESS_ID)
{
Adress o = new Adress();
dynamic p = new ExpandoObject();
p.ADRESS_ID = ADRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADRESS_BY_ADRESS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Category Get_Category_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
Category o = new Category();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Color Get_Color_By_COLOR_ID ( Int32? COLOR_ID)
{
Color o = new Color();
dynamic p = new ExpandoObject();
p.COLOR_ID = COLOR_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_COLOR_BY_COLOR_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Customer Get_Customer_By_CUSTOMER_ID ( Int32? CUSTOMER_ID)
{
Customer o = new Customer();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID = CUSTOMER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CUSTOMER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Invoice Get_Invoice_By_INVOICE_ID ( Int32? INVOICE_ID)
{
Invoice o = new Invoice();
dynamic p = new ExpandoObject();
p.INVOICE_ID = INVOICE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_INVOICE_BY_INVOICE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Order_details Get_Order_details_By_ORDER_DETAILS_ID ( Int32? ORDER_DETAILS_ID)
{
Order_details o = new Order_details();
dynamic p = new ExpandoObject();
p.ORDER_DETAILS_ID = ORDER_DETAILS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Person Get_Person_By_PERSON_ID ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Product Get_Product_By_PRODUCT_ID ( Int32? PRODUCT_ID)
{
Product o = new Product();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_PRODUCT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Product_color Get_Product_color_By_PRODUCT_COLOR_ID ( long? PRODUCT_COLOR_ID)
{
Product_color o = new Product_color();
dynamic p = new ExpandoObject();
p.PRODUCT_COLOR_ID = PRODUCT_COLOR_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_COLOR_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Product_size Get_Product_size_By_PRODUCT_SIZE_ID ( long? PRODUCT_SIZE_ID)
{
Product_size o = new Product_size();
dynamic p = new ExpandoObject();
p.PRODUCT_SIZE_ID = PRODUCT_SIZE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_SIZE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Size Get_Size_By_SIZE_ID ( Int32? SIZE_ID)
{
Size o = new Size();
dynamic p = new ExpandoObject();
p.SIZE_ID = SIZE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SIZE_BY_SIZE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID ( long? UPLOADED_FILE_ID)
{
Uploaded_file o = new Uploaded_file();
dynamic p = new ExpandoObject();
p.UPLOADED_FILE_ID = UPLOADED_FILE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_UPLOADED_FILE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(R["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(R["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(R["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(R["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(R["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(R["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(R["T_LOC_L4_OWNER_ID"]);
}
return o;
}
public Adress Get_Adress_By_ADRESS_ID_Adv ( Int32? ADRESS_ID)
{
Adress o = new Adress();
dynamic p = new ExpandoObject();
p.ADRESS_ID = ADRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADRESS_BY_ADRESS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Category Get_Category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
Category o = new Category();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Color Get_Color_By_COLOR_ID_Adv ( Int32? COLOR_ID)
{
Color o = new Color();
dynamic p = new ExpandoObject();
p.COLOR_ID = COLOR_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_COLOR_BY_COLOR_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
}
return o;
}
public Customer Get_Customer_By_CUSTOMER_ID_Adv ( Int32? CUSTOMER_ID)
{
Customer o = new Customer();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID = CUSTOMER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CUSTOMER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(R["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(R["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(R["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(R["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(R["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(R["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(R["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(R["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(R["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(R["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(R["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(R["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(R["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(R["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(R["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(R["T_ADRESS_OWNER_ID"]);
}
return o;
}
public Invoice Get_Invoice_By_INVOICE_ID_Adv ( Int32? INVOICE_ID)
{
Invoice o = new Invoice();
dynamic p = new ExpandoObject();
p.INVOICE_ID = INVOICE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_INVOICE_BY_INVOICE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(R["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(R["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(R["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(R["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(R["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(R["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(R["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(R["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(R["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(R["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(R["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(R["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(R["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(R["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(R["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(R["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(R["T_ADRESS_OWNER_ID"]);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
}
return o;
}
public Order_details Get_Order_details_By_ORDER_DETAILS_ID_Adv ( Int32? ORDER_DETAILS_ID)
{
Order_details o = new Order_details();
dynamic p = new ExpandoObject();
p.ORDER_DETAILS_ID = ORDER_DETAILS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(R["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(R["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(R["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(R["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(R["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(R["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(R["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(R["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(R["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(R["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(R["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(R["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(R["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(R["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(R["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(R["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(R["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(R["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(R["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(R["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(R["T_PRODUCT_OWNER_ID"]);
}
return o;
}
public Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Product Get_Product_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID)
{
Product o = new Product();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_PRODUCT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(R["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(R["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(R["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(R["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(R["T_CATEGORY_OWNER_ID"]);
}
return o;
}
public Product_color Get_Product_color_By_PRODUCT_COLOR_ID_Adv ( long? PRODUCT_COLOR_ID)
{
Product_color o = new Product_color();
dynamic p = new ExpandoObject();
p.PRODUCT_COLOR_ID = PRODUCT_COLOR_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_COLOR_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(R["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(R["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(R["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(R["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(R["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(R["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(R["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(R["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(R["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(R["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(R["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(R["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(R["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(R["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(R["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(R["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(R["T_COLOR_OWNER_ID"]);
}
return o;
}
public Product_size Get_Product_size_By_PRODUCT_SIZE_ID_Adv ( long? PRODUCT_SIZE_ID)
{
Product_size o = new Product_size();
dynamic p = new ExpandoObject();
p.PRODUCT_SIZE_ID = PRODUCT_SIZE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_SIZE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(R["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(R["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(R["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(R["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(R["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(R["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(R["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(R["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(R["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(R["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(R["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(R["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(R["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(R["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(R["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(R["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(R["T_SIZE_OWNER_ID"]);
}
return o;
}
public Size Get_Size_By_SIZE_ID_Adv ( Int32? SIZE_ID)
{
Size o = new Size();
dynamic p = new ExpandoObject();
p.SIZE_ID = SIZE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SIZE_BY_SIZE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Adress> Get_Adress_By_ADRESS_ID_List ( List<Int32?> ADRESS_ID_LIST)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_ADRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Color> Get_Color_By_COLOR_ID_List ( List<Int32?> COLOR_ID_LIST)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_COLOR_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_CUSTOMER_ID_List ( List<Int32?> CUSTOMER_ID_LIST)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CUSTOMER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_ID_List ( List<Int32?> INVOICE_ID_LIST)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_INVOICE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_List ( List<Int32?> ORDER_DETAILS_ID_LIST)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.ORDER_DETAILS_ID_LIST = string.Join(",", ORDER_DETAILS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_PRODUCT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_PRODUCT_COLOR_ID_List ( List<long?> PRODUCT_COLOR_ID_LIST)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.PRODUCT_COLOR_ID_LIST = string.Join(",", PRODUCT_COLOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_COLOR_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_PRODUCT_SIZE_ID_List ( List<long?> PRODUCT_SIZE_ID_LIST)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.PRODUCT_SIZE_ID_LIST = string.Join(",", PRODUCT_SIZE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_SIZE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Size> Get_Size_By_SIZE_ID_List ( List<Int32?> SIZE_ID_LIST)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_SIZE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List ( List<long?> UPLOADED_FILE_ID_LIST)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.UPLOADED_FILE_ID_LIST = string.Join(",", UPLOADED_FILE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_UPLOADED_FILE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Adress> Get_Adress_By_ADRESS_ID_List_Adv ( List<Int32?> ADRESS_ID_LIST)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_ADRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Color> Get_Color_By_COLOR_ID_List_Adv ( List<Int32?> COLOR_ID_LIST)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_COLOR_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_CUSTOMER_ID_List_Adv ( List<Int32?> CUSTOMER_ID_LIST)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CUSTOMER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_INVOICE_ID_List_Adv ( List<Int32?> INVOICE_ID_LIST)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_INVOICE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_List_Adv ( List<Int32?> ORDER_DETAILS_ID_LIST)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.ORDER_DETAILS_ID_LIST = string.Join(",", ORDER_DETAILS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_PRODUCT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_PRODUCT_COLOR_ID_List_Adv ( List<long?> PRODUCT_COLOR_ID_LIST)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.PRODUCT_COLOR_ID_LIST = string.Join(",", PRODUCT_COLOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_COLOR_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_PRODUCT_SIZE_ID_List_Adv ( List<long?> PRODUCT_SIZE_ID_LIST)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.PRODUCT_SIZE_ID_LIST = string.Join(",", PRODUCT_SIZE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_SIZE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Size> Get_Size_By_SIZE_ID_List_Adv ( List<Int32?> SIZE_ID_LIST)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_SIZE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Adress> Get_Adress_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Color> Get_Color_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID ( Int32? ADRESS_ID)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.ADRESS_ID = ADRESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_ADRESS_ID", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID ( long? USER_ID)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_USER_ID", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_CUSTOMER_ID ( Int32? CUSTOMER_ID)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID = CUSTOMER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CUSTOMER_ID", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_ADRESS_ID ( Int32? ADRESS_ID)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.ADRESS_ID = ADRESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_ADRESS_ID", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_INVOICE_ID ( Int32? INVOICE_ID)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.INVOICE_ID = INVOICE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_INVOICE_ID", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID ( Int32? PRODUCT_ID)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_PRODUCT_ID", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_IS_BEST_SELLING ( bool? IS_BEST_SELLING)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.IS_BEST_SELLING = IS_BEST_SELLING;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_IS_BEST_SELLING", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_IS_RECOMMENDED ( bool? IS_RECOMMENDED)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.IS_RECOMMENDED = IS_RECOMMENDED;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_IS_RECOMMENDED", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_PRODUCT_ID ( Int32? PRODUCT_ID)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_ID", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_COLOR_ID ( Int32? COLOR_ID)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.COLOR_ID = COLOR_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_COLOR_ID", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_PRODUCT_ID ( Int32? PRODUCT_ID)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_ID", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_SIZE_ID ( Int32? SIZE_ID)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.SIZE_ID = SIZE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_SIZE_ID", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Size> Get_Size_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_KEY = REL_KEY;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_KEY = REL_KEY; p.REL_FIELD = REL_FIELD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY_REL_FIELD", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Adress> Get_Adress_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Color> Get_Color_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID_Adv ( Int32? ADRESS_ID)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.ADRESS_ID = ADRESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_ADRESS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID_Adv ( long? USER_ID)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_USER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_CUSTOMER_ID_Adv ( Int32? CUSTOMER_ID)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID = CUSTOMER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CUSTOMER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_ADRESS_ID_Adv ( Int32? ADRESS_ID)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.ADRESS_ID = ADRESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_ADRESS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_INVOICE_ID_Adv ( Int32? INVOICE_ID)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.INVOICE_ID = INVOICE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_INVOICE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_PRODUCT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CATEGORY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_IS_BEST_SELLING_Adv ( bool? IS_BEST_SELLING)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.IS_BEST_SELLING = IS_BEST_SELLING;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_IS_BEST_SELLING_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_IS_RECOMMENDED_Adv ( bool? IS_RECOMMENDED)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.IS_RECOMMENDED = IS_RECOMMENDED;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_IS_RECOMMENDED_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_COLOR_ID_Adv ( Int32? COLOR_ID)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.COLOR_ID = COLOR_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_COLOR_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_PRODUCT_ID_Adv ( Int32? PRODUCT_ID)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID = PRODUCT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_SIZE_ID_Adv ( Int32? SIZE_ID)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.SIZE_ID = SIZE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_SIZE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Size> Get_Size_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID_List ( List<Int32?> ADRESS_ID_LIST)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_ADRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_CUSTOMER_ID_List ( List<Int32?> CUSTOMER_ID_LIST)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CUSTOMER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_ADRESS_ID_List ( List<Int32?> ADRESS_ID_LIST)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_ADRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_INVOICE_ID_List ( List<Int32?> INVOICE_ID_LIST)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_INVOICE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_PRODUCT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_COLOR_ID_List ( List<Int32?> COLOR_ID_LIST)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_COLOR_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_PRODUCT_ID_List ( List<Int32?> PRODUCT_ID_LIST)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_SIZE_ID_List ( List<Int32?> SIZE_ID_LIST)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_SIZE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_ADRESS_ID_List_Adv ( List<Int32?> ADRESS_ID_LIST)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_ADRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Customer> Get_Customer_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_CUSTOMER_ID_List_Adv ( List<Int32?> CUSTOMER_ID_LIST)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CUSTOMER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Invoice> Get_Invoice_By_ADRESS_ID_List_Adv ( List<Int32?> ADRESS_ID_LIST)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_ADRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_INVOICE_ID_List_Adv ( List<Int32?> INVOICE_ID_LIST)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_INVOICE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Order_details> Get_Order_details_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_PRODUCT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product> Get_Product_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_PRODUCT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_color> Get_Product_color_By_COLOR_ID_List_Adv ( List<Int32?> COLOR_ID_LIST)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_COLOR_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_PRODUCT_ID_List_Adv ( List<Int32?> PRODUCT_ID_LIST)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_PRODUCT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Product_size> Get_Product_size_By_SIZE_ID_List_Adv ( List<Int32?> SIZE_ID_LIST)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_SIZE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Adress> Get_Adress_By_Criteria ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.STREET_NAME_ONE = STREET_NAME_ONE; p.STREET_NAME_TWO = STREET_NAME_TWO; p.STATE = STATE; p.POST_CODE = POST_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Adress> Get_Adress_By_Where ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.STREET_NAME_ONE = STREET_NAME_ONE; p.STREET_NAME_TWO = STREET_NAME_TWO; p.STATE = STATE; p.POST_CODE = POST_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Color> Get_Color_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Color> Get_Color_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Criteria ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Where ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Size> Get_Size_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Size> Get_Size_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Criteria ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_FIELD = REL_FIELD; p.EXTENSION = EXTENSION; p.STAMP = STAMP; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Where ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_FIELD = REL_FIELD; p.EXTENSION = EXTENSION; p.STAMP = STAMP; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Adress> Get_Adress_By_Criteria_Adv ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.STREET_NAME_ONE = STREET_NAME_ONE; p.STREET_NAME_TWO = STREET_NAME_TWO; p.STATE = STATE; p.POST_CODE = POST_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Adress> Get_Adress_By_Where_Adv ( string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Adress> oList = new List<Adress>();
dynamic p = new ExpandoObject();
p.STREET_NAME_ONE = STREET_NAME_ONE; p.STREET_NAME_TWO = STREET_NAME_TWO; p.STATE = STATE; p.POST_CODE = POST_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADRESS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Adress o = new Adress();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Color> Get_Color_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Color> Get_Color_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Color> oList = new List<Color>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COLOR_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Color o = new Color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Size> Get_Size_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Size> Get_Size_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Size> oList = new List<Size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SIZE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Size o = new Size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Criteria_InList ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Where_InList ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria_InList ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Where_InList ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria_InList ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray()); p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Where_InList ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray()); p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Criteria_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Where_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Criteria_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Where_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Criteria_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Where_InList ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Criteria_InList_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Customer> Get_Customer_By_Where_InList_Adv ( string FIRST_NAME, string LAST_NAME, string PHONE, List<long?> USER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Customer> oList = new List<Customer>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.PHONE = PHONE; p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CUSTOMER_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Customer o = new Customer();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.EMAIL = GV<String>(X["T_USER_EMAIL"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Invoice> Get_Invoice_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> CUSTOMER_ID_LIST, List<Int32?> ADRESS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Invoice> oList = new List<Invoice>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.CUSTOMER_ID_LIST = string.Join(",", CUSTOMER_ID_LIST.ToArray()); p.ADRESS_ID_LIST = string.Join(",", ADRESS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INVOICE_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Invoice o = new Invoice();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Customer = new Customer();
o.My_Customer.CUSTOMER_ID = GV<Int32>(X["T_CUSTOMER_CUSTOMER_ID"]);o.My_Customer.USER_ID = GV<Int64>(X["T_CUSTOMER_USER_ID"]);o.My_Customer.FIRST_NAME = GV<String>(X["T_CUSTOMER_FIRST_NAME"]);o.My_Customer.LAST_NAME = GV<String>(X["T_CUSTOMER_LAST_NAME"]);o.My_Customer.ADRESS_ID = GV<Int32>(X["T_CUSTOMER_ADRESS_ID"]);o.My_Customer.PHONE = GV<String>(X["T_CUSTOMER_PHONE"]);o.My_Customer.ENTRY_USER_ID = GV<Int64>(X["T_CUSTOMER_ENTRY_USER_ID"]);o.My_Customer.ENTRY_DATE = GV<String>(X["T_CUSTOMER_ENTRY_DATE"]);o.My_Customer.OWNER_ID = GV<Int32>(X["T_CUSTOMER_OWNER_ID"]);
o.My_Adress = new Adress();
o.My_Adress.ADRESS_ID = GV<Int32>(X["T_ADRESS_ADRESS_ID"]);o.My_Adress.STREET_NAME_ONE = GV<String>(X["T_ADRESS_STREET_NAME_ONE"]);o.My_Adress.STREET_NAME_TWO = GV<String>(X["T_ADRESS_STREET_NAME_TWO"]);o.My_Adress.STATE = GV<String>(X["T_ADRESS_STATE"]);o.My_Adress.POST_CODE = GV<String>(X["T_ADRESS_POST_CODE"]);o.My_Adress.ENTRY_USER_ID = GV<Int64>(X["T_ADRESS_ENTRY_USER_ID"]);o.My_Adress.ENTRY_DATE = GV<String>(X["T_ADRESS_ENTRY_DATE"]);o.My_Adress.OWNER_ID = GV<Int32>(X["T_ADRESS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray()); p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Order_details> Get_Order_details_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> INVOICE_ID_LIST, List<Int32?> PRODUCT_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Order_details> oList = new List<Order_details>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.INVOICE_ID_LIST = string.Join(",", INVOICE_ID_LIST.ToArray()); p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ORDER_DETAILS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Order_details o = new Order_details();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Invoice = new Invoice();
o.My_Invoice.INVOICE_ID = GV<Int32>(X["T_INVOICE_INVOICE_ID"]);o.My_Invoice.CUSTOMER_ID = GV<Int32>(X["T_INVOICE_CUSTOMER_ID"]);o.My_Invoice.AMMOUNT = GV<Int32>(X["T_INVOICE_AMMOUNT"]);o.My_Invoice.ADRESS_ID = GV<Int32>(X["T_INVOICE_ADRESS_ID"]);o.My_Invoice.ORDER_STATUS = GV<Int32>(X["T_INVOICE_ORDER_STATUS"]);o.My_Invoice.ENTRY_USER_ID = GV<Int64>(X["T_INVOICE_ENTRY_USER_ID"]);o.My_Invoice.ENTRY_DATE = GV<String>(X["T_INVOICE_ENTRY_DATE"]);o.My_Invoice.OWNER_ID = GV<Int32>(X["T_INVOICE_OWNER_ID"]);o.My_Invoice.DESCRIPTION = GV<String>(X["T_INVOICE_DESCRIPTION"]);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Criteria_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product> Get_Product_By_Where_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product> oList = new List<Product>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product o = new Product();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_color> Get_Product_color_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> COLOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_color> oList = new List<Product_color>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.COLOR_ID_LIST = string.Join(",", COLOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_COLOR_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_color o = new Product_color();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Color = new Color();
o.My_Color.COLOR_ID = GV<Int32>(X["T_COLOR_COLOR_ID"]);o.My_Color.NAME = GV<String>(X["T_COLOR_NAME"]);o.My_Color.ENTRY_USER_ID = GV<Int64>(X["T_COLOR_ENTRY_USER_ID"]);o.My_Color.ENTRY_DATE = GV<String>(X["T_COLOR_ENTRY_DATE"]);o.My_Color.OWNER_ID = GV<Int32>(X["T_COLOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Product_size> Get_Product_size_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> PRODUCT_ID_LIST, List<Int32?> SIZE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Product_size> oList = new List<Product_size>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PRODUCT_ID_LIST = string.Join(",", PRODUCT_ID_LIST.ToArray()); p.SIZE_ID_LIST = string.Join(",", SIZE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCT_SIZE_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Product_size o = new Product_size();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Product = new Product();
o.My_Product.PRODUCT_ID = GV<Int32>(X["T_PRODUCT_PRODUCT_ID"]);o.My_Product.NAME = GV<String>(X["T_PRODUCT_NAME"]);o.My_Product.DESCRIPTION = GV<String>(X["T_PRODUCT_DESCRIPTION"]);o.My_Product.CATEGORY_ID = GV<Int32>(X["T_PRODUCT_CATEGORY_ID"]);o.My_Product.STOCK = GV<Int32>(X["T_PRODUCT_STOCK"]);o.My_Product.FULL_PRICE = GV<Decimal>(X["T_PRODUCT_FULL_PRICE"]);o.My_Product.DISCOUNT_PRICE = GV<Decimal>(X["T_PRODUCT_DISCOUNT_PRICE"]);o.My_Product.IS_BEST_SELLING = GV<Boolean>(X["T_PRODUCT_IS_BEST_SELLING"]);o.My_Product.IS_RECOMMENDED = GV<Boolean>(X["T_PRODUCT_IS_RECOMMENDED"]);o.My_Product.ENTRY_USER_ID = GV<Int64>(X["T_PRODUCT_ENTRY_USER_ID"]);o.My_Product.ENTRY_DATE = GV<String>(X["T_PRODUCT_ENTRY_DATE"]);o.My_Product.OWNER_ID = GV<Int32>(X["T_PRODUCT_OWNER_ID"]);
o.My_Size = new Size();
o.My_Size.SIZE_ID = GV<Int32>(X["T_SIZE_SIZE_ID"]);o.My_Size.DESCRIPTION = GV<String>(X["T_SIZE_DESCRIPTION"]);o.My_Size.ENTRY_USER_ID = GV<Int64>(X["T_SIZE_ENTRY_USER_ID"]);o.My_Size.ENTRY_DATE = GV<String>(X["T_SIZE_ENTRY_DATE"]);o.My_Size.OWNER_ID = GV<Int32>(X["T_SIZE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Address ( long? ADDRESS_ID)
{
var p = new { ADDRESS_ID = ADDRESS_ID };
ExecuteDelete("UPG_DELETE_ADDRESS", p);
}
public void Delete_Adress ( Int32? ADRESS_ID)
{
var p = new { ADRESS_ID = ADRESS_ID };
ExecuteDelete("UPG_DELETE_ADRESS", p);
}
public void Delete_Category ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_CATEGORY", p);
}
public void Delete_Color ( Int32? COLOR_ID)
{
var p = new { COLOR_ID = COLOR_ID };
ExecuteDelete("UPG_DELETE_COLOR", p);
}
public void Delete_Contact ( Int32? CONTACT_ID)
{
var p = new { CONTACT_ID = CONTACT_ID };
ExecuteDelete("UPG_DELETE_CONTACT", p);
}
public void Delete_Customer ( Int32? CUSTOMER_ID)
{
var p = new { CUSTOMER_ID = CUSTOMER_ID };
ExecuteDelete("UPG_DELETE_CUSTOMER", p);
}
public void Delete_Invoice ( Int32? INVOICE_ID)
{
var p = new { INVOICE_ID = INVOICE_ID };
ExecuteDelete("UPG_DELETE_INVOICE", p);
}
public void Delete_Loc_l1 ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L1", p);
}
public void Delete_Loc_l2 ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L2", p);
}
public void Delete_Loc_l3 ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L3", p);
}
public void Delete_Loc_l4 ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_LOC_L4", p);
}
public void Delete_Order_details ( Int32? ORDER_DETAILS_ID)
{
var p = new { ORDER_DETAILS_ID = ORDER_DETAILS_ID };
ExecuteDelete("UPG_DELETE_ORDER_DETAILS", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Person ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_PERSON", p);
}
public void Delete_Product ( Int32? PRODUCT_ID)
{
var p = new { PRODUCT_ID = PRODUCT_ID };
ExecuteDelete("UPG_DELETE_PRODUCT", p);
}
public void Delete_Product_color ( long? PRODUCT_COLOR_ID)
{
var p = new { PRODUCT_COLOR_ID = PRODUCT_COLOR_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_COLOR", p);
}
public void Delete_Product_size ( long? PRODUCT_SIZE_ID)
{
var p = new { PRODUCT_SIZE_ID = PRODUCT_SIZE_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_SIZE", p);
}
public void Delete_Size ( Int32? SIZE_ID)
{
var p = new { SIZE_ID = SIZE_ID };
ExecuteDelete("UPG_DELETE_SIZE", p);
}
public void Delete_Uploaded_file ( long? UPLOADED_FILE_ID)
{
var p = new { UPLOADED_FILE_ID = UPLOADED_FILE_ID };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_Address_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID", p);
}
public void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L1_ID", p);
}
public void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L2_ID", p);
}
public void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L3_ID", p);
}
public void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_OWNER_ID", p);
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
var p = new { PERSON_ID = PERSON_ID,ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
}
public void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L4_ID", p);
}
public void Delete_Adress_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ADRESS_BY_OWNER_ID", p);
}
public void Delete_Category_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CATEGORY_BY_OWNER_ID", p);
}
public void Delete_Color_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_COLOR_BY_OWNER_ID", p);
}
public void Delete_Contact_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID", p);
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
var p = new { PERSON_ID = PERSON_ID,CONTACT_TYPE_CODE = CONTACT_TYPE_CODE,CONTACT = CONTACT };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
}
public void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_OWNER_ID", p);
}
public void Delete_Customer_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CUSTOMER_BY_OWNER_ID", p);
}
public void Delete_Customer_By_ADRESS_ID ( Int32? ADRESS_ID)
{
var p = new { ADRESS_ID = ADRESS_ID };
ExecuteDelete("UPG_DELETE_CUSTOMER_BY_ADRESS_ID", p);
}
public void Delete_Customer_By_USER_ID ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_CUSTOMER_BY_USER_ID", p);
}
public void Delete_Invoice_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_INVOICE_BY_OWNER_ID", p);
}
public void Delete_Invoice_By_CUSTOMER_ID ( Int32? CUSTOMER_ID)
{
var p = new { CUSTOMER_ID = CUSTOMER_ID };
ExecuteDelete("UPG_DELETE_INVOICE_BY_CUSTOMER_ID", p);
}
public void Delete_Invoice_By_ADRESS_ID ( Int32? ADRESS_ID)
{
var p = new { ADRESS_ID = ADRESS_ID };
ExecuteDelete("UPG_DELETE_INVOICE_BY_ADRESS_ID", p);
}
public void Delete_Loc_l1_By_CODE ( string CODE)
{
var p = new { CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_CODE", p);
}
public void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_OWNER_ID", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
var p = new { LOC_L1_ID = LOC_L1_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID_CODE", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID", p);
}
public void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_OWNER_ID", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
var p = new { LOC_L2_ID = LOC_L2_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID_CODE", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID", p);
}
public void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_OWNER_ID", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
var p = new { LOC_L3_ID = LOC_L3_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID_CODE", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID", p);
}
public void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_OWNER_ID", p);
}
public void Delete_Order_details_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ORDER_DETAILS_BY_OWNER_ID", p);
}
public void Delete_Order_details_By_INVOICE_ID ( Int32? INVOICE_ID)
{
var p = new { INVOICE_ID = INVOICE_ID };
ExecuteDelete("UPG_DELETE_ORDER_DETAILS_BY_INVOICE_ID", p);
}
public void Delete_Order_details_By_PRODUCT_ID ( Int32? PRODUCT_ID)
{
var p = new { PRODUCT_ID = PRODUCT_ID };
ExecuteDelete("UPG_DELETE_ORDER_DETAILS_BY_PRODUCT_ID", p);
}
public void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PERSON_BY_OWNER_ID", p);
}
public void Delete_Product_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_BY_OWNER_ID", p);
}
public void Delete_Product_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_BY_CATEGORY_ID", p);
}
public void Delete_Product_By_IS_BEST_SELLING ( bool? IS_BEST_SELLING)
{
var p = new { IS_BEST_SELLING = IS_BEST_SELLING };
ExecuteDelete("UPG_DELETE_PRODUCT_BY_IS_BEST_SELLING", p);
}
public void Delete_Product_By_IS_RECOMMENDED ( bool? IS_RECOMMENDED)
{
var p = new { IS_RECOMMENDED = IS_RECOMMENDED };
ExecuteDelete("UPG_DELETE_PRODUCT_BY_IS_RECOMMENDED", p);
}
public void Delete_Product_color_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_COLOR_BY_OWNER_ID", p);
}
public void Delete_Product_color_By_PRODUCT_ID ( Int32? PRODUCT_ID)
{
var p = new { PRODUCT_ID = PRODUCT_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_COLOR_BY_PRODUCT_ID", p);
}
public void Delete_Product_color_By_COLOR_ID ( Int32? COLOR_ID)
{
var p = new { COLOR_ID = COLOR_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_COLOR_BY_COLOR_ID", p);
}
public void Delete_Product_size_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_SIZE_BY_OWNER_ID", p);
}
public void Delete_Product_size_By_PRODUCT_ID ( Int32? PRODUCT_ID)
{
var p = new { PRODUCT_ID = PRODUCT_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_SIZE_BY_PRODUCT_ID", p);
}
public void Delete_Product_size_By_SIZE_ID ( Int32? SIZE_ID)
{
var p = new { SIZE_ID = SIZE_ID };
ExecuteDelete("UPG_DELETE_PRODUCT_SIZE_BY_SIZE_ID", p);
}
public void Delete_Size_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SIZE_BY_OWNER_ID", p);
}
public void Delete_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_OWNER_ID", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY)
{
var p = new { REL_ENTITY = REL_ENTITY };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY)
{
var p = new { REL_ENTITY = REL_ENTITY,REL_KEY = REL_KEY };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD)
{
var p = new { REL_ENTITY = REL_ENTITY,REL_KEY = REL_KEY,REL_FIELD = REL_FIELD };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY_REL_FIELD", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Address oAddress = new Address();
oAddress.ADDRESS_ID = ADDRESS_ID;oAddress.PERSON_ID = PERSON_ID;oAddress.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;oAddress.LOC_L1_ID = LOC_L1_ID;oAddress.LOC_L2_ID = LOC_L2_ID;oAddress.LOC_L3_ID = LOC_L3_ID;oAddress.LOC_L4_ID = LOC_L4_ID;oAddress.STREET = STREET;oAddress.BUILDING = BUILDING;oAddress.FLOOR = FLOOR;oAddress.POBOX = POBOX;oAddress.VALID_DATE_START = VALID_DATE_START;oAddress.VALID_DATE_END = VALID_DATE_END;oAddress.NOTES = NOTES;oAddress.ENTRY_DATE = ENTRY_DATE;oAddress.ENTRY_USER_ID = ENTRY_USER_ID;oAddress.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ADDRESS", oAddress, "ADDRESS_ID");
return oAddress.ADDRESS_ID;
}
public Int32? Edit_Adress ( Int32? ADRESS_ID, string STREET_NAME_ONE, string STREET_NAME_TWO, string STATE, string POST_CODE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Adress oAdress = new Adress();
oAdress.ADRESS_ID = ADRESS_ID;oAdress.STREET_NAME_ONE = STREET_NAME_ONE;oAdress.STREET_NAME_TWO = STREET_NAME_TWO;oAdress.STATE = STATE;oAdress.POST_CODE = POST_CODE;oAdress.ENTRY_USER_ID = ENTRY_USER_ID;oAdress.ENTRY_DATE = ENTRY_DATE;oAdress.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ADRESS", oAdress, "ADRESS_ID");
return oAdress.ADRESS_ID;
}
public Int32? Edit_Category ( Int32? CATEGORY_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Category oCategory = new Category();
oCategory.CATEGORY_ID = CATEGORY_ID;oCategory.NAME = NAME;oCategory.ENTRY_USER_ID = ENTRY_USER_ID;oCategory.ENTRY_DATE = ENTRY_DATE;oCategory.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CATEGORY", oCategory, "CATEGORY_ID");
return oCategory.CATEGORY_ID;
}
public Int32? Edit_Color ( Int32? COLOR_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Color oColor = new Color();
oColor.COLOR_ID = COLOR_ID;oColor.NAME = NAME;oColor.ENTRY_USER_ID = ENTRY_USER_ID;oColor.ENTRY_DATE = ENTRY_DATE;oColor.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_COLOR", oColor, "COLOR_ID");
return oColor.COLOR_ID;
}
public Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Contact oContact = new Contact();
oContact.CONTACT_ID = CONTACT_ID;oContact.PERSON_ID = PERSON_ID;oContact.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE;oContact.CONTACT = CONTACT;oContact.DESCRIPTION = DESCRIPTION;oContact.ENTRY_USER_ID = ENTRY_USER_ID;oContact.ENTRY_DATE = ENTRY_DATE;oContact.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CONTACT", oContact, "CONTACT_ID");
return oContact.CONTACT_ID;
}
public Int32? Edit_Customer ( Int32? CUSTOMER_ID, long? USER_ID, string FIRST_NAME, string LAST_NAME, Int32? ADRESS_ID, string PHONE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Customer oCustomer = new Customer();
oCustomer.CUSTOMER_ID = CUSTOMER_ID;oCustomer.USER_ID = USER_ID;oCustomer.FIRST_NAME = FIRST_NAME;oCustomer.LAST_NAME = LAST_NAME;oCustomer.ADRESS_ID = ADRESS_ID;oCustomer.PHONE = PHONE;oCustomer.ENTRY_USER_ID = ENTRY_USER_ID;oCustomer.ENTRY_DATE = ENTRY_DATE;oCustomer.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CUSTOMER", oCustomer, "CUSTOMER_ID");
return oCustomer.CUSTOMER_ID;
}
public Int32? Edit_Invoice ( Int32? INVOICE_ID, Int32? CUSTOMER_ID, Int32? AMMOUNT, Int32? ADRESS_ID, Int32? ORDER_STATUS, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Invoice oInvoice = new Invoice();
oInvoice.INVOICE_ID = INVOICE_ID;oInvoice.CUSTOMER_ID = CUSTOMER_ID;oInvoice.AMMOUNT = AMMOUNT;oInvoice.ADRESS_ID = ADRESS_ID;oInvoice.ORDER_STATUS = ORDER_STATUS;oInvoice.ENTRY_USER_ID = ENTRY_USER_ID;oInvoice.ENTRY_DATE = ENTRY_DATE;oInvoice.OWNER_ID = OWNER_ID;oInvoice.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_INVOICE", oInvoice, "INVOICE_ID");
return oInvoice.INVOICE_ID;
}
public long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l1 oLoc_l1 = new Loc_l1();
oLoc_l1.LOC_L1_ID = LOC_L1_ID;oLoc_l1.CODE = CODE;oLoc_l1.DESCRIPTION = DESCRIPTION;oLoc_l1.NOTES = NOTES;oLoc_l1.ENTRY_DATE = ENTRY_DATE;oLoc_l1.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l1.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L1", oLoc_l1, "LOC_L1_ID");
return oLoc_l1.LOC_L1_ID;
}
public long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l2 oLoc_l2 = new Loc_l2();
oLoc_l2.LOC_L2_ID = LOC_L2_ID;oLoc_l2.CODE = CODE;oLoc_l2.DESCRIPTION = DESCRIPTION;oLoc_l2.LOC_L1_ID = LOC_L1_ID;oLoc_l2.NOTES = NOTES;oLoc_l2.ENTRY_DATE = ENTRY_DATE;oLoc_l2.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l2.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L2", oLoc_l2, "LOC_L2_ID");
return oLoc_l2.LOC_L2_ID;
}
public long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l3 oLoc_l3 = new Loc_l3();
oLoc_l3.LOC_L3_ID = LOC_L3_ID;oLoc_l3.CODE = CODE;oLoc_l3.DESCRIPTION = DESCRIPTION;oLoc_l3.LOC_L2_ID = LOC_L2_ID;oLoc_l3.NOTES = NOTES;oLoc_l3.ENTRY_DATE = ENTRY_DATE;oLoc_l3.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l3.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L3", oLoc_l3, "LOC_L3_ID");
return oLoc_l3.LOC_L3_ID;
}
public long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l4 oLoc_l4 = new Loc_l4();
oLoc_l4.LOC_L4_ID = LOC_L4_ID;oLoc_l4.CODE = CODE;oLoc_l4.DESCRIPTION = DESCRIPTION;oLoc_l4.LOC_L3_ID = LOC_L3_ID;oLoc_l4.NOTES = NOTES;oLoc_l4.ENTRY_DATE = ENTRY_DATE;oLoc_l4.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l4.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L4", oLoc_l4, "LOC_L4_ID");
return oLoc_l4.LOC_L4_ID;
}
public Int32? Edit_Order_details ( Int32? ORDER_DETAILS_ID, Int32? INVOICE_ID, Int32? PRODUCT_ID, decimal PRICE, Int32? QUANTITY, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Order_details oOrder_details = new Order_details();
oOrder_details.ORDER_DETAILS_ID = ORDER_DETAILS_ID;oOrder_details.INVOICE_ID = INVOICE_ID;oOrder_details.PRODUCT_ID = PRODUCT_ID;oOrder_details.PRICE = PRICE;oOrder_details.QUANTITY = QUANTITY;oOrder_details.ENTRY_USER_ID = ENTRY_USER_ID;oOrder_details.ENTRY_DATE = ENTRY_DATE;oOrder_details.OWNER_ID = OWNER_ID;oOrder_details.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_ORDER_DETAILS", oOrder_details, "ORDER_DETAILS_ID");
return oOrder_details.ORDER_DETAILS_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE)
{
Person oPerson = new Person();
oPerson.PERSON_ID = PERSON_ID;oPerson.FIRST_NAME = FIRST_NAME;oPerson.LAST_NAME = LAST_NAME;oPerson.FATHER_NAME = FATHER_NAME;oPerson.MOTHER_NAME = MOTHER_NAME;oPerson.TITLE_CODE = TITLE_CODE;oPerson.GENDER_CODE = GENDER_CODE;oPerson.RELIGION_CODE = RELIGION_CODE;oPerson.BIRTH_DATE = BIRTH_DATE;oPerson.IS_BLOCKED = IS_BLOCKED;oPerson.DESCRIPTION = DESCRIPTION;oPerson.OWNER_ID = OWNER_ID;oPerson.ENTRY_USER_ID = ENTRY_USER_ID;oPerson.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_PERSON", oPerson, "PERSON_ID");
return oPerson.PERSON_ID;
}
public Int32? Edit_Product ( Int32? PRODUCT_ID, string NAME, string DESCRIPTION, Int32? CATEGORY_ID, Int32? STOCK, decimal FULL_PRICE, decimal? DISCOUNT_PRICE, bool? IS_BEST_SELLING, bool? IS_RECOMMENDED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Product oProduct = new Product();
oProduct.PRODUCT_ID = PRODUCT_ID;oProduct.NAME = NAME;oProduct.DESCRIPTION = DESCRIPTION;oProduct.CATEGORY_ID = CATEGORY_ID;oProduct.STOCK = STOCK;oProduct.FULL_PRICE = FULL_PRICE;oProduct.DISCOUNT_PRICE = DISCOUNT_PRICE;oProduct.IS_BEST_SELLING = IS_BEST_SELLING;oProduct.IS_RECOMMENDED = IS_RECOMMENDED;oProduct.ENTRY_USER_ID = ENTRY_USER_ID;oProduct.ENTRY_DATE = ENTRY_DATE;oProduct.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_PRODUCT", oProduct, "PRODUCT_ID");
return oProduct.PRODUCT_ID;
}
public long? Edit_Product_color ( long? PRODUCT_COLOR_ID, Int32? PRODUCT_ID, Int32? COLOR_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Product_color oProduct_color = new Product_color();
oProduct_color.PRODUCT_COLOR_ID = PRODUCT_COLOR_ID;oProduct_color.PRODUCT_ID = PRODUCT_ID;oProduct_color.COLOR_ID = COLOR_ID;oProduct_color.ENTRY_USER_ID = ENTRY_USER_ID;oProduct_color.ENTRY_DATE = ENTRY_DATE;oProduct_color.OWNER_ID = OWNER_ID;oProduct_color.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_PRODUCT_COLOR", oProduct_color, "PRODUCT_COLOR_ID");
return oProduct_color.PRODUCT_COLOR_ID;
}
public long? Edit_Product_size ( long? PRODUCT_SIZE_ID, Int32? PRODUCT_ID, Int32? SIZE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Product_size oProduct_size = new Product_size();
oProduct_size.PRODUCT_SIZE_ID = PRODUCT_SIZE_ID;oProduct_size.PRODUCT_ID = PRODUCT_ID;oProduct_size.SIZE_ID = SIZE_ID;oProduct_size.ENTRY_USER_ID = ENTRY_USER_ID;oProduct_size.ENTRY_DATE = ENTRY_DATE;oProduct_size.OWNER_ID = OWNER_ID;oProduct_size.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_PRODUCT_SIZE", oProduct_size, "PRODUCT_SIZE_ID");
return oProduct_size.PRODUCT_SIZE_ID;
}
public Int32? Edit_Size ( Int32? SIZE_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Size oSize = new Size();
oSize.SIZE_ID = SIZE_ID;oSize.DESCRIPTION = DESCRIPTION;oSize.ENTRY_USER_ID = ENTRY_USER_ID;oSize.ENTRY_DATE = ENTRY_DATE;oSize.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_SIZE", oSize, "SIZE_ID");
return oSize.SIZE_ID;
}
public long? Edit_Uploaded_file ( long? UPLOADED_FILE_ID, string REL_ENTITY, long? REL_KEY, string REL_FIELD, Int32? SIZE, string EXTENSION, string STAMP, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Uploaded_file oUploaded_file = new Uploaded_file();
oUploaded_file.UPLOADED_FILE_ID = UPLOADED_FILE_ID;oUploaded_file.REL_ENTITY = REL_ENTITY;oUploaded_file.REL_KEY = REL_KEY;oUploaded_file.REL_FIELD = REL_FIELD;oUploaded_file.SIZE = SIZE;oUploaded_file.EXTENSION = EXTENSION;oUploaded_file.STAMP = STAMP;oUploaded_file.ENTRY_USER_ID = ENTRY_USER_ID;oUploaded_file.ENTRY_DATE = ENTRY_DATE;oUploaded_file.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_UPLOADED_FILE", oUploaded_file, "UPLOADED_FILE_ID");
return oUploaded_file.UPLOADED_FILE_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string EMAIL, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.EMAIL = EMAIL;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ADDRESS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADDRESS_ID = GV<Int64>(X["ADDRESS_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.ADDRESS_TYPE_CODE = GV<String>(X["ADDRESS_TYPE_CODE"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.STREET = GV<String>(X["STREET"]);o.BUILDING = GV<String>(X["BUILDING"]);o.FLOOR = GV<String>(X["FLOOR"]);o.POBOX = GV<String>(X["POBOX"]);o.VALID_DATE_START = GV<String>(X["VALID_DATE_START"]);o.VALID_DATE_END = GV<String>(X["VALID_DATE_END"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ADRESS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ADRESS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADRESS_ID = GV<Int32>(X["ADRESS_ID"]);o.STREET_NAME_ONE = GV<String>(X["STREET_NAME_ONE"]);o.STREET_NAME_TWO = GV<String>(X["STREET_NAME_TWO"]);o.STATE = GV<String>(X["STATE"]);o.POST_CODE = GV<String>(X["POST_CODE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ATTRIBUTE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ATTRIBUTE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CATEGORY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CATEGORY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.NAME = GV<String>(X["NAME"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_COLOR ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_COLOR", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.COLOR_ID = GV<Int32>(X["COLOR_ID"]);o.NAME = GV<String>(X["NAME"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CONTACT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CONTACT_ID = GV<Int32>(X["CONTACT_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.CONTACT_TYPE_CODE = GV<String>(X["CONTACT_TYPE_CODE"]);o.CONTACT = GV<String>(X["CONTACT"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CUSTOMER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CUSTOMER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CUSTOMER_ID = GV<Int32>(X["CUSTOMER_ID"]);o.USER_ID = GV<Int64>(X["USER_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.ADRESS_ID = GV<Int32>(X["ADRESS_ID"]);o.PHONE = GV<String>(X["PHONE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_INVOICE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_INVOICE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.INVOICE_ID = GV<Int32>(X["INVOICE_ID"]);o.CUSTOMER_ID = GV<Int32>(X["CUSTOMER_ID"]);o.AMMOUNT = GV<Int32>(X["AMMOUNT"]);o.ADRESS_ID = GV<Int32>(X["ADRESS_ID"]);o.ORDER_STATUS = GV<Int32>(X["ORDER_STATUS"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L1", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L2", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L3", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L4", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ORDER_DETAILS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ORDER_DETAILS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ORDER_DETAILS_ID = GV<Int32>(X["ORDER_DETAILS_ID"]);o.INVOICE_ID = GV<Int32>(X["INVOICE_ID"]);o.PRODUCT_ID = GV<Int32>(X["PRODUCT_ID"]);o.PRICE = GV<Decimal>(X["PRICE"]);o.QUANTITY = GV<Int32>(X["QUANTITY"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OWNER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CODE = GV<String>(X["CODE"]);o.MAINTENANCE_DUE_DATE = GV<String>(X["MAINTENANCE_DUE_DATE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PERSON", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.FATHER_NAME = GV<String>(X["FATHER_NAME"]);o.MOTHER_NAME = GV<String>(X["MOTHER_NAME"]);o.TITLE_CODE = GV<String>(X["TITLE_CODE"]);o.GENDER_CODE = GV<String>(X["GENDER_CODE"]);o.RELIGION_CODE = GV<String>(X["RELIGION_CODE"]);o.BIRTH_DATE = GV<String>(X["BIRTH_DATE"]);o.IS_BLOCKED = GV<Boolean>(X["IS_BLOCKED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PRODUCT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PRODUCT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PRODUCT_ID = GV<Int32>(X["PRODUCT_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.STOCK = GV<Int32>(X["STOCK"]);o.FULL_PRICE = GV<Decimal>(X["FULL_PRICE"]);o.DISCOUNT_PRICE = GV<Decimal>(X["DISCOUNT_PRICE"]);o.IS_BEST_SELLING = GV<Boolean>(X["IS_BEST_SELLING"]);o.IS_RECOMMENDED = GV<Boolean>(X["IS_RECOMMENDED"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PRODUCT_COLOR ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PRODUCT_COLOR", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PRODUCT_COLOR_ID = GV<Int64>(X["PRODUCT_COLOR_ID"]);o.PRODUCT_ID = GV<Int32>(X["PRODUCT_ID"]);o.COLOR_ID = GV<Int32>(X["COLOR_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PRODUCT_SIZE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PRODUCT_SIZE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PRODUCT_SIZE_ID = GV<Int64>(X["PRODUCT_SIZE_ID"]);o.PRODUCT_ID = GV<Int32>(X["PRODUCT_ID"]);o.SIZE_ID = GV<Int32>(X["SIZE_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SIZE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SIZE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SIZE_ID = GV<Int32>(X["SIZE_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_UPLOADED_FILE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_UPLOADED_FILE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.UPLOADED_FILE_ID = GV<Int64>(X["UPLOADED_FILE_ID"]);o.REL_ENTITY = GV<String>(X["REL_ENTITY"]);o.REL_KEY = GV<Int64>(X["REL_KEY"]);o.REL_FIELD = GV<String>(X["REL_FIELD"]);o.SIZE = GV<Int32>(X["SIZE"]);o.EXTENSION = GV<String>(X["EXTENSION"]);o.STAMP = GV<String>(X["STAMP"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.EMAIL = GV<String>(X["EMAIL"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
}
}
