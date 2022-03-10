using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drifblim Species to store common natural stats of all Drifblims
	#region SpeciesDrifblim
	public class SpeciesDrifblim : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrifblim? _instance = null;
#nullable restore
        public static SpeciesDrifblim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrifblim();
                }
                return _instance;
            }
        }

		#region SpeciesDrifblim Constructor
		public SpeciesDrifblim() : base(
			"Drifblim",
			1.2,
			15.0,
			150, // HPs
			80, 44, // Attack & Defense
			90, 54, // Special Attack & Defense
			80		
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
				"Fly",
				"Bind",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Minimize",
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
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Secret-Power",
				"Astonish",
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
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Round",
				"Hex",
				"Acrobatics",
				"Phantom-Force",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Drifblim PokemonInstance Class
	#region Drifblim
	public class DrifblimInstance : PokemonInstance
	{
		#region Drifblim Constructors
		/// <summary>
		/// Drifblim Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrifblimInstance(string nickname, int level)
		: base(
				426,
				SpeciesDrifblim.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifblim Builder only waiting for a Level
		/// </summary>
		public DrifblimInstance(int level)
		: base(
				426,
				SpeciesDrifblim.Instance, // PokemonInstance Species
				"Drifblim", level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifblim Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Drifblim() : base(
			426,
			SpeciesDrifblim.Instance, // PokemonInstance Species
			Ghost.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}