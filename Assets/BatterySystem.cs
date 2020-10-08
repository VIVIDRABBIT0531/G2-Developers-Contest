using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatterySystem : MonoBehaviour
{
    public float BatteryDecreaseSpeed;
    public bool Battery1;
    public bool Battery2;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Slider>().value = 1;
        Battery1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Slider>().value -= BatteryDecreaseSpeed;
        if(Battery1)
        {
            BatteryDecreaseSpeed = 0.0001f;
        }
        else if(Battery2)
        {
            BatteryDecreaseSpeed = 0.00001f;
        }
    }
}
