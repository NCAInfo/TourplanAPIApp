
    public class GetRateResult
    {
        public string OptionCode { get; set; }

        public DateTime Date_From { get; set; }
    public DateTime Date_To { get; set; }
    public string Note { get; set; }
  
    public bool Add1Year {
        get;set;
    }
    public List<DateRange> DateRanges { get; set; } = new List<DateRange>();
    }

