using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlertLevelSystem : MonoBehaviour
{
    public float AlertLevelValue;
    public bool AlertLevelIncrease;
    // Start is called before the first frame update
    void Start()
    {
        AlertLevelValue = 0;

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Slider>().value = AlertLevelValue;
        if (AlertLevelIncrease)
        {
            this.GetComponent<Slider>().value += 0.001f;
        }
    }
    public void LightBreakAlertLevel()
    {
        AlertLevelValue += 0.1f;
    }
}
