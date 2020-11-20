using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentBools : MonoBehaviour
{
    public static int CompLevel1;
    public static int CompLevel2;
    public static int CompLevel3;
    public static int CompLevel4;
    public static int CompLevel5;
    public static int CompLevel6;
    // Start is called before the first frame update
    void Start()
    {
        CompLevel1 = PlayerPrefs.GetInt("Level1Comp");
        CompLevel2 = PlayerPrefs.GetInt("Level2Comp");
        CompLevel3 = PlayerPrefs.GetInt("Level3Comp");
        CompLevel4 = PlayerPrefs.GetInt("Level4Comp");
        CompLevel5 = PlayerPrefs.GetInt("Level5Comp");
        CompLevel6 = PlayerPrefs.GetInt("Level6Comp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
