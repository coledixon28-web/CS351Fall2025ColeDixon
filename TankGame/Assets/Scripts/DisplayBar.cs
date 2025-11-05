using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//must include this to use slider
using UnityEngine.UI;


public class DisplayBar : MonoBehaviour
{

//reference to slider for health bar
public Slider slider;

//function to set the current value of the slider 
public void SetValue(float value) 
{
//set value of slider 
	slider.value = value;


}

//function to set max value of slider
public void SetMaxValue(float value)
{
//set maxvalue of slider 
slider.maxValue = value;
//also set current value of slider to the max value
slider.value = value;


}


   }
