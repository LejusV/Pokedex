using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from leaving battle.
	public class MoveMeanLook : Move
	{
#nullable enable
		private static MoveMeanLook? _instance = null;
#nullable restore
        public static MoveMeanLook Instance => _instance ?? (_instance = new MoveMeanLook());

		public MoveMeanLook() : base(
			"Mean-Look",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}