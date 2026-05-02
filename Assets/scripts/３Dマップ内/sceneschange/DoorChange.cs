using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DoorChange : MonoBehaviour
{
    [SerializeField] string sceneName; // Raycast‚Ì‹——£

    public void SceneChange()
    {
        SceneManager.LoadScene(sceneName);
    }
}
