using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackpackUIBehaviour : MonoBehaviour {

	//update the canvas with info from backpack
	
	private Text UIText;
	
    public void DisplayControls()
    {
        UIText.text = "WSAD -> Movement\n" + "Q -> Drop Item\n" + "I -> Display Items\n"; 
    }

	public void UpdateBackpackUI(List<Item> items)
	{
		UIText.text = "Items \n";
		foreach(var item in items)
		{
            //Debug.Log(item);
			UIText.text += item.Name + "\n";
		}
	}

	// Use this for initialization
	void Start () {

		UIText = GetComponentInChildren<Text>();
	}
}
