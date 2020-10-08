using cakeslice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public GameObject EmptyTarget;
    public GameObject HackTarget;
    public GameObject HackTargetLight;
    public GameObject HackLine;
    public bool isTargetLock;
    public bool isForklift;

    // Start is called before the first frame update
    void Start()
    {
        isTargetLock = true;
        HackTarget = EmptyTarget;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーからレーザー出して当たったキャラの情報を取得
        Ray ray = Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 50.5f))
        {
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 0.05f);
            if (hit.collider.tag == ("Citizen"))
            {
                //キャラにカーソル判定
                HackTarget = hit.collider.gameObject;
                //合わせたらアウトラインが表示される
                HackTarget.GetComponent<Outline>().eraseRenderer = false;
                //HackTargetに今カーソル合わせてるキャラをセット
                HackLine.GetComponent<HackLineController>().m_Target = HackTarget.transform;
                //カーソル合わせた状態で左クリックでハッキング開始
                this.GetComponent<Hacking>().StartHack();
                return;
            }
            if (hit.collider.tag == ("Citizen2"))
            {
                //キャラにカーソル判定
                HackTarget = hit.collider.gameObject;
                //合わせたらアウトラインが表示される
                HackTarget.GetComponent<Outline>().eraseRenderer = false;
                //HackTargetに今カーソル合わせてるキャラをセット
                HackLine.GetComponent<HackLineController>().m_Target = HackTarget.transform;
                //カーソル合わせた状態で左クリックでハッキング開始
                this.GetComponent<Hacking>().StartHack();
                return;
            }
            if (hit.collider.tag == ("ForkLift"))
            {
                //キャラにカーソル判定
                HackTarget = hit.collider.gameObject;
                //合わせたらアウトラインが表示される
                
                HackTarget.GetComponent<Outline>().eraseRenderer = false;
                //HackTargetに今カーソル合わせてるキャラをセット
                HackLine.GetComponent<HackLineController>().m_Target = HackTarget.transform;
                //カーソル合わせた状態で左クリックでハッキング開始
                this.GetComponent<Hacking>().ForkLiftHack();
                return;
            }
            if (hit.collider.tag == ("Light"))
            {
                //キャラにカーソル判定
                HackTarget = hit.collider.gameObject;
                //合わせたらアウトラインが表示される
                HackTarget.GetComponent<Outline>().eraseRenderer = false;
                //HackTargetに今カーソル合わせてるキャラをセット
                HackLine.GetComponent<HackLineController>().m_Target = HackTarget.transform;
                //カーソル合わせた状態で左クリックでハッキング開始
                this.GetComponent<Hacking>().LightHack();
                return;
            }
            if (hit.collider.tag == ("Untagged") && isTargetLock)
            {
                //カーソル外したらアウトライン非表示
                HackTarget.GetComponent<Outline>().eraseRenderer = true;
                //HackLineのターゲットに自分をセット(ハッキング線が表示されなくなる)
                HackLine.GetComponent<HackLineController>().m_Target = this.transform;
                return;
            }
        }
        //ハッキングを中止
        this.GetComponent<Hacking>().StopHack();
    }

}
