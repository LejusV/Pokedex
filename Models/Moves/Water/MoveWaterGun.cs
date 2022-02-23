using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveWaterGun : Move
	{
		public MoveWaterGun() : base(
			"Water-Gun",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 40,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}