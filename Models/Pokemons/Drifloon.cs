using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drifloon Species to store common natural stats of all Drifloons
	#region SpeciesDrifloon
	public class SpeciesDrifloon : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrifloon? _instance = null;
#nullable restore
        public static SpeciesDrifloon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrifloon();
                }
                return _instance;
            }
        }

		#region SpeciesDrifloon Constructor
		public SpeciesDrifloon() : base(
			425,
			"Drifloon",
			0.4,
			1.2,
			90, // HPs
			50, 34, // Attack & Defense
			60, 44, // Special Attack & Defense
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
				"Cut",
				"Gust",
				"Bind",
				"Body-Slam",
				"Disable",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Minimize",
				"Haze",
				"Focus-Energy",
				"Swift",
				"Constrict",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Baton-Pass",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Secret-Power",
				"Astonish",
				"Weather-Ball",
				"Air-Cutter",
				"Silver-Wind",
				"Calm-Mind",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Tailwind",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Defog",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Round",
				"Clear-Smog",
				"Hex",
				"Acrobatics",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Drifloon PokemonInstance Class
	#region Drifloon
	public class DrifloonInstance : PokemonInstance
	{
		#region Drifloon Constructors
		/// <summary>
		/// Drifloon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrifloonInstance(string nickname, int level)
		: base(
				SpeciesDrifloon.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifloon Builder only waiting for a Level
		/// </summary>
		public DrifloonInstance(int level)
		: base(
				SpeciesDrifloon.Instance, // PokemonInstance Species
				"Drifloon", level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifloon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DrifloonInstance() : base(
			SpeciesDrifloon.Instance, // PokemonInstance Species
			Ghost.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}