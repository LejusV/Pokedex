using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveExpandingForce : Move
	{
#nullable enable
		private static MoveExpandingForce? _instance = null;
#nullable restore
        public static MoveExpandingForce Instance => _instance ?? (_instance = new MoveExpandingForce());

		public MoveExpandingForce() : base(
			"Expanding-Force",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}