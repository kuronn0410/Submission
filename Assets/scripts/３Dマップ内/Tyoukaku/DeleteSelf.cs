using UnityEngine;

public class DeleteSelf : MonoBehaviour
{
    [SerializeField] TyoukakuStage stageManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DeleteOBJ()
    {

        if (stageManager != null)
        {
            stageManager.EnemyManager();
        }
        this.gameObject.SetActive(false);
    }
}
