﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{

	//Extended Method for CanvasGroup API
	public static void SetActive(this CanvasGroup canvasGroup, bool isTrue)
	{
		if(isTrue)
		{
			canvasGroup.alpha = 1f;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
		}
		else
		{
			canvasGroup.alpha = 0f;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
		}
	}

    public static T AddComponent<T>(this Component component) where T : Component
    {
        return component.gameObject.AddComponent<T>();
    }

    public static T GetOrAddComponent<T>(this Component component) where T : Component
    {
        return component.GetComponent<T>() ?? component.AddComponent<T>();
    }

    public static bool HasComponent<T>(this Component component) where T : Component
    {
        return component.GetComponent<T>() != null;
    }
   
}

public class PlayerPrefs2
 {
     public static void SetBool(string key, bool state)
     {
         PlayerPrefs.SetInt(key, state ? 1 : 0);
     }
 
    public static bool GetBool(string key)
    {
        return PlayerPrefs.GetInt(key) == 1 ? true : false;
    }
 }
