using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;
    public Camera thirdCamera;

    private Camera activeCamera;

    void Start()
    {
        // 最初は subCamera を有効にして他は無効
        mainCamera.enabled = false;
        subCamera.enabled = true;
        thirdCamera.enabled = false;
        activeCamera = subCamera;
    }

    void Update()
    {
        // カメラ切り替え処理
        if (Input.GetKeyDown(KeyCode.A))
        {
            mainCamera.enabled = false;
            subCamera.enabled = true;
            thirdCamera.enabled = false;
            activeCamera = subCamera;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // 条件にかかわらず切り替えたいなら条件なしでOK
            if (mainCamera.enabled)
            {
                mainCamera.enabled = false;
                subCamera.enabled = false;
                thirdCamera.enabled = true;
                activeCamera = thirdCamera;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            mainCamera.enabled = true;
            subCamera.enabled = false;
            thirdCamera.enabled = false;
            activeCamera = mainCamera;
        }

        // クリック判定は現在有効なカメラからRayを飛ばす
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = activeCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("クリックしたオブジェクト名：" + hit.collider.gameObject.name);
                // ここにオブジェクト操作処理を追加
            }
        }
    }
}
