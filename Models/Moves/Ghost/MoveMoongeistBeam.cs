using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cannot be disrupted by abilities.
	public class MoveMoongeistBeam : Move
	{
#nullable enable
		private static MoveMoongeistBeam? _instance = null;
#nullable restore
        public static MoveMoongeistBeam Instance => _instance ?? (_instance = new MoveMoongeistBeam());

		public MoveMoongeistBeam() : base(
			"Moongeist-Beam",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}