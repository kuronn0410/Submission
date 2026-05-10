using UnityEngine;

public class AvoidPoisonTimer : MonoBehaviour
{
    [SerializeField] private GameObject MainDoor; // 毒回避のドアオブジェクト
    [SerializeField] private float avoidDuration = 20f; // 毒回避の持続時間
    public float AvoidTime = 0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AvoidTime = avoidDuration; // タイマーを初期化
    }

    // Update is called once per frame
    void Update()
    {
        if (AvoidTime > 0)
        {
            AvoidTime -= Time.deltaTime; // タイマーを減少
        }
        else       
        {
            
           MainDoor.SetActive(true);
            
        }
    }

    public void ResetTimer()
    {
        AvoidTime = avoidDuration; // タイマーをリセット
    }
}
