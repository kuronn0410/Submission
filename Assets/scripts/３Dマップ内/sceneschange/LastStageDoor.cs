using UnityEngine;
using UnityEngine.SceneManagement;

public class LastStageDoor : MonoBehaviour
{
    [SerializeField] string sceneName; 

    public static float ClearTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.gameObject.SetActive(false);
        Collider collider = GetComponent<Collider>();
        Renderer renderer = GetComponent<Renderer>();
        collider.enabled = false;
        renderer.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(TransitionHistory.TransitionCheck())
        {
            //this.gameObject.SetActive(true);
                Collider collider = GetComponent<Collider>();
                Renderer renderer = GetComponent<Renderer>();
                collider.enabled = true;
                renderer.enabled = true;
        }
    }

    public void SceneChange()
    {
        if (sceneName != null)
        {
            ClearTime = Timer.timer;
            SceneManager.LoadScene(sceneName);
        }
    }
}
