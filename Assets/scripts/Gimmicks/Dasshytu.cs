using UnityEngine;
using UnityEngine.SceneManagement;

public class Dasshytu : MonoBehaviour
{

    [SerializeField] Item.Type clearItem;

    public void OnClickObj()
    {
        Debug.Log("クリックされた");

        bool clear = ItemBox.instance.TryUseItem(clearItem);
        Debug.Log("TryUseItem 結果: " + clear);

        if (clear)
        {
            Debug.Log("ギミック解除：シーン遷移します");
            gameObject.SetActive(false);
            SceneManager.LoadScene("Clear");
        }
        else
        {
            Debug.Log("必要なアイテムが使えません");
        }
    }

    /*
    public Item GetSelectedSlot()
    {
        return selectedSlot.GetItem();
    }*/

}
