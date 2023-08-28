using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuLogic : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject InputMenu;
    [SerializeField] private GameObject gameMenu;


    public void RestartGame()
    {
        StartInputMenu();
        playerData.DiscardAllData();
        playerData.LoadPlayerData();
    }
    public void StartGame()
    {
        StartGameMenu();
    }
    public void ContinueGame()
    {
        StartGameMenu();
        playerData.LoadPlayerData();
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
        InputMenu.SetActive(true);
    }
    private void StartGameMenu()
    {
        mainMenu.SetActive(false);
        InputMenu.SetActive(false);
        gameMenu.SetActive(true);
    }
}