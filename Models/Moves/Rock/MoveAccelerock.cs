using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAccelerock : Move
	{
#nullable enable
		private static MoveAccelerock? _instance = null;
#nullable restore
        public static MoveAccelerock Instance => _instance ?? (_instance = new MoveAccelerock());

		public MoveAccelerock() : base(
			"Accelerock",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}