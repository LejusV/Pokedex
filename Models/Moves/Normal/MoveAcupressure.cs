using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises one of a friendly Pokémon's stats at random by two stages.
	public class MoveAcupressure : Move
	{
#nullable enable
		private static MoveAcupressure? _instance = null;
#nullable restore
        public static MoveAcupressure Instance => _instance ?? (_instance = new MoveAcupressure());

		public MoveAcupressure() : base(
			"Acupressure",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}