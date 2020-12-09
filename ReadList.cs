using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public static class ReadProviderFile
{
    public static List<string> ReadFile()
    {
        List<Provider> list = new List<Provider>();
        using (StreamReader file = File.OpenText(@"Providers.json"))

        using (JsonTextReader reader = new JsonTextReader(file))
        {
            JObject o2 = (JObject)JToken.ReadFrom(reader);

            foreach(var provider in o2)
            {
                list.Add( new Provider
                {
                    Name = provider
                });
            }
        }
    }
}