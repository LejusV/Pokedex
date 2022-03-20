using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lairon Species to store common natural stats of all Lairons
	#region LaironSpecies
	public class LaironSpecies : PokemonSpecies
	{
#nullable enable
		private static LaironSpecies? _instance = null;
#nullable restore
        public static LaironSpecies Instance => _instance ?? (_instance = new LaironSpecies());

		#region LaironSpecies Constructor
		public LaironSpecies() : base(
			305,
			"Lairon",
			Steel.Instance, Rock.Instance,
			0.9,
			120.0,
			new PokemonStats(
				60, // HPs
				90, 140, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				40 // Speed
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Metal-Burst",
				"Magnet-Rise",
				"Rock-Polish",
				"Earth-Power",
				"Shadow-Claw",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Autotomize",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}