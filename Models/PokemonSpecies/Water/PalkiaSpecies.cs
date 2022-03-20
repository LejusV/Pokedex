using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Palkia Species to store common natural stats of all Palkias
	#region PalkiaSpecies
	public class PalkiaSpecies : PokemonSpecies
	{
#nullable enable
		private static PalkiaSpecies? _instance = null;
#nullable restore
        public static PalkiaSpecies Instance => _instance ?? (_instance = new PalkiaSpecies());

		#region PalkiaSpecies Constructor
		public PalkiaSpecies() : base(
			484,
			"Palkia",
			Water.Instance, Dragon.Instance,
			4.2,
			336.0,
			new PokemonStats(
				90, // HPs
				120, 100, // Attack & Defense
				150, 120, // Spacial Attack & Defense
				100 // Speed
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
				"Hydro-Pump",
				"Surf",
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
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Bulk-Up",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Heal-Block",
				"Aqua-Ring",
				"Aura-Sphere",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Power-Gem",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Trick-Room",
				"Draco-Meteor",
				"Stone-Edge",
				"Spacial-Rend",
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