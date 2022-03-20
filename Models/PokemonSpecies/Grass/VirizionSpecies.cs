using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Virizion Species to store common natural stats of all Virizions
	#region VirizionSpecies
	public class VirizionSpecies : PokemonSpecies
	{
#nullable enable
		private static VirizionSpecies? _instance = null;
#nullable restore
        public static VirizionSpecies Instance => _instance ?? (_instance = new VirizionSpecies());

		#region VirizionSpecies Constructor
		public VirizionSpecies() : base(
			640,
			"Virizion",
			Grass.Instance, Fighting.Instance,
			2.0,
			200.0,
			new PokemonStats(
				91, // HPs
				90, 72, // Attack & Defense
				90, 129, // Spacial Attack & Defense
				108 // Speed
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
				"Double-Kick",
				"Take-Down",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Aerial-Ace",
				"Block",
				"Bounce",
				"Magical-Leaf",
				"Calm-Mind",
				"Leaf-Blade",
				"Close-Combat",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Work-Up",
				"Sacred-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}