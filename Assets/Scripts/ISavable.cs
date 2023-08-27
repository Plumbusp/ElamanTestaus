using UnityEngine;

 public interface ISavable 
{
  public string fileName { get; }
  public string currentValue { get; set; }
    public void SetValue<T> (T value);
}
