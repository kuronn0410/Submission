using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//シーン切り替えに必要

public class Button_game_start_c : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(osu);
    }

    void osu()
    {
        SceneManager.LoadScene("3dmap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
