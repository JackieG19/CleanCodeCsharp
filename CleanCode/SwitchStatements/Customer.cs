using System;

namespace CleanCode.SwitchStatement
{
    public abstract class Customer
    {   
        public abstract MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage);
    }
}
