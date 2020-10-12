using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.gameObject.AddComponent<BoxCollider>();
            this.gameObject.GetComponent<BoxCollider>().center = new Vector3(0, 0, 1);
            //this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            this.gameObject.GetComponent<BoxCollider>().size = new Vector3(0.3f, 0.3f, 0.3f);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Destroy(this.gameObject.GetComponent<BoxCollider>());
        }
    }
}
