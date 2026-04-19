using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //—ñ‹“Œ^Fí—Ş‚ğ—ñ‹“‚·‚é
    public enum Type
    {
        Cube,
    }
    public Type type; //í—Ş
   

    public Enemy(Type type)
    {
        this.type = type;
       
    }
}
