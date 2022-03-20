using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMegaPunch : Move
	{
#nullable enable
		private static MoveMegaPunch? _instance = null;
#nullable restore
        public static MoveMegaPunch Instance => _instance ?? (_instance = new MoveMegaPunch());

		public MoveMegaPunch() : base(
			"Mega-Punch",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}