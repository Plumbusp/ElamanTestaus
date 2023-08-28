using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class HamsterHealth: ISavable
{
    private float _maxValue;
    private Slider _healthBar;
    private TMP_Text _textForHealth;

    private float _currentHealth;

    public string fileName { get; private set; }
    public string currentValue { get ; set; }
    public string initialValue { get; private set; }


    public HamsterHealth(float maxValue, Slider healthBar, TMP_Text textForHealth)
    {
        fileName = "hamsterHealth.txt";
        initialValue = maxValue.ToString();
        this._maxValue = maxValue;
        this._healthBar = healthBar;
        this._textForHealth = textForHealth;
        HealthToDefault();
    }
    public void SetValue<T>(T amount)
    {
        if (float.TryParse(amount.ToString(), out float amountInFloat))
        {
            currentValue = amountInFloat.ToString();
            _currentHealth = amountInFloat;
            _healthBar.value = _currentHealth;
            _textForHealth.text = _currentHealth.ToString();
            HowMuchHealth();
        }
        else
        {
            Debug.LogWarning(amount.ToString());
        }

    }

    public void Decrease()
    {
        if (!(_currentHealth <= _healthBar.minValue))
        {
            SetValue(_currentHealth -= 10f);
            HowMuchHealth();
        }
    }
    public void Increase()
    {
        if (!(_currentHealth >= _maxValue))
        {
            SetValue(_currentHealth += 10f);
            HowMuchHealth();
        }
    }


    private void HealthToDefault()
    {

        SetValue(initialValue);
    }

    private void HowMuchHealth()
    {
        if (_currentHealth >= 80f)
        {
            ImageChanger.instance.ChangeConditionTo(ImageChanger.Condition.happy);
        }
        else if (_currentHealth >= 40f && _currentHealth < 80f)
        {
            ImageChanger.instance.ChangeConditionTo(ImageChanger.Condition.neutral);
        }
        else if (_currentHealth < 40f)
        {
            ImageChanger.instance.ChangeConditionTo(ImageChanger.Condition.sad);
        }
    }

    /*
public void SaveHealth()
{
    SaveData(healthPath, _currentHealth.ToString()); // save health  
}

public string LoadHealth()
{
    if(LoadData(healthPath)== null)
    {
        HealthToDefault();
        return _currentHealth.ToString();
    }
    float health = float.Parse(LoadData(healthPath));
    SetHealth(health);  // set health to saved health( it also could be null). Convert returned string to float for health.
    return _currentHealth.ToString();
}

*/


    /*
        public void AwakeMethod()         // read the current health if there is; if no, than make in max
        {
            _path = Path.Combine(Application.dataPath, fileName);
            _healthBar.maxValue = _maxValue;
            LoadHealth();
        }
    */

}
