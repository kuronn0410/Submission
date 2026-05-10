using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Enemy_to_Near : MonoBehaviour
{
    [SerializeField] public Transform playerTransform; // プレイヤーのTransformをInspectorで設定
    [SerializeField] public AudioClip audioClip; // 再生するAudioClipをInspectorで設定
    [SerializeField] private float nearDistance = 5f; // プレイヤーに近づく距離の閾値
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //bool isAudioPlayed = false; // 音声が再生されたかどうかを追跡するフラグ
    private AudioSource audiosource; // AudioSourceコンポーネントを格納する変数

    void Start()
    {
        audiosource  = GetComponent<AudioSource>(); // AudioSourceコンポーネントを取得
        audiosource.clip = audioClip; // AudioSourceにAudioClipを設定
        audiosource.loop = true; // 音声をループさせない
        audiosource.playOnAwake = false; // ゲーム開始時に自動で再生しない
    }

    // Update is called once per frame
    void Update()
    {

        // プレイヤーが設定されていない、または既に鳴らした後は何もしない
        if (playerTransform == null) return;
        NearPlayer();

    }

    private float distans; // プレイヤーと敵の位置の差を格納する変数
    void NearPlayer()
    {
        distans = Vector3.Distance(playerTransform.position, transform.position); // プレイヤーと敵の位置の差を計算
        if(distans < nearDistance)
        {
            // プレイヤーが近づいたときの処理
            if(!audiosource.isPlaying)
            {

                audiosource.Play();
                //isAudioPlayed = true; // 音声が再生されたことを記録
            }
        }
        else
        {
            // プレイヤーが離れたときの処理
            if(audiosource.isPlaying)
            {
                audiosource.Stop();
                //isAudioPlayed = false; // 音声が停止されたことを記録
            }
        }
    }
}
