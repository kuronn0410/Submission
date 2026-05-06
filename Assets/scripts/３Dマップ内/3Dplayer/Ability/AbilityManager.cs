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
        TyoukakuAbility.enabled = false;
        MikakuAbility.enabled = false;
        SyokkakuAbility.enabled = false;
        KyuukakuAbility.enabled = false;
        ShikakuAbility.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        PossessionAbility();
    }

    void PossessionAbility()
    {
        if (TransitionHistory.Tyoukaku && !TyoukakuAbility.enabled)
        {
            TyoukakuAbility.enabled = true;
            Debug.Log("Tyoukaku能力取得");
        }
        if (TransitionHistory.Mikaku && !MikakuAbility.enabled)
        {
            MikakuAbility.enabled = true;
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
        if (TransitionHistory.Shikaku && !ShikakuAbility.enabled)
        {
            ShikakuAbility.enabled = true;
            Debug.Log("Shikaku能力取得");
        }
    }
}
