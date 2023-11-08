
public class DbService
{
    private readonly dbContext db;
    public DbService(dbContext _db)
    {
        db = _db;
    }

    public IEnumerable<RequestSetRate> RequestSetRateGetByUser(LoginModel username)
    {
        IEnumerable<RequestSetRate> obj = new List<RequestSetRate>();
        if(username.SEC >= 70)
        {
            obj = db.RequestSetRate.Where(w => w.Country == username.Country && !w.IsPublish).ToArray();
        }
        else
        {
            obj = db.RequestSetRate.Where(w => w.CreateBy == username.Username && w.Country == username.Country && !w.IsPublish).ToArray();
        }
             
        return obj;
    }

    public async Task<RequestSetRate> RequestSetRateById(int id)
    {
        var obj = db.RequestSetRate.FirstOrDefault(w => w.Id == id);
        return await Task.FromResult(obj);
    }

    public int RequestSetRateSave(RequestSetRate model)
    {
        if (model.Id == 0)
        {
            db.RequestSetRate.Add(model);
        }
        else
        {
            db.RequestSetRate.Update(model);
        }
        db.SaveChanges();
        return model.Id;
    }

    public bool RequestSetRateDelete(int id)
    {
        var obj = db.RequestSetRate.FirstOrDefault(w => w.Id == id);
        if (obj != null)
        {
            db.RequestSetRate.Remove(obj);
            db.SaveChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public IEnumerable<Cancellation> CancellationGetAll(LoginModel username)
    {
        IEnumerable<Cancellation> obj = new List<Cancellation>();
        if (username.SEC >= 70)
        {
            obj = db.Cancellation.Where(w => w.Country == username.Country && !w.IsPublish).ToArray();
        }
        else
        {
            obj = db.Cancellation.Where(w => w.CreateBy == username.Username && w.Country == username.Country && !w.IsPublish).ToArray();
        }

        return obj;
        
    }
    public bool CancellationGetByPolId(int polid)
    {
        
        return true;
    }
    public bool CancellationSave(Cancellation model)
    {
        if(model.Id == 0)
        {
            db.Cancellation.Add(model);
        }
        else
        {
            db.Cancellation.Update(model);
        }
        db.SaveChanges();
        return true;
    }
    public bool CancellationDelete(Cancellation model)
    {
       
            db.Cancellation.Remove(model);
        
        db.SaveChanges();
        return true;
    }
}

