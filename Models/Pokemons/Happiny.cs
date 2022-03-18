using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Happiny Species to store common natural stats of all Happinys
	#region SpeciesHappiny
	public class SpeciesHappiny : PokemonSpecies
	{
#nullable enable
		private static SpeciesHappiny? _instance = null;
#nullable restore
        public static SpeciesHappiny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHappiny();
                }
                return _instance;
            }
        }

		#region SpeciesHappiny Constructor
		public SpeciesHappiny() : base(
			440,
			"Happiny",
			0.6,
			24.4,
			100, // HPs
			5, 5, // Attack & Defense
			15, 65, // Special Attack & Defense
			30		
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
				"Pound",
				"Headbutt",
				"Flamethrower",
				"Counter",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Metronome",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Recycle",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Last-Resort",
				"Drain-Punch",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Happiny PokemonInstance Class
	#region Happiny
	public class HappinyInstance : PokemonInstance
	{
		#region Happiny Constructors
		/// <summary>
		/// Happiny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HappinyInstance(string nickname, int level)
		: base(
				SpeciesHappiny.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Happiny Builder only waiting for a Level
		/// </summary>
		public HappinyInstance(int level)
		: base(
				SpeciesHappiny.Instance, // PokemonInstance Species
				"Happiny", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Happiny Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HappinyInstance() : base(
			SpeciesHappiny.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}