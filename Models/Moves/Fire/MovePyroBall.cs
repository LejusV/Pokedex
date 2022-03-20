using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MovePyroBall : Move
	{
#nullable enable
		private static MovePyroBall? _instance = null;
#nullable restore
        public static MovePyroBall Instance => _instance ?? (_instance = new MovePyroBall());

		public MovePyroBall() : base(
			"Pyro-Ball",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}