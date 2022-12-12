using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInventar : MonoBehaviour
{

    public float mony = 0;
    
    // Start is called before the first frame update

    // Update is called once per frame
    public void AddMony()
    {
        mony = mony + 1;
    }
    
}
