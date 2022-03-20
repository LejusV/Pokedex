using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to confuse the target.
	public class MoveDynamicPunch : Move
	{
#nullable enable
		private static MoveDynamicPunch? _instance = null;
#nullable restore
        public static MoveDynamicPunch Instance => _instance ?? (_instance = new MoveDynamicPunch());

		public MoveDynamicPunch() : base(
			"Dynamic-Punch",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			50, 0 // Acc & Priority
		) {}
	}
}