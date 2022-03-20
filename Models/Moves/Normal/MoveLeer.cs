using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by one stage.
	public class MoveLeer : Move
	{
#nullable enable
		private static MoveLeer? _instance = null;
#nullable restore
        public static MoveLeer Instance => _instance ?? (_instance = new MoveLeer());

		public MoveLeer() : base(
			"Leer",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}