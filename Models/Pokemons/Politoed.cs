using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Politoed Species to store common natural stats of all Politoeds
	#region SpeciesPolitoed
	public class SpeciesPolitoed : PokemonSpecies
	{
#nullable enable
		private static SpeciesPolitoed? _instance = null;
#nullable restore
        public static SpeciesPolitoed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPolitoed();
                }
                return _instance;
            }
        }

		#region SpeciesPolitoed Constructor
		public SpeciesPolitoed() : base(
			186,
			"Politoed",
			1.1,
			33.9,
			90, // HPs
			75, 75, // Attack & Defense
			90, 100, // Special Attack & Defense
			70		
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
				"Double-Slap",
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Waterfall",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Bounce",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Politoed PokemonInstance Class
	#region Politoed
	public class PolitoedInstance : PokemonInstance
	{
		#region Politoed Constructors
		/// <summary>
		/// Politoed Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PolitoedInstance(string nickname, int level)
		: base(
				SpeciesPolitoed.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Politoed Builder only waiting for a Level
		/// </summary>
		public PolitoedInstance(int level)
		: base(
				SpeciesPolitoed.Instance, // PokemonInstance Species
				"Politoed", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Politoed Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PolitoedInstance() : base(
			SpeciesPolitoed.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}