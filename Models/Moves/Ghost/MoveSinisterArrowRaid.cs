using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSinisterArrowRaid : Move
	{
		public MoveSinisterArrowRaid() : base(
			"Sinister-Arrow-Raid",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 180,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}