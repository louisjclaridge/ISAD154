using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Summary description for parts
/// </summary>
public class Parts
{
    string partName;
    int partPrice;
    string expectedDelivery; 
    string supplier;
    int purchaseOrderNumber;
    string returnReason;
    string returnDate;   
    int returnConCode;


   
   
    ////commodity
    //public Parts(string inPartName, decimal inPartPrice )
    //{
    //    partName = inPartName;
    //    partPrice = inPartPrice;
    //}
    ////specialised
    //public Parts(string inPartName, decimal inPartPrice, string inExpectedDelivery, string inSupplier, 
    //    int inPurchaseOrderNumber)
    //{
    //    partName = inPartName;
    //    partPrice = inPartPrice;
    //    expectedDelivery = inExpectedDelivery;
    //    supplier = inSupplier;
    //    purchaseOrderNumber = inPurchaseOrderNumber;
    //}
    ////returns
    public Parts(string inPartName, int inPartPrice, string inExpectedDelivery, string inSupplier,
       int inPurchaseOrderNumber, string inReturnReason, string inReturnDate, int inReturnConCode)
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
    public int PartPrice
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
    public string ExpectedDelivery
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
            returnReason = value;
        }
    }
    public string ReturnDate
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
    public int ReturnConCode
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
    public static List<Parts> getParts()
    {
        using (StreamReader file = new StreamReader("C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/parts.json"))
        {
            string json = file.ReadToEnd();

            List<Parts> items = JsonConvert.DeserializeObject<List<Parts>>(json);

            return items;
        }

    }
    public string getCommodityPartsDisplayFormat()
    {
        string output;
        output = "partName: " + partName + " " + "partPrice: " + partPrice + " " + "supplier: " + " " + supplier;
        return output;
    }
    public string getSpecialisedPartsDisplayFormula()
    {
        string output;
        output = "partName: " + partName + " " + "partPrice: " + partPrice + " " + "expectedDelivery: " + expectedDelivery + " " + "supplier: " + supplier + " " + "purchaseOrderNumber: " + purchaseOrderNumber;
        return output;
    }
    public string getReturnsPartsDisplayFormula()
    {
        string output;
        output = "purchaseOrderNumber: " + purchaseOrderNumber + " " + "returnReason: " + returnReason + " " + "returnDate: " + returnDate + " " + "returnConCode: " + returnConCode;
        return output;
    }


    
}