using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Deals splash damage to Pokémon next to the target.
	public class MoveFlameBurst : Move
	{
#nullable enable
		private static MoveFlameBurst? _instance = null;
#nullable restore
        public static MoveFlameBurst Instance => _instance ?? (_instance = new MoveFlameBurst());

		public MoveFlameBurst() : base(
			"Flame-Burst",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}