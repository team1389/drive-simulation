using UnityEngine;

public class DistanceChecker : MonoBehaviour
{
    public float theDistance;
    public static float points;
    public bool carryingObject;

    private void Start()
    {
        points = 0;
        carryingObject = false;
    }

    private void Update()
    {
        RaycastHit hit;
        
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if(Physics.Raycast(transform.position, (forward), out hit))
        {
            theDistance = hit.distance;     
        }
        else
        {
            theDistance = -1;
        }
        
        if(theDistance < 1 && Input.GetKeyDown(KeyCode.E) && hit.collider.tag == "CargoShip" && carryingObject)      // Scoring points
        {     
            points += 2;
            carryingObject = false;
        }
        else if(theDistance < 1 && Input.GetKeyDown(KeyCode.R) && hit.collider.tag == "Depot")     // Getting object  ***if hit.collider.tag is not working check if you have a box collider or something like that
        {
            Debug.Log("hit");
            if(ObjectDepot.objectInPlace == true)
            {
                ObjectDepot.objectInPlace = false;
                carryingObject = true; 
            }
        }
    }
    
}
