using UnityEngine;
using System.Collections;

////////////////////////////////////////////////////////////////////////
//
// Adapted and modified version of Volumetric Script from Wwise 301
//
////////////////////////////////////////////////////////////////////////

[RequireComponent(typeof(Collider))]
public class EventPositionConfiner : MonoBehaviour
{
    [Header("Event to clamp to AkAudioListener")]
    public AK.Wwise.Event Event;

    [Header("Settings")]
    public float UpdateInterval = 0.05f;
    public bool isAkRoomAware = false;

    //private BoxCollider trigger;
    private MeshCollider trigger;
    private Transform targetTransform;
    private GameObject eventEmitter;
    private Coroutine positionClamperRoutine;


    private void Awake()
    {
        //trigger = GetComponent<BoxCollider>();
        trigger = GetComponent<MeshCollider>();
        trigger.isTrigger = true;

        CreateEventEmitter();
    }

    private void CreateEventEmitter()
    {
        eventEmitter = new GameObject("Clamped Emitter");
        eventEmitter.transform.parent = transform;

        Rigidbody Rigidboody = eventEmitter.AddComponent<Rigidbody>();
        Rigidboody.isKinematic = true;

        SphereCollider SPC = eventEmitter.AddComponent<SphereCollider>();
        SPC.isTrigger = true;

        eventEmitter.AddComponent<AkGameObj>();

        if (isAkRoomAware)
        {
            eventEmitter.AddComponent<AkRoomAwareObject>();
        }
    }

    private void Start()
    {
        FindListener();
        InitializeEmitter();
        StartClampingPosition();
    }


    private void FindListener()
    {
        var listenerGameObject = FindAnyObjectByType<AkAudioListener>();

        if (listenerGameObject != null)
        {
            targetTransform = listenerGameObject.transform;
        }
        else
        {
            Debug.LogError(this + ": No GameObject with 'AkAudioListener' Component found — Bailing.");
            enabled = false;
        }
    }

    private void InitializeEmitter()
    {
        Event.Post(eventEmitter);
    }

    private void StartClampingPosition()
    {
        positionClamperRoutine = StartCoroutine(ClampEmitterPosition());
    }

    private IEnumerator ClampEmitterPosition()
    {
        while (true)
        {
            Vector3 closestPoint = trigger.ClosestPoint(targetTransform.position);
            eventEmitter.transform.position = closestPoint;

            yield return new WaitForSecondsRealtime(UpdateInterval);
        }
    }

    public void OnDisable()
    {
        Event.Stop(eventEmitter);

        if (positionClamperRoutine != null)
        {
            StopCoroutine(positionClamperRoutine);
        }
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        if (eventEmitter != null)
        {
            Gizmos.DrawSphere(eventEmitter.transform.position, 0.2f);
        }
    }
#endif

}