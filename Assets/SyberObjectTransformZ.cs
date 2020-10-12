using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyberObjectTransformZ : MonoBehaviour
{
    public float MoveInterval;
    public int ObjectDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveInterval += 1;
        if (MoveInterval % Random.Range(10, 20) == 0)
        {
            transform.position += new Vector3(0, 0, -20);

        }
        if (MoveInterval % Random.Range(40, 60) == 0)
        {
            ObjectDirection = Random.Range(1, 3);
            if (ObjectDirection == 1)
            {
                transform.position += new Vector3(20, 0, 0);
            }
            if (ObjectDirection == 2)
            {
                transform.position += new Vector3(-20, 0, 0);
            }
        }
    }
}

