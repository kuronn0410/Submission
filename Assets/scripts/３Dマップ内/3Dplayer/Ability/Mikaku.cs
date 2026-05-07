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
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (FoodPanel_1 != null)
            {
                FoodPanel_1.color = Color.black;
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (FoodPanel_2 != null)
            {
                FoodPanel_2.color = Color.black;
            }
        }
    }
}
