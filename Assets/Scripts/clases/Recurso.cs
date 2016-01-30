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

	protected void reducir_disponibilidad()
	{
		cantidad_disponible--;
	}

	protected bool	verificar_si_esta_disponible()
	{
		if (cantidad_disponible == 0)
			return false;
		else
			return true;
	}
}
