using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemBox : MonoBehaviour
{
    //slotsにslot要素をコードから入れる方法
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot = null;
    //どこでも実行できる
    public static ItemBox instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            //同じ要素を集める
            slots = GetComponentsInChildren<Slot>();
        }
    }

    //PickupObjがクリックされたら、スロットにアイテムを入れる
    //Slotが空いていたら入れる
    public void SetItem(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
    }

    public void OnSelectSlot(int position)
    {
        //全てのパネルを非表示
        foreach (Slot slot in slots)
        {
            slot.HideBGPanel();
        }

        selectedSlot = null;
        //選択肢されたパネルを非表示
        if (slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }
            
    }
    //Debug.Log("SetItem");
    //Debug.Log(item.type);
    //アイテムの使用
    public bool TryUseItem(Item.Type type)
    {
        //選択スロットがあるかどうか
        if(selectedSlot == null)
        {
            return false;
        }
        if(selectedSlot.GetItem().type == type)
        {
            selectedSlot.SetItem(null);
            selectedSlot.HideBGPanel();
            selectedSlot = null;
            return true;
        }
        return false;
    }
    public Item GetSelectedItem()
    {
        if (selectedSlot == null)
        {
            return null;
        }
        return selectedSlot.GetItem();
    }

    public Slot[] GetSlots()
    {
        return slots;
    }

}
