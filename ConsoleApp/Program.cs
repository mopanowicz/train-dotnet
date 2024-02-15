using Newtonsoft.Json;
using AVRO;
using Newtonsoft.Json.Serialization;

var field = new Field();

field.Name = "field name";

string json = JsonConvert.SerializeObject(field, Formatting.Indented, new JsonSerializerSettings{
    ContractResolver = new CamelCasePropertyNamesContractResolver(),
    NullValueHandling = NullValueHandling.Ignore,
});

Console.WriteLine(json);