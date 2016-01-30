using UnityEngine;
using System.Collections;

public class Recurso : MonoBehaviour {

	public int id_recurso;
	public int cantidad_disponible;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void reducir_disponibilidad()
	{
		cantidad_disponible--;
	}

	public bool	verificar_si_esta_disponible()
	{
		if (cantidad_disponible == 0)
			return false;
		else
			return true;
	}
}
