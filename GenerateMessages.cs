using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerate : MonoBehaviour
{
	[SerializeField] private string[] messages;
	[SerializeField] private Text messageText;
	
	public void GenerateMessage()
	{
		messageText.text = messages[Random.Range(0, messages.Length)];
	}
}
