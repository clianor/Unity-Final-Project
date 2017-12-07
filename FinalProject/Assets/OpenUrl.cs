using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour {

    public void onClick_1()
    {
        Application.OpenURL("https://cms1.ks.ac.kr/kor/Main.do");
    }
    public void onClick_2()
    {
        Application.OpenURL("https://cms2.ks.ac.kr/nuri/sub.do?mCode=MN0045");
    }
    public void onClick_3()
    {
        Application.OpenURL("https://apps.ks.ac.kr/ptl/sso/login.jsp");
    }
    public void RealTimeClick()
    {
        Application.OpenURL("http://www.1min.kr");
    }
}
