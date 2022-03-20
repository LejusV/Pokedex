using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Destroys Reflect and Light Screen.
	public class MoveBrickBreak : Move
	{
#nullable enable
		private static MoveBrickBreak? _instance = null;
#nullable restore
        public static MoveBrickBreak Instance => _instance ?? (_instance = new MoveBrickBreak());

		public MoveBrickBreak() : base(
			"Brick-Break",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}