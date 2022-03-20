using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Copies the target's last used move.
	public class MoveMimic : Move
	{
#nullable enable
		private static MoveMimic? _instance = null;
#nullable restore
        public static MoveMimic Instance => _instance ?? (_instance = new MoveMimic());

		public MoveMimic() : base(
			"Mimic",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}