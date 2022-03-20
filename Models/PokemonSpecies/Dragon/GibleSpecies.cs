using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gible Species to store common natural stats of all Gibles
	#region GibleSpecies
	public class GibleSpecies : PokemonSpecies
	{
#nullable enable
		private static GibleSpecies? _instance = null;
#nullable restore
        public static GibleSpecies Instance => _instance ?? (_instance = new GibleSpecies());

		#region GibleSpecies Constructor
		public GibleSpecies() : base(
			443,
			"Gible",
			Dragon.Instance, Ground.Instance,
			0.7,
			20.5,
			new PokemonStats(
				58, // HPs
				70, 45, // Attack & Defense
				40, 45, // Spacial Attack & Defense
				42 // Speed
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
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
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
				"Scary-Face",
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
				"Dragon-Breath",
				"Iron-Tail",
				"Metal-Claw",
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
				"Mud-Shot",
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
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}