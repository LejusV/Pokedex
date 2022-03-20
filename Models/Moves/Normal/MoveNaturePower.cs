using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Uses a move which depends upon the terrain.
	public class MoveNaturePower : Move
	{
#nullable enable
		private static MoveNaturePower? _instance = null;
#nullable restore
        public static MoveNaturePower Instance => _instance ?? (_instance = new MoveNaturePower());

		public MoveNaturePower() : base(
			"Nature-Power",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}