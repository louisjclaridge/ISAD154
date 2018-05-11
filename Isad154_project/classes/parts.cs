using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for parts
/// </summary>
public class Parts
{
    string partName;
    decimal partPrice;
    string expectedDelivery; 
    string supplier;
    int purchaseOrderNumber;
    string returnReason;
    string returnDate;   
    int returnConCode;

   
   
    //commodity
    public Parts(string inPartName, decimal inPartPrice )
    {
        partName = inPartName;
        partPrice = inPartPrice;
    }
    //specialised
    public Parts(string inPartName, decimal inPartPrice, DateTime inExpectedDelivery, string inSupplier, 
        int inPurchaseOrderNumber)
    {
        partName = inPartName;
        partPrice = inPartPrice;
        expectedDelivery = inExpectedDelivery;
        supplier = inSupplier;
        purchaseOrderNumber = inPurchaseOrderNumber;
    }
    //returns
    public Parts(string inPartName, decimal inPartPrice, DateTime inExpectedDelivery, string inSupplier,
       int inPurchaseOrderNumber, string inReturnReason, DateTime inReturnDate, string inReturnConCode)
    {
        partName = inPartName;
        partPrice = inPartPrice;
        expectedDelivery = inExpectedDelivery;
        supplier = inSupplier;
        purchaseOrderNumber = inPurchaseOrderNumber;
        returnReason = inReturnReason;
        returnDate = inReturnDate;
        returnConCode = inReturnConCode;

    }

    public string PartName
    {
        get
        {
            return partName ;
        }
        set
        {
           partName = value;
        }
    }
    public decimal PartPrice
    {
        get
        {
            return partPrice;
        }
        set
        {
            partPrice = value;
        }
    }
    public DateTime ExpectedDelivery
    {
        get
        {
            return expectedDelivery;
        }
        set
        {
             expectedDelivery = value;
        }
    }
    public string Supplier
    {
        get
        {
            return supplier;
        }
        set
        {
            supplier = value;
        }
    }
    public int PurchaseOrderNumber
    {
        get
        {
            return purchaseOrderNumber;
        }
        set
        {
            purchaseOrderNumber = value;
        }
    }
    public string ReturnReason
    {
        get
        {
            return returnReason;
        }
        set
        {
            ReturnReason = value;
        }
    }
    public DateTime ReturnDate
    {
        get
        {
            return returnDate;
        }
        set
        {
            returnDate = value;
        }
    }
    public string ReturnConCode
    {
        get
        {
            return returnConCode;
        }
        set
        {
            returnConCode = value;
        }
    }

    //methods

    //displayparts
    //parts format
    // get parts

}