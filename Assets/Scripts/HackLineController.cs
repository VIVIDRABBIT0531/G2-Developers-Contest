using UnityEngine;
using System.Collections;

public class HackLineController : MonoBehaviour
{

    [SerializeField] Transform m_Player;// 線の始点位置
    public  Transform m_Target;// 線の終点位置
    public Material[] m_Material;       // ハッキング線マテリアル(自作テクスチャ)

    private LineRenderer m_LineRendere;
    private int m_Index = -1;           // 前回フレームで割り当てたマテリアルのインデックス

    private Vector3 m_Offset = new Vector3(0.1f, 0.4f, 0.0f);  // ハッキング線がキャラクターの腰あたりに当たるように位置補正
    public float distance;
    // Use this for initialization
    void Start()
    {
        m_LineRendere = GetComponent<LineRenderer>();
        m_LineRendere.SetVertexCount(2);

        SetMaterial();
    }

    // Update is called once per frame
    void Update()
    {
        m_LineRendere.SetPosition(0, m_Player.position + m_Offset); // 始点位置指定 ※キャラクターが動いているかもしれないので、毎フレーム取得する
        m_LineRendere.SetPosition(1, m_Target.position + m_Offset); // 終点位置指定
        if(m_Target.tag == "Light")
        {
            m_LineRendere.SetPosition(0, m_Player.position + m_Offset); // 始点位置指定 ※キャラクターが動いているかもしれないので、毎フレーム取得する
            m_LineRendere.SetPosition(1, m_Target.position + new Vector3(3.2f, 6f, 0.0f));
        }
        distance = Vector3.Distance(m_Player.position, m_Target.position);
        m_LineRendere.GetComponent<Renderer>().material.mainTextureScale = new Vector2(distance * 2f, 1);    // テクスチャ繰り返し処理。"*2"を調整すれば繰り返し頻度を変更できる。
        SetMaterial();
    }

    // LineRendererのマテリアル切り替え
    private void SetMaterial()
    {
        bool ok = false;
        while (!ok)
        {
            int id = Random.Range(1, 4);
            if (id != m_Index)
            {
                ok = true;
                m_Index = id;
                this.GetComponent<LineRenderer>().material = m_Material[m_Index];
            }
        }
    }
}