using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the terrain to Psychic Terrain after inflicting damage.
	public class MoveGenesisSupernova : Move
	{
#nullable enable
		private static MoveGenesisSupernova? _instance = null;
#nullable restore
        public static MoveGenesisSupernova Instance => _instance ?? (_instance = new MoveGenesisSupernova());

		public MoveGenesisSupernova() : base(
			"Genesis-Supernova",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 185,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}