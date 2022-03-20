using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User pays half its max HP to max out its Attack.
	public class MoveBellyDrum : Move
	{
#nullable enable
		private static MoveBellyDrum? _instance = null;
#nullable restore
        public static MoveBellyDrum Instance => _instance ?? (_instance = new MoveBellyDrum());

		public MoveBellyDrum() : base(
			"Belly-Drum",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}