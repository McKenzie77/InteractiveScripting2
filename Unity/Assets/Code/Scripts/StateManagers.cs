using UnityEngine;
using Assets.Code.States;					// Accessed BeginState.cs (BeginState.cs declared namespace)

public class StateManagers : MonoBehaviour 	
{
	private BeginState activeState;			// Constructor protype
	
	
	void Start () 
	{
		activeState = new BeginState();		// Instantiates BeginState() and assigns it to activeState
		Debug.Log("This object is of type: " + activeState);
	}
	
	void Update () {
	
	}
}
