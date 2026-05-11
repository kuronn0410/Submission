using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float timer = 0;
    public static bool isRunning = true;
    private static Timer instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        // シーンを跨いでもタイマーを破壊したくない場合など
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        isRunning = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isRunning) // フラグがtrueのときだけ時間を進める
        {
            timer += Time.deltaTime;
        }
    }

    public static void ResetTimer()
    {
        timer = 0;
    }
}
