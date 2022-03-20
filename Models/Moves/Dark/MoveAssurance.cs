using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is doubled if the target has already received damage this turn.
	public class MoveAssurance : Move
	{
#nullable enable
		private static MoveAssurance? _instance = null;
#nullable restore
        public static MoveAssurance Instance => _instance ?? (_instance = new MoveAssurance());

		public MoveAssurance() : base(
			"Assurance",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}