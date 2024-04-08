using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeandler : MonoBehaviour
{
    private PlayerControler player;
    private float widthLineX;
    private float widthLineY;
    [SerializeField] private KeyCode forward = KeyCode.W;
    [SerializeField] private KeyCode back = KeyCode.S;
    [SerializeField] private KeyCode right = KeyCode.D;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode up = KeyCode.Space;
    [SerializeField] private KeyCode down = KeyCode.LeftShift;
    [SerializeField] private KeyCode spinRight = KeyCode.E;
    [SerializeField] private KeyCode spinLeft = KeyCode.Q;

    void Start()
    {
        player = gameObject.GetComponent<PlayerControler>();
        widthLineX = Screen.width * 0.2f;
        widthLineY = Screen.height * 0.1f;
    }

    void Update()
    {
        if(Input.GetKey(forward))
            player.Move(transform.forward);
        if(Input.GetKey(back))
            player.Move(-transform.forward);
        if(Input.GetKey(right))
            player.Move(transform.right);
        if(Input.GetKey(left))
            player.Move(-transform.right);
        if(Input.GetKey(up))
            player.Move(transform.up);
        if(Input.GetKey(down))
            player.Move(-transform.up);
        if (Input.GetKey(spinRight))
            player.Spin(-transform.forward);
        if (Input.GetKey(spinLeft))
            player.Spin(transform.forward);


        if (Input.mousePosition.x < widthLineX)
            player.SpinMouse(-transform.up, Input.mousePosition.x/widthLineX);
        if (Input.mousePosition.x > Screen.width - widthLineX )
            player.SpinMouse(-transform.up, -(Input.mousePosition.x - (Screen.width - widthLineX))/widthLineX);
        if (Input.mousePosition.y < widthLineX)
            player.SpinMouse(transform.right, Input.mousePosition.y/widthLineY);
        if (Input.mousePosition.y > Screen.height - widthLineY )
            player.SpinMouse(transform.right, -(Input.mousePosition.y - (Screen.height - widthLineY))/widthLineY);
    
    }
}
