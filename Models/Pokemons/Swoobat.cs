using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swoobat Species to store common natural stats of all Swoobats
	#region SpeciesSwoobat
	public class SpeciesSwoobat : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwoobat? _instance = null;
#nullable restore
        public static SpeciesSwoobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwoobat();
                }
                return _instance;
            }
        }

		#region SpeciesSwoobat Constructor
		public SpeciesSwoobat() : base(
			528,
			"Swoobat",
			0.9,
			10.5,
			67, // HPs
			57, 55, // Attack & Defense
			77, 55, // Special Attack & Defense
			114		
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
				"Fly",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Knock-Off",
				"Endeavor",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Air-Cutter",
				"Odor-Sleuth",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"Gyro-Ball",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Assurance",
				"Embargo",
				"Air-Slash",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Acrobatics",
				"Heart-Stamp",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Swoobat PokemonInstance Class
	#region Swoobat
	public class SwoobatInstance : PokemonInstance
	{
		#region Swoobat Constructors
		/// <summary>
		/// Swoobat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwoobatInstance(string nickname, int level)
		: base(
				SpeciesSwoobat.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swoobat Builder only waiting for a Level
		/// </summary>
		public SwoobatInstance(int level)
		: base(
				SpeciesSwoobat.Instance, // PokemonInstance Species
				"Swoobat", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swoobat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SwoobatInstance() : base(
			SpeciesSwoobat.Instance, // PokemonInstance Species
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}