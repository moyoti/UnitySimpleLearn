using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eulerAngles : MonoBehaviour {
    float y = 5.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        y += Input.GetAxis("Horizontal");//获取方向输入

        transform.eulerAngles = new Vector3(10, y, 0);//旋转作为欧拉角度,这里相当于改变y轴向量指向使其旋转

    }
}
