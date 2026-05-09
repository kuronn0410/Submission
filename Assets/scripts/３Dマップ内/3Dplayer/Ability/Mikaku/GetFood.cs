using UnityEngine;

public class GetFood : MonoBehaviour
{
    [SerializeField] FoodType foodtype;
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switch(foodtype)
            {
                case FoodType.SpeedUp:
                    FoodManager.Food_1_count += 1;
                    Debug.Log("SpeedUp”\—ÍŽæ“¾");
                    break;
                case FoodType.GravityInversion:
                    FoodManager.Food_2_count += 1;
                    Debug.Log("GravityInversion”\—ÍŽæ“¾");
                    break;
            }
          this.gameObject.SetActive(false);
        }
    }
   
    
}
