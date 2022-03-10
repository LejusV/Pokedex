using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bounsweet Species to store common natural stats of all Bounsweets
	#region SpeciesBounsweet
	public class SpeciesBounsweet : PokemonSpecies
	{
#nullable enable
		private static SpeciesBounsweet? _instance = null;
#nullable restore
        public static SpeciesBounsweet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBounsweet();
                }
                return _instance;
            }
        }

		#region SpeciesBounsweet Constructor
		public SpeciesBounsweet() : base(
			"Bounsweet",
			0.3,
			3.2,
			42, // HPs
			30, 38, // Attack & Defense
			30, 38, // Special Attack & Defense
			32		
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
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Splash",
				"Rest",
				"Substitute",
				"Flail",
				"Protect",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Teeter-Dance",
				"Grass-Whistle",
				"Magical-Leaf",
				"Feint",
				"Acupressure",
				"Energy-Ball",
				"Grass-Knot",
				"Round",
				"Play-Rough",
				"Play-Nice",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Bounsweet PokemonInstance Class
	#region Bounsweet
	public class BounsweetInstance : PokemonInstance
	{
		#region Bounsweet Constructors
		/// <summary>
		/// Bounsweet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BounsweetInstance(string nickname, int level)
		: base(
				761,
				SpeciesBounsweet.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bounsweet Builder only waiting for a Level
		/// </summary>
		public BounsweetInstance(int level)
		: base(
				761,
				SpeciesBounsweet.Instance, // PokemonInstance Species
				"Bounsweet", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bounsweet Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Bounsweet() : base(
			761,
			SpeciesBounsweet.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}