using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMachPunch : Move
	{
#nullable enable
		private static MoveMachPunch? _instance = null;
#nullable restore
        public static MoveMachPunch Instance => _instance ?? (_instance = new MoveMachPunch());

		public MoveMachPunch() : base(
			"Mach-Punch",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}