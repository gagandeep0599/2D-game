using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 3f;
    private Button jumpBtn;
    private Rigidbody2D myBody;
   
    void Awake(){
        jumpBtn = GameObject.Find("Jump").GetComponent<Button>();
        myBody = GetComponent<Rigidbody2D>();
        jumpBtn.onClick.AddListener(() => Jump());
    }

    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position  = temp;
    }

    public void Jump(){
        myBody.gravityScale *= -1;
        Vector3 temp = transform.localScale;
        temp.y *= -1;
        transform.localScale = temp;
    }

} //class




























