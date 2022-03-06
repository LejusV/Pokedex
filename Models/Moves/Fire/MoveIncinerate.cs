using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Destroys the target's held berry.
	public class MoveIncinerate : Move
	{
		public MoveIncinerate() : base(
			"Incinerate",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}