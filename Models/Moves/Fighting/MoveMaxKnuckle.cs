using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxKnuckle : Move
	{
#nullable enable
		private static MoveMaxKnuckle? _instance = null;
#nullable restore
        public static MoveMaxKnuckle Instance => _instance ?? (_instance = new MoveMaxKnuckle());

		public MoveMaxKnuckle() : base(
			"Max-Knuckle",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}