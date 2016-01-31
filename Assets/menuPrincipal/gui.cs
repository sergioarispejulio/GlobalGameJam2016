using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {
		GUI.Box(new Rect(325,200,300,175), "Loader Menu");
		if(GUI.Button(new Rect(375,250,200,40), "Nueva Partida")) {

			Application.LoadLevel("Pantallajuego");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(375,325,200,40), "Salir")) {

			Application.Quit();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
