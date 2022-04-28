using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemsCounter : MonoBehaviour
{
    public static GemsCounter instance;

    public TMP_Text gemText;
    public int currentGems = 0;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gemText.text = "GEMS: " + currentGems.ToString();
    }

    public void IncreaseGems(int v)
    {
        currentGems += v;
        gemText.text = "GEMS: " + currentGems.ToString();
    }
}
