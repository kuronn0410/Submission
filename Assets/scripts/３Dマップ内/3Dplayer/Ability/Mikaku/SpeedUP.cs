using UnityEngine;

public class SpeedUP : MonoBehaviour
{
    [SerializeField] private float speedUpMultiplier = 1.5f; // スピードアップの倍率
    [SerializeField] private float speedUpDuration = 5f; // スピードアップの持続時間
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   public void SpeedUpActive()
    {
        
          PlayerMove playerMove = GetComponent<PlayerMove>();
          if (playerMove != null)
          {
              playerMove.PlayerSpeed *= speedUpMultiplier; // スピードアップの倍率を調整
              Invoke("ResetSpeed", speedUpDuration); // 指定した持続時間後にスピードを元に戻す 
          }
    }   
}
