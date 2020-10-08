using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkLiftDown : MonoBehaviour
{
    public GameObject Player;
    public float ForkLiftSec;
    public GameObject Lift;
    // Start is called before the first frame update
    void Start()
    {
        ForkLiftSec = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ForkLiftSec += Time.deltaTime;
        if (ForkLiftSec <= 4)
        {
            Lift.transform.position -= new Vector3(0, 0.01f, 0);
        }
        else if (ForkLiftSec > 4)
        {
            Player.GetComponent<Hacking>().isLift = false;
            
        }
    }
}
