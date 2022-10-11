using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI 부품을 사용하기 위해서 중요!


public class ArrowController : MonoBehaviour
{
   // public float x = 0;
    //public float y = 0;
    
    private GameDirector axis2;

    float rotSpeed = 0;  // 회전속도
    float targetangle;

    void Start()
    {
    }

    float GetAngle(Vector2 end, Vector2 start)
    {
        //Debug.Log(end);
        Vector2 v2 = end - start;
        return Mathf.Atan2(v2.y, v2.x) * Mathf.Rad2Deg;
    }

    void Update()
    {
        //외부 스크립트 변수 참조
        axis2 = GetComponent<GameDirector>();

        // 마우스가 눌리면 회전 속도를 설정한다
        /*if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 1;
        }*/
       // Debug.Log(transform.eulerAngles.z - 360);
        //Debug.Log(-90 + Vector2.Angle(new Vector2(x, y), new Vector2(0, 0)));
        //Debug.Log(-90 + GetAngle(new Vector2(axis.x, axis.y), new Vector2(0, 0)));
        Debug.Log(axis2.x);
        Debug.Log(axis2.y);

        //현재 각도 : transform.eulerAngles.z - 360
        //목표 각도 : -90 + GetAngle(new Vector2(axis.x, axis.y), new Vector2(0, 0))
        if (transform.eulerAngles.z != GetAngle(new Vector2(axis2.y, axis2.x), new Vector2(0, 0)))
        {
            //Debug.Log("rotate");
            if (axis2.x > 0)
                transform.rotation = Quaternion.Euler(0, 0, -GetAngle(new Vector2(axis2.y, axis2.x), new Vector2(0, 0)));
            else
                transform.rotation = Quaternion.Euler(0, 0, -GetAngle(new Vector2(axis2.y, axis2.x), new Vector2(0, 0)));

            /*
            this.rotSpeed = 1;
            while (transform.eulerAngles.z - 360 != -90 + GetAngle(new Vector2(axis.x, -axis.y), new Vector2(0, 0)))
            {
                transform.Rotate(0, 0, this.rotSpeed);
                this.rotSpeed *= 0.96f;
            }
            this.rotSpeed = 0;
            */

            /*
            targetangle = -90 + GetAngle(new Vector2(axis.x, axis.y), new Vector2(0, 0));
            if (transform.eulerAngles.z - 360 != targetangle)
            {
                this.rotSpeed = 1;
            }

            transform.Rotate(0, 0, this.rotSpeed);

            this.rotSpeed *= 0.96f;
            */
        }

        // 회전 속도만큼 룰렛을 회전 시킨다
        //transform.Rotate(x, y, 0);
        //Debug.Log("a");
        //transform.Rotate(0, 0, this.rotSpeed);

        //https://killu.tistory.com/12
        // transform.rotation = Quaternion.Euler(0, 0, -90 + Vector2.Angle(new Vector2(x, y), new Vector2(0, 0)));
        //transform.Translate(new Vector3(x, y, z));

        // 룰렛을 감속시킨다 (추가)
        //Debug.Log("b");
        //this.rotSpeed *= 0.96f;
    }
}