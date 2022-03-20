using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Confuses the target.
	public class MoveSweetKiss : Move
	{
#nullable enable
		private static MoveSweetKiss? _instance = null;
#nullable restore
        public static MoveSweetKiss Instance => _instance ?? (_instance = new MoveSweetKiss());

		public MoveSweetKiss() : base(
			"Sweet-Kiss",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}