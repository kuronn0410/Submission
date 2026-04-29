using UnityEngine;

public class ScreenClick : MonoBehaviour
{
    [SerializeField] private float distance = 10f; // Raycastの距離

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, distance))
            {
                DoorChange door = hit.collider.GetComponent<DoorChange>();

                // 2. スクリプトが見つかった場合だけ実行する
                if (door != null)
                {
                    door.SceneChange();
                }
            }
        }
    }
}
