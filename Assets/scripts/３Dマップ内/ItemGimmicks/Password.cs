using UnityEngine;

public class Password : MonoBehaviour
{
    //正解
    [SerializeField] int[] correctNumbers;
    //クリックするたびに現在のパネルの数値と正解を比較
    //一致するならクリアログ

    //現在の数値:passwordButtonのNumberを見ればよい
    [SerializeField] PasswordBotton[] passwordButtons;

    [SerializeField] PasswordGimmick[] gimmicksToActivate;


    public void CheckClear()
    {
        if (IsClear())
        {
            Debug.Log("クリア");
            // ギミックをすべて発動
            
            foreach (PasswordGimmick gimmick in gimmicksToActivate)
            {
                gimmick.OnClear();
            }
            
        }
    }

    bool IsClear()
    {
        //正解してるかどうか　＝　全部一致

        for (int i = 0; i < correctNumbers.Length; i++)
        {
            if (passwordButtons[i].number != correctNumbers[i])
            {
            return false;
            }
        }
        return true;
    }
    
}
