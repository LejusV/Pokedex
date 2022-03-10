using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lugia Species to store common natural stats of all Lugias
	#region SpeciesLugia
	public class SpeciesLugia : PokemonSpecies
	{
#nullable enable
		private static SpeciesLugia? _instance = null;
#nullable restore
        public static SpeciesLugia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLugia();
                }
                return _instance;
            }
        }

		#region SpeciesLugia Constructor
		public SpeciesLugia() : base(
			"Lugia",
			5.2,
			216.0,
			106, // HPs
			90, 130, // Attack & Defense
			90, 154, // Special Attack & Defense
			110		
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
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
				"Psychic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Aeroblast",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Trick",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Weather-Ball",
				"Air-Cutter",
				"Signal-Beam",
				"Extrasensory",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"Punishment",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Defog",
				"Iron-Head",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Lugia PokemonInstance Class
	#region Lugia
	public class LugiaInstance : PokemonInstance
	{
		#region Lugia Constructors
		/// <summary>
		/// Lugia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LugiaInstance(string nickname, int level)
		: base(
				249,
				SpeciesLugia.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lugia Builder only waiting for a Level
		/// </summary>
		public LugiaInstance(int level)
		: base(
				249,
				SpeciesLugia.Instance, // PokemonInstance Species
				"Lugia", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lugia Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lugia() : base(
			249,
			SpeciesLugia.Instance, // PokemonInstance Species
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}