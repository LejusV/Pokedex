using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Whiscash Species to store common natural stats of all Whiscashs
	#region SpeciesWhiscash
	public class SpeciesWhiscash : PokemonSpecies
	{
#nullable enable
		private static SpeciesWhiscash? _instance = null;
#nullable restore
        public static SpeciesWhiscash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWhiscash();
                }
                return _instance;
            }
        }

		#region SpeciesWhiscash Constructor
		public SpeciesWhiscash() : base(
			"Whiscash",
			0.9,
			23.6,
			110, // HPs
			78, 73, // Attack & Defense
			76, 71, // Special Attack & Defense
			60		
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
				"Headbutt",
				"Thrash",
				"Double-Edge",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Tickle",
				"Muddy-Water",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Earth-Power",
				"Giga-Impact",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Stone-Edge",
				"Captivate",
				"Round",
				"Scald",
				"Bulldoze",
				"Belch",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Whiscash PokemonInstance Class
	#region Whiscash
	public class WhiscashInstance : PokemonInstance
	{
		#region Whiscash Constructors
		/// <summary>
		/// Whiscash Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WhiscashInstance(string nickname, int level)
		: base(
				340,
				SpeciesWhiscash.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whiscash Builder only waiting for a Level
		/// </summary>
		public WhiscashInstance(int level)
		: base(
				340,
				SpeciesWhiscash.Instance, // PokemonInstance Species
				"Whiscash", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whiscash Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Whiscash() : base(
			340,
			SpeciesWhiscash.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}