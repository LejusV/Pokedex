using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Seeds the target after inflicting damage.
	public class MoveJawLock : Move
	{
		public MoveJawLock() : base(
			"Jaw-Lock",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}