using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User takes 1/3 the damage inflicted in recoil.  Has a 10% chance to burn the target.
	public class MoveFlareBlitz : Move
	{
		public MoveFlareBlitz() : base(
			"Flare-Blitz",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}