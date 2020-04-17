using System;

namespace CleanCode
{
    private PayFrequency _payFrequency;
    
    public PayCalculator(PayFrequency payFrequency)
    {
        _payFrequency = payFrequency;
    }
    
    public decimal CalcGross(decimal rate, decimal hours)
    {
        decimal overtimeHours = 0;
        decimal regularHours = 0;
        decimal regularPay = 0;
        decimal grossPay;
        
        if(_payFrequency == PayFrequency.Fortnightly)
        {
            if(hours > 8)
            {
                overtimeHours = hours - 80;
                regularHours = 80;
            }
            
            else
                regularHours = hours;
        }
        
        else if(_payFrequency == PayFrequency.Weekly)
        {
            if(hours > 40)
            {
                overtimeHours = hours - 40;
                regularHours = 40;
            }
            
            else
                regularHours = hours;
        }
        
        decimal overtimePay = 0;
        if(overtimeHours > 0m)
        {
            overtimePay += (rate * 1.5m) * overtimeHours;
        }
        regularPay = (regularHours * rate);
        grossPay = regularPay + overtimePay;
        return grossPay;
    }
    
    public enum PayFrequency
    {
        Weekly,
        Fortnightly
    }
}