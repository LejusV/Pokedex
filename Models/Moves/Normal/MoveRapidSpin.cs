using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Frees the user from binding moves, removes Leech Seed, and blows away Spikes.
	public class MoveRapidSpin : Move
	{
#nullable enable
		private static MoveRapidSpin? _instance = null;
#nullable restore
        public static MoveRapidSpin Instance => _instance ?? (_instance = new MoveRapidSpin());

		public MoveRapidSpin() : base(
			"Rapid-Spin",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}