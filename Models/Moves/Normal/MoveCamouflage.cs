using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User's type changes to match the terrain.
	public class MoveCamouflage : Move
	{
#nullable enable
		private static MoveCamouflage? _instance = null;
#nullable restore
        public static MoveCamouflage Instance => _instance ?? (_instance = new MoveCamouflage());

		public MoveCamouflage() : base(
			"Camouflage",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}