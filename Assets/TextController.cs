using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI 부품을 사용하기 위해서 중요!

public class TextController : MonoBehaviour
{
    GameObject distance;
    GameObject locate;

    private GameDirector axis;

    void Start()
    {
        this.distance = GameObject.Find("Distance");
        this.locate = GameObject.Find("Location");
    }

    void Update()
    {
        //외부 스크립트 변수 참조
        axis = GetComponent<GameDirector>();

        float length = axis.x * axis.x + axis.y * axis.y;
        //float length = x * x + y * y;
        length = Mathf.Sqrt(length);
        //Debug.Log(length);

        string location = " ";

        //위치 문장으로
        //벡터로 대체?
        if (axis.x > 0)
        {
            if (axis.y > 0)
            {
                if (axis.z > 0)
                {
                    location = "Upper Right";
                }
                else if (axis.z < 0)
                {
                    location = "Lower Right";
                }
                else //z == 0
                {
                    location = "Right";
                }
            }
            else if (axis.y < 0)
            {
                if (axis.z > 0)
                {
                    location = "Upper Right Back";
                }
                else if (axis.z < 0)
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
                if (axis.z > 0)
                {
                    location = "Upper Right";
                }
                else if (axis.z < 0)
                {
                    location = "Lower Right";
                }
                else //z == 0
                {
                    location = "Right";
                }
            }
        }
        else if (axis.x < 0)
        {
            if (axis.y > 0)
            {
                if (axis.z > 0)
                {
                    location = "Upper Left";
                }
                else if (axis.z < 0)
                {
                    location = "Lower Left";
                }
                else //z == 0
                {
                    location = "Left";
                }
            }
            else if (axis.y < 0)
            {
                if (axis.z > 0)
                {
                    location = "Upper Left Back";
                }
                else if (axis.z < 0)
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
                if (axis.z > 0)
                {
                    location = "Upper Left";
                }
                else if (axis.z < 0)
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
            if (axis.y > 0)
            {
                if (axis.z > 0)
                {
                    location = "Upper Front";
                }
                else if (axis.z < 0)
                {
                    location = "Lower Front";
                }
                else //z == 0
                {
                    location = "Front";
                }
            }
            else if (axis.y < 0)
            {
                if (axis.z > 0)
                {
                    location = "Upper Back";
                }
                else if (axis.z < 0)
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
                if (axis.z > 0)
                {
                    location = "Upper";
                }
                else if (axis.z < 0)
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