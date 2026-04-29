using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DoorChange : MonoBehaviour
{
    [SerializeField] string sceneName; // Raycast‚Ì‹——£

    // Update is called once per frame
    /*void Update()
    {
        SceneChange();
    }*/

    public void SceneChange()
    {
        SceneManager.LoadScene(sceneName);
    }
}
