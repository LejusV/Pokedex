using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MovePrismaticLaser : Move
	{
#nullable enable
		private static MovePrismaticLaser? _instance = null;
#nullable restore
        public static MovePrismaticLaser Instance => _instance ?? (_instance = new MovePrismaticLaser());

		public MovePrismaticLaser() : base(
			"Prismatic-Laser",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 160,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}