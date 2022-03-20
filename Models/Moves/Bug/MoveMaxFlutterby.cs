using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxFlutterby : Move
	{
#nullable enable
		private static MoveMaxFlutterby? _instance = null;
#nullable restore
        public static MoveMaxFlutterby Instance => _instance ?? (_instance = new MoveMaxFlutterby());

		public MoveMaxFlutterby() : base(
			"Max-Flutterby",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}