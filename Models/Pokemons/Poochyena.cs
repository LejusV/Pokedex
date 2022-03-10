using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Poochyena Species to store common natural stats of all Poochyenas
	#region SpeciesPoochyena
	public class SpeciesPoochyena : PokemonSpecies
	{
#nullable enable
		private static SpeciesPoochyena? _instance = null;
#nullable restore
        public static SpeciesPoochyena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPoochyena();
                }
                return _instance;
            }
        }

		#region SpeciesPoochyena Constructor
		public SpeciesPoochyena() : base(
			"Poochyena",
			0.5,
			13.6,
			35, // HPs
			55, 35, // Attack & Defense
			30, 30, // Special Attack & Defense
			35		
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
				"Leer",
				"Bite",
				"Roar",
				"Counter",
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
				"Poison-Fang",
				"Astonish",
				"Odor-Sleuth",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Embargo",
				"Me-First",
				"Sucker-Punch",
				"Dark-Pulse",
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

	//Poochyena PokemonInstance Class
	#region Poochyena
	public class PoochyenaInstance : PokemonInstance
	{
		#region Poochyena Constructors
		/// <summary>
		/// Poochyena Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PoochyenaInstance(string nickname, int level)
		: base(
				261,
				SpeciesPoochyena.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poochyena Builder only waiting for a Level
		/// </summary>
		public PoochyenaInstance(int level)
		: base(
				261,
				SpeciesPoochyena.Instance, // PokemonInstance Species
				"Poochyena", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poochyena Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Poochyena() : base(
			261,
			SpeciesPoochyena.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}