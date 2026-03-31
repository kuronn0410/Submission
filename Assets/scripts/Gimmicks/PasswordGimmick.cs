using UnityEngine;

public class PasswordGimmick : MonoBehaviour
{
   
    // 消す対象（自分自身の場合は空のまま）
    [SerializeField] GameObject targetToDisappear;

    // Passwordからこれが呼び出される
    public void OnClear()
    {
        Debug.Log("PasswordGimmick.OnClear 呼び出された");

        if (targetToDisappear != null)
        {
            Debug.Log("ターゲット: " + targetToDisappear.name + " を非表示にします");
            targetToDisappear.SetActive(false);
        }
        else
        {
            Debug.Log("自分自身 " + gameObject.name + " を非表示にします");
            gameObject.SetActive(false);
        }
    }

}
