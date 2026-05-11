using UnityEngine;

public class StageDescription : MonoBehaviour
{
    [SerializeField] GameObject stagerulePanel;
    [SerializeField] AbilityType abilityType;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (abilityType)
        {
            /*
            case AbilityType.Kyuukaku when TransitionHistory.Kyuukaku:
                stagerulePanel.SetActive(false);
                return;
            case AbilityType.Syokkaku when TransitionHistory.Syokkaku:
                stagerulePanel.SetActive(false);
                return;
            case AbilityType.Tyoukaku when TransitionHistory.Tyoukaku:
                stagerulePanel.SetActive(false);
                return;
            case AbilityType.Mikaku when TransitionHistory.Mikaku:
                stagerulePanel.SetActive(false);
                return;
            */
            case AbilityType.Shikaku when TransitionHistory.Shikaku:
                stagerulePanel.SetActive(false);
                return;
            case AbilityType.other:
                ShowStageRulePanel();
                return;
        }
        ShowStageRulePanel();
    }

    public void ShowStageRulePanel()
    {
        SetCursorManager.SetCursorState(true);
        stagerulePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnClickCloseButton()
    {
        ClosePanel();
    }

    void ClosePanel()
    {
        stagerulePanel.SetActive(false);
        Time.timeScale = 1f;
        SetCursorManager.SetCursorState(false);
    }


}
