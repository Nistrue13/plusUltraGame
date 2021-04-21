using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour {

	public string name;
	public GameObject InputField;
	public GameObject textDisplay;
	
	public void StoreName()
	{
		name = InputField.GetComponent<Text>().text;
	}
}
