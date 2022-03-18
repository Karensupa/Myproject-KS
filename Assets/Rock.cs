using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
    	//pregunto si este objecto le pego o colisiono contra el objecto que tiene el tag de Carro
    	if (collision.gameObject.yag=="Carro") {
    	// En la consola de Unity aparece qu perdi
    		Debug.Log ("Game Over");
    	}
    }
}

