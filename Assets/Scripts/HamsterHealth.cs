using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class HamsterHealth: MonoBehaviour, ISavable
{
    [SerializeField] float maxValue;
    [SerializeField] Slider healthBar;
    [SerializeField] TMP_Text textForHealth;

    private float _currentHealth;

    private HamsterHealth(float maxValue, Slider healthBar, TMP_Text textForHealth)
    {
        this.maxValue = maxValue;
        this.healthBar = healthBar;
        this.textForHealth = textForHealth;
    }

    public void SaveData(ref DataObject data)
    { 
        data.health = _currentHealth;
    }

    public void LoadData(DataObject data)
    {
        SetHealth(data.health);
    }
    
    public void HealthToDefault()
    {
        SetHealth(healthBar.maxValue);
    }

    public void Decrease()
    {
        if (!(_currentHealth <= healthBar.minValue))
        {
            SetHealth(_currentHealth -= 10f);
            HowMuchHealth();
       }
    }

    public void Increase()
    {
        if (!(_currentHealth >= maxValue))
       {
            SetHealth(_currentHealth += 10f);
            HowMuchHealth();
        }
    }

    private void SetHealth(float amount) 
    {
        _currentHealth = amount;
        healthBar.value = _currentHealth;
        textForHealth.text = _currentHealth.ToString();
        HowMuchHealth();
    }

    private void HowMuchHealth()
    {
        healthBar.value = _currentHealth;
        textForHealth.text = _currentHealth.ToString();

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
        public void AwakeMethod()         // read the current health if there is; if no, than make in max
        {
            _path = Path.Combine(Application.dataPath, fileName);
            _healthBar.maxValue = _maxValue;
            LoadHealth();
        }
    */
}
