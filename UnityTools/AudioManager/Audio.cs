using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;
using System;
public class Audio : MonoBehaviour
{
	public static Audio instance;
	public Sound[] sounds;
	//put this on a gameobject for audio. I call mine AudioManager
   
	void Awake()
	{
		
		if (instance == null)
		{
			instance = this;
		}
		else {
			Destroy(gameObject);
			return;
		}
		DontDestroyOnLoad(gameObject);
		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.Loop;
		}
	}
	//call this in other scripts using FindObjectOfType<yourgameobjectname>().PlaySound("yoursoundname") 
	public void PlaySound(string name)
	{
	
		Sound s = Array.Find(sounds, sound => sound.name == name);
		if(s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found.");
			return;
		}
		else
		{
			s.source.Play();
		}
	}
	//call this in other scripts using FindObjectOfType<yourgameobjectname>().StopSound("yoursoundname") 
	public void StopSound(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.Stop();
	}

}
