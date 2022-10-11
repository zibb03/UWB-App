using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI ��ǰ�� ����ϱ� ���ؼ� �߿�!


public class ArrowController : MonoBehaviour
{
   // public float x = 0;
    //public float y = 0;
    
    private GameDirector axis2;

    float rotSpeed = 0;  // ȸ���ӵ�
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
        //�ܺ� ��ũ��Ʈ ���� ����
        axis2 = GetComponent<GameDirector>();

        // ���콺�� ������ ȸ�� �ӵ��� �����Ѵ�
        /*if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 1;
        }*/
       // Debug.Log(transform.eulerAngles.z - 360);
        //Debug.Log(-90 + Vector2.Angle(new Vector2(x, y), new Vector2(0, 0)));
        //Debug.Log(-90 + GetAngle(new Vector2(axis.x, axis.y), new Vector2(0, 0)));
        Debug.Log(axis2.x);
        Debug.Log(axis2.y);

        //���� ���� : transform.eulerAngles.z - 360
        //��ǥ ���� : -90 + GetAngle(new Vector2(axis.x, axis.y), new Vector2(0, 0))
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

        // ȸ�� �ӵ���ŭ �귿�� ȸ�� ��Ų��
        //transform.Rotate(x, y, 0);
        //Debug.Log("a");
        //transform.Rotate(0, 0, this.rotSpeed);

        //https://killu.tistory.com/12
        // transform.rotation = Quaternion.Euler(0, 0, -90 + Vector2.Angle(new Vector2(x, y), new Vector2(0, 0)));
        //transform.Translate(new Vector3(x, y, z));

        // �귿�� ���ӽ�Ų�� (�߰�)
        //Debug.Log("b");
        //this.rotSpeed *= 0.96f;
    }
}