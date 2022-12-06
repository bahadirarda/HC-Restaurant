using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Extensions
{
    public static class SessionHelper
    {
        public static void SetProductJson(this ISession session, string key, object value) // Self-session
        {
            session.SetString(key, JsonConvert.SerializeObject(value)); //Object to JSON
        }

        public static TEntity GetProductJson<TEntity>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(TEntity) : JsonConvert.DeserializeObject<TEntity>(value); 
        }
    }
}
