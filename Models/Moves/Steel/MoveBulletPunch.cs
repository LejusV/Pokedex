using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBulletPunch : Move
	{
#nullable enable
		private static MoveBulletPunch? _instance = null;
#nullable restore
        public static MoveBulletPunch Instance => _instance ?? (_instance = new MoveBulletPunch());

		public MoveBulletPunch() : base(
			"Bullet-Punch",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}