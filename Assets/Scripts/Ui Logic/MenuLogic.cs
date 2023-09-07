using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuLogic : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject InputMenu;
    [SerializeField] private GameObject foodChoiceMenu;
    [SerializeField] private GameObject gameMenu;


    public void StartChoice1()
    {
        StartFoodChoice();
    }
    public void StartChoice2()
    {

    }
    public void StartChoice3()
    {

    }
    public void StartChoice4()
    {

    }
    public void StartGame()
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
    public void GoToMainMenu()
    {
        StartMainMenu();
    }


    private void StartMainMenu()
    {
        gameMenu.SetActive(false);
        InputMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    private void StartInputMenu()
    {
        mainMenu.SetActive(false);
        gameMenu.SetActive(false);
        foodChoiceMenu.SetActive(false);
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
        foodChoiceMenu.SetActive(true);
    }
}