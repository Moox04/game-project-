using UnityEngine;
using UnityEngine.UI;
public class selfInstant : MonoBehaviour {
	RaycastHit fit;
	public GameObject tile;
	public int[] fr ;
	bool istrue = true;
	float maxdist = 2f;
	public Vector3 offset;
	public MeshRenderer meshrnd;



	//public int[] num = new int[4] {0,1,2,4};

	void Start () {
		Invoke ("hide",5f);
	}
	public void hide(){
		meshrnd.enabled = false;
	}
	void Update () {
		//
		//Random.seed = (int)System.DateTime.Now.Ticks;
		int randomIndx = Random.Range (1,4);
		while(istrue){
			print (randomIndx);
			if(randomIndx == 1){moveup ();}
			if(randomIndx == 2){moveright ();}
			if(randomIndx == 3){moveleft ();
			}
			//if(randomIndx == 4){movedown ();}

			istrue = false;
		}

	}
	public void moveup(){
		
		if (Physics.Raycast (transform.position + offset, transform.TransformDirection (Vector3.forward), out fit,maxdist)) {
			if (fit.collider.tag == "spnpnt") {
				Instantiate (tile, fit.transform.position, Quaternion.identity);
				//fit.collider.enabled = false;

			} 
		}else {
			moveright ();
			print ("this works!");
		}
	}

	public void moveright(){
		if (Physics.Raycast (transform.position+ offset, transform.TransformDirection (Vector3.right), out fit,maxdist)) {
			if (fit.collider.tag == "spnpnt") {
				Instantiate (tile, fit.transform.position, Quaternion.identity);
				//fit.collider.enabled = false;
			}
		}else{
			moveleft ();
			print ("this works!");
		}
	}
	public void moveleft(){
		if (Physics.Raycast (transform.position+ offset, transform.TransformDirection (Vector3.left), out fit,maxdist)) {
			if (fit.collider.tag == "spnpnt") {
				Instantiate (tile, fit.transform.position, Quaternion.identity);
				//fit.collider.enabled = false;
			}
		}else{
			moveright ();
			print ("this works!");
		}
	}
	public void movedown(){
		if (Physics.Raycast (transform.position+ offset, transform.TransformDirection (-Vector3.forward), out fit,maxdist)) {
			if (fit.collider.tag == "spnpnt") {
				Instantiate (tile, fit.transform.position, Quaternion.identity);
				fit.collider.enabled = false;
			}
		}
	}
}
