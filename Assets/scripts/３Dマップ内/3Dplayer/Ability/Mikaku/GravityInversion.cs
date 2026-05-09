using UnityEngine;

public class GravityInversion : MonoBehaviour
{
    //[SerializeField] float gravityScale = -1f; // 重力の反転スケール
    public static bool isActive = false; // 重力反転が有効かどうか

    public void GravityInversionActive()
    {
        isActive = true;
        Debug.Log("重力反転！");
        this.gameObject.SetActive(false);

    }


}
