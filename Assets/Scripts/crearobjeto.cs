using UnityEngine;
using System.Collections;

public class crearobjeto : MonoBehaviour {

	private bool creando;
	private Vector3 posiantimouse;

	// Use this for initialization
	void Start () {
		creando = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1))
		{
			if(creando == true)
			{
				creando = false;
				Vector3 pos = Input.mousePosition;
				pos.z = 20;
				pos = Camera.main.ScreenToWorldPoint(pos);
				Instantiate(GameObject.Find("Cubogenerado"), pos,  Quaternion.identity);
				Destroy(GameObject.Find("Cubogeneradosombra(Clone)"), 0.0F);
			}
			else
			{
				Vector3 pos = Input.mousePosition;
				pos.z = 20;
				pos = Camera.main.ScreenToWorldPoint(pos);
				Instantiate(GameObject.Find("Cubogeneradosombra"), pos,  Quaternion.identity);
				creando = true;
				posiantimouse = pos;
			}
		}
		else
		{
			if(creando == true)
			{
				Vector3 pos = Input.mousePosition;
				pos.z = 20;
				pos = Camera.main.ScreenToWorldPoint(pos);
				GameObject.Find("Cubogeneradosombra(Clone)").transform.Translate(pos-posiantimouse);
				posiantimouse = pos;
			}

		}
	}
}
