using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[System.Serializable]
public class Sound
{
	//put this on a gameobject for audio. I call mine AudioManager
	public string name;
	public AudioClip clip;
	public bool Loop;
	[HideInInspector]
	public AudioSource source;
}
