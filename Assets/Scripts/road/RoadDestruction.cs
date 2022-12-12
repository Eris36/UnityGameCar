using UnityEngine;


public class RoadDestruction : MonoBehaviour
{
    private float smoothTime = 0.5f;
    private float yVelocity;

    public void Visited()
    {
        Invoke ("Rotation", 1f);
        Invoke ("GoDown", 1.5f);
        Invoke ("Destruction", 2f);
    }
    void GoDown()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.y, transform.position.y -1 , ref yVelocity, smoothTime);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }
    
    void Rotation()
    {
        Quaternion newRotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);;
        newRotation *= Quaternion.Euler(0, 0, 90); // this add a 90 degrees Y rotation
        transform.rotation= Quaternion.Slerp(transform.rotation, newRotation,1 * Time.deltaTime);   
    }
    
    void Destruction()
    {
        Destroy(gameObject);
    }
   
}
