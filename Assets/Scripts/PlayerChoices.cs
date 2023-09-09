using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChoices: MonoBehaviour, ISavable
{
    public static PlayerChoices instance;
    public delegate void SetChoice(Sprite whichSprite);
    public static event SetChoice OnFoodChoiceSet;
    public static event SetChoice OnMiraculousChoice;
    public static event SetChoice OnHousedChoiceSet;

    private string food;
    [SerializeField] private Image foodImage;
    private string miraculous;
    [SerializeField] private Image miraculousImage;
    private string house;
    [SerializeField] private Image houseImage;

    private string _foodFolderPath = "ChooseYourSuperFood";
    private string _houseFolderPath ="ChooseYourHouse";
    private string _miraculousFolderPath = "ChooseYourLuckyCharm";
    private Dictionary<string, Sprite> foodImages = new Dictionary<string, Sprite>();
    private Dictionary<string, Sprite> housesImages = new Dictionary<string, Sprite>();
    private Dictionary<string, Sprite> miraculousImages = new Dictionary<string, Sprite>();

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
        DontDestroyOnLoad(this);

        foodImages.Add("eggplant", Resources.Load<Sprite>(_foodFolderPath + "/Food_eggplant"));
        foodImages.Add("banana", Resources.Load<Sprite>(_foodFolderPath + "/Food_banana"));
        foodImages.Add("sushie", Resources.Load<Sprite>(_foodFolderPath + "/Food_sushi"));
        foodImages.Add("cucumber", Resources.Load<Sprite>(_foodFolderPath + "/Food_cucumber"));

        miraculousImages.Add("whiteshell", Resources.Load<Sprite>(_miraculousFolderPath + "/Seashell_white"));
        miraculousImages.Add("blueshell", Resources.Load<Sprite>(_miraculousFolderPath + "/Seashell_blue"));
        miraculousImages.Add("blackshell", Resources.Load<Sprite>(_miraculousFolderPath + "/Seashell_black"));
        miraculousImages.Add("brownshell", Resources.Load<Sprite>(_miraculousFolderPath + "/Seashell_browm"));

        housesImages.Add("can", Resources.Load<Sprite>(_houseFolderPath + "/House_can"));
        housesImages.Add("box", Resources.Load<Sprite>(_houseFolderPath + "/House_box"));
        housesImages.Add("pot", Resources.Load<Sprite>(_houseFolderPath + "/House_pot"));


    }
    public void LoadData(DataObject data)
    {
        foodImage.sprite = null;
        miraculousImage.sprite = null;
        houseImage.sprite = null;

        food = data.food;
        miraculous = data.miraculous;
        house = data.house;

        if (foodImages.ContainsKey(food.ToLower().Trim()))
        {
           foodImage.sprite = foodImages[food.ToLower().Trim()];
        }
        if(miraculousImages.ContainsKey(miraculous.ToLower().Trim()))
        {
            miraculousImage.sprite = miraculousImages[miraculous.ToLower().Trim()];
        }
        if(housesImages.ContainsKey(house.ToLower().Trim()))
        {
            houseImage.sprite = housesImages[house.ToLower().Trim()];
        }
        
    }

    public void SaveData(ref DataObject data)
    {
        data.food = this.food;
        data.miraculous = this.miraculous;
        data.house = this.house;
    }

    public void SetFood(Sprite whichSprite, string whichFood)
    {
        food = whichFood;
        foodImage.sprite = whichSprite;
        OnFoodChoiceSet?.Invoke(whichSprite);
    }
    public void SetMiraculous(Sprite whichSprite, string whichMiraculous)
    {
        miraculous = whichMiraculous;
        miraculousImage.sprite = whichSprite;
        OnMiraculousChoice?.Invoke(whichSprite);
    }
    public void SetHouse( Sprite whichSprite, string whichHouse)
    {
        house = whichHouse;
        houseImage.sprite = whichSprite;
        OnHousedChoiceSet?.Invoke(whichSprite);
    }
}
