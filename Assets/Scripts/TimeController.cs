using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    [SerializeField] private Text _textView;
    public float _timeStart = 20f;
    
    void Update()
    {
        if (_timeStart >= 0)
        {
            _timeStart -= Time.deltaTime;
            _textView.text = Mathf.Round(_timeStart).ToString();
        }
        else
        {
            _textView.text = "0";
        }
        
    }
}
