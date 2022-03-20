using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveIceShard : Move
	{
#nullable enable
		private static MoveIceShard? _instance = null;
#nullable restore
        public static MoveIceShard Instance => _instance ?? (_instance = new MoveIceShard());

		public MoveIceShard() : base(
			"Ice-Shard",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}