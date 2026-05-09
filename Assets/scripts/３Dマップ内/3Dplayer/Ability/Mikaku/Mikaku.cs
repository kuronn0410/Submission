using UnityEngine;
using UnityEngine.UI;

public class Mikaku : MonoBehaviour
{
    [SerializeField] GameObject MikakuPanel;
    [SerializeField] Image FoodPanel_1;
    [SerializeField] Image FoodPanel_2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (MikakuPanel != null)
        {
            MikakuPanel.SetActive(true);
            FoodPanel_1.color = Color.white;
            FoodPanel_2.color = Color.white;


        }

    }

    // Update is called once per frame
    void Update()
    {
        UseFood();
    }

    void UseFood()
    {
        if(FoodPanel_1 != null && FoodManager.Food_1_count > 0)
        {
            FoodPanel_1.color = Color.white;
        }
        if (FoodPanel_1 != null && FoodManager.Food_1_count == 0)
        {
            FoodPanel_1.color = Color.black;
        }
        else if (Input.GetKeyDown(KeyCode.R) && FoodManager.Food_1_count > 0)
        {
            FoodManager.Food_1_count--;
            SpeedUP speedUP = GetComponent<SpeedUP>();
            if (speedUP != null)
            {
                speedUP.SpeedUpActive();
            }

        }


        if(FoodPanel_2 != null && FoodManager.Food_2_count > 0)
        {
            FoodPanel_2.color = Color.white;
        }
        if (FoodPanel_2 != null && FoodManager.Food_2_count == 0)
        {
            FoodPanel_2.color = Color.black;
        }
        else if (Input.GetKeyDown(KeyCode.T) && FoodManager.Food_2_count > 0)
        {
            FoodManager.Food_2_count--;
            GravityInversion gravityInversion = GetComponent<GravityInversion>();
            if (gravityInversion != null)
            {
                gravityInversion.GravityInversionActive();
            }
        }

    }

    
    
}
