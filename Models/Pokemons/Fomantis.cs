using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Fomantis Species to store common natural stats of all Fomantiss
	#region SpeciesFomantis
	public class SpeciesFomantis : PokemonSpecies
	{
#nullable enable
		private static SpeciesFomantis? _instance = null;
#nullable restore
        public static SpeciesFomantis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFomantis();
                }
                return _instance;
            }
        }

		#region SpeciesFomantis Constructor
		public SpeciesFomantis() : base(
			"Fomantis",
			0.3,
			1.5,
			40, // HPs
			55, 35, // Attack & Defense
			50, 35, // Special Attack & Defense
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
				"Swords-Dance",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Leech-Life",
				"Rest",
				"Slash",
				"Substitute",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Weather-Ball",
				"Aromatherapy",
				"Leaf-Blade",
				"Payback",
				"Fling",
				"Poison-Jab",
				"X-Scissor",
				"Energy-Ball",
				"Defog",
				"Leaf-Storm",
				"Grass-Knot",
				"Round",
				"Confide",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion

	//Fomantis PokemonInstance Class
	#region Fomantis
	public class FomantisInstance : PokemonInstance
	{
		#region Fomantis Constructors
		/// <summary>
		/// Fomantis Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FomantisInstance(string nickname, int level)
		: base(
				753,
				SpeciesFomantis.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fomantis Builder only waiting for a Level
		/// </summary>
		public FomantisInstance(int level)
		: base(
				753,
				SpeciesFomantis.Instance, // PokemonInstance Species
				"Fomantis", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fomantis Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Fomantis() : base(
			753,
			SpeciesFomantis.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}