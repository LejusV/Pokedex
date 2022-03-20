using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Takes one turn to charge, then raises the user's Special Attack, Special Defense, and Speed by two stages.
	public class MoveGeomancy : Move
	{
#nullable enable
		private static MoveGeomancy? _instance = null;
#nullable restore
        public static MoveGeomancy Instance => _instance ?? (_instance = new MoveGeomancy());

		public MoveGeomancy() : base(
			"Geomancy",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}