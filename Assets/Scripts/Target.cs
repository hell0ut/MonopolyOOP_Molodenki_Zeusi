using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    private NavMeshAgent[] navAgents;
    private Transform targetMarker = null;
    Camera mycam;
    float minFov      = 15f;
    float maxFov      = 90f;
    float sensitivity = 15f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;





    private void Start()
    {
        mycam = GetComponent<Camera>();
        navAgents = FindObjectsOfType(typeof(NavMeshAgent)) as NavMeshAgent[];
       
    }

    private void UpdateTargets(Vector3 targetPosition)
    {
        foreach (NavMeshAgent agent in navAgents)
        {
            agent.destination = targetPosition;
        }
    }

    private void Update()
    {
        if ( Input.GetMouseButton(1))
        {
            
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
        Cursor.SetCursor(null,hotSpot, cursorMode);

        var fov = Camera.main.fieldOfView;
        fov += -Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
        if (GetInput())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                Vector3 targetPosition = hitInfo.point;
                UpdateTargets(targetPosition);
                targetMarker.position = targetPosition;
            }
        }
    }

    private bool GetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }
        return false;
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(targetMarker.position, targetMarker.position + Vector3.up * 5, Color.red);
    }
}