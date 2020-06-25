using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class ViveController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 컨트롤러 정의
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Input_Sources any;
    
    // 컨트ㅗㄹ러 입력값 정의
    public SteamVR_Action_Boolean trigger;

    void Awake()
    {
        trigger = SteamVR_Actions.default_InteractUI;
    }

    // Update is called once per frame
    void Update()
    {
        if(SteamVR_Actions.default_InteractUI.GetStateDown(leftHand))
        {
            Debug.Log("Clicked Trigger Button");
        }

    }
}
