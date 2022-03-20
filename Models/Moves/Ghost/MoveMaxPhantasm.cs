using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxPhantasm : Move
	{
#nullable enable
		private static MoveMaxPhantasm? _instance = null;
#nullable restore
        public static MoveMaxPhantasm Instance => _instance ?? (_instance = new MoveMaxPhantasm());

		public MoveMaxPhantasm() : base(
			"Max-Phantasm",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}