using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States				// Allows other scripts to access this file
{
	public class WonState	: IStateBase	// Creates object & attaches IStateBase.cs to object
	{
		private StateManager manager;
		
		public WonState(StateManager managerRef)					// Constructor so object can be used
		{
			manager = managerRef;
			Debug.Log("Constructing WonState");			
		}
		
		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space)) 
			{	Application.LoadLevel("BeginningScene");  // Added per Brian... last statement to execute in block
				manager.SwitchState(new PlayState (manager));			
			}
		}
		public void ShowIt()
		{

		}
		
	}
}


