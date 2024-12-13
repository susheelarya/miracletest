using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for UnitConvertionInfo    
//</summary>    
namespace ENTITY    
{    
public class UnitConvertionInfo    
{    
    private decimal _unitconvertionId;    
    private decimal _productId;    
    private decimal _unitId;    
    private decimal _conversionRate;    
    private DateTime _extraDate;
    private string _quantities;
    private string _extra1;    
    private string _extra2;    
    
    public decimal UnitconvertionId    
    {    
        get { return _unitconvertionId; }    
        set { _unitconvertionId = value; }    
    }    
    public decimal ProductId    
    {    
        get { return _productId; }    
        set { _productId = value; }    
    }    
    public decimal UnitId    
    {    
        get { return _unitId; }    
        set { _unitId = value; }    
    }    
    public decimal ConversionRate    
    {    
        get { return _conversionRate; }    
        set { _conversionRate = value; }    
    }    
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    public string Extra1    
    {    
        get { return _extra1; }    
        set { _extra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }
    public string Quantities
    {
        get { return _quantities; }
        set { _quantities = value; }
    }    
}    
}
