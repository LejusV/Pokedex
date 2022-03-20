using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Latios Species to store common natural stats of all Latioss
	#region LatiosSpecies
	public class LatiosSpecies : PokemonSpecies
	{
#nullable enable
		private static LatiosSpecies? _instance = null;
#nullable restore
        public static LatiosSpecies Instance => _instance ?? (_instance = new LatiosSpecies());

		#region LatiosSpecies Constructor
		public LatiosSpecies() : base(
			381,
			"Latios",
			Dragon.Instance, Psychic.Instance,
			2.0,
			60.0,
			new PokemonStats(
				80, // HPs
				90, 80, // Attack & Defense
				130, 110, // Spacial Attack & Defense
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
				"Memento",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Luster-Purge",
				"Aerial-Ace",
				"Dragon-Claw",
				"Calm-Mind",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Psycho-Shift",
				"Heal-Block",
				"Last-Resort",
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
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Stored-Power",
				"Heal-Pulse",
				"Retaliate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}