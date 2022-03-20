using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Arceus Species to store common natural stats of all Arceuss
	#region ArceusSpecies
	public class ArceusSpecies : PokemonSpecies
	{
#nullable enable
		private static ArceusSpecies? _instance = null;
#nullable restore
        public static ArceusSpecies Instance => _instance ?? (_instance = new ArceusSpecies());

		#region ArceusSpecies Constructor
		public ArceusSpecies() : base(
			493,
			"Arceus",
			Normal.Instance,
			3.2,
			320.0,
			new PokemonStats(
				120, // HPs
				120, 120, // Attack & Defense
				120, 120, // Spacial Attack & Defense
				120 // Speed
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
				"Fly",
				"Headbutt",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Extreme-Speed",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Heat-Wave",
				"Hail",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Overheat",
				"Rock-Tomb",
				"Silver-Wind",
				"Cosmic-Power",
				"Signal-Beam",
				"Bullet-Seed",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"Payback",
				"Punishment",
				"Last-Resort",
				"Poison-Jab",
				"Dark-Pulse",
				"Aqua-Tail",
				"X-Scissor",
				"Dragon-Pulse",
				"Focus-Blast",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Rock-Climb",
				"Defog",
				"Trick-Room",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Judgment",
				"Charge-Beam",
				"Ominous-Wind",
				"Hone-Claws",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Quash",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}