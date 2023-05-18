using System;

namespace Game.Objects {

	public class Brick : GameObject
	{
		public enum eType
        {
			B1,
			B2,
			B3
        }
		eType type;

		public Brick(Vector pos, Vector size, eType type)
		{
			Shape = new Rectangle();

		}
	} 
}

