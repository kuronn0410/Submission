using UnityEngine;

public class SyokkakuGool : MonoBehaviour
{
    [SerializeField] private GameObject MainDoor; // エフェクトのプレハブ
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       MainDoor.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MainDoor.SetActive(true);
        }
    }
}
