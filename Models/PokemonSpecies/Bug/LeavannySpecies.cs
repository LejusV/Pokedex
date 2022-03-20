using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Leavanny Species to store common natural stats of all Leavannys
	#region LeavannySpecies
	public class LeavannySpecies : PokemonSpecies
	{
#nullable enable
		private static LeavannySpecies? _instance = null;
#nullable restore
        public static LeavannySpecies Instance => _instance ?? (_instance = new LeavannySpecies());

		#region LeavannySpecies Constructor
		public LeavannySpecies() : base(
			542,
			"Leavanny",
			Bug.Instance, Grass.Instance,
			1.2,
			20.5,
			new PokemonStats(
				75, // HPs
				103, 80, // Attack & Defense
				70, 80, // Spacial Attack & Defense
				92 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Hyper-Beam",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Calm-Mind",
				"Leaf-Blade",
				"Payback",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Leaf-Storm",
				"Grass-Knot",
				"Bug-Bite",
				"Hone-Claws",
				"Entrainment",
				"Round",
				"Retaliate",
				"Struggle-Bug",
				"Electroweb",
				"Fell-Stinger",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}