using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wimpod Species to store common natural stats of all Wimpods
	#region SpeciesWimpod
	public class SpeciesWimpod : PokemonSpecies
	{
#nullable enable
		private static SpeciesWimpod? _instance = null;
#nullable restore
        public static SpeciesWimpod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWimpod();
                }
                return _instance;
            }
        }

		#region SpeciesWimpod Constructor
		public SpeciesWimpod() : base(
			"Wimpod",
			0.5,
			12.0,
			25, // HPs
			35, 40, // Attack & Defense
			20, 30, // Special Attack & Defense
			80		
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
				"Surf",
				"Toxic",
				"Double-Team",
				"Harden",
				"Waterfall",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Protect",
				"Spikes",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Hail",
				"Facade",
				"Taunt",
				"Aqua-Jet",
				"Wide-Guard",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Wimpod PokemonInstance Class
	#region Wimpod
	public class WimpodInstance : PokemonInstance
	{
		#region Wimpod Constructors
		/// <summary>
		/// Wimpod Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WimpodInstance(string nickname, int level)
		: base(
				767,
				SpeciesWimpod.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wimpod Builder only waiting for a Level
		/// </summary>
		public WimpodInstance(int level)
		: base(
				767,
				SpeciesWimpod.Instance, // PokemonInstance Species
				"Wimpod", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wimpod Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Wimpod() : base(
			767,
			SpeciesWimpod.Instance, // PokemonInstance Species
			Bug.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}