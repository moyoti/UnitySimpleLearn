using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class study : MonoBehaviour {
    public Vector3 v;
    Vector3 p;
    public Transform t;
    public GameObject mc;
    public GameObject s;
    // Use this for initialization
    void Start () {
        p = this.transform.position;
        mc = GameObject.Find("Main Camera");
        s = GameObject.Find("Sphere");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 velocity = Vector3.up;
        Vector3 tp = this.transform.TransformPoint(new Vector3(2,3,4));
        mc.transform.position = Vector3.SmoothDamp(mc.transform.position,tp,ref velocity,0.1f);
        s.transform.position = Vector3.Reflect(new Vector3(2, 3, 4), v);
        //print(Vector3.Slerp(p, new Vector3(2, 3, 4), Time.time));
        //Time.captureFramerate = 60;
        //print(Time.captureFramerate);

    }
    public void Awake()
    {
        v = new Vector3(1, 2, 3);
        print("Scale:由缩放的相同的组件对应乘以这个矢量的每个组件。"+Vector3.Scale(new Vector3(1,2,3),new Vector3(2,3,4)));
        print("normalized:返回向量的长度为1（只读）" + Vector3.Scale(new Vector3(1, 2, 3), new Vector3(2, 3, 4)).normalized);
        print("sqrMagnitude:返回这个向量的长度的平方（只读）。"+Vector3.Scale(new Vector3(1, 2, 3), new Vector3(2, 3, 4)).sqrMagnitude);
        print("magnitude:返回向量的长度（只读）。"+Vector3.Scale(new Vector3(1, 2, 3), new Vector3(2, 3, 4)).magnitude);
        print("Normalize:使向量的长度为1。(返回结果与 new Vector3(1,2,3).normalized相同)" +Vector3.Normalize(new Vector3(1,2,3)));
        print("ToString:"+v.ToString());
        print("zero:写Vector3(0, 0, 0)的简码。" + Vector3.zero);
        print("one:写Vector3(1, 1, 1)的简码。" + Vector3.one);
        print("forword:写Vector3(0, 0, 1)的简码,也就是向z轴。" + Vector3.forward);
        print("up:写Vector3(0, 1, 0)的简码,也就是向y轴。" + Vector3.up);
        print("right:写Vector3(1, 0, 0)的简码,也就是向x轴。"+Vector3.right);
        print("Lerp:两个向量之间的线性插值。" + Vector3.Lerp(v,new Vector3(2,3,4),0.1f));//static function Lerp (from : Vector3, to : Vector3, t : float) : Vector3。t是夹在 [0...1]之间，当t = 0时，返回from，当t = 1时，返回to。当t = 0.5 返回from和to的平均数。
        print("Slerp:???????update中测试");
        print("OrthoNormalize:??????????(创建自己的坐标系)");
        print("MoveTowards:当前的地点移向目标。this.transform.position = Vector3.MoveTowards(p, new Vector3(2, 3, 4), Time.time);" + Vector3.MoveTowards(v,new Vector3(2,3,4),0.1f));
        print("RotateTowards:当前的向量转向目标。this.transform.position = Vector3.RotateTowards(p, new Vector3(2, 3, 4), Time.time,Time.time);");
        print("SmoothDamp:随着时间的推移，逐渐改变一个向量朝向预期的目标。(见上）");
        print("Scale:两个矢量组件对应相乘。"+Vector3.Scale(new Vector3(2,3,4),v));
        print("Cross:两个向量的交叉乘积。返回lhs x rhs" + Vector3.Cross(v,new Vector3(2,3,4)));
        print("Reflect:沿着法线反射向量。" + Vector3.Reflect(new Vector3(2,3,4),v));
        print("Dot:两个向量的点乘积。" + Vector3.Dot(new Vector3(2,3,4),v));
        print("Angle:由from和to两者返回一个角度。(第一个from第二个to)" + Vector3.Angle(v,new Vector3(2,3,4)));
        print("Project:投影一个向量到另一个向量。" + Vector3.Project(v,new Vector3(2,3,4)));//返回被投影到onNormal的vector。如果onNormal接近0，返回 0 vector。
        print("Distance:返回a和b之间的距离。" + Vector3.Distance(v, new Vector3(2, 3, 4)));
        print("ClampMagnitude:返回向量的长度，最大不超过maxLength所指示的长度。" + Vector3.ClampMagnitude(v,1));
        print("Max:返回一个由两个向量的最大组件组成的向量。" + Vector3.Max(v,new Vector3(2,3,4)));
        print("Min:返回一个由两个向量的最小组件组成的向量。" + Vector3.Min(v, new Vector3(2, 3, 4)));
        print("支持+,-,*,/,==,!=运算,例:"+(v+new Vector3(2,3,4))+(v==new Vector3(2,3,4)));
    }
}
