using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Scatters Spikes, hurting opposing Pokémon that switch in.
	public class MoveSpikes : Move
	{
#nullable enable
		private static MoveSpikes? _instance = null;
#nullable restore
        public static MoveSpikes Instance => _instance ?? (_instance = new MoveSpikes());

		public MoveSpikes() : base(
			"Spikes",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}