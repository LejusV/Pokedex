using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Arceus Species to store common natural stats of all Arceuss
	#region SpeciesArceus
	public class SpeciesArceus : PokemonSpecies
	{
#nullable enable
		private static SpeciesArceus? _instance = null;
#nullable restore
        public static SpeciesArceus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArceus();
                }
                return _instance;
            }
        }

		#region SpeciesArceus Constructor
		public SpeciesArceus() : base(
			"Arceus",
			3.2,
			320.0,
			120, // HPs
			120, 120, // Attack & Defense
			120, 120, // Special Attack & Defense
			120		
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

	//Arceus PokemonInstance Class
	#region Arceus
	public class ArceusInstance : PokemonInstance
	{
		#region Arceus Constructors
		/// <summary>
		/// Arceus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArceusInstance(string nickname, int level)
		: base(
				493,
				SpeciesArceus.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arceus Builder only waiting for a Level
		/// </summary>
		public ArceusInstance(int level)
		: base(
				493,
				SpeciesArceus.Instance, // PokemonInstance Species
				"Arceus", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arceus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Arceus() : base(
			493,
			SpeciesArceus.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}