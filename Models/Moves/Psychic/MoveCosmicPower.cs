using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense and Special Defense by one stage.
	public class MoveCosmicPower : Move
	{
		public MoveCosmicPower() : base(
			"Cosmic-Power",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}