using System;
using NUnit.Framework;
namespace MyGame
{
	
	/// <summary>
	/// Madelin
	/// Pass Task 10. 2 part 2
	/// Unit testing for the gamestate if can be switch 
	/// </summary>
	[TestFixture ()]
	public class UnitTest1
	{
		[Test ()]
		public void TestingSwitchState ()
		{
			GameController.SwitchState (GameState.Deploying);
			Assert.AreEqual (GameController.CurrentState, GameState.Deploying);
		}
	}
}
