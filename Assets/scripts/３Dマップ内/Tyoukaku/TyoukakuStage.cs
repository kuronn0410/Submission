using UnityEngine;

public class TyoukakuStage : MonoBehaviour
{

    [SerializeField] private float TotalTekiNum;
    [SerializeField] private GameObject TyoukakuDoor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int TyoukakuCount = 0; // Á‚¦‚½“G‚Ì”
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
}
