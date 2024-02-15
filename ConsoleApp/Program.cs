using Newtonsoft.Json;
using AVRO;
using Newtonsoft.Json.Serialization;

var f1 = new Field();
f1.Name = "field name";
f1.Type = PrimitiveTypes.Double;
f1.Default = 1.23;

var f2 = new NullableField();
f2.Name = "nullable field name";
f2.Type = [PrimitiveTypes.Null, PrimitiveTypes.Double];
f2.Default = 1.23;

var entity = new Record();
entity.Name = "record name";

entity.Fields = [f1, f2];

string json = JsonConvert.SerializeObject(entity, Formatting.Indented, new JsonSerializerSettings
{
  ContractResolver = new CamelCasePropertyNamesContractResolver(),
  NullValueHandling = NullValueHandling.Ignore,
});

Console.WriteLine(json);