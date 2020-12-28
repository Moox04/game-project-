
using UnityEngine;

public class playerMovement : MonoBehaviour {
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.W))
			transform.Translate(Vector3.forward * 2);
		
		if(Input.GetKeyDown(KeyCode.S))
			transform.Translate(Vector3.back* 2);
		
		if(Input.GetKeyDown(KeyCode.A))
			transform.Translate(Vector3.left* 2);
		
		if(Input.GetKeyDown(KeyCode.D))
			transform.Translate(Vector3.right* 2);
	}
}
