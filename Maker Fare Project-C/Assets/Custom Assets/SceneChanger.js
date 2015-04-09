#pragma strict

var levelName : String; 

function OnTriggerEnter (collider : Collider) { 
	if (collider.tag == "enemy") 
	{ 
		Application.LoadLevel("L1"); 
	}  
    if (collider.tag == "door")
    {
        Application.LoadLevel("L2");
    }
    	if (collider.tag == "start") 
	{ 
	 
		}
}