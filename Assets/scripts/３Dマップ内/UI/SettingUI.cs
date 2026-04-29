using UnityEngine;

public class SettingUI : MonoBehaviour
{
    [SerializeField] private GameObject settingPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       CloseSettingPanel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleSettingPanel();
        }
    }
     
    public void OnClickSettingButton()
    {
           ToggleSettingPanel();
    }

    private void ToggleSettingPanel()
    {
        if (settingPanel.activeSelf)
        {
            CloseSettingPanel();
        }
        else
        {
            OpenSettingPanel();
        }
    }

    void CloseSettingPanel()
    {
        settingPanel.SetActive(false);
        Cursor.visible = false; // ポインターを隠す
        Cursor.lockState = CursorLockMode.Locked; // 中央固定
    }

   void OpenSettingPanel()
    {
        settingPanel.SetActive(true);
        Cursor.visible = true; // ポインターを表示
        Cursor.lockState = CursorLockMode.None; // ポインターのロックを解除
    }


}
