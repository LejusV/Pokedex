using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.  Affected by weather.
	public class MoveSynthesis : Move
	{
		public MoveSynthesis() : base(
			"Synthesis",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}