# NestedConditionals
- **Use ternay operator**
```
if(a)
  c = someValue;
else
  c = anotherValue;
```
Rewrite condition:
```
c = (a)? someValue : anotherValue;
```
Example 1:
```
if(customer.TotalOrders > 50)
  discount = 0.1f;
else
  discount = 0.01f;
```
Rewriten:
```
discount = (customer.TotalOrders > 50) ? 0.1f : 0.1f
```
Example 2:
```
if(customer.TotalOrders > 50)
  return 0.1f;
else
  return 0.1f;
```
Rewriten:
```
return (customer.TotalOrders > 50) ? 0.1f : 0.1f
```
- Ternay operator misused
```
c = a ? b :d ? e : f ?
// do not apply more than one expression
```
___
- **Simplify true/false**
```
if(a)
  b = true;
else
  b = false;

// b = a;
```
Example:
```
if(customer.TotalOrders > 50)
  isGoldCustomer = true;
else
  isGoldCustomer = false;
```
Rewriten:
```
isGoldCustomer = customer.TotalOrders > 50;
```
___
- **Combine**
```
if(a)
{
    if(b)
    {
        // statement
    }
}
```
Rewritten:
```
if(a && b)
{
    // statement
}
```
- **Early Exit**
```
if(a)
{
    if(b)
    {
        // statement
    }
}
```
Rewritten:
```
if(!a)
  return;
if(b)
  return;
```
- **Early Exit + Combine**
```
if(a)
{
    if(b)
    {
        // statement
    }
}
```
Rewrite:
```
if(!a || !b)
  return;
```
___
- **Swap Orders**
```
if(a)
{
    if(b)
    {
        isValid = true;
    }
}
if(c)
{
    if(b)
    {
        isValid = true;
    }
}
```
Rewrite1:
```
if(b)
{
    if(a)
    {
        isValid = true;
    }
    
    if(c)
    {
        isValid = true;
    }
}
```
Rewrite2: Combine
```
if(b)
{
    if(a || c)
    {
        isValid = true;
    }
}
```
```
if(b && (a || c))
{
    isValid = true;
}
```
```
isValid = (b && (a || c));
```
