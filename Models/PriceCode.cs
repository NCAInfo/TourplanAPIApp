
    public class PriceCode
    {
    public string Code { get; set; }
    public string Description { get; set; }

    public string label { get
        {
            return Code + "-" + Description;
        } }
}

