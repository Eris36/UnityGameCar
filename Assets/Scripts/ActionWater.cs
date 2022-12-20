using UnityEngine;

public class ActionWater : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    public void StopPosition()
    {
        rb.velocity = new Vector3 (0f, 0, 0f);
    }
}
