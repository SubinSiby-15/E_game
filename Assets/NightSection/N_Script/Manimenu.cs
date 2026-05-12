using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manimenu : MonoBehaviour
{
    public GameObject settingpanels;
  public Image Image;
 
    public Button OpenSettingBtn;
    public Button CloseSettingBtn;


    private void Start()
    {
      settingpanels.SetActive(false);

        Image.enabled= false;

        OpenSettingBtn.onClick.AddListener(OpenSetting);
        CloseSettingBtn.onClick.AddListener(CloseSetting);
        DontDestroyOnLoad(gameObject);
    }
    
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


    public void ExitGame()
    {
        Application.Quit();
    }





}
