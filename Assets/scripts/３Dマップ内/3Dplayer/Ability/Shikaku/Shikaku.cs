using UnityEngine;

public class Shikaku : MonoBehaviour
{
    [SerializeField] private GameObject BlindnessPanel; // 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BlindnessPanel.SetActive(!TransitionHistory.Shikaku);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Eye"))
        {
            TransitionHistory.Shikaku = true;
            BlindnessPanel.SetActive(false);
        }
    }
}
