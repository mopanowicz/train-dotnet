namespace AVRO;

public class Record : IRecord {
    public string Name { get; set; }

    public Field[] Fields { get; set; }
}