using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts twice the damage the user received from the last special hit it took.
	public class MoveMirrorCoat : Move
	{
#nullable enable
		private static MoveMirrorCoat? _instance = null;
#nullable restore
        public static MoveMirrorCoat Instance => _instance ?? (_instance = new MoveMirrorCoat());

		public MoveMirrorCoat() : base(
			"Mirror-Coat",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			100, -5 // Acc & Priority
		) {}
	}
}