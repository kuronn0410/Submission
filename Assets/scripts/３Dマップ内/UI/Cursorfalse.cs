using UnityEngine;

public class Cursorfalse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       FalseCursor();
    }

    void FalseCursor()
    {
        Cursor.visible = false;
    }
}
