using UnityEngine;
using Assets.Code.States;					// Accessed BeginState.cs (BeginState.cs declared namespace)
using Assets.Code.Interfaces;

public class StateManager : MonoBehaviour 	
{
	private IStateBase activeState;			// Constructor prototype

	private static StateManager instanceRef;

	void Awake()							// runs before Start() and Update()
	{
		if (instanceRef == null) 
		{
			instanceRef = this;
			DontDestroyOnLoad (gameObject);
		} 
		else 
		{
			DestroyImmediate (gameObject);
		}
	}

	void Start () 
	{
		activeState = new BeginState(this);		// Instantiates BeginState() and assigns it to activeStateDebug.Log("This object is of type: " + activeState);
	}
	
	void Update () 
	{
		if (activeState != null)
			activeState.StateUpdate ();
	}

	void OnGUI()
	{
		if (activeState != null)
			activeState.ShowIt ();
	}

	public void SwitchState(IStateBase newState)
	{
		activeState = newState;
	}
}
