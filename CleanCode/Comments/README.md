# Comments can be code smells
- Stating the obvious
```
Example 1:

// Returns the list of customer
public List<Customer> GetCustomer()
{
    // ...
} 
```
```
Example 2:

// create a new connection to the database
var connection = new SqlConnection();
```
```
Example 3: 

// If the number of overdue days is less than 5, notify the customer.
// Otherwise, issue a fine.

if(overdueDays < 5)
  NotifyCustomer();
else
  IssueFine();
```
___
- Version History
```
// prior to v1.3
if(isActive) {}
```
```
// 1 Jan 2000 - John Smith: ...
// 4 Jun 2003 - John Smith: ...
// 21 Dec 2005 - Andy McDonald: ...
...
...
...
...
...

public class WorkScheduler
```
___
- Clarify the code
```
// Pay Frequency
var pf = 10;
```
___
- Dead Code
```
// public class WorkScheduler
// {
// }

just delete it
```
# * The ultimate comment for the code is the code itself *
