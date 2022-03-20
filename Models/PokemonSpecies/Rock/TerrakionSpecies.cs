using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Terrakion Species to store common natural stats of all Terrakions
	#region TerrakionSpecies
	public class TerrakionSpecies : PokemonSpecies
	{
#nullable enable
		private static TerrakionSpecies? _instance = null;
#nullable restore
        public static TerrakionSpecies Instance => _instance ?? (_instance = new TerrakionSpecies());

		#region TerrakionSpecies Constructor
		public TerrakionSpecies() : base(
			639,
			"Terrakion",
			Rock.Instance, Fighting.Instance,
			1.9,
			260.0,
			new PokemonStats(
				91, // HPs
				129, 90, // Attack & Defense
				72, 90, // Spacial Attack & Defense
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
				"Earthquake",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Reflect",
				"Rest",
				"Rock-Slide",
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
				"Hidden-Power",
				"Psych-Up",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Calm-Mind",
				"Close-Combat",
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Sacred-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}