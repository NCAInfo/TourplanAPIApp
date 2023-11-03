


using DiethelmAPI.ModelDb;
using Newtonsoft.Json;
using System.Text;

public class APIService
{
    private readonly string _endPoint;
    private readonly IConfiguration _config;
    HttpClient client = new HttpClient();
    public APIService(IConfiguration configuration)
    {
        _config = configuration;
        _endPoint = _config.GetValue<string>("Endpoint");
    }

    public async Task<IEnumerable<Supplier>> SuppliersGetAll(string country)
    {
        var res = await client.GetAsync(_endPoint + "/api/db/GetAllSupplier/" + country);
        var content = await res.Content.ReadAsStringAsync();
        var rsobj = JsonConvert.DeserializeObject<IEnumerable<Supplier>>(content);
        return rsobj;
    }

    public async Task<IEnumerable<Product>> OptionGetByCode(string supplier,string country)
    {
        var res = await client.GetAsync(_endPoint + $"/api/Db/GetAllProductBySupplierCode/{supplier}/{country}");
        var content = await res.Content.ReadAsStringAsync();
        var rsobj = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
        return rsobj.OrderBy(o=>o.Description);
    }
    public async Task<ReplyFromGetRate> GetRate(GetRateRequest rq,string country)
    {
        string jsonRequest = JsonConvert.SerializeObject(rq);

        // Create a StringContent object with the JSON data
        HttpContent hc = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Perform the HTTP POST request
        var res = await client.PostAsync(_endPoint + $"/api/GetRate/{country}", hc);

        // Process the response and return the result
        if (res.IsSuccessStatusCode)
        {
            // Deserialize the response content to the ReplyFromGetRate object
            string jsonResponse = await res.Content.ReadAsStringAsync();
            var reply = JsonConvert.DeserializeObject<ReplyFromGetRate>(jsonResponse);
            return reply;
        }
        else
        {
            // Handle the error response or throw an exception
            throw new Exception($"HTTP request failed with status code {res.StatusCode}");
        }
    }

    public async Task<ReplyFromSetRate> SetRate(SetRateRequest rq, string country)
    {
        string jsonRequest = JsonConvert.SerializeObject(rq);

        // Create a StringContent object with the JSON data
        HttpContent hc = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Perform the HTTP POST request
        var res = await client.PostAsync(_endPoint + $"/api/SetRate/{country}", hc);

        // Process the response and return the result
        if (res.IsSuccessStatusCode)
        {
            // Deserialize the response content to the ReplyFromGetRate object
            string jsonResponse = await res.Content.ReadAsStringAsync();
            var reply = JsonConvert.DeserializeObject<ReplyFromSetRate>(jsonResponse);
            return reply;
        }
        else
        {
            // Handle the error response or throw an exception
            throw new Exception($"HTTP request failed with status code {res.StatusCode}");
        }
    }

    public async Task<GetOptionReplyRoot> GetOptionDetail(GetOptionRequest rq,string country)
    {
        try
        {
            string jsonRequest = JsonConvert.SerializeObject(rq);

            // Create a StringContent object with the JSON data
            HttpContent hc = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            // Perform the HTTP POST request
            var res = await client.PostAsync(_endPoint + $"/api/GetOptionDetail/{country}", hc);

            // Process the response and return the result
            if (res.IsSuccessStatusCode)
            {
                // Deserialize the response content to the ReplyFromGetRate object
                string jsonResponse = await res.Content.ReadAsStringAsync();
                var reply = JsonConvert.DeserializeObject<GetOptionReplyRoot>(jsonResponse);
                return reply;
            }
            else
            {
                // Handle the error response or throw an exception
                throw new Exception($"HTTP request failed with status code {res.StatusCode}");
            }
        }
        catch (Exception e)
        {
            throw new Exception($"HTTP request failed with status code {e.Message}");
        }
        
    }

    public async Task<List<PriceCode>> GetPriceCodeDetail(string country)
    {
        try
        {
            
            // Perform the HTTP POST request
            var res = await client.GetAsync(_endPoint + $"/api/db/GetAllPricecode/{country}");

            // Process the response and return the result
            if (res.IsSuccessStatusCode)
            {
                // Deserialize the response content to the ReplyFromGetRate object
                string jsonResponse = await res.Content.ReadAsStringAsync();
                var reply = JsonConvert.DeserializeObject<List<PriceCode>>(jsonResponse);
                return reply;
            }
            else
            {
                // Handle the error response or throw an exception
                throw new Exception($"HTTP request failed with status code {res.StatusCode}");
            }
        }
        catch (Exception e)
        {
            throw new Exception($"HTTP request failed with status code {e.Message}");
        }

    }

