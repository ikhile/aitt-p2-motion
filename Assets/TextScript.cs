using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
       Screen.orientation = ScreenOrientation.LandscapeLeft; 
    //    text = gameObject;
    //    Debug.Log(text.name);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        if (dir.sqrMagnitude > 1) dir.Normalize();

        dir *= Time.deltaTime;

        text.text = $"[{dir.x}, {dir.y}, {dir.z}]";
        // Debug.Log($"[{dir.x}, {dir.y}, {dir.z}]");
    }
}
