using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {
		if (GUILayout.Button("Press Me"))
			Debug.Log("Hello!");
		/*GUILayout.TextArea (new Rect(10,10,200,200), "Recuerdo esos tiempos donde todo era mas simple adorabamos a aquellos dioses " +
			"cuando las nuevas generaciones empezaron a dudar de su divinidad, ahi es donde todo empezo a ser mas complicado" +
			"ahora los dioses, estan furiosos y empiezaron a mandar mountruos, muestras de su fuiria por si furia" +
			"se rumora que existen personas que intentar combatirlas, espero que alguien detenga a aquellos dioses. la la la" +
			"no sabia que escribir :P");*/
	}
	// Update is called once per frame
	void Update () {
	
	}
}
