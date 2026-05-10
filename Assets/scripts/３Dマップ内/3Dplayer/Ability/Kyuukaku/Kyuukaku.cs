using UnityEngine;
using System.Collections;


public class Kyuukaku : MonoBehaviour
{
    [SerializeField] private float poisonDuration = 5f; // ポイズンの持続時間
    GameObject[] Poisons;
   // private bool isPoisoned = false; // プレイヤーがポイズン状態かどうか
    //private int count = 0; // ポイズンの数
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Poisons = GameObject.FindGameObjectsWithTag("Poison");
        
        foreach (GameObject poison in Poisons)
        {
            Renderer renderer = poison.GetComponent<Renderer>();
            renderer.enabled = false; // レンダラーを無効にして見えなくする

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(AppearToxic());
        }
    }

   IEnumerator AppearToxic()
    {
        
        foreach (GameObject poison in Poisons)
        {
                Renderer renderer = poison.GetComponent<Renderer>();
                renderer.enabled = true; // レンダラーを有効にして見えるようにする
        }
        yield return new WaitForSeconds(poisonDuration);// ポイズンの持続時間だけ待機
        foreach (GameObject poison in Poisons)
        {
                Renderer renderer = poison.GetComponent<Renderer>();
                renderer.enabled = false; // レンダラーを無効にして見えなくする
        }
    }
}
