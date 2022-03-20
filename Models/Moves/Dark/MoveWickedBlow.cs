using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveWickedBlow : Move
	{
#nullable enable
		private static MoveWickedBlow? _instance = null;
#nullable restore
        public static MoveWickedBlow Instance => _instance ?? (_instance = new MoveWickedBlow());

		public MoveWickedBlow() : base(
			"Wicked-Blow",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}