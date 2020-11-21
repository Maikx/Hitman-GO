using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level6 : MonoBehaviour
{
    public Sprite NotComp;
    public Sprite Comp;
    public GameObject FinishedLevel;
    Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }
    void Start()
    {
        if (PersistentBools.CompLevel1 == 1)
        {
            button.image.sprite = Comp;
            FinishedLevel.SetActive(true);
        }
        else
        {
            button.image.sprite = NotComp;
            FinishedLevel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
