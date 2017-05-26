using System;
using SwinGameSDK;
using NUnit.Framework;

namespace MyGame
{
	[TestFixture ()]
	public class Test
	{
		//Test mouse and ship misalignment.
		[Test ()]
		public void TestDeployment ()
		{
			int Row = 0;
			int Col = 0;
			Point2D mouse = SwinGame.MousePosition ();

			Row = Convert.ToInt32 (Math.Floor ((mouse.Y - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
			Col = Convert.ToInt32 (Math.Floor ((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

			Assert.IsTrue (-3 == Row);
			Assert.IsTrue (-9 == Col);
		}
	}
}
