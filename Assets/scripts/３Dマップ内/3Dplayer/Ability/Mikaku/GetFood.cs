using UnityEngine;

public class GetFood : MonoBehaviour
{
    [SerializeField] FoodType foodtype;
    [SerializeField] float resetTime = 5f;

    private Renderer Renderer;
    private Collider foodCollider;
    void Start()
    {
        // コンポーネントを取得しておく
        Renderer = GetComponent<Renderer>();
        foodCollider = GetComponent<Collider>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switch(foodtype)
            {
                case FoodType.SpeedUp:
                    FoodManager.Food_1_count += 1;
                    Debug.Log("SpeedUp能力取得");
                    break;
                case FoodType.GravityInversion:
                    FoodManager.Food_2_count += 1;
                    Debug.Log("GravityInversion能力取得");
                    break;
            }
          SetFoodActive(false);
          Invoke("ResetFood", resetTime);
            
        }
    }

    void ResetFood()
    {
        // 見た目と当たり判定を戻す
        SetFoodActive(true);
    }

    void SetFoodActive(bool state)
    {
        if (Renderer != null) Renderer.enabled = state;
        if (foodCollider != null) foodCollider.enabled = state;
    }
}
