using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class scriptMask : MonoBehaviour
{


    public CapsuleCollider2D capsuleMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public CapsuleCollider2D GetCapsuleMask(){

        return this.capsuleMask;

    }

   

}
