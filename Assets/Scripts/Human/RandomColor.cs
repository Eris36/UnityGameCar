using UnityEngine;

public class RandomColor : MonoBehaviour
{
    void Start()
    {
        var material = GetComponent<Renderer>().material;
        var r = Random.Range(0, 1f);
        var g = Random.Range(0, 1f);
        var b = Random.Range(0, 1f);
        Color customColor = new Color(r, g, b, 1.0f);
        material.SetColor("_Color", customColor);
        Debug.Log(customColor);
    }
}
