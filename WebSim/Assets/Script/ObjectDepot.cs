using UnityEngine;

public class ObjectDepot : MonoBehaviour
{
    public static bool objectInPlace;
    private float counter;

    private void Start()
    {
        objectInPlace = true;
        counter = 0;
    }

    private void Update()
    {
        if(counter >= 600)
        {
            objectInPlace = true;
        }
    }

    private void FixedUpdate(){
        if(!objectInPlace)
        {
            counter++;
        }
        else
        {
            counter = 0;
        }
    }
}
