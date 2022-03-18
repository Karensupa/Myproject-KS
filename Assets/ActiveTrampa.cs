using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTrampa : MonoBehaviour {
	public GameObject activarTrampa;
	public Rigidbody esfera;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Carro") {
			esfera.GetComponent <Rigidbody> ().useGravity =true; 
		}
	}
}
