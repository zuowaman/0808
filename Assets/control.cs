using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{   
    public int m_speed ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        MoveControlByTranslateGetAxis();
    }
    //Translate��?�����?
    void MoveControlByTranslateGetAxis()
    {
        float horizontal = Input.GetAxis("Horizontal"); //A D ���k
        float vertical = Input.GetAxis("Vertical"); //W S �W �U

        transform.Translate(Vector3.forward * vertical * m_speed * Time.deltaTime);//W S �W �U
        transform.Translate(Vector3.right * horizontal * m_speed * Time.deltaTime);//A D ���k
    }
}
