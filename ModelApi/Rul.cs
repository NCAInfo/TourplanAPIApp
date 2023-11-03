using System;
using System.Collections.Generic;

namespace DiethelmAPI.ModelDb;

public partial class Rul
{
    public int RulId { get; set; }

    public int Period { get; set; }

    public string FeeType { get; set; }

    public decimal FeeAmount { get; set; }

    public bool DisplayInDays { get; set; }

    public int XlmId { get; set; }

    public DateTime AppliesFrom { get; set; }

    public int MinScu { get; set; }

    public int MaxScu { get; set; }

    public int MinRooms { get; set; }

    public int MaxRooms { get; set; }

    public virtual Xlm Xlm { get; set; }

    private string _GetDisplayinDay;
    public string GetDisplayinDay
    {
        get
        {
            _GetDisplayinDay = Convert.ToInt32(DisplayInDays).ToString();
            return _GetDisplayinDay;
        }
        set
        {
            _GetDisplayinDay = value;
        }
    }
    public string GetDisplayValue { get; set; }
}
