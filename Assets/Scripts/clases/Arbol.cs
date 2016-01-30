using UnityEngine;
using System.Collections;

public class Arbol : Recurso {

	// Use this for initialization
	void Start () {
		id_recurso = 1;
		cantidad_disponible = 20;
	}
	
	// Update is called once per frame
	void Update () {
		if(verificar_si_esta_disponible())
		{
			Destroy(this.gameObject,0.0f);
		}
		else
		{
		}
	}
}
