using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cannot be disrupted by abilities.
	public class MoveMenacingMoonrazeMaelstrom : Move
	{
#nullable enable
		private static MoveMenacingMoonrazeMaelstrom? _instance = null;
#nullable restore
        public static MoveMenacingMoonrazeMaelstrom Instance => _instance ?? (_instance = new MoveMenacingMoonrazeMaelstrom());

		public MoveMenacingMoonrazeMaelstrom() : base(
			"Menacing-Moonraze-Maelstrom",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 200,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}