using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camoreRotate : MonoBehaviour
{
    //Tato část kódu natáčí o určitý úhel kameru při pohybu

	float mod = 0.1f;
	float zVal = 0.0f;
	private Movements mv;

	// Use this for initialization
	void Start()
	{
		mv = GameObject.FindGameObjectWithTag("Player").GetComponent<Movements>();
	}

	// Update is called once per frame
	void Update()
	{
		if (mv.moving) //Pokud se Player hýbe tak se kamera o určitý úhel natáčí
		{
			Vector3 rot = new Vector3(0, 0, zVal);
			this.transform.eulerAngles = rot;

			zVal += mod;

			if (transform.eulerAngles.z >= 5.0f && transform.eulerAngles.z < 10.0f) 
			{
				mod = -0.1f;
			}
			else if (transform.eulerAngles.z < 355.0f && transform.eulerAngles.z > 350.0f)
			{
				mod = 0.1f;
			}
		}
	}
}
