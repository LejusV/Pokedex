using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cobalion Species to store common natural stats of all Cobalions
	#region CobalionSpecies
	public class CobalionSpecies : PokemonSpecies
	{
#nullable enable
		private static CobalionSpecies? _instance = null;
#nullable restore
        public static CobalionSpecies Instance => _instance ?? (_instance = new CobalionSpecies());

		#region CobalionSpecies Constructor
		public CobalionSpecies() : base(
			638,
			"Cobalion",
			Steel.Instance, Fighting.Instance,
			2.1,
			250.0,
			new PokemonStats(
				91, // HPs
				90, 129, // Attack & Defense
				90, 72, // Spacial Attack & Defense
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
				"Thunder-Wave",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Reflect",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Metal-Claw",
				"Hidden-Power",
				"Psych-Up",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Bounce",
				"Calm-Mind",
				"Metal-Burst",
				"Close-Combat",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Volt-Switch",
				"Work-Up",
				"Sacred-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}