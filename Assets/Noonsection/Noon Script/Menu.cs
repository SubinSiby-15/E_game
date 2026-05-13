using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{

    public GameObject settingpanels;
    public Button startButton;

    public Button exitButton;


    void Start()
    {
        settingpanels.SetActive(false);

        startButton.onClick.AddListener(StartGame);

        exitButton.onClick.AddListener(ExitGame);   
    }
    [ContextMenu("Start Game")]
    public void StartGame()
    {
        SceneManager.LoadScene("Levelone");
    }

    public void OpenSetting()
    {
        settingpanels.SetActive(true);

    }
    public void CloseSetting()
    {
        settingpanels.SetActive(false);
    }

   [ ContextMenu("Exit Game")]
    public void ExitGame()
    {  
        Debug.Log("Exit");
        Application.Quit();
    }
}
