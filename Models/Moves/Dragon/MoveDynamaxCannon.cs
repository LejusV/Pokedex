using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Sets Light Screen on the user's side of the field after inflicting damage.
	public class MoveDynamaxCannon : Move
	{
#nullable enable
		private static MoveDynamaxCannon? _instance = null;
#nullable restore
        public static MoveDynamaxCannon Instance => _instance ?? (_instance = new MoveDynamaxCannon());

		public MoveDynamaxCannon() : base(
			"Dynamax-Cannon",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}