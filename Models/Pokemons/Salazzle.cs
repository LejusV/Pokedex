using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Salazzle Species to store common natural stats of all Salazzles
	#region SpeciesSalazzle
	public class SpeciesSalazzle : PokemonSpecies
	{
#nullable enable
		private static SpeciesSalazzle? _instance = null;
#nullable restore
        public static SpeciesSalazzle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSalazzle();
                }
                return _instance;
            }
        }

		#region SpeciesSalazzle Constructor
		public SpeciesSalazzle() : base(
			"Salazzle",
			1.2,
			22.2,
			68, // HPs
			64, 60, // Attack & Defense
			111, 60, // Special Attack & Defense
			117		
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
				"Pound",
				"Double-Slap",
				"Disable",
				"Ember",
				"Flamethrower",
				"Dragon-Rage",
				"Toxic",
				"Double-Team",
				"Smog",
				"Fire-Blast",
				"Poison-Gas",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Sludge-Bomb",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Sweet-Scent",
				"Hidden-Power",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Overheat",
				"Dragon-Claw",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Shadow-Claw",
				"Captivate",
				"Venoshock",
				"Flame-Burst",
				"Sludge-Wave",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Dragon-Tail",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Salazzle PokemonInstance Class
	#region Salazzle
	public class SalazzleInstance : PokemonInstance
	{
		#region Salazzle Constructors
		/// <summary>
		/// Salazzle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SalazzleInstance(string nickname, int level)
		: base(
				758,
				SpeciesSalazzle.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salazzle Builder only waiting for a Level
		/// </summary>
		public SalazzleInstance(int level)
		: base(
				758,
				SpeciesSalazzle.Instance, // PokemonInstance Species
				"Salazzle", level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salazzle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Salazzle() : base(
			758,
			SpeciesSalazzle.Instance, // PokemonInstance Species
			Poison.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}