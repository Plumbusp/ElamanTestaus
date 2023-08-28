using UnityEngine;

 public interface ISavable 
{
  public string fileName { get; }
  public string currentValue { get; set; }
    public string initialValue { get; } 
    public void SetValue<T> (T value);
}
