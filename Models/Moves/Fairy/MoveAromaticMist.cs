using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises a selected ally's Special Defense by one stage.
	public class MoveAromaticMist : Move
	{
#nullable enable
		private static MoveAromaticMist? _instance = null;
#nullable restore
        public static MoveAromaticMist Instance => _instance ?? (_instance = new MoveAromaticMist());

		public MoveAromaticMist() : base(
			"Aromatic-Mist",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}