using NUnit.Framework;
namespace MyGame
{
	[TestFixture()]
	public class TestState
	{
		/// <summary>
		/// This test makes sure if the game state can be added successfully.
		/// </summary>
		[Test ()]
		public void TestStateAdd ()
		{
			GameController.AddNewState (GameState.AlteringSettings);
			Assert.AreEqual (GameController.CurrentState, GameState.AlteringSettings);

			GameController.AddNewState (GameState.EndingGame);
			Assert.AreEqual (GameController.CurrentState, GameState.EndingGame);

			GameController.EndCurrentState ();
			Assert.AreEqual (GameController.CurrentState, GameState.AlteringSettings);
		}
	}
}
