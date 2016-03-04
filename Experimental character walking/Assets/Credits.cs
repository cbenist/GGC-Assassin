using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Credits : MonoBehaviour 
{
	public float timer;

	// Use this for initialization
	void Start () 
	{
		timer = 400.0f;
	}

	// Update is called once per frame
	void Update () 
	{
		timer -= 1.0f;
		if (timer <= 0) 
		{
			Application.LoadLevel ("Credits");
		}
	}
}