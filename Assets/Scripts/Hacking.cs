using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class Hacking : MonoBehaviour
{
    public GameObject HackTarget;
    public GameObject HackLine;
    public bool CanStart;
    public bool CanStop;
    public bool isLift;
    public bool TurnOff;
    // Start is called before the first frame update
    void Start()
    {
        CanStart = true;
        CanStop = false;
        TurnOff = true;
    }

    // Update is called once per frame
    void Update()
    {

        HackTarget = this.GetComponent<PlayerRay>().HackTarget;
        if (HackLine.GetComponent<HackLineController>().distance > 10)
        {
            Debug.Log("Stophack!");
            this.GetComponent<PlayerRay>().isTargetLock = true;
            CanStart = true;
            CanStop = false;
        }

    }
    public void StartHack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && CanStart)
        {
                Debug.Log("Starthack!");
                this.GetComponent<PlayerRay>().isTargetLock = false;
                CanStart = false;
                CanStop = true;
        }
    }
    public void StopHack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && CanStop)
        {
            Debug.Log("Stophack!");
            this.GetComponent<PlayerRay>().isTargetLock = true;
            CanStart = true;
            CanStop = false;
        }

    }
    public void ForkLiftHack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isLift == false)
        {
            Debug.Log("ForkLifthackUp!");
            HackTarget.GetComponent<ForkLiftDown>().ForkLiftSec = 0;
            HackTarget.GetComponent<ForkLiftUp>().enabled = true;
            HackTarget.GetComponent<ForkLiftDown>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && isLift)
        {
            Debug.Log("ForkLifthackDown!");
            HackTarget.GetComponent<ForkLiftUp>().ForkLiftSec = 0;
            HackTarget.GetComponent<ForkLiftUp>().enabled = false;
            HackTarget.GetComponent<ForkLiftDown>().enabled = true;
        }

    }
    public void LightHack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && TurnOff)
        {
            Debug.Log("Lighthack!");
            HackTarget.transform.GetChild(0).gameObject.GetComponent<Light>().enabled = false;
        }

    }

}
