using UnityEngine;
using System.Collections;

public class desplegarconstruir : MonoBehaviour {
	
	private GameObject esferaprincipal;
	private GameObject opcion1;
	private GameObject opcion2;
	private GameObject opcion3;
	private bool selecciono_anteriormente = false;
	private Vector3 medio_principal;
	private Vector3 medio_opcion1;
	private Vector3 medio_opcion2;
	private Vector3 medio_opcion3;
	private int radiox=36;
	private int radioy=18;
	private int radioopcionx=20;
	private int radioopciony=14;
	private bool creando;
	private int indexOpcion;
	private Vector3 posiantimouse;

	public void ocultar_opciones()
	{
		opcion1.transform.Translate (0, 0, -30);
		opcion2.transform.Translate (0, 0, -30);
		opcion3.transform.Translate (0, 0, -30);
	}

	public void mostrar_opciones()
	{
		opcion1.transform.Translate (0, 0, 30);
		opcion2.transform.Translate (0, 0, 30);
		opcion3.transform.Translate (0, 0, 30);
		//Aqui rellenar las esferas
	}

	public int selecciono_alguna_opcion()
	{
		Vector3 mouse = Input.mousePosition;
		Debug.Log (mouse);
		Debug.Log (medio_opcion3);
		//esfera 1
		if(mouse.x <=(medio_opcion1.x+radioopcionx) && mouse.x >=(medio_opcion1.x-radioopcionx))
		{
			if(mouse.y <=(medio_opcion1.y+radioopciony) && mouse.y >=(medio_opcion1.y-radioopciony))
			{
				return 1;
			}
		}
		//
		//esfera 2
		if(mouse.x <=(medio_opcion2.x+radioopcionx) && mouse.x >=(medio_opcion2.x-radioopcionx))
		{
			if(mouse.y <=(medio_opcion2.y+radioopciony) && mouse.y >=(medio_opcion2.y-radioopciony))
			{
				return 2;
			}
		}
		//
		//esfera 3
		if(mouse.x <=(medio_opcion3.x+radioopcionx) && mouse.x >=(medio_opcion3.x-radioopcionx))
		{
			if(mouse.y <=(medio_opcion3.y+radioopciony) && mouse.y >=(medio_opcion3.y-radioopciony))
			{
				return 3;
			}
		}
		//
		return 0;
	}

	public bool click_dentro_esfera_principal()
	{
		bool resu = false;
		Vector3 mouse = Input.mousePosition;
		Debug.Log (mouse);
		Debug.Log (medio_principal);
		if(mouse.x <=(medio_principal.x+radiox) && mouse.x >=(medio_principal.x-radiox))
		{
			if(mouse.y <=(medio_principal.y+radioy) && mouse.y >=(medio_principal.y-radioy))
			{
				resu = true;
			}
		}
		return resu; 
	}
	
	// Use this for initialization
	void Start () {
		creando = false;
		esferaprincipal = GameObject.Find("construir");
		opcion1 = GameObject.Find("construiropcion1");
		opcion2 = GameObject.Find("construiropcion2");
		opcion3 = GameObject.Find("construiropcion3");
		medio_principal = new Vector3 (Screen.width-(Screen.width*0.05f),Screen.height-(Screen.height*0.13f),0);
		medio_opcion1 = new Vector3 (Screen.width-(Screen.width*0.133f),Screen.height-(Screen.height*0.076f),0);
		medio_opcion2 = new Vector3 (Screen.width-(Screen.width*0.133f),Screen.height-(Screen.height*0.178f),0);
		medio_opcion3 = new Vector3 (Screen.width-(Screen.width*0.133f),Screen.height-(Screen.height*0.291f),0);

	}
	
	// Update is called once per frame
	void Update () {
		int resu;
		if(Input.GetMouseButtonUp(0))
		{
			resu = selecciono_alguna_opcion();
			if(creando == true)
			{

				creando = false;
				Vector3 pos = Input.mousePosition;
				pos.z = 20;
				pos = Camera.main.ScreenToWorldPoint(pos);
				if (indexOpcion == 1) {
					Instantiate(GameObject.Find("Cubogenerado"), pos,  Quaternion.identity);
				}
				if (indexOpcion == 2) {
					Instantiate(GameObject.Find("roca"), pos,  Quaternion.identity);
				}
				if (indexOpcion == 3) {
					Instantiate(GameObject.Find("arbol"), pos,  Quaternion.identity);
				}
				//Instantiate(GameObject.Find("Cubogenerado"), pos,  Quaternion.identity);
				Destroy(GameObject.Find("Cubogeneradosombra(Clone)"), 0.0F);
			}
			else
			{

				if(selecciono_anteriormente == true)
				{
					//Debug.Log ("*************************");
					resu = selecciono_alguna_opcion();
					if(resu != 0)
					{
						selecciono_anteriormente = false;
						Vector3 pos = Input.mousePosition;
						pos.z = 20;
						pos = Camera.main.ScreenToWorldPoint(pos);
						Instantiate(GameObject.Find("Cubogeneradosombra"), pos,  Quaternion.identity);
						creando = true;
						posiantimouse = pos;
						Debug.Log ("Entro a "+resu);
						indexOpcion = resu;
						ocultar_opciones();
					}
					else
					{
						selecciono_anteriormente = false;
						ocultar_opciones();
					}
				}
				else
				{
					Vector3 mouse = Input.mousePosition;
					//Debug.Log ("----------------------");

					if(click_dentro_esfera_principal() && selecciono_anteriormente != true)
					{
						selecciono_anteriormente = true;
						//Debug.Log("ENTRO!!!!!!!!!!!!!!!!!!!!!!!!!!!");
						mostrar_opciones();
					}
				}
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
