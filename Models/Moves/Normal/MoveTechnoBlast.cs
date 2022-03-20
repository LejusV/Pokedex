using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the user is holding a appropriate plate or drive, the damage inflicted will match it.
	public class MoveTechnoBlast : Move
	{
#nullable enable
		private static MoveTechnoBlast? _instance = null;
#nullable restore
        public static MoveTechnoBlast Instance => _instance ?? (_instance = new MoveTechnoBlast());

		public MoveTechnoBlast() : base(
			"Techno-Blast",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}