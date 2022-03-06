using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers all targets' Attack and Special Attack by one stage.  Makes the user switch out.
	public class MovePartingShot : Move
	{
		public MovePartingShot() : base(
			"Parting-Shot",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}