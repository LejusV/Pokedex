using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Special Attack by one stage.
	public class MoveMysticalFire : Move
	{
#nullable enable
		private static MoveMysticalFire? _instance = null;
#nullable restore
        public static MoveMysticalFire Instance => _instance ?? (_instance = new MoveMysticalFire());

		public MoveMysticalFire() : base(
			"Mystical-Fire",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}