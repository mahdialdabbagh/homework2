using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Order
{
    private DateTime date;
    private string status;

    public Order(DateTime date, string status)
    {
        this.date = date;
        this.status = status;
    }

    public void CalcSubTotal()
    {
      
        Console.WriteLine("Calculating SubTotal...");
    }

    public void CalcTax()
    {
    
        Console.WriteLine("Calculating Tax...");
    }

    public void CalcTotal()
    {
    
        Console.WriteLine("Calculating Total...");
    }

    public void CalcTotalWeight()
    {
       
        Console.WriteLine("Calculating Total Weight...");
    }