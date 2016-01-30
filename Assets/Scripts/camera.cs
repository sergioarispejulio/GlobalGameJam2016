using UnityEngine;
using System.Collections;


public class camera : MonoBehaviour {

	//
	// VARIABLES
	//
	

	
	private Vector3 mouseOrigin;	// Position of cursor when mouse dragging starts
	private float speed = 15.0f;
	private float tamanoxpantalla = (Screen.width*0.40f);
	private float tamanoypantalla = (Screen.height*0.40f);
	Vector3 medio = new Vector3((Screen.width/2), (Screen.height/2) ,0);
	private float limitex = 50;
	private float limitey = 50;
	private float movidasx = 0;
	private float movidasy = 0;	

	

	// Use this for initialization
	void Start () {
		mouseOrigin = Input.mousePosition;
	}
	
	//
	// UPDATE
	//

	public bool puede_moverse_la_camara(int posicion)
	{
		bool condi = false;
		switch(posicion)
		{
		case 1:
			if((movidasx + 1) <= limitex)
			{
				condi = true;
			}
			else
			{
				condi = false;
			}
			break;

		case 2:
			if((movidasx - 1) >= (-limitex))
			{
				condi = true;
			}
			else
			{
				condi = false;
			}
			break;

		case 3:
			if((movidasy + 1) <= limitey)
			{
				condi = true;
			}
			else
			{
				condi = false;
			}
			break;

		case 4:
			if((movidasy - 1) >= (-limitey))
			{
				condi = true;
			}
			else
			{
				condi = false;
			}
			break;
		}
		return condi;
	}


	public void mover_camara()
	{
		Vector3 mouse = Input.mousePosition;
		bool resultado = false;
		if(mouse.x >= medio.x) //x derecha
		{
			if(mouse.x <= (medio.x + tamanoxpantalla)) //dentro de la region limite x
			{
				;
			}
			else //fuera de la region limite x
			{
				if(puede_moverse_la_camara(1))
				{
					movidasx++;
					transform.Translate(new Vector3(speed * Time.deltaTime, 0 ,0));
					resultado = true;
				}
			}
		}
		else //x izquierda
		{
			if(mouse.x >= (medio.x - tamanoxpantalla)) //dentro de la region limite x
			{
				;
			}
			else //fuera de la region limite x
			{
				if(puede_moverse_la_camara(2))
				{
					movidasx--;
					transform.Translate(new Vector3(-speed * Time.deltaTime, 0 ,0));
					resultado = true;
				}
			}
		}
		
		if(mouse.y >= medio.y) //y arriba y que en x no se salga del limite
		{
			if(mouse.y <= (medio.y + tamanoypantalla)) //dentro de la region limite y
			{
				;
			}
			else //fuera de la region limite y
			{
				if(puede_moverse_la_camara(3))
				{
					movidasy++;
					transform.Translate(new Vector3(0, speed * Time.deltaTime,0));
					resultado = true;
				}
			}
		}
		else //x abajo
		{
			if(mouse.y >= (medio.y - tamanoypantalla)) //dentro de la region limite y
			{
				;
			}
			else //fuera de la region limite y
			{
				if(puede_moverse_la_camara(4))
				{
					movidasy--;
					transform.Translate(new Vector3(0, -speed * Time.deltaTime,0));
					resultado = true;
				}
			}
		}
	}


	
	void Update () 
	{
		mover_camara();
	}
}

