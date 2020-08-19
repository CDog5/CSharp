using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bg : MonoBehaviour
{
public Gradient camgrad;
	float value = 0f;

	// Start is called before the first frame update
	void Start()
	{
		StartCoroutine(bgrnd());

	}


	// Update is called once per frame
	void Update()
	{


		if (value > 1)
		{
			value = 0;
		}

		//transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
	}
	IEnumerator bgrnd()
	{
		while (true)
		{
			value += 0.05f;
			GetComponent<Renderer>().material.color = camgrad.Evaluate(value);
			yield return new WaitForSeconds(1);
		}
	}
}
