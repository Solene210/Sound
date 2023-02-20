using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

enum DoorState
{
    CLOSED,
    OPENING,
    OPENED,
    CLOSING
}
public class Door : MonoBehaviour, IUsable
{
    [SerializeField]
    private float _animDuration;
    [SerializeField]
    private GameObject _body;
    [SerializeField]
    private AudioMixer _audioMixer;
    [SerializeField]
    private float _closedDoorCutoff;
    [SerializeField]
    private float _openDoorCutoff;

    private void Awake()
    {
        _state = DoorState.CLOSED;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnStateUpadate();
        _audioMixer.SetFloat("LowpassCutoff", _closedDoorCutoff);
    }

    private void OnStateUpadate()
    {
        switch (_state)
        {
            case DoorState.OPENING:

                break;
            case DoorState.CLOSING:

                break;
            default:
                break;
        }
    }

    public void Use()
    {
        switch (_state)
        {
            case DoorState.CLOSED:
                _state = DoorState.OPENING;
                break;
            case DoorState.OPENED:
                _state = DoorState.OPENING;
                break;
            default:
                break;
        }
    }

    private float _animTime;
    private DoorState _state;
}
