using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to make the target flinch.
	public class MoveBoneClub : Move
	{
#nullable enable
		private static MoveBoneClub? _instance = null;
#nullable restore
        public static MoveBoneClub Instance => _instance ?? (_instance = new MoveBoneClub());

		public MoveBoneClub() : base(
			"Bone-Club",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}