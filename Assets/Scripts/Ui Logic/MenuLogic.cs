using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class MenuLogic : MonoBehaviour
{
    [SerializeField] private GameObject initialMenu;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Button continueButton;
    [SerializeField] private GameObject InputMenu;
    [SerializeField] private GameObject foodChoiceMenu;
    [SerializeField] private GameObject houseChoiceMenu;
    [SerializeField] private GameObject miraculousChoiceMenu;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] private GameObject shopMenu;

    Dictionary<string, GameObject> menus = new Dictionary<string, GameObject>();
    public Text text;

    private void OnEnable()
    {
        menus.Add(initialMenu.name, initialMenu);
        menus.Add(mainMenu.name, mainMenu);
        menus.Add(InputMenu.name, InputMenu);
        menus.Add(foodChoiceMenu.name, foodChoiceMenu);
        menus.Add(houseChoiceMenu.name, houseChoiceMenu);
        menus.Add(miraculousChoiceMenu.name, miraculousChoiceMenu);
        menus.Add(gameMenu.name, gameMenu);
        menus.Add(shopMenu.name, shopMenu);
    }
    private void OnDisable()
    {
    }
    public void StartInitialMenu()
    {
        StartSomeMenu(initialMenu);
    }
    public void StartMainMenu()
    {
        initialMenu.SetActive(false);
        gameMenu.SetActive(false);
        InputMenu.SetActive(false);
        mainMenu.SetActive(true);
        if(SavingsManager.Instance.HasSavedData())
        {
            continueButton.gameObject.SetActive(true);
            text.text = "HAS saved data";
        }
        else
        {
            continueButton.gameObject.SetActive(false);
            mainMenu.TryGetComponent<VerticalLayoutGroup>(out VerticalLayoutGroup layoutGroup);
            layoutGroup.transform.position = layoutGroup.transform.position;
            text.text = "NO saved data";
        }
    }

    public void StartChoice1()
    {
        StartSomeMenu(foodChoiceMenu);
    }
    public void StartChoice2()
    {
        StartSomeMenu(houseChoiceMenu);
    }
    public void StartChoice3()
    {
        StartSomeMenu(miraculousChoiceMenu);
    }
    public void StartChoice4()
    {
        StartSomeMenu(InputMenu);
    }
    public void StartGameMenu()
    {
        StartSomeMenu(gameMenu);
    }
    public void StartShopMenu()
    {
        StartSomeMenu(shopMenu);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void StartSomeMenu(GameObject menu)
    {
        foreach (KeyValuePair<string, GameObject> kvp in menus)
        {
            if (kvp.Value == menu)
            {
                kvp.Value.SetActive(true);
            }
            else
            {
                kvp.Value.SetActive(false);
            }
        }
    }
}