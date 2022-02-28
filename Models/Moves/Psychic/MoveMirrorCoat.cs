using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts twice the damage the user received from the last special hit it took.
	public class MoveMirrorCoat : Move
	{
		public MoveMirrorCoat() : base(
			"Mirror-Coat",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			100, -5 // Acc & Priority
		) {}
	}
}