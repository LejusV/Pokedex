using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Latias Species to store common natural stats of all Latiass
	#region LatiasSpecies
	public class LatiasSpecies : PokemonSpecies
	{
#nullable enable
		private static LatiasSpecies? _instance = null;
#nullable restore
        public static LatiasSpecies Instance => _instance ?? (_instance = new LatiasSpecies());

		#region LatiasSpecies Constructor
		public LatiasSpecies() : base(
			380,
			"Latias",
			Dragon.Instance, Psychic.Instance,
			1.4,
			40.0,
			new PokemonStats(
				80, // HPs
				80, 90, // Attack & Defense
				110, 130, // Spacial Attack & Defense
				110 // Speed
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
				"Fly",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Charm",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mist-Ball",
				"Aerial-Ace",
				"Dragon-Claw",
				"Covet",
				"Water-Sport",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Healing-Wish",
				"Natural-Gift",
				"Tailwind",
				"Psycho-Shift",
				"Last-Resort",
				"Sucker-Punch",
				"Dragon-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Defog",
				"Draco-Meteor",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Guard-Split",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Stored-Power",
				"Heal-Pulse",
				"Reflect-Type",
				"Retaliate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}