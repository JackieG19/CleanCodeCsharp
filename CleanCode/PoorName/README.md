# Poorly Named Code
- Mysterious Names 
```
SqlDataReader dr1;              
int od;                         
void Button_Click();            
class Page1{}                   
```
Improved Naming
```
SqlDataReader dataReader;  or  SqlDataReader reader;
int overdueDays;
void CheckAvailabitity_Click();
class ViewCustomerPage;
```
- Meaningless Names
```
void BeginCheckFunctionality_StoreClientSideCheckboxIDsArray();
```
___
- Names with Encodings 
```               
int iMaxRequests;                   
var m_objCollection = new StringCollection();
```
Improved Naming
```
int maxRequests;
var countryNames = new StringCollection();
```
___
 - Ambiguous Names - what does this code do?
```
bool MultiSelect() {}
incidentNameId;
```
 - Noisy Name
```
Customer theCustomer;
List<Customer> listOfApprovedCustomers;
```
Improved Naming
```
Customer customer;
List<Customer> approvedCustomers;
```
