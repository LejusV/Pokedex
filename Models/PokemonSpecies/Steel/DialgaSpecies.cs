using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dialga Species to store common natural stats of all Dialgas
	#region DialgaSpecies
	public class DialgaSpecies : PokemonSpecies
	{
#nullable enable
		private static DialgaSpecies? _instance = null;
#nullable restore
        public static DialgaSpecies Instance => _instance ?? (_instance = new DialgaSpecies());

		#region DialgaSpecies Constructor
		public DialgaSpecies() : base(
			483,
			"Dialga",
			Steel.Instance, Dragon.Instance,
			5.4,
			683.0,
			new PokemonStats(
				100, // HPs
				120, 120, // Attack & Defense
				150, 100, // Spacial Attack & Defense
				90 // Speed
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
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Flash",
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
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Metal-Burst",
				"Heal-Block",
				"Magnet-Rise",
				"Aura-Sphere",
				"Dragon-Pulse",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Trick-Room",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Roar-Of-Time",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}