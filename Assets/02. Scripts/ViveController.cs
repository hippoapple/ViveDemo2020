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
    public SteamVR_Action_Boolean trackPadClick = SteamVR_Actions.default_Teleport;
    public SteamVR_Action_Boolean trackPadTouch = SteamVR_Actions.default_TrackPadTouch;
    public SteamVR_Action_Vector2 trackPadPosition = SteamVR_Actions.default_TrackPadPosition;


    void Awake()
    {
        trigger = SteamVR_Actions.default_InteractUI;
    }

    // Update is called once per frame
    void Update()
    {
        // 왼손 컨트롤러 트리거 버튼을 릴리스 했을 때 발생
        if(trigger.GetStateDown(leftHand))
        {
            Debug.Log("Clicked Trigger Button");
        }
        
        // 오른손 컨트롤러의 트리거 버튼을 릴리스 했을 때 발생
        if(trigger.GetStateUp(rightHand))
        {
            Debug.Log("Released Trigger Button");
        }

        if(trackPadClick.GetStateDown(any))
        {
            Debug.Log("trackPadClick Click");
        }

        if(trackPadTouch.GetState(any))
        {
            Vector2 pos = trackPadPosition.GetAxis(any);
            Debug.Log($"Touch Pos x={pos.x}/y={pos.y}");
        }

    }
}
