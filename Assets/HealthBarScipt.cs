using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScipt : MonoBehaviour
{   
    public Slider slider;
    void Start()
    {
        slider.value = 0;
    }
    public void SetMaxBarDeRire(float bareDeRire){
        slider.maxValue = bareDeRire;
        
    }
    public void SetHealth(float bareDeRire){
        
    }
}
