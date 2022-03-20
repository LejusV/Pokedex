using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Negates held items for five turns.
	public class MoveMagicRoom : Move
	{
#nullable enable
		private static MoveMagicRoom? _instance = null;
#nullable restore
        public static MoveMagicRoom Instance => _instance ?? (_instance = new MoveMagicRoom());

		public MoveMagicRoom() : base(
			"Magic-Room",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}