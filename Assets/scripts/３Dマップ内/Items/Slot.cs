using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //アイテムを画像をスロットに表示する
    Item item;
    [SerializeField] Image image;
    [SerializeField] GameObject bakgroundPanel;
    /*
    public bool IsEmpty
    {
        get => item == null;
    }*/

    private void Awake()
    {
        //image = GetComponent<Image>();
    }
    private void Start()
    {
        bakgroundPanel.SetActive(false);
    }

    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }

   public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    public Item GetItem()
    {
        return item;
    }

    void UpdateImage(Item item)
    {
        if(item == null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = item.sprite;
        }
            
    }
    public bool OnSelected()
    {
        if(item ==null)
        {
            return false;
        }
        bakgroundPanel.SetActive(true);
        return true;
    }
    public void HideBGPanel()
    {
        
        bakgroundPanel.SetActive(false);
    }
}
