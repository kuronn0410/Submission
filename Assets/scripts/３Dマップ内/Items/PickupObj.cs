using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;
    private void Start()
    {
        //itemType‚É‰‚¶‚Äitem‚ğ¶¬‚·‚é
        item = ItemGenerater.instance.Spawn(itemType);

    }
    //ƒNƒŠƒbƒN‚µ‚½‚çÁ‚·
    public void OnClickObj()
    {
        //Debug.Log(item);
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
