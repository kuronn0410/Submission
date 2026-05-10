using UnityEngine;

public class AbilityManager : MonoBehaviour
{

    [SerializeField] private Tyoukaku TyoukakuAbility;
    [SerializeField] private Mikaku MikakuAbility;
    [SerializeField] private Syokkaku SyokkakuAbility;
    [SerializeField] private Kyuukaku KyuukakuAbility;
    [SerializeField] private Shikaku ShikakuAbility;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TyoukakuAbility.enabled = true;
        MikakuAbility.enabled = false;
        SyokkakuAbility.enabled = false;
        KyuukakuAbility.enabled = false;
        ShikakuAbility.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        PossessionAbility();
    }

    void PossessionAbility()
    {
        if (TransitionHistory.Tyoukaku && TyoukakuAbility.enabled)
        {
            TyoukakuAbility.enabled = false;
            Debug.Log("Tyoukaku能力取得");
            AudioListener.volume = 1f;
        }
        if (TransitionHistory.Mikaku && !MikakuAbility.enabled)
        {
            MikakuAbility.enabled = true;
            MikakuAbility.SetUpMikakuPanel();
            Debug.Log("Mikaku能力取得");
        }
        if (TransitionHistory.Syokkaku && !SyokkakuAbility.enabled)
        {
            SyokkakuAbility.enabled = true;
            Debug.Log("Syokkaku能力取得");
        }
        if (TransitionHistory.Kyuukaku && !KyuukakuAbility.enabled)
        {
            KyuukakuAbility.enabled = true;
            Debug.Log("Kyuukaku能力取得");
        }
        if (TransitionHistory.Shikaku && ShikakuAbility.enabled)
        {
            ShikakuAbility.enabled = false;
            Debug.Log("Shikaku能力取得");
        }
    }
}
