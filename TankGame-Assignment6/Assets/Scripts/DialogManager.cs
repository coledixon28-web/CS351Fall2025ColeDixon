using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogManager : MonoBehaviour
{
	public TMP_Text textbox;
	public string[] sentences;
	private int index;
	public float typingSpeed;
	public GameObject continueButton;
	public GameObject dialogPanel;

	void OnEnable()
	{
	continueButton.SetActive(false);
	StartCoroutine(Type());
	}

	//coroutine to type one at a time 
	IEnumerator Type()
	{
	textbox.text = " ";
	//start textbox as empty
	//then loop thru message one letter at time
	
	foreach (char letter in sentences[index])
	{
	textbox.text += letter;
	yield return new WaitForSeconds(typingSpeed);
	}
	continueButton.SetActive(true);
}
	public void NextSentence()
	{
	continueButton.SetActive(false);
	if (index < sentences.Length - 1)
	{
	index++;
	textbox.text = " ";
	StartCoroutine(Type());
	}
	else
	 {
	textbox.text = " ";
	dialogPanel.SetActive(false);
		}
	}
}

   
