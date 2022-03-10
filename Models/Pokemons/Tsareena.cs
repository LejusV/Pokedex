using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tsareena Species to store common natural stats of all Tsareenas
	#region SpeciesTsareena
	public class SpeciesTsareena : PokemonSpecies
	{
#nullable enable
		private static SpeciesTsareena? _instance = null;
#nullable restore
        public static SpeciesTsareena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTsareena();
                }
                return _instance;
            }
        }

		#region SpeciesTsareena Constructor
		public SpeciesTsareena() : base(
			"Tsareena",
			1.2,
			21.4,
			72, // HPs
			120, 98, // Attack & Defense
			50, 98, // Special Attack & Defense
			72		
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
				"Stomp",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"High-Jump-Kick",
				"Splash",
				"Rest",
				"Substitute",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Teeter-Dance",
				"Aromatherapy",
				"Magical-Leaf",
				"U-Turn",
				"Payback",
				"Fling",
				"Punishment",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam",
				"Trop-Kick"
			};
		}
		#endregion
	}
	#endregion

	//Tsareena PokemonInstance Class
	#region Tsareena
	public class TsareenaInstance : PokemonInstance
	{
		#region Tsareena Constructors
		/// <summary>
		/// Tsareena Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TsareenaInstance(string nickname, int level)
		: base(
				763,
				SpeciesTsareena.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tsareena Builder only waiting for a Level
		/// </summary>
		public TsareenaInstance(int level)
		: base(
				763,
				SpeciesTsareena.Instance, // PokemonInstance Species
				"Tsareena", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tsareena Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Tsareena() : base(
			763,
			SpeciesTsareena.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}