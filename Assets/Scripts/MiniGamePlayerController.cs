using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayerController : MonoBehaviour
{
    public GameObject Camera;
    public int PlayerHP;
    public bool CameraRepairStart;
    public bool CameraRepairStop;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHP = 3;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //transform.forward = Mathf.Clamp(transform.forward, -4.8f, 4.8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3 (0,transform.position.y,0));
        transform.position += new Vector3(0, -0.5f, 0);
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), -2f);
        }
        if(CameraRepairStart)
        {
            Camera.GetComponent<CRT>().NoiseX -= 0.003f;
            Camera.GetComponent<CRT>().RGBNoise -= 0.003f;
            Camera.GetComponent<CRT>().ScanLineTail += 0.003f;
            
        }
        if (Camera.GetComponent<CRT>().NoiseX <= 0)
        {
            CameraRepairStart = false; ;
            Camera.GetComponent<CRT>().NoiseX = 0;
            Camera.GetComponent<CRT>().RGBNoise = 0;
            Camera.GetComponent<CRT>().ScanLineTail = 2;
            
        }
    }
    void OnCollisionEnter(Collision Object)
    {
        if(Object.gameObject.tag == "Object")
        {
            PlayerHP -= 1;
            Camera.GetComponent<CRT>().NoiseX = 0.2f;
            Camera.GetComponent<CRT>().RGBNoise = 0.2f;
            Camera.GetComponent<CRT>().ScanLineTail = 1.4f;
            CameraRepairStart = true;
        }
    }
}
