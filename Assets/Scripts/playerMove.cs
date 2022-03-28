using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{

    Rigidbody rb;

    public Text countCubes;
    public Text winText;
    public Text collisionPoint;
    public Text velocityBallText;

    private int count;
    public float Speed;
    public float velocity;

    public Transform target;
    public Button button;
    public Camera cam;
    Vector3 btnPos;
    Vector3 targetPos;

    private void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText(count);
        winText.text = "";
    }
    private void Update()
    {
        /*
        Vector3 worldPos = cam.ScreenToWorldPoint(button.transform.position);
        //Debug.Log("Screen to world pos of button: " + worldPos);
        btnPos = target.transform.position;
        btnPos = worldPos;
        */
        //Debug.Log("Button pos: " + btnPos);

        Vector3 screenPos = cam.WorldToScreenPoint(target.transform.position);
        //Debug.Log("World to screen pos of player: " + screenPos);
        btnPos = target.transform.position;
        targetPos = button.transform.position;
        targetPos = screenPos;
        target.transform.Translate(Vector3.forward * Time.deltaTime);
        Debug.Log("Button pos (World to Screen): " + targetPos);
        //button.transform.Translate(targetPos * Time.deltaTime);
        button.transform.position += (targetPos - button.transform.position) * 10 * Time.deltaTime;


        /*
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveH, 0f, moveV);
        transform.Translate(move * Speed * Time.deltaTime);
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText(count);
            collisionPoint.text = "Collision point:" + other.gameObject.transform.position.ToString();
        }
    }


    public void SetCountText(int cube_count)
    {
        countCubes.text = "Collected cubes:" + cube_count.ToString();
        if (count >= 5)
            SetWinText();
    }

    public void SetWinText()
    {
        winText.text = "Game Over";
    }
}
