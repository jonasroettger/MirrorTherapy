using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Controller : MonoBehaviour {

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;
    public Vector3 Position;
    public Vector3 mirroredPosition;
    public GameObject mirroredCube;

    // Use this for initialization
    void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        
    }
	
	// Update is called once per frame
	void Update () {
		Position = trackedObj.transform.position;
        mirroredPosition = -Position;
        mirroredCube.transform.position = mirroredPosition;
	}
}
