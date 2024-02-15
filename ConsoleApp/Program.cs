using Newtonsoft.Json;
using AVRO;
using Newtonsoft.Json.Serialization;

var field = new Field();
field.Name = "field name";
field.Type = PrimitiveTypes.Double;
field.Default = 1.23;

var entity = new Record();
entity.Name = "record name";
entity.Fields = [field];

string json = JsonConvert.SerializeObject(entity, Formatting.Indented, new JsonSerializerSettings{
    ContractResolver = new CamelCasePropertyNamesContractResolver(),
    NullValueHandling = NullValueHandling.Ignore,
});

Console.WriteLine(json);