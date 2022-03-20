using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveXScissor : Move
	{
#nullable enable
		private static MoveXScissor? _instance = null;
#nullable restore
        public static MoveXScissor Instance => _instance ?? (_instance = new MoveXScissor());

		public MoveXScissor() : base(
			"X-Scissor",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}