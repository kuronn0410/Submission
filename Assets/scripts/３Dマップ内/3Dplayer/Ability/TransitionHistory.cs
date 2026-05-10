using UnityEngine;

public static class TransitionHistory 
{
    public static bool Tyoukaku = false;
    public static bool Mikaku = false;
    public static bool Syokkaku = false;
    public static bool Kyuukaku = false;
    public static bool Shikaku = false;

    public static bool TransitionCheck()
    {
       if(Tyoukaku == true && Mikaku == true && Syokkaku == true && Kyuukaku == true && Shikaku == true)
       {
            return true;
       }
        return false;
    }

}
