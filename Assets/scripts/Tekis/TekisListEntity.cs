using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TekisListEntity : ScriptableObject
{
    public List<Enemy> enemies = new List<Enemy>();
}
