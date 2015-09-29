using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States				// Allows other scripts to access this file
{
	public class PlayState	: IStateBase	// Creates object & attaches IStateBase.cs to object
	{
		private StateManager manager;
		
		public PlayState(StateManager managerRef)					// Constructor so object can be used
		{
			manager = managerRef;
			Debug.Log("Constructing PlayState");			
		}
		
		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space)) 
			{
				manager.SwitchState(new WonState (manager));			
			}

			if (Input.GetKeyUp (KeyCode.Return))
			{
				manager.SwitchState(new LostState (manager));
			}
		}
		public void ShowIt()
		{

		}
		
	}
}