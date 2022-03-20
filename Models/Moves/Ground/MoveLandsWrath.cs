using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveLandsWrath : Move
	{
#nullable enable
		private static MoveLandsWrath? _instance = null;
#nullable restore
        public static MoveLandsWrath Instance => _instance ?? (_instance = new MoveLandsWrath());

		public MoveLandsWrath() : base(
			"Lands-Wrath",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}