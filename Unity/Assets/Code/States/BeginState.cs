using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States				// Allows other scripts to access this file
{
	public class BeginState	: IStateBase	// Creates object & attaches IStateBase.cs to object
	{
		private StateManager manager;
		private float futureTime = 0;
		private int countDown = 0;
		private float screenDuration = 8;
		
		public BeginState(StateManager managerRef)	// Constructor so BeginState object can be used // pg130
		{
			manager = managerRef;
			futureTime = screenDuration + Time.realtimeSinceStartup;
		}
		
		public void StateUpdate()
		{
			float rightNow = Time.realtimeSinceStartup;
			countDown = (int)futureTime - (int)rightNow;

			if (Input.GetKeyUp (KeyCode.Space) || countDown <= 0) 
			{
				Switch();			
			}
		}

		public void ShowIt()
		{
			if (GUI.Button (new Rect (10, 10, 150, 100), "Press to Play")) // 10,10 = position; 150,100 = size  ...new Rect((Screen.width/2)-75, (Screen.height/2)-50
			{
				Switch();
			}

			GUI.Box (new Rect (Screen.width - 60, 10, 50, 25), countDown.ToString ());
		}

		void Switch()
		{
			Application.LoadLevel ("StateScene");
			manager.SwitchState (new PlayState (manager));
		}
	}
}