using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Murkrow Species to store common natural stats of all Murkrows
	#region SpeciesMurkrow
	public class SpeciesMurkrow : PokemonSpecies
	{
#nullable enable
		private static SpeciesMurkrow? _instance = null;
#nullable restore
        public static SpeciesMurkrow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMurkrow();
                }
                return _instance;
            }
        }

		#region SpeciesMurkrow Constructor
		public SpeciesMurkrow() : base(
			198,
			"Murkrow",
			0.5,
			2.1,
			60, // HPs
			85, 42, // Attack & Defense
			85, 42, // Special Attack & Defense
			91		
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Double-Edge",
				"Peck",
				"Drill-Peck",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Mirror-Move",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Feather-Dance",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Payback",
				"Assurance",
				"Embargo",
				"Psycho-Shift",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Foul-Play",
				"Round",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Murkrow PokemonInstance Class
	#region Murkrow
	public class MurkrowInstance : PokemonInstance
	{
		#region Murkrow Constructors
		/// <summary>
		/// Murkrow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MurkrowInstance(string nickname, int level)
		: base(
				SpeciesMurkrow.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Murkrow Builder only waiting for a Level
		/// </summary>
		public MurkrowInstance(int level)
		: base(
				SpeciesMurkrow.Instance, // PokemonInstance Species
				"Murkrow", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Murkrow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MurkrowInstance() : base(
			SpeciesMurkrow.Instance, // PokemonInstance Species
			Dark.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}