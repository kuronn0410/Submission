using UnityEngine;

public class mixObj : MonoBehaviour
{
    [SerializeField] Item.Type Item1;
    [SerializeField] Item.Type Item2;
    [SerializeField] Item.Type MixItem;

    private bool isMixed = false; // 合成済みフラグ

    void Update()
    {
        if (!isMixed && ItemBox.instance != null)
        {
            if (CheckInventory(Item1) && CheckInventory(Item2))
            {
                Debug.Log("条件揃ったので合成開始");

                // アイテム削除
                RemoveItem(Item1);
                RemoveItem(Item2);

                // MixItem を作成して追加
                Item newItem = ItemGenerater.instance.Spawn(MixItem);
                newItem.type = MixItem;
                ItemBox.instance.SetItem(newItem);

                isMixed = true; // 合成は1回だけ
                Debug.Log("合成成功：MixItemを追加しました");
            }
        }
    }

    // 指定タイプのアイテムが所持されているか
    private bool CheckInventory(Item.Type type)
    {
        foreach (Slot slot in ItemBox.instance.GetSlots())
        {
            Item item = slot.GetItem();
            if (item != null && item.type == type)
            {
                return true;
            }
        }
        return false;
    }

    // 指定タイプのアイテムを1つ削除
    private void RemoveItem(Item.Type type)
    {
        foreach (Slot slot in ItemBox.instance.GetSlots())
        {
            Item item = slot.GetItem();
            if (item != null && item.type == type)
            {
                slot.SetItem(null);
                break;
            }
        }
    }
}
