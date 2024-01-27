using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoCycleScript : MonoBehaviour
{

    public CapsuleCollider2D capsuleMonoCycle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public CapsuleCollider2D GetCapsuleMonoCycle(){

        return this.capsuleMonoCycle;

    }
}
