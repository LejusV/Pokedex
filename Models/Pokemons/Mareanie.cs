using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mareanie Species to store common natural stats of all Mareanies
	#region SpeciesMareanie
	public class SpeciesMareanie : PokemonSpecies
	{
#nullable enable
		private static SpeciesMareanie? _instance = null;
#nullable restore
        public static SpeciesMareanie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMareanie();
                }
                return _instance;
            }
        }

		#region SpeciesMareanie Constructor
		public SpeciesMareanie() : base(
			747,
			"Mareanie",
			0.4,
			8.0,
			50, // HPs
			53, 62, // Attack & Defense
			43, 52, // Special Attack & Defense
			45		
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
				"Poison-Sting",
				"Pin-Missile",
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Peck",
				"Toxic",
				"Double-Team",
				"Recover",
				"Haze",
				"Spike-Cannon",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Wide-Guard",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion

	//Mareanie PokemonInstance Class
	#region Mareanie
	public class MareanieInstance : PokemonInstance
	{
		#region Mareanie Constructors
		/// <summary>
		/// Mareanie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MareanieInstance(string nickname, int level)
		: base(
				SpeciesMareanie.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareanie Builder only waiting for a Level
		/// </summary>
		public MareanieInstance(int level)
		: base(
				SpeciesMareanie.Instance, // PokemonInstance Species
				"Mareanie", level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareanie Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MareanieInstance() : base(
			SpeciesMareanie.Instance, // PokemonInstance Species
			Poison.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}