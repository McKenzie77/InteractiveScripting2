using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States				// Allows other scripts to access this file
{
	public class LostState	: IStateBase	// Creates object & attaches IStateBase.cs to object
	{
		private StateManager manager;
		
		public LostState(StateManager managerRef)					// Constructor so object can be used
		{
			manager = managerRef;
			Debug.Log("Constructing LostState");			
		}
		
		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space)) 
			{
				Application.LoadLevel("BeginningScene");
				manager.SwitchState(new BeginState (manager));			
			}
		}
		public void ShowIt()
		{

		}
		
	}
}

