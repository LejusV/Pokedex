using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Uses the target's last used move.
	public class MoveMirrorMove : Move
	{
#nullable enable
		private static MoveMirrorMove? _instance = null;
#nullable restore
        public static MoveMirrorMove Instance => _instance ?? (_instance = new MoveMirrorMove());

		public MoveMirrorMove() : base(
			"Mirror-Move",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}