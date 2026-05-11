using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TyoukakuStage : MonoBehaviour
{

    [SerializeField] private float TotalTekiNum;
    [SerializeField] private GameObject TyoukakuDoor;
    [SerializeField] private GameObject remainiNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int TyoukakuCount = 0; // Á‚¦‚½“G‚Ì”
    void Start()
    {
        if (remainiNum != null)
        {
            remainiNum.SetActive(true);
        }
    }
    public void EnemyManager()
    {

        TyoukakuCount++;
        if (TyoukakuCount >= TotalTekiNum)
        {
            //this.gameObject.SetActive(false);
            if (TyoukakuDoor != null)
            {
                TyoukakuDoor.SetActive(true);
            }

        }

        
    }
    void Update()
    {
        if (remainiNum != null)
        {
            Text text = remainiNum.GetComponent<Text>();
            text.text = (TotalTekiNum - TyoukakuCount).ToString();
        }
    }


}
