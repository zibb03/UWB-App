using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowController2 : MonoBehaviour
{
    GameObject arrow;
    GameObject distance;
    GameObject locate;
    /*    public float x = 10;
        public float y = 20;
        public float z = 30;
    */

    float x = 10;
    float y = 20;
    float z = 30;

    // Start is called before the first frame update
    void Start()
    {
        this.arrow = GameObject.Find("arrow");
        this.distance = GameObject.Find("Distance");
        this.locate = GameObject.Find("Location");
    }

    float GetAngle(Vector2 end, Vector2 start)
    {
        //Debug.Log(end);
        Vector2 v2 = end - start;
        return Mathf.Atan2(v2.y, v2.x) * Mathf.Rad2Deg;
    }

    // Update is called once per frame
    void Update()
    {
        float length = x * x + y * y;
        //float length = x * x + y * y;
        length = Mathf.Sqrt(length);
        //Debug.Log(length);

        string location = " ";

        if (this.arrow.transform.eulerAngles.z != GetAngle(new Vector2(y, x), new Vector2(0, 0)))
        {
            //Debug.Log("rotate");
            if (x > 0)
                this.arrow.transform.rotation = Quaternion.Euler(0, 0, -GetAngle(new Vector2(y, x), new Vector2(0, 0)));
            else
                this.arrow.transform.rotation = Quaternion.Euler(0, 0, -GetAngle(new Vector2(y, x), new Vector2(0, 0)));
        }
        if (x > 0)
        {
            if (y > 0)
            {
                if (z > 0)
                {
                    location = "Upper Right";
                }
                else if (z < 0)
                {
                    location = "Lower Right";
                }
                else //z == 0
                {
                    location = "Right";
                }
            }
            else if (y < 0)
            {
                if (z > 0)
                {
                    location = "Upper Right Back";
                }
                else if (z < 0)
                {
                    location = "Lower Right Back";
                }
                else //z == 0
                {
                    location = "Right Back";
                }
            }
            else //y == 0
            {
                if (z > 0)
                {
                    location = "Upper Right";
                }
                else if (z < 0)
                {
                    location = "Lower Right";
                }
                else //z == 0
                {
                    location = "Right";
                }
            }
        }
        else if (x < 0)
        {
            if (y > 0)
            {
                if (z > 0)
                {
                    location = "Upper Left";
                }
                else if (z < 0)
                {
                    location = "Lower Left";
                }
                else //z == 0
                {
                    location = "Left";
                }
            }
            else if (y < 0)
            {
                if (z > 0)
                {
                    location = "Upper Left Back";
                }
                else if (z < 0)
                {
                    location = "Lower Left Back";
                }
                else //z == 0
                {
                    location = "Left Back";
                }
            }
            else //y == 0
            {
                if (z > 0)
                {
                    location = "Upper Left";
                }
                else if (z < 0)
                {
                    location = "Lower Left";
                }
                else //z == 0
                {
                    location = "Left";
                }
            }
        }
        else //x == 0
        {
            if (y > 0)
            {
                if (z > 0)
                {
                    location = "Upper Front";
                }
                else if (z < 0)
                {
                    location = "Lower Front";
                }
                else //z == 0
                {
                    location = "Front";
                }
            }
            else if (y < 0)
            {
                if (z > 0)
                {
                    location = "Upper Back";
                }
                else if (z < 0)
                {
                    location = "Lower Back";
                }
                else //z == 0
                {
                    location = "Back";
                }
            }
            else //y == 0
            {
                if (z > 0)
                {
                    location = "Upper";
                }
                else if (z < 0)
                {
                    location = "Lower";
                }
                else //z == 0
                {
                    location = "Here";
                }
            }
        }

        if (location == "Here")
            this.distance.GetComponent<Text>().text = " ";
        else
            this.distance.GetComponent<Text>().text = length.ToString("F2") + "m";

        this.locate.GetComponent<Text>().text = location;
    }
}
