using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Causes a one-hit KO.
	public class MoveSheerCold : Move
	{
#nullable enable
		private static MoveSheerCold? _instance = null;
#nullable restore
        public static MoveSheerCold Instance => _instance ?? (_instance = new MoveSheerCold());

		public MoveSheerCold() : base(
			"Sheer-Cold",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			30, 0 // Acc & Priority
		) {}
	}
}