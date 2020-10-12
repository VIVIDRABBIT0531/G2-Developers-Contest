using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public TrailRenderer line; // LineRendererコンポーネントを受ける変数
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() // updateでもいいけど，fixedのほうが今回都合がいい
    {
        //line.SetPosition(count - 1, transform.position); // オブジェクトの位置情報をセット

    }
}
