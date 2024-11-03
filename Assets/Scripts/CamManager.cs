using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Material RenderMaterial;

    [SerializeField] GameObject Monitor;
    [SerializeField] private Transform NearView;
    [SerializeField] private Transform FarView;
    [SerializeField] private Transform[] Placements;
    [SerializeField] private float InputWait = 5.0f;
    private float InputTimer = 0;
    private int PlaceIndex = 0;
    
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {

        RenderMaterial.SetFloat("_Contribution", 1.0f - Mathf.Clamp(Vector3.Distance(Monitor.transform.position, NearView.position), 0.0f, 1.0f));

        Graphics.Blit(source, destination, RenderMaterial);
    }
    void Start()
    {
        if (Placements.Length == 0) Placements = new Transform[] {transform};
        transform.position = Placements[PlaceIndex].position;
        transform.rotation = Placements[PlaceIndex].rotation;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)) NextPlace();

        if (Input.anyKey) InputTimer = InputWait;
        else InputTimer -= Time.deltaTime;

        if (InputTimer > 0)
        {
            Monitor.transform.position = Vector3.Lerp(Monitor.transform.position, NearView.position, 0.05f);
            Monitor.transform.rotation = Quaternion.Lerp(Monitor.transform.rotation, NearView.rotation, 0.05f);
        }
        else
        {
            Monitor.transform.position = Vector3.Lerp(Monitor.transform.position, FarView.position, 0.001f);
            Monitor.transform.rotation = Quaternion.Lerp(Monitor.transform.rotation, FarView.rotation, 0.001f);
        }

    }

    void NextPlace()
    {

        PlaceIndex++;

        if (PlaceIndex >= Placements.Length) PlaceIndex = 0;

        transform.position = Placements[PlaceIndex].position;
        transform.rotation = Placements[PlaceIndex].rotation;
    }

}
