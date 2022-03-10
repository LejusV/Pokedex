using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mightyena Species to store common natural stats of all Mightyenas
	#region SpeciesMightyena
	public class SpeciesMightyena : PokemonSpecies
	{
#nullable enable
		private static SpeciesMightyena? _instance = null;
#nullable restore
        public static SpeciesMightyena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMightyena();
                }
                return _instance;
            }
        }

		#region SpeciesMightyena Constructor
		public SpeciesMightyena() : base(
			"Mightyena",
			1.0,
			37.0,
			70, // HPs
			90, 70, // Attack & Defense
			60, 60, // Special Attack & Defense
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Yawn",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Captivate",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Mightyena PokemonInstance Class
	#region Mightyena
	public class MightyenaInstance : PokemonInstance
	{
		#region Mightyena Constructors
		/// <summary>
		/// Mightyena Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MightyenaInstance(string nickname, int level)
		: base(
				262,
				SpeciesMightyena.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mightyena Builder only waiting for a Level
		/// </summary>
		public MightyenaInstance(int level)
		: base(
				262,
				SpeciesMightyena.Instance, // PokemonInstance Species
				"Mightyena", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mightyena Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Mightyena() : base(
			262,
			SpeciesMightyena.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}