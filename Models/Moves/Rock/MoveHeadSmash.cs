using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User receives 1/2 the damage inflicted in recoil.
	public class MoveHeadSmash : Move
	{
		public MoveHeadSmash() : base(
			"Head-Smash",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			0.8, 0 // Acc & Priority
		) {}
	}
}