using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Halves all Fire-type damage.
	public class MoveWaterSport : Move
	{
		public MoveWaterSport() : base(
			"Water-Sport",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}