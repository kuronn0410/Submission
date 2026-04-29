using System;
using UnityEngine;

[Serializable]
public class Item 
{
    //—ñ‹“Œ^Fí—Ş‚ğ—ñ‹“‚·‚é
   public enum Type
    {
        Cube,
        Ball,
        Haniwa,
        Micro,
        key1,
        takkyuu1,
        Hint,
        star7,
        cap0,
        scissors,
        Cube1,
        Cube2,
        AnsCube2

    }
    public Type type; //í—Ş
    public Sprite sprite; //Slot‚É•\¦‚·‚é‰æ‘œ
    public GameObject zoomObj;

    public Item(Type type, Sprite sprite, GameObject zoomObj)
    {
        this.type = type;
        this.sprite = sprite;
        this.zoomObj = zoomObj;
    }
}
