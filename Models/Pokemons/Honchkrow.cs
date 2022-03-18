using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Honchkrow Species to store common natural stats of all Honchkrows
	#region SpeciesHonchkrow
	public class SpeciesHonchkrow : PokemonSpecies
	{
#nullable enable
		private static SpeciesHonchkrow? _instance = null;
#nullable restore
        public static SpeciesHonchkrow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHonchkrow();
                }
                return _instance;
            }
        }

		#region SpeciesHonchkrow Constructor
		public SpeciesHonchkrow() : base(
			430,
			"Honchkrow",
			0.9,
			27.3,
			100, // HPs
			125, 52, // Attack & Defense
			105, 52, // Special Attack & Defense
			71		
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
				"Fly",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Haze",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Steel-Wing",
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
				"Facade",
				"Taunt",
				"Superpower",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Nasty-Plot",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Honchkrow PokemonInstance Class
	#region Honchkrow
	public class HonchkrowInstance : PokemonInstance
	{
		#region Honchkrow Constructors
		/// <summary>
		/// Honchkrow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HonchkrowInstance(string nickname, int level)
		: base(
				SpeciesHonchkrow.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honchkrow Builder only waiting for a Level
		/// </summary>
		public HonchkrowInstance(int level)
		: base(
				SpeciesHonchkrow.Instance, // PokemonInstance Species
				"Honchkrow", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honchkrow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HonchkrowInstance() : base(
			SpeciesHonchkrow.Instance, // PokemonInstance Species
			Dark.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}