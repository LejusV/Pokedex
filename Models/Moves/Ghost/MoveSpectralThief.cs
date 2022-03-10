using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Steals the target's stat increases, then inflicts damage.
	public class MoveSpectralThief : Move
	{
		public MoveSpectralThief() : base(
			"Spectral-Thief",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}