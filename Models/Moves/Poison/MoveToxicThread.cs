using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Poisons the target and lowers its Speed by one stage.
	public class MoveToxicThread : Move
	{
#nullable enable
		private static MoveToxicThread? _instance = null;
#nullable restore
        public static MoveToxicThread Instance => _instance ?? (_instance = new MoveToxicThread());

		public MoveToxicThread() : base(
			"Toxic-Thread",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}