    public async Task<User> Login(LoginModel rq)
    {
        try
        {
            string jsonRequest = JsonConvert.SerializeObject(rq);

            // Create a StringContent object with the JSON data
            HttpContent hc = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            // Perform the HTTP POST request
            var res = await client.PostAsync(_endPoint + $"/api/db/login/{rq.Country}", hc);

            // Process the response and return the result
            if (res.IsSuccessStatusCode)
            {
                // Deserialize the response content to the ReplyFromGetRate object
                string jsonResponse = await res.Content.ReadAsStringAsync();
                var reply = JsonConvert.DeserializeObject<User>(jsonResponse);
                return reply;
            }
            else
            {
                // Handle the error response or throw an exception
                throw new Exception($"HTTP request failed with status code {res.StatusCode}");
            }
        }
        catch (Exception e)
        {
            throw new Exception($"HTTP request failed with status code {e.Message}");
        }

    }

    public async Task<ReplyFromGetInventory> GetInventory(GetInventoryRequest rq, string country)
    {
        string jsonRequest = JsonConvert.SerializeObject(rq);

        // Create a StringContent object with the JSON data
        HttpContent hc = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Perform the HTTP POST request
        var res = await client.PostAsync(_endPoint + $"/api/GetInventory/{country}", hc);

        // Process the response and return the result
        if (res.IsSuccessStatusCode)
        {
            // Deserialize the response content to the ReplyFromGetRate object
            string jsonResponse = await res.Content.ReadAsStringAsync();
            var reply = JsonConvert.DeserializeObject<ReplyFromGetInventory>(jsonResponse);
            return reply;
        }
        else
        {
            // Handle the error response or throw an exception
            throw new Exception($"HTTP request failed with status code {res.StatusCode}");
        }
    }

    public async Task<ReplyFromSetInventory> SetInventory(SetInventoryRequest rq, string country)
    {
        string jsonRequest = JsonConvert.SerializeObject(rq);
        Console.WriteLine(jsonRequest);
        // Create a StringContent object with the JSON data
        HttpContent hc = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Perform the HTTP POST request
        var res = await client.PostAsync(_endPoint + $"/api/SetInventory/{country}", hc);

        // Process the response and return the result
        if (res.IsSuccessStatusCode)
        {
            // Deserialize the response content to the ReplyFromGetRate object
            string jsonResponse = await res.Content.ReadAsStringAsync();
            var reply = JsonConvert.DeserializeObject<ReplyFromSetInventory>(jsonResponse);
            return reply;
        }
        else
        {
            // Handle the error response or throw an exception
            throw new Exception($"HTTP request failed with status code {res.StatusCode}");
        }
    }

    public async Task<IEnumerable<Product>> GetOptionList(string suppliercode, string optionCode, string country)
    {
        var res = await client.GetAsync(_endPoint + $"/api/Db/GetAllProductByOption/{suppliercode}/{optionCode}/{country}");
        var content = await res.Content.ReadAsStringAsync();
        var rsobj = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
        return rsobj.OrderBy(o => o.Description);
    }

    public async Task<IEnumerable<GetPolicy>> GetPolicies(string suppliercode, string country)
    {
        var res = await client.GetAsync(_endPoint + $"/api/Db/GetCancellationBySupplier/{suppliercode}/{country}");
        var content = await res.Content.ReadAsStringAsync();
        var rsobj = JsonConvert.DeserializeObject<IEnumerable<GetPolicy>>(content);
        return rsobj.OrderBy(o => o.Period);
    }

    public async Task<IEnumerable<GetOption>> GetOptionBySupplier(string suppliercode, string country)
    {
        var res = await client.GetAsync(_endPoint + $"/api/Db/GetOptionBySupplier/{suppliercode}/{country}");
        var content = await res.Content.ReadAsStringAsync();
        var rsobj = JsonConvert.DeserializeObject<IEnumerable<GetOption>>(content);
        return rsobj.OrderBy(o => o.OptionCode);
    }
    public async Task<GetSelectOption> GetSelectOption(string country)
    {
        var res = await client.GetAsync(_endPoint + $"/api/Db/GetSelectOption/{country}");
        var content = await res.Content.ReadAsStringAsync();
        var rsobj = JsonConvert.DeserializeObject<GetSelectOption>(content);
        return rsobj;
    }
    public async Task<Pol> GetPolById(int polid, string country)
    {
        var res = await client.GetAsync(_endPoint + $"/api/Db/GetPolById/{polid}/{country}");
        var content = await res.Content.ReadAsStringAsync();
        var rsobj = JsonConvert.DeserializeObject<Pol>(content);
        return rsobj;
    }

    public async Task<bool> PolSave(List<Pol> obj,string country)
    {
        string jsonRequest = JsonConvert.SerializeObject(obj);
        Console.WriteLine(jsonRequest);
        // Create a StringContent object with the JSON data
        HttpContent hc = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Perform the HTTP POST request
        var res = await client.PostAsync(_endPoint + $"/api/Db/PolSave/{country}", hc);

        // Process the response and return the result
        if (res.IsSuccessStatusCode)
        {
            // Deserialize the response content to the ReplyFromGetRate object
          
            return true;
        }
        else
        {
            // Handle the error response or throw an exception
            return false;
        }
      
    }
}

