using System.ComponentModel;

namespace AVRO;

public abstract class BaseField : IField
{
  public string Name { get; set; }
  public string Doc { get; set; }
  public Object Default { get; set; }
}
