using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour {
    float y = 5.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        y += Input.GetAxis("Horizontal");
        transform.eulerAngles = new Vector3(10, y, 0);
        print("旋转作为欧拉角度。eulerAngles:x" + this.transform.eulerAngles.x + "eulerAngles:y" + this.transform.eulerAngles.y + "eulerAngles:z" + this.transform.eulerAngles.z);
        print("旋转作为欧拉角度，相对于父级的变换旋转角度。localEulerAngles:" + this.transform.localEulerAngles);
    }
    private void Awake()
    {
        print("在世界空间坐标transform的位置。positioin:" + this.transform.position);
        print("相对于父级的变换的位置。localPosition" + this.transform.localPosition);
        print("旋转作为欧拉角度。eulerAngles:x" + this.transform.eulerAngles.x+"eulerAngles:y"+this.transform.eulerAngles.y+"eulerAngles:z"+this.transform.eulerAngles.z);
        print("旋转作为欧拉角度，相对于父级的变换旋转角度。localEulerAngles:" + this.transform.localEulerAngles);
        print("在世界空间坐标变换的红色轴。也就是x轴。right:" + this.transform.right + ",在世界空间坐标变换的绿色轴。也就是z轴。forword:" + this.transform.forward + ",在世界空间坐标变换的绿色轴。也就是y轴。up:" + this.transform.up);
        print("在世界空间坐标物体变换的旋转角度作为Quaternion储存。rotation:" + this.transform.rotation);
        print("物体变换的旋转角度相对于父级的物体变换的旋转角度。localRotation:" + this.transform.localRotation);
        print("相对于父级物体变换的缩放。localScale:" + this.transform.localScale);
        print("物体变换的父级。parent:" + this.transform.parent);
        print("矩阵变换的点从世界坐标转为自身坐标（只读）。worldToLocalMatrix:" + this.transform.worldToLocalMatrix);//???????????
        print("矩阵变换的点从自身坐标转为世界坐标（只读）。localToWorldMatrix:" + this.transform.localToWorldMatrix);//???????????
        print("返回层次最高的变换。root:" + this.transform.root);
        print("变换的子物体数量。childCount:" + this.transform.childCount);
        print("物体的全局缩放（只读）。lossyScale:" + this.transform.lossyScale);
    }
}
