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
#region Params_Get_Address_By_ADDRESS_ID
public partial class Params_Get_Address_By_ADDRESS_ID
{
#region Properties
public long? ADDRESS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Adress_By_ADRESS_ID
public partial class Params_Get_Adress_By_ADRESS_ID
{
#region Properties
public Int32? ADRESS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Category_By_CATEGORY_ID
public partial class Params_Get_Category_By_CATEGORY_ID
{
#region Properties
public Int32? CATEGORY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Color_By_COLOR_ID
public partial class Params_Get_Color_By_COLOR_ID
{
#region Properties
public Int32? COLOR_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Contact_By_CONTACT_ID
public partial class Params_Get_Contact_By_CONTACT_ID
{
#region Properties
public Int32? CONTACT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Customer_By_CUSTOMER_ID
public partial class Params_Get_Customer_By_CUSTOMER_ID
{
#region Properties
public Int32? CUSTOMER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Invoice_By_INVOICE_ID
public partial class Params_Get_Invoice_By_INVOICE_ID
{
#region Properties
public Int32? INVOICE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Invoice_status_By_INVOICE_STATUS_ID
public partial class Params_Get_Invoice_status_By_INVOICE_STATUS_ID
{
#region Properties
public Int32? INVOICE_STATUS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l1_By_LOC_L1_ID
public partial class Params_Get_Loc_l1_By_LOC_L1_ID
{
#region Properties
public long? LOC_L1_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l2_By_LOC_L2_ID
public partial class Params_Get_Loc_l2_By_LOC_L2_ID
{
#region Properties
public long? LOC_L2_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l3_By_LOC_L3_ID
public partial class Params_Get_Loc_l3_By_LOC_L3_ID
{
#region Properties
public long? LOC_L3_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l4_By_LOC_L4_ID
public partial class Params_Get_Loc_l4_By_LOC_L4_ID
{
#region Properties
public long? LOC_L4_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Order_details_By_ORDER_DETAILS_ID
public partial class Params_Get_Order_details_By_ORDER_DETAILS_ID
{
#region Properties
public Int32? ORDER_DETAILS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Person_By_PERSON_ID
public partial class Params_Get_Person_By_PERSON_ID
{
#region Properties
public long? PERSON_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Product_By_PRODUCT_ID
public partial class Params_Get_Product_By_PRODUCT_ID
{
#region Properties
public Int32? PRODUCT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Size_By_SIZE_ID
public partial class Params_Get_Size_By_SIZE_ID
{
#region Properties
public Int32? SIZE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_account_By_USER_ACCOUNT_ID
public partial class Params_Get_User_account_By_USER_ACCOUNT_ID
{
#region Properties
public long? USER_ACCOUNT_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_Address_By_ADDRESS_ID_List
{
public List<long?> ADDRESS_ID_LIST {get;set;}
}
public partial class Params_Get_Address_By_ADDRESS_ID_List_SP
{
public string ADDRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Adress_By_ADRESS_ID_List
{
public List<Int32?> ADRESS_ID_LIST {get;set;}
}
public partial class Params_Get_Adress_By_ADRESS_ID_List_SP
{
public string ADRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Category_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}
}
public partial class Params_Get_Category_By_CATEGORY_ID_List_SP
{
public string CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Color_By_COLOR_ID_List
{
public List<Int32?> COLOR_ID_LIST {get;set;}
}
public partial class Params_Get_Color_By_COLOR_ID_List_SP
{
public string COLOR_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_CONTACT_ID_List
{
public List<Int32?> CONTACT_ID_LIST {get;set;}
}
public partial class Params_Get_Contact_By_CONTACT_ID_List_SP
{
public string CONTACT_ID_LIST {get;set;}

}
public partial class Params_Get_Customer_By_CUSTOMER_ID_List
{
public List<Int32?> CUSTOMER_ID_LIST {get;set;}
}
public partial class Params_Get_Customer_By_CUSTOMER_ID_List_SP
{
public string CUSTOMER_ID_LIST {get;set;}

}
public partial class Params_Get_Invoice_By_INVOICE_ID_List
{
public List<Int32?> INVOICE_ID_LIST {get;set;}
}
public partial class Params_Get_Invoice_By_INVOICE_ID_List_SP
{
public string INVOICE_ID_LIST {get;set;}

}
public partial class Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List
{
public List<Int32?> INVOICE_STATUS_ID_LIST {get;set;}
}
public partial class Params_Get_Invoice_status_By_INVOICE_STATUS_ID_List_SP
{
public string INVOICE_STATUS_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List_SP
{
public string LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List_SP
{
public string LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List_SP
{
public string LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List_SP
{
public string LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Order_details_By_ORDER_DETAILS_ID_List
{
public List<Int32?> ORDER_DETAILS_ID_LIST {get;set;}
}
public partial class Params_Get_Order_details_By_ORDER_DETAILS_ID_List_SP
{
public string ORDER_DETAILS_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_Person_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}
}
public partial class Params_Get_Person_By_PERSON_ID_List_SP
{
public string PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Product_By_PRODUCT_ID_List
{
public List<Int32?> PRODUCT_ID_LIST {get;set;}
}
public partial class Params_Get_Product_By_PRODUCT_ID_List_SP
{
public string PRODUCT_ID_LIST {get;set;}

}
public partial class Params_Get_Size_By_SIZE_ID_List
{
public List<Int32?> SIZE_ID_LIST {get;set;}
}
public partial class Params_Get_Size_By_SIZE_ID_List_SP
{
public string SIZE_ID_LIST {get;set;}

}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List
{
public List<long?> UPLOADED_FILE_ID_LIST {get;set;}
}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP
{
public string UPLOADED_FILE_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_User_account_By_USER_ACCOUNT_ID_List
{
public List<long?> USER_ACCOUNT_ID_LIST {get;set;}
}
public partial class Params_Get_User_account_By_USER_ACCOUNT_ID_List_SP
{
public string USER_ACCOUNT_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}

}
public partial class Params_Get_Adress_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Adress_By_USER_ID
{
public long? USER_ID {get;set;}

}
public partial class Params_Get_Category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Color_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}

}
public partial class Params_Get_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Customer_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Customer_By_ADRESS_ID
{
public Int32? ADRESS_ID {get;set;}

}
public partial class Params_Get_Customer_By_USER_ID
{
public long? USER_ID {get;set;}

}
public partial class Params_Get_Invoice_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Invoice_By_INVOICE_STATUS_ID
{
public Int32? INVOICE_STATUS_ID {get;set;}

}
public partial class Params_Get_Invoice_By_USER_ACCOUNT_ID
{
public long? USER_ACCOUNT_ID {get;set;}

}
public partial class Params_Get_Invoice_status_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l1_By_CODE
{
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Order_details_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Order_details_By_PRODUCT_ID
{
public Int32? PRODUCT_ID {get;set;}

}
public partial class Params_Get_Order_details_By_INVOICE_ID
{
public Int32? INVOICE_ID {get;set;}

}
public partial class Params_Get_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Product_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Product_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}

}
public partial class Params_Get_Product_By_IS_BEST_SELLING
{
public bool? IS_BEST_SELLING {get;set;}

}
public partial class Params_Get_Product_By_IS_RECOMMENDED
{
public bool? IS_RECOMMENDED {get;set;}

}
public partial class Params_Get_Product_By_COLOR_ID
{
public Int32? COLOR_ID {get;set;}

}
public partial class Params_Get_Product_By_SIZE_ID
{
public Int32? SIZE_ID {get;set;}

}
public partial class Params_Get_Size_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_User_By_EMAIL
{
public string EMAIL {get;set;}

}
public partial class Params_Get_User_account_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_account_By_USER_ID
{
public long? USER_ID {get;set;}

}
public partial class Params_Get_User_account_By_ADRESS_ID
{
public Int32? ADRESS_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Adress_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Customer_By_ADRESS_ID_List
{
public List<Int32?> ADRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Customer_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}

}
public partial class Params_Get_Invoice_By_INVOICE_STATUS_ID_List
{
public List<Int32?> INVOICE_STATUS_ID_LIST {get;set;}

}
public partial class Params_Get_Invoice_By_USER_ACCOUNT_ID_List
{
public List<long?> USER_ACCOUNT_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Order_details_By_PRODUCT_ID_List
{
public List<Int32?> PRODUCT_ID_LIST {get;set;}

}
public partial class Params_Get_Order_details_By_INVOICE_ID_List
{
public List<Int32?> INVOICE_ID_LIST {get;set;}

}
public partial class Params_Get_Product_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Product_By_COLOR_ID_List
{
public List<Int32?> COLOR_ID_LIST {get;set;}

}
public partial class Params_Get_Product_By_SIZE_ID_List
{
public List<Int32?> SIZE_ID_LIST {get;set;}

}
public partial class Params_Get_User_account_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}

}
public partial class Params_Get_User_account_By_ADRESS_ID_List
{
public List<Int32?> ADRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Adress_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string HOST_NAME {get;set;}
public string STREET_NAME_ONE {get;set;}
public string STREET_NAME_TWO {get;set;}
public string STATE {get;set;}
public string POST_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Adress_By_Where
{

public Int32? OWNER_ID {get;set;}
public string HOST_NAME {get;set;}
public string STREET_NAME_ONE {get;set;}
public string STREET_NAME_TWO {get;set;}
public string STATE {get;set;}
public string POST_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Color_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Color_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Customer_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Customer_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_status_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string INVOICE_STATUS {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_status_By_Where
{

public Int32? OWNER_ID {get;set;}
public string INVOICE_STATUS {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Order_details_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Order_details_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Product_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Product_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Size_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Size_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Where
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string EMAIL {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string EMAIL {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_account_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_account_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Adress_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string HOST_NAME {get;set;}
public string STREET_NAME_ONE {get;set;}
public string STREET_NAME_TWO {get;set;}
public string STATE {get;set;}
public string POST_CODE {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Adress_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string HOST_NAME {get;set;}
public string STREET_NAME_ONE {get;set;}
public string STREET_NAME_TWO {get;set;}
public string STATE {get;set;}
public string POST_CODE {get;set;}
public string USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Adress_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string HOST_NAME {get;set;}
public string STREET_NAME_ONE {get;set;}
public string STREET_NAME_TWO {get;set;}
public string STATE {get;set;}
public string POST_CODE {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Adress_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string HOST_NAME {get;set;}
public string STREET_NAME_ONE {get;set;}
public string STREET_NAME_TWO {get;set;}
public string STATE {get;set;}
public string POST_CODE {get;set;}
public string USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Customer_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public List<Int32?> ADRESS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Customer_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public string USER_ID_LIST {get;set;}
public string ADRESS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Customer_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public List<Int32?> ADRESS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Customer_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public string USER_ID_LIST {get;set;}
public string ADRESS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> USER_ACCOUNT_ID_LIST {get;set;}
public List<Int32?> INVOICE_STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string USER_ACCOUNT_ID_LIST {get;set;}
public string INVOICE_STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> USER_ACCOUNT_ID_LIST {get;set;}
public List<Int32?> INVOICE_STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Invoice_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string USER_ACCOUNT_ID_LIST {get;set;}
public string INVOICE_STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Order_details_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> PRODUCT_ID_LIST {get;set;}
public List<Int32?> INVOICE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Order_details_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string PRODUCT_ID_LIST {get;set;}
public string INVOICE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Order_details_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> PRODUCT_ID_LIST {get;set;}
public List<Int32?> INVOICE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Order_details_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string PRODUCT_ID_LIST {get;set;}
public string INVOICE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Product_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public List<Int32?> COLOR_ID_LIST {get;set;}
public List<Int32?> SIZE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Product_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public string COLOR_ID_LIST {get;set;}
public string SIZE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Product_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public List<Int32?> COLOR_ID_LIST {get;set;}
public List<Int32?> SIZE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Product_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public string COLOR_ID_LIST {get;set;}
public string SIZE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_account_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> ADRESS_ID_LIST {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_account_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string ADRESS_ID_LIST {get;set;}
public string USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_account_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> ADRESS_ID_LIST {get;set;}
public List<long?> USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_account_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string ADRESS_ID_LIST {get;set;}
public string USER_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_Address
public partial class Params_Delete_Address
{
#region Properties
public long? ADDRESS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Adress
public partial class Params_Delete_Adress
{
#region Properties
public Int32? ADRESS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Category
public partial class Params_Delete_Category
{
#region Properties
public Int32? CATEGORY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Color
public partial class Params_Delete_Color
{
#region Properties
public Int32? COLOR_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Contact
public partial class Params_Delete_Contact
{
#region Properties
public Int32? CONTACT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Customer
public partial class Params_Delete_Customer
{
#region Properties
public Int32? CUSTOMER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Invoice
public partial class Params_Delete_Invoice
{
#region Properties
public Int32? INVOICE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Invoice_status
public partial class Params_Delete_Invoice_status
{
#region Properties
public Int32? INVOICE_STATUS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l1
public partial class Params_Delete_Loc_l1
{
#region Properties
public long? LOC_L1_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l2
public partial class Params_Delete_Loc_l2
{
#region Properties
public long? LOC_L2_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l3
public partial class Params_Delete_Loc_l3
{
#region Properties
public long? LOC_L3_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l4
public partial class Params_Delete_Loc_l4
{
#region Properties
public long? LOC_L4_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Order_details
public partial class Params_Delete_Order_details
{
#region Properties
public Int32? ORDER_DETAILS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Person
public partial class Params_Delete_Person
{
#region Properties
public long? PERSON_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Product
public partial class Params_Delete_Product
{
#region Properties
public Int32? PRODUCT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Size
public partial class Params_Delete_Size
{
#region Properties
public Int32? SIZE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Uploaded_file
public partial class Params_Delete_Uploaded_file
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User_account
public partial class Params_Delete_User_account
{
#region Properties
public long? USER_ACCOUNT_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}
}
public partial class Params_Delete_Adress_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Adress_By_USER_ID
{
public long? USER_ID {get;set;}
}
public partial class Params_Delete_Category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Color_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
}
public partial class Params_Delete_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Customer_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Customer_By_ADRESS_ID
{
public Int32? ADRESS_ID {get;set;}
}
public partial class Params_Delete_Customer_By_USER_ID
{
public long? USER_ID {get;set;}
}
public partial class Params_Delete_Invoice_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Invoice_By_INVOICE_STATUS_ID
{
public Int32? INVOICE_STATUS_ID {get;set;}
}
public partial class Params_Delete_Invoice_By_USER_ACCOUNT_ID
{
public long? USER_ACCOUNT_ID {get;set;}
}
public partial class Params_Delete_Invoice_status_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l1_By_CODE
{
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Order_details_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Order_details_By_PRODUCT_ID
{
public Int32? PRODUCT_ID {get;set;}
}
public partial class Params_Delete_Order_details_By_INVOICE_ID
{
public Int32? INVOICE_ID {get;set;}
}
public partial class Params_Delete_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Product_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Product_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}
}
public partial class Params_Delete_Product_By_IS_BEST_SELLING
{
public bool? IS_BEST_SELLING {get;set;}
}
public partial class Params_Delete_Product_By_IS_RECOMMENDED
{
public bool? IS_RECOMMENDED {get;set;}
}
public partial class Params_Delete_Product_By_COLOR_ID
{
public Int32? COLOR_ID {get;set;}
}
public partial class Params_Delete_Product_By_SIZE_ID
{
public Int32? SIZE_ID {get;set;}
}
public partial class Params_Delete_Size_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_User_By_EMAIL
{
public string EMAIL {get;set;}
}
public partial class Params_Delete_User_account_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_account_By_USER_ID
{
public long? USER_ID {get;set;}
}
public partial class Params_Delete_User_account_By_ADRESS_ID
{
public Int32? ADRESS_ID {get;set;}
}
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
}
public partial class Adress
{
public Int32? ADRESS_ID {get;set;}
public long? USER_ID {get;set;}
public string HOST_NAME {get;set;}
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
}
public partial class Invoice
{
public Int32? INVOICE_ID {get;set;}
public long? USER_ACCOUNT_ID {get;set;}
public Int32? INVOICE_STATUS_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
}
public partial class Invoice_status
{
public Int32? INVOICE_STATUS_ID {get;set;}
public string INVOICE_STATUS {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
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
}
public partial class Order_details
{
public Int32? ORDER_DETAILS_ID {get;set;}
public Int32? PRODUCT_ID {get;set;}
public decimal PRICE {get;set;}
public Int32? QUANTITY {get;set;}
public Int32? INVOICE_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
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
public Int32? COLOR_ID {get;set;}
public Int32? SIZE_ID {get;set;}
public decimal? DISCOUNT_PRICE {get;set;}
public bool? IS_BEST_SELLING {get;set;}
public bool? IS_RECOMMENDED {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
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
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string PHONE {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class User_account
{
public long? USER_ACCOUNT_ID {get;set;}
public Int32? ADRESS_ID {get;set;}
public long? USER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
}
#region Params_Edit_Address_List
public partial class Params_Edit_Address_List
{
#region Properties
public List<Address> My_List_To_Edit { get; set; }
public List<Address> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Adress_List
public partial class Params_Edit_Adress_List
{
#region Properties
public List<Adress> My_List_To_Edit { get; set; }
public List<Adress> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Category_List
public partial class Params_Edit_Category_List
{
#region Properties
public List<Category> My_List_To_Edit { get; set; }
public List<Category> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Color_List
public partial class Params_Edit_Color_List
{
#region Properties
public List<Color> My_List_To_Edit { get; set; }
public List<Color> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Contact_List
public partial class Params_Edit_Contact_List
{
#region Properties
public List<Contact> My_List_To_Edit { get; set; }
public List<Contact> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Customer_List
public partial class Params_Edit_Customer_List
{
#region Properties
public List<Customer> My_List_To_Edit { get; set; }
public List<Customer> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Invoice_List
public partial class Params_Edit_Invoice_List
{
#region Properties
public List<Invoice> My_List_To_Edit { get; set; }
public List<Invoice> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Invoice_status_List
public partial class Params_Edit_Invoice_status_List
{
#region Properties
public List<Invoice_status> My_List_To_Edit { get; set; }
public List<Invoice_status> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l1_List
public partial class Params_Edit_Loc_l1_List
{
#region Properties
public List<Loc_l1> My_List_To_Edit { get; set; }
public List<Loc_l1> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l2_List
public partial class Params_Edit_Loc_l2_List
{
#region Properties
public List<Loc_l2> My_List_To_Edit { get; set; }
public List<Loc_l2> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l3_List
public partial class Params_Edit_Loc_l3_List
{
#region Properties
public List<Loc_l3> My_List_To_Edit { get; set; }
public List<Loc_l3> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l4_List
public partial class Params_Edit_Loc_l4_List
{
#region Properties
public List<Loc_l4> My_List_To_Edit { get; set; }
public List<Loc_l4> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Order_details_List
public partial class Params_Edit_Order_details_List
{
#region Properties
public List<Order_details> My_List_To_Edit { get; set; }
public List<Order_details> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Person_List
public partial class Params_Edit_Person_List
{
#region Properties
public List<Person> My_List_To_Edit { get; set; }
public List<Person> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Product_List
public partial class Params_Edit_Product_List
{
#region Properties
public List<Product> My_List_To_Edit { get; set; }
public List<Product> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Size_List
public partial class Params_Edit_Size_List
{
#region Properties
public List<Size> My_List_To_Edit { get; set; }
public List<Size> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Uploaded_file_List
public partial class Params_Edit_Uploaded_file_List
{
#region Properties
public List<Uploaded_file> My_List_To_Edit { get; set; }
public List<Uploaded_file> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_account_List
public partial class Params_Edit_User_account_List
{
#region Properties
public List<User_account> My_List_To_Edit { get; set; }
public List<User_account> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
