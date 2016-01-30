using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {
		GUI.Box(new Rect(10,10,120,120), "Loader Menu");
		if(GUI.Button(new Rect(20,40,100,20), "Nueva Partida")) {

			Application.LoadLevel("Pantallajuego");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,100,20), "Salir")) {

			Application.Quit();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
