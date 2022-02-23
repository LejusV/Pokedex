using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Uses a move which depends upon the terrain.
	public class MoveNaturePower : Move
	{
		public MoveNaturePower() : base(
			"Nature-Power",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}