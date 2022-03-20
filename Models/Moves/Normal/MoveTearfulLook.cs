using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack and Special Attack by one stage.
	public class MoveTearfulLook : Move
	{
#nullable enable
		private static MoveTearfulLook? _instance = null;
#nullable restore
        public static MoveTearfulLook Instance => _instance ?? (_instance = new MoveTearfulLook());

		public MoveTearfulLook() : base(
			"Tearful-Look",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}