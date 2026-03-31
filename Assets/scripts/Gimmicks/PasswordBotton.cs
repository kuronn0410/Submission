using UnityEngine;
using TMPro;

public class PasswordBotton : MonoBehaviour
{
    
    [SerializeField] TMP_Text numberText;
    //クリックされたら数値を変える
    public int number;
    
    public void OnCLIckTIs()
    {
        number++;
        if(number >9)
        {
            number = 0;
        }
        numberText.text = number.ToString();
    }
}
