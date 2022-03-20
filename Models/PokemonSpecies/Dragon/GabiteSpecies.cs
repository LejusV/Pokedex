using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gabite Species to store common natural stats of all Gabites
	#region GabiteSpecies
	public class GabiteSpecies : PokemonSpecies
	{
#nullable enable
		private static GabiteSpecies? _instance = null;
#nullable restore
        public static GabiteSpecies Instance => _instance ?? (_instance = new GabiteSpecies());

		#region GabiteSpecies Constructor
		public GabiteSpecies() : base(
			444,
			"Gabite",
			Dragon.Instance, Ground.Instance,
			1.4,
			56.0,
			new PokemonStats(
				68, // HPs
				90, 65, // Attack & Defense
				50, 55, // Spacial Attack & Defense
				82 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Natural-Gift",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Shadow-Claw",
				"Rock-Climb",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dual-Chop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}