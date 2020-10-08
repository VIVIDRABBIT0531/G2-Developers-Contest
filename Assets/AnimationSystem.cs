using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSystem : MonoBehaviour
{
    public GameObject Player;
    public Animation LightBlinkAnimation;
    public GameObject SparkParticle;
    public GameObject SparkParticleClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LightAnimation()
    {
        LightBlinkAnimation = Player.GetComponent<Hacking>()
        .HackTarget.transform.GetChild(0).gameObject.GetComponent<Animation>();
        LightBlinkAnimation.Play();
        SparkParticleClone = Instantiate(SparkParticle, Player.GetComponent<Hacking>()
        .HackTarget.transform.position + new Vector3(3.3f,5.7f,0), Quaternion.identity);
        Destroy(SparkParticleClone,3);
    }
}
