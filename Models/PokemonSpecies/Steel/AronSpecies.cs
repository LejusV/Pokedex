using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Aron Species to store common natural stats of all Arons
	#region AronSpecies
	public class AronSpecies : PokemonSpecies
	{
#nullable enable
		private static AronSpecies? _instance = null;
#nullable restore
        public static AronSpecies Instance => _instance ?? (_instance = new AronSpecies());

		#region AronSpecies Constructor
		public AronSpecies() : base(
			304,
			"Aron",
			Steel.Instance, Rock.Instance,
			0.4,
			60.0,
			new PokemonStats(
				50, // HPs
				70, 100, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				30 // Speed
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
				"Stomp",
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
				"Screech",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Reversal",
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
				"Smelling-Salts",
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
				"Dragon-Rush",
				"Earth-Power",
				"Shadow-Claw",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
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