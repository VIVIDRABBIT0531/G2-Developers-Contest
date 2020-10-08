using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundSun : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.1f, 0, 0));
        if(this.gameObject.transform.eulerAngles.x >= 180)
        {
            this.GetComponent<Light>().enabled = false;
        }
        if (this.gameObject.transform.eulerAngles.x >= 350)
        {
            this.GetComponent<Light>().enabled = true;
        }

    }
}
