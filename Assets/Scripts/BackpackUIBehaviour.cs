using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackpackUIBehaviour : MonoBehaviour {

	//update the canvas with info from backpack	
	
	private Text UIText;

	public void UpdateBackpackUI(Item item)
	{
		UIText.text += item.Name + "\n";
		//UnityEngine.Canvas.ForceUpdateCanvases();
	}

	public void UpdateBackpackUI(List<Item> items)
	{
		UIText.text = "Items \n";
		foreach(var item in items)
		{
            Debug.Log(item);
			//UIText.text += item.Name + "\n";
		}
	}

	// Use this for initialization
	void Start () {

		UIText = GetComponentInChildren<Text>();		
		//GetComponentInChildren<Text>().text = "STARTUP";
	}
}
