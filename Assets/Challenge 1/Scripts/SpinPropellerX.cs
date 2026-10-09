using UnityEngine;

public class Propeller : MonoBehaviour
{
    private Vector3 PropellerRotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PropellerRotationSpeed = new Vector3(0,0,360);
        transform.Rotate(PropellerRotationSpeed * Time.deltaTime);
    }
}
