using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    public Text text;

    private void OnEnable()
    {
        continueButton.onClick.AddListener(StartGameMenu);
    }
    private void OnDisable()
    {
        continueButton.onClick.RemoveListener(StartGameMenu);
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
            text.text = "DOSENT HAS saved data";
        }
    }
    public void StartChoice1()
    {
        StartFoodChoice();
    }
    public void StartChoice2()
    {
        StartHouseChoice();
    }
    public void StartChoice3()
    {
        StartMiraculousChoice();
    }
    public void StartChoice4()
    {
        StartInputMenu();
    }
    public void StartMainGame()
    {
        StartGameMenu();
    }
    public void ContinueGame()
    {
        StartGameMenu();
    }
    public void QuitGame()
    {
        Application.Quit();
    }



    private void StartInputMenu()
    {
        mainMenu.SetActive(false);
        gameMenu.SetActive(false);
        foodChoiceMenu.SetActive(false);
        miraculousChoiceMenu.SetActive(false);
        InputMenu.SetActive(true);
    }
    private void StartGameMenu()
    {
        mainMenu.SetActive(false);
        InputMenu.SetActive(false);
        foodChoiceMenu.SetActive(false);
        gameMenu.SetActive(true);
    }
    private void StartFoodChoice()
    {
        mainMenu.SetActive(false);
        InputMenu.SetActive(false);
        houseChoiceMenu.SetActive(false);
        foodChoiceMenu.SetActive(true);
    }
    private void StartHouseChoice()
    {
        mainMenu.SetActive(false);
        foodChoiceMenu.SetActive(false);
        InputMenu.SetActive(false);
        houseChoiceMenu.SetActive(true);

    }
    private void StartMiraculousChoice()
    {
        mainMenu.SetActive(false);
        foodChoiceMenu.SetActive(false);
        houseChoiceMenu.SetActive(false);
        InputMenu.SetActive(false);
        miraculousChoiceMenu.SetActive(true);
    }
}