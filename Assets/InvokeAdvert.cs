﻿using UnityEngine;
using UnityEngine.Advertisements;

public class InvokeAdvert : MonoBehaviour
{

	void Update()
	{
		ShowAd();
	}

	public void ShowAd()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}
	}
}