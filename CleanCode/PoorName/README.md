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
___
**Inconsistent Naming Conventions**
```
Customer GetCustomer(int _id);
Customer saveCustomer(Customer Customer);
private in customerId;
```
.NET Naming Conventions
- PascalCase
- camelCase
```
public class Customer
{
   private int _id;
   
   public string Name { get; set; }
   
   public void Charge(int amount)
   {
     var tax = 0;
   }
}
```
