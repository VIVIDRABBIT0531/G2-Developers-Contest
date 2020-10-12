using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MappingSystem : MonoBehaviour
{
    [Header("MAP")]
    public GameObject MapStart;
    public GameObject MapGoal;
    public GameObject Map1;
    public GameObject Map2;
    public GameObject Map3;
    public GameObject Map4;
    public GameObject Map5;
    public GameObject Map6;
    public GameObject Map7;
    public GameObject Map8;
    public GameObject Map9;
    public GameObject Map10;
    [Header("MAPQuantity")]
    public int Quantity;
    public int x;
    [Header("MAPUse")]
    public int MAPNumber;
    [Header("MAPRotate")]
    public int MAPRotate;
    [Header("TrailObject")]
    public GameObject Player;
    public GameObject X_TrailObject;
    public GameObject Z_TrailObject;
    public GameObject X_TrailObject_C;
    public GameObject Z_TrailObject_C;
    public float TrailInterval;
    public int TrailDirection;
    // Start is called before the first frame update
    void Start()
    {
        Quantity = Random.Range(5, 10);
        for (int x = 0; x <= Quantity; ++x)
        {
            MAPNumber = Random.Range(1, 10);
            MAPRotate = Random.Range(0, 360);
            if (x == 1)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -100, 0),Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -100, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 2)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -200, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 3)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -300, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 4)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -400, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 5)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -500, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 6)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -600, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 7)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -700, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 8)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -800, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 9)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -900, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if (x == 10)
            {
                if (MAPNumber == 1)
                {
                    Instantiate(Map1, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 2)
                {
                    Instantiate(Map2, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 3)
                {
                    Instantiate(Map3, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 4)
                {
                    Instantiate(Map4, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 5)
                {
                    Instantiate(Map5, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 6)
                {
                    Instantiate(Map6, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 7)
                {
                    Instantiate(Map7, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 8)
                {
                    Instantiate(Map8, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 9)
                {
                    Instantiate(Map9, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
                if (MAPNumber == 10)
                {
                    Instantiate(Map10, new Vector3(0, -1000, 0), Quaternion.Euler(0,MAPRotate,0));
                }
            }
            if(x == Quantity)
            {
                if (Quantity == 5)
                {
                    Instantiate(MapGoal, new Vector3(0, -600, 0), Quaternion.identity);
                }
                if (Quantity == 6)
                {
                    Instantiate(MapGoal, new Vector3(0, -700, 0), Quaternion.identity);
                }
                if (Quantity == 7)
                {
                    Instantiate(MapGoal, new Vector3(0, -800, 0), Quaternion.identity);
                }
                if (Quantity == 8)
                {
                    Instantiate(MapGoal, new Vector3(0, -900, 0), Quaternion.identity);
                }
                if (Quantity == 9)
                {
                    Instantiate(MapGoal, new Vector3(0, -1000, 0), Quaternion.identity);
                }
                if (Quantity == 10)
                {
                    Instantiate(MapGoal, new Vector3(0, -1100, 0), Quaternion.identity);
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        TrailInterval += 1;
        if(TrailInterval % 40 == 0)
        {
            X_TrailObject_C = Instantiate(X_TrailObject, new Vector3(100, Player.transform.position.y - Random.Range(150, 200), Random.Range(-100, 100)), Quaternion.identity);
            Z_TrailObject_C = Instantiate(Z_TrailObject, new Vector3(Random.Range(-100, 100), Player.transform.position.y - Random.Range(150, 200), 100), Quaternion.identity);
            Destroy(X_TrailObject_C, 5);
            Destroy(Z_TrailObject_C, 5);
        }

    }  
}
