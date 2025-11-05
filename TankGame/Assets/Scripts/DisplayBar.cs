using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//must include this to use slider
using UnityEngine.UI;


public class DisplayBar : MonoBehaviour
{

//reference to slider for health bar
public Slider slider;



	public Gradient gradient;

	public Image fill;

//function to set the current value of the slider 
public void SetValue(float value) 
{
//set value of slider 
	slider.value = value;

	//set color of fill of slider
	fill.color = gradient.Evaluate(slider.normalizedValue);
}

//function to set max value of slider
public void SetMaxValue(float value)
{
//set maxvalue of slider 
slider.maxValue = value;
//also set current value of slider to the max value
slider.value = value;
	//set color of fill of the slider
	fill.color = gradient.Evaluate(1f);

}


   }
