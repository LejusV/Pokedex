using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lurantis Species to store common natural stats of all Lurantiss
	#region SpeciesLurantis
	public class SpeciesLurantis : PokemonSpecies
	{
#nullable enable
		private static SpeciesLurantis? _instance = null;
#nullable restore
        public static SpeciesLurantis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLurantis();
                }
                return _instance;
            }
        }

		#region SpeciesLurantis Constructor
		public SpeciesLurantis() : base(
			754,
			"Lurantis",
			0.9,
			18.5,
			70, // HPs
			105, 90, // Attack & Defense
			80, 90, // Special Attack & Defense
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
				"Swords-Dance",
				"Hyper-Beam",
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
				"Brick-Break",
				"Aerial-Ace",
				"Leaf-Blade",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Solar-Blade",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion

	//Lurantis PokemonInstance Class
	#region Lurantis
	public class LurantisInstance : PokemonInstance
	{
		#region Lurantis Constructors
		/// <summary>
		/// Lurantis Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LurantisInstance(string nickname, int level)
		: base(
				SpeciesLurantis.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lurantis Builder only waiting for a Level
		/// </summary>
		public LurantisInstance(int level)
		: base(
				SpeciesLurantis.Instance, // PokemonInstance Species
				"Lurantis", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lurantis Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LurantisInstance() : base(
			SpeciesLurantis.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}