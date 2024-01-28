using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScipt : MonoBehaviour
{   
    private statPlayer statPlayer;
    public Slider slider;
    public float BarreDeRire;
    void Start()
    {   
        BarreDeRire = statPlayer.barreRire;
        slider.value = BarreDeRire;
    }

    void Update()
    {
        SetHealth();
    }
    public void SetMaxBarDeRire(float bareDeRire){
        slider.maxValue = bareDeRire;
    }
    public void SetHealth(){
        slider.value = BarreDeRire;
    }
}
