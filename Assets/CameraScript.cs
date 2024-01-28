using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Rigidbody2D player1;
    public Rigidbody2D player2;
    public CinemachineVirtualCamera camera;
    public void camZoom(){

        double distPlayer = Math.Sqrt((player1.position[0] - player2.position[0])*(player1.position[0] - player2.position[0])+(player1.position[1] - player2.position[1])*(player1.position[1] - player2.position[1]));
        if(distPlayer>0 && distPlayer<=25){
            
            ModifyLensParameters(15);
            
        }
        else if(distPlayer>25 && distPlayer<=43){

            ModifyLensParameters(20);

        }
        else {

            ModifyLensParameters(30);

        }

    }

    public void ModifyLensParameters(float zoom)
    {
        // Accéder aux paramètres de la lentille
        LensSettings lensSettings = camera.m_Lens;

        // Modifier les paramètres selon vos besoins
        lensSettings.OrthographicSize = zoom; // Exemple : augmenter le champ de vision de 10 degrés

        // Appliquer les modifications à la lentille
        camera.m_Lens = lensSettings;
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        camZoom();
    }
}
