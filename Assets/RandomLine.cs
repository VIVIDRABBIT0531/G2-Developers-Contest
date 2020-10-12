using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLine : MonoBehaviour
{
    public TrailRenderer TrailRenderer;
    public int M_Number;
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        M_Number = Random.Range(1, 4);
        if(M_Number == 1)
        {
            TrailRenderer.material = Material1;
        }
        if (M_Number == 2)
        {
            TrailRenderer.material = Material2;
        }
        if (M_Number == 3)
        {
            TrailRenderer.material = Material3;
        }
        if (M_Number == 4)
        {
            TrailRenderer.material = Material4;
        }
    }
}
