using UnityEngine;

public class GravityInversion : MonoBehaviour
{
    //[SerializeField] float gravityScale = -1f; // 重力の反転スケール
    public static bool isActive = false; // 重力反転が有効かどうか
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("触れた");
        if (other.CompareTag("Player"))
        {
            isActive = true;
            Debug.Log("重力反転！");
            this.gameObject.SetActive(false);

        }
    }
}
