using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlertLevelSystem : MonoBehaviour
{
    public bool AlertLevelIncrease;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Slider>().value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(AlertLevelIncrease)
        {
            this.GetComponent<Slider>().value = 0.001f;
        }
    }
}
