using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PULL1 : MonoBehaviour //https://youtu.be/OUlxP4rZap0
{
	public List<string> characters;
	public int[] table =
	{
		60, //common
		30, //uncommon
		10  //rare
	};
	public int total;
	public int randomNumber;
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		foreach (var item in table)
		{
			total += item;
		}
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");

		randomNumber = Random.Range(0, total); //draw random number

		for(int i = 0; i < table.Length; i++)
        {
			if (randomNumber <= table[i]) //awardItem
            {
				Debug.Log(characters[i]);
				return;
            }
            else
            {
				randomNumber -= table[i];
            }
        }
	}
}
