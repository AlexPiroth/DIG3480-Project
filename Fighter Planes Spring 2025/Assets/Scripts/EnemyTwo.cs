using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    private float screenTop = 5f;
    private float screenBottom = -3f;
    private float screenLeft = -8f;
    private float screenRight = 8f;
    private float rotationVal;
    public float currAngle;

    private Quaternion defaultAngle = Quaternion.Euler(180, 0, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currAngle = Quaternion.Angle(transform.rotation, defaultAngle);
        if (transform.rotation.z < 0)
        {
            currAngle = 360 - currAngle;
        }
        if ((transform.position.x <= screenLeft && currAngle < 180) || (transform.position.x >= screenRight && currAngle > 180))
        {
            rotationVal = (360f - currAngle);
            transform.rotation = Quaternion.Euler(180, 0, rotationVal);
        }
        if ((transform.position.y <= screenBottom && (currAngle < 90 || currAngle > 270)) || (transform.position.y >= screenTop && currAngle > 90 && currAngle < 270))
        {
            if (currAngle < 180)
            {
                rotationVal = (180f - currAngle);
            }
            else
            {
                rotationVal = (180f - currAngle);
            }
            if (rotationVal < 0)
            {
                rotationVal += 360f;
            }
            transform.rotation = Quaternion.Euler(180, 0, rotationVal);
        }
    }
}
