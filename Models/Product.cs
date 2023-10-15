public class Product{

    public int Opt_Id { get; set; }
    public string Location { get; set; }
    public string Service { get; set; }
    public string Supplier { get; set; }
    public string Code { get; set; }
    private string _OptionCode;
    public string OptionCode { 
        get {
            _OptionCode = string.Format("{0}{1}{2}{3}",Location,Service,Supplier,Code);
            return _OptionCode;
        } 
        set {
            _OptionCode = value;
        }
    }
    
    public string Description { get; set; }
    public string Comment { get; set; }
}