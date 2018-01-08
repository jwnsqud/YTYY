using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickItem : MonoBehaviour
{
	public GameObject deletegameObject;
	public GameObject Particle;
	void Start()
	{
		
	}

	void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if(col.CompareTag("Player"))
		{
			Debug.Log("들어감");
			Particle.SetActive(true);
		}
	}

	private void OnTriggerStay2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			Particle.SetActive(true);
		}

		if (Input.GetMouseButtonDown(0))
		{
			Destroy(deletegameObject);
		}
	}

	private void OnTriggerExit2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			Particle.SetActive(false);
		}
	}

}
