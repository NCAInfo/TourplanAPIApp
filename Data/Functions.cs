using Newtonsoft.Json;


    public class Functions
    {
        public static T CloneObject<T>(T master)
        {
            var obj = JsonConvert.SerializeObject(master);

            var copy = JsonConvert.DeserializeObject<T>(obj);
            return copy;
        }
    }

