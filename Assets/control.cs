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
    //Translate移?控制函?
    void MoveControlByTranslateGetAxis()
    {
        float horizontal = Input.GetAxis("Horizontal"); //A D 左右
        float vertical = Input.GetAxis("Vertical"); //W S 上 下

        transform.Translate(Vector3.forward * vertical * m_speed * Time.deltaTime);//W S 上 下
        transform.Translate(Vector3.right * horizontal * m_speed * Time.deltaTime);//A D 左右
    }
}
