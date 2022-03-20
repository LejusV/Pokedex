using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by two stages.
	public class MoveIronDefense : Move
	{
#nullable enable
		private static MoveIronDefense? _instance = null;
#nullable restore
        public static MoveIronDefense Instance => _instance ?? (_instance = new MoveIronDefense());

		public MoveIronDefense() : base(
			"Iron-Defense",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}