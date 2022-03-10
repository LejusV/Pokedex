using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Salandit Species to store common natural stats of all Salandits
	#region SpeciesSalandit
	public class SpeciesSalandit : PokemonSpecies
	{
#nullable enable
		private static SpeciesSalandit? _instance = null;
#nullable restore
        public static SpeciesSalandit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSalandit();
                }
                return _instance;
            }
        }

		#region SpeciesSalandit Constructor
		public SpeciesSalandit() : base(
			"Salandit",
			0.6,
			4.8,
			48, // HPs
			44, 40, // Attack & Defense
			71, 40, // Special Attack & Defense
			77		
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
				"Double-Slap",
				"Scratch",
				"Sand-Attack",
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
				"Sweet-Scent",
				"Hidden-Power",
				"Fake-Out",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Overheat",
				"Dragon-Claw",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Shadow-Claw",
				"Venoshock",
				"Flame-Burst",
				"Sludge-Wave",
				"Flame-Charge",
				"Round",
				"Belch",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Salandit PokemonInstance Class
	#region Salandit
	public class SalanditInstance : PokemonInstance
	{
		#region Salandit Constructors
		/// <summary>
		/// Salandit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SalanditInstance(string nickname, int level)
		: base(
				757,
				SpeciesSalandit.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salandit Builder only waiting for a Level
		/// </summary>
		public SalanditInstance(int level)
		: base(
				757,
				SpeciesSalandit.Instance, // PokemonInstance Species
				"Salandit", level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salandit Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Salandit() : base(
			757,
			SpeciesSalandit.Instance, // PokemonInstance Species
			Poison.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}