using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour {
    //Vector3 mouse;
    Ray ray;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //射线方法获得物体位置
        //获得鼠标三维位置
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            Vector3 Point = hit.point;
            print(Point);
            print(hit.transform.name);
        }
        //mouse = Input.mousePosition;//获取鼠标位置
        //this.transform.LookAt(mouse);//使当前物体注视某个位置，可以是某物体的transform或者任意vector3
        //print(mouse);
	}
}
