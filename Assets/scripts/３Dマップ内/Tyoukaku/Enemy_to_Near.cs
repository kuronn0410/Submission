using UnityEngine;

public class Enemy_to_Near : MonoBehaviour
{
    [SerializeField] public Transform playerTransform; // プレイヤーのTransformをInspectorで設定
    [SerializeField] public AudioClip audioClip; // 再生するAudioClipをInspectorで設定
    [SerializeField] private float nearDistance = 5f; // プレイヤーに近づく距離の閾値
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool isAudioPlayed = false; // 音声が再生されたかどうかを追跡するフラグ

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // プレイヤーが設定されていない、または既に鳴らした後は何もしない
        if (playerTransform == null || isAudioPlayed) return;
        NearPlayer();

    }

    private float distans; // プレイヤーと敵の位置の差を格納する変数
    void NearPlayer()
    {
        distans = Vector3.Distance(playerTransform.position, transform.position); // プレイヤーと敵の位置の差を計算
        if(distans < nearDistance)
        {
            // プレイヤーが近づいたときの処理
            if(audioClip != null)
            {
                AudioSource.PlayClipAtPoint(audioClip, transform.position);
                isAudioPlayed = true; // 音声が再生されたことを記録
            }
        }
    }
}
