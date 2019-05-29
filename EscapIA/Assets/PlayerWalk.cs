using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float playerSpeed = 10.0f;
    public bool moveForward;

    private CharacterController cc;
    private Rigidbody rbody;

    void Start(){
    	cc = GetComponent<CharacterController> ();
    	rbody = GetComponent<Rigidbody> ();
    }

    void Update(){
    //    if(Input.GetButton("Fire1")){

   //     		Vector3 p = GetBaseInput();
   //     		p = p * Time.deltaTime;
   //    		Vector3 newPosition = transform.position;
			// transform.Translate(p);
   //         	newPosition.x = transform.position.x;
   //         	newPosition.z = transform.position.z;
            
   //          float inputX = Input.GetAxis("Horizontal");
   //          float inputZ = Input.GetAxis("Vertical");

   //          float moveX = inputX * playerSpeed * Time.deltaTime;
   //          float moveZ = inputZ * playerSpeed * Time.deltaTime;

   //          Vector3 movement = new Vector3(moveX, 0, moveZ);

   //          rbody.MovePosition(transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime);
   //          transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
    //    }

    	if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.y <= 90.0f){
    		moveForward = true;
    	}else{
    		moveForward = false;
    	}

    	if(moveForward){
    		transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
    		Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

    		cc.SimpleMove(forward * playerSpeed);
    	}
    }

    	// Déclaration de la variable de vitesse
	// float mainSpeed = 10.0f; //regular speed
 //    float shiftAdd = 25.0f; //multiplied by how long shift is held.  Basically running
 //    float maxShift = 100.0f; //Maximum speed when holdin gshift
 //    float camSens = 0.10f; //How sensitive it with mouse
 //    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
 //    private float totalRun= 1.0f;
 //    private Rigidbody rbody;

 //    void Start(){
 //    	rbody = GetComponent<Rigidbody>();
 //    }  

 //    void Update () {
 //        lastMouse = Input.mousePosition - lastMouse ;
 //        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0 );
 //        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x , transform.eulerAngles.y + lastMouse.y, 0);
 //        transform.eulerAngles = lastMouse;
 //        lastMouse =  Input.mousePosition;
 //        //Mouse  camera angle done.  
       
 //        //Keyboard commands
 //        float f = 0.0f;
 //        Vector3 p = GetBaseInput();

 //        if (Input.GetKey (KeyCode.RightArrow)){
 //            totalRun += Time.deltaTime;
 //            p  = p * totalRun * shiftAdd;
 //            p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
 //            p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
 //            p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
 //        }
 //        else{
 //            totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
 //            p = p * mainSpeed;
 //        }
       
 //        p = p * Time.deltaTime;
 //       Vector3 newPosition = transform.position;
 //        if (Input.GetKey(KeyCode.Space)){ //If player wants to move on X and Z axis only
 //            transform.Translate(p);
 //            newPosition.x = transform.position.x;
 //            newPosition.z = transform.position.z;
 //            transform.position = newPosition;
 //        }
 //        else{
 //            transform.Translate(p);
 //        }
       
 //    }
     
 //    private Vector3 GetBaseInput() { //returns the basic values, if it's 0 than it's not active.
 //        Vector3 p_Velocity = new Vector3();
 //        if (Input.GetKey (KeyCode.Z)){
 //            p_Velocity += new Vector3(0, 0 , 1);
 //        }
 //        if (Input.GetKey (KeyCode.S)){
 //            p_Velocity += new Vector3(0, 0, -1);
 //        }
 //        if (Input.GetKey (KeyCode.Q)){
 //            p_Velocity += new Vector3(-1, 0, 0);
 //        }
 //        if (Input.GetKey (KeyCode.D)){
 //            p_Velocity += new Vector3(1, 0, 0);
 //        }
 //        return p_Velocity;
 //    }



}