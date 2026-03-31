using UnityEngine;

public class SampleGImmick : MonoBehaviour
{
    //やりたいこと
    //アイテムCubeを持っている状態でクリックすると消える
    //クリック判定
    //アイテム持ってる判定

    [SerializeField] Item.Type clearItem;

    public void OnClickObj()
    {
        Debug.Log("クリック");
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            Debug.Log("ギミック解除");
            gameObject.SetActive(false);
        }
    }
    /*
    public Item GetSelectedSlot()
    {
        return selectedSlot.GetItem();
    }*/

}
