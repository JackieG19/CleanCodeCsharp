## Output Parameters
Example 1 
- Doesn't make sense to pass a data in and come out from the argument
```
int count = 0;
var customers = GetCustomers(pageIndex, out count);
```
Example 2
- In order to call this method, have to initialize two variable and thats unnecessary.
```
int count = 0;
bool more = false;

var customer = GetCustomers(pageIndex, out count, out more);
```

**To avoid this: Return an object from a method instead.**
