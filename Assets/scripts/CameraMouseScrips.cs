using UnityEngine;
using System.Collections;

public class CameraMouseScrips : MonoBehaviour
{

    private Transform _XForm_Camera;
    private Transform _XForm_Parent;

    private Vector3 _LocalRotation;
    private float _CameraDistance = 5f;

    public float MouseSensitivity = 4f;
    public float ScrollSensitvity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;

    public bool CameraDisabled = false;


    // Use this for initialization
    void Start()
    {
        _XForm_Camera = this.transform;
        _XForm_Parent = this.transform.parent;
        _LocalRotation.y = 15f;
    }


    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            CameraDisabled = false;
        }
        else
        {
            CameraDisabled = true;
        }


        if (!CameraDisabled)
        {
            //Rotation of the Camera based on Mouse Coordinates
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                _LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
                _LocalRotation.y += Input.GetAxis("Mouse Y") * -MouseSensitivity;

                //Clamp the y Rotation to horizon and not flipping over at the top
              //  if (_LocalRotation.y < 0f)
               //     _LocalRotation.y = 3.0f;                        //TEST<
               // else if (_LocalRotation.y > 90f)
               //     _LocalRotation.y = 90f;
            }
        }
            //Zooming Input from our Mouse Scroll Wheel
            if (Input.GetAxis("Mouse ScrollWheel") != 0f)
            {
                float ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitvity;

                ScrollAmount *= (this._CameraDistance * 0.3f);

                this._CameraDistance += ScrollAmount * -1f;

                this._CameraDistance = Mathf.Clamp(this._CameraDistance, 1.5f, 30f);
            }
        

        //Actual Camera Rig Transformations
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0.0f );
        _XForm_Parent.rotation = Quaternion.Lerp(this._XForm_Parent.rotation , QT, Time.deltaTime * OrbitDampening);

        if (_XForm_Camera.localPosition.z != _CameraDistance * -1f)
        {
            _XForm_Camera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(_XForm_Camera.localPosition.z, _CameraDistance * -1f, Time.deltaTime * ScrollDampening));
        }
    }
}
