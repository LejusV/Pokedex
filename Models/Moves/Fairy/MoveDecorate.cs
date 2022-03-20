using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveDecorate : Move
	{
#nullable enable
		private static MoveDecorate? _instance = null;
#nullable restore
        public static MoveDecorate Instance => _instance ?? (_instance = new MoveDecorate());

		public MoveDecorate() : base(
			"Decorate",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}