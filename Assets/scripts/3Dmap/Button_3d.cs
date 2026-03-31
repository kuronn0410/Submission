using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_3d : MonoBehaviour
{
    void Update()
    {
        // マウスの左クリックがされたら
        if (Input.GetMouseButtonDown(0))
        {
            // クリックされた位置にRayを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // オブジェクトの名前が"Karaoke"だった場合
                if (hit.collider.gameObject.name == "Karaoke")
                {
                    // シーンを読み込む
                    SceneManager.LoadScene("SampleScene");
                }
            }
        }
    }
}
