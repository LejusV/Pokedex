using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Confuses the target.
	public class MoveConfuseRay : Move
	{
#nullable enable
		private static MoveConfuseRay? _instance = null;
#nullable restore
        public static MoveConfuseRay Instance => _instance ?? (_instance = new MoveConfuseRay());

		public MoveConfuseRay() : base(
			"Confuse-Ray",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}