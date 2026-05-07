using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DoorChange : MonoBehaviour
{
    [SerializeField] string sceneName; // Raycast‚Ì‹——£
    [SerializeField] AbilityType abilitytype;

    public void SceneChange()
    {
        switch(abilitytype)
            {
            case AbilityType.Tyoukaku:
                TransitionHistory.Tyoukaku = true; ;
                Debug.Log("Tyoukaku”\—ÍŽæ“¾");
                break;
            case AbilityType.Mikaku:
                TransitionHistory.Mikaku = true; ;
                break;
            case AbilityType.Syokkaku:
                TransitionHistory.Syokkaku = true; ;
                break;
            case AbilityType.Kyuukaku:
                TransitionHistory.Kyuukaku = true; ;
                break;
            case AbilityType.Shikaku:
                TransitionHistory.Shikaku = true; ;
                break;
            case AbilityType.other:
                break;
        }


        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }
}
