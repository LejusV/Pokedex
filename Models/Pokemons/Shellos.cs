using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shellos Species to store common natural stats of all Shelloss
	#region SpeciesShellos
	public class SpeciesShellos : PokemonSpecies
	{
#nullable enable
		private static SpeciesShellos? _instance = null;
#nullable restore
        public static SpeciesShellos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShellos();
                }
                return _instance;
            }
        }

		#region SpeciesShellos Constructor
		public SpeciesShellos() : base(
			"Shellos",
			0.3,
			6.3,
			76, // HPs
			48, 48, // Attack & Defense
			57, 62, // Special Attack & Defense
			34		
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
				"Body-Slam",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"String-Shot",
				"Fissure",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Sludge",
				"Amnesia",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Ancient-Power",
				"Whirlpool",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Memento",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Muddy-Water",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Trump-Card",
				"Earth-Power",
				"Mud-Bomb",
				"Captivate",
				"Round",
				"Clear-Smog",
				"Scald",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Shellos PokemonInstance Class
	#region Shellos
	public class ShellosInstance : PokemonInstance
	{
		#region Shellos Constructors
		/// <summary>
		/// Shellos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShellosInstance(string nickname, int level)
		: base(
				422,
				SpeciesShellos.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellos Builder only waiting for a Level
		/// </summary>
		public ShellosInstance(int level)
		: base(
				422,
				SpeciesShellos.Instance, // PokemonInstance Species
				"Shellos", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellos Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Shellos() : base(
			422,
			SpeciesShellos.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}