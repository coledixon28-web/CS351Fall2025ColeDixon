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


	void OnEnable()
	{

	StartCoroutine(Type());
	}

	//coroutine to type one at a time 
	IEnumerator Type();
	{
	textbox.text = " ";
	//start textbox as empty
	//then loop thru message one letter at time
	
	foreach (char letter in sentences[index])
	{
	textbox.text += letter;
	}


	}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
