using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour{
	public GameObject characterPrincipal;
	public float velocidad=20f;
	//Use this for initialization
	void Start() {
		
}

    // Update is called once per frame
    void Update(){
		//transform.position += Vector3.forward * Time.deltaTime;
		if(Input.GetKey(KeyCode.UpArrow)) {
			transform.position += Vector3.forward * Time.deltaTime;
    }
	//Cuando presione la tecla DOWN el carro avanza hacia atras o en reversa
		if(Input.GetKey(KeyCode.DownArrow)) {
			transform.position -= Vector3.forward * Time.deltaTime;
	}
	//Cuando presione la tecla RIGHT
		if(Input.GetKey(KeyCode.RightArrow)) {
			//transform.position += Vector3.right * Time.deltaTime;
			transform.eulerAngles += new Vector3(0,velocidad*Time.deltaTime,0);
	}
	//Cuando presione la tecla LETF
		if(Input.GetKey(KeyCode.LeftArrow)) {
			//transform.position -= Vector3.right * Time.deltaTime;
			transform.eulerAngles -= new Vector3(0,velocidad*Time.deltaTime,0);
		}
  }		
}
