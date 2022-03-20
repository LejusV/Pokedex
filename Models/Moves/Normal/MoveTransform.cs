using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User becomes a copy of the target until it leaves battle.
	public class MoveTransform : Move
	{
#nullable enable
		private static MoveTransform? _instance = null;
#nullable restore
        public static MoveTransform Instance => _instance ?? (_instance = new MoveTransform());

		public MoveTransform() : base(
			"Transform",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}