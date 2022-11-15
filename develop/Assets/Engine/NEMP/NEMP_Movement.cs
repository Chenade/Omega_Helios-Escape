using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEMP_Movement : MonoBehaviour
{

    //public GameObject correctForm;

    private bool moving;
    private bool finish;

    private float startPosX;
    private float startPosY;

    public float target_x;
    public float target_y;
    public float target_z;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving && !finish)
        {
            Vector3  mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, -20);
            //UnityEngine.Debug.Log("SAVE");
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;


        UnityEngine.Debug.Log(this.transform.localPosition.x + "!!!!!!!" + this.transform.localPosition.y);

        if(target_x - 0.5f < this.transform.localPosition.x && this.transform.localPosition.x < target_x + 0.5f)
        {
            if (target_y - 0.5f < this.transform.localPosition.y && this.transform.localPosition.y < target_y + 0.5f)
            {
                UnityEngine.Debug.Log("DONEDONE");
                this.transform.localPosition = new Vector3(target_x, target_y, target_z);
                finish = true;
            }
        }

    }
}
