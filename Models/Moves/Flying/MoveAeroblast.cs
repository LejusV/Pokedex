using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveAeroblast : Move
	{
#nullable enable
		private static MoveAeroblast? _instance = null;
#nullable restore
        public static MoveAeroblast Instance => _instance ?? (_instance = new MoveAeroblast());

		public MoveAeroblast() : base(
			"Aeroblast",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}