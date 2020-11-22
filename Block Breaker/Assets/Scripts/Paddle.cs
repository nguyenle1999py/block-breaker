using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnit = 16f;
    [SerializeField] float minWidth = 0f;
    [SerializeField] float maxWidth = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse position by width unit, default mouse position and screen width is pixel 
        float mousePos = Input.mousePosition.x / Screen.width * screenWidthInUnit;
        //  Set transform x always in minWidth and maxWidth
        float transX = Mathf.Clamp(mousePos, minWidth, maxWidth);
        Vector2 paddlePos = new Vector2(transX, transform.position.y);
        // Set transform (game object position) = mouse position
        transform.position = paddlePos;
    }
}
