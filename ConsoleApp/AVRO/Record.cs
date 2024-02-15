namespace AVRO;

public class Record : IRecord {
    public string Name { get; set; }

    public IField[] Fields { get; set; }
}