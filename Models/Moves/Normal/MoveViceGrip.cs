using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveViceGrip : Move
	{
#nullable enable
		private static MoveViceGrip? _instance = null;
#nullable restore
        public static MoveViceGrip Instance => _instance ?? (_instance = new MoveViceGrip());

		public MoveViceGrip() : base(
			"Vice-Grip",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 55,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}