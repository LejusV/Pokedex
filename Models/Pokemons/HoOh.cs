using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ho-Oh Species to store common natural stats of all Ho-Ohs
	#region SpeciesHo-Oh
	public class SpeciesHoOh : PokemonSpecies
	{
#nullable enable
		private static SpeciesHoOh? _instance = null;
#nullable restore
        public static SpeciesHoOh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHoOh();
                }
                return _instance;
            }
        }

		#region SpeciesHo-Oh Constructor
		public SpeciesHoOh() : base(
			"Ho-Oh",
			3.8,
			199.0,
			106, // HPs
			130, 90, // Attack & Defense
			110, 154, // Special Attack & Defense
			90		
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
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
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
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
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
				"Sacred-Fire",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Hyper-Voice",
				"Weather-Ball",
				"Air-Cutter",
				"Overheat",
				"Signal-Beam",
				"Extrasensory",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Punishment",
				"Brave-Bird",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Iron-Head",
				"Charge-Beam",
				"Ominous-Wind",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Ho-Oh PokemonInstance Class
	#region Ho-Oh
	public class HoOhInstance : PokemonInstance
	{
		#region Ho-Oh Constructors
		/// <summary>
		/// Ho-Oh Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HoOhInstance(string nickname, int level)
		: base(
				250,
				SpeciesHoOh.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ho-Oh Builder only waiting for a Level
		/// </summary>
		public HoOhInstance(int level)
		: base(
				250,
				SpeciesHoOh.Instance, // PokemonInstance Species
				"Ho-Oh", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ho-Oh Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HoOh() : base(
			250,
			SpeciesHoOh.Instance, // PokemonInstance Species
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}