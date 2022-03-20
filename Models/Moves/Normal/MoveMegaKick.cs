using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMegaKick : Move
	{
#nullable enable
		private static MoveMegaKick? _instance = null;
#nullable restore
        public static MoveMegaKick Instance => _instance ?? (_instance = new MoveMegaKick());

		public MoveMegaKick() : base(
			"Mega-Kick",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